using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Orleans.CodeGeneration;
using Orleans.Messaging;
using Orleans.Providers;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using Orleans.Serialization;
using Orleans.Streams;

namespace Orleans
{
    internal class OutsideRuntimeClient : IRuntimeClient, IDisposable
    {
        internal static bool TestOnlyThrowExceptionDuringInit { get; set; }

        private readonly Logger logger;
        private readonly Logger appLogger;

        private readonly ClientConfiguration config;

        private readonly ConcurrentDictionary<CorrelationId, CallbackData> callbacks;
        private readonly ConcurrentDictionary<GuidId, LocalObjectData> localObjects;

        private readonly ProxiedMessageCenter transport;
        private bool listenForMessages;
        private CancellationTokenSource listeningCts;
        private bool firstMessageReceived;

        private readonly ClientProviderRuntime clientProviderRuntime;
        private readonly StatisticsProviderManager statisticsProviderManager;

        internal ClientStatisticsManager ClientStatistics;
        private GrainId clientId;
        private readonly GrainId handshakeClientId;
        private IGrainTypeResolver grainInterfaceMap;
        private readonly ThreadTrackingStatistic incomingMessagesThreadTimeTracking;
        private readonly Func<Message, bool> tryResendMessage;
        private readonly Action<Message> unregisterCallback;

        // initTimeout used to be AzureTableDefaultPolicies.TableCreationTimeout, which was 3 min
        private static readonly TimeSpan initTimeout = TimeSpan.FromMinutes(1);

        private static readonly TimeSpan resetTimeout = TimeSpan.FromMinutes(1);

        private const string BARS = "----------";

        private readonly GrainFactory grainFactory;

        public IInternalGrainFactory InternalGrainFactory
        {
            get { return grainFactory; }
        }

        /// <summary>
        /// Response timeout.
        /// </summary>
        private TimeSpan responseTimeout;

        private static readonly Object staticLock = new Object();

        private TypeMetadataCache typeCache;

        private readonly AssemblyProcessor assemblyProcessor;

        Logger IRuntimeClient.AppLogger
        {
            get { return appLogger; }
        }

        public ActivationAddress CurrentActivationAddress
        {
            get;
            private set;
        }
        
        public string CurrentActivationIdentity
        {
            get { return CurrentActivationAddress.ToString(); }
        }
        
        internal IList<Uri> Gateways
        {
            get
            {
                return transport.GatewayManager.ListProvider.GetGateways().GetResult();
            }
        }

        public IStreamProviderManager CurrentStreamProviderManager { get; private set; }

        public IStreamProviderRuntime CurrentStreamProviderRuntime
        {
            get { return clientProviderRuntime; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope",
            Justification = "MessageCenter is IDisposable but cannot call Dispose yet as it lives past the end of this method call.")]
        public OutsideRuntimeClient(ClientConfiguration cfg, bool secondary = false)
        {
            this.typeCache = new TypeMetadataCache();
            this.assemblyProcessor = new AssemblyProcessor(this.typeCache);
            this.grainFactory = new GrainFactory(this, this.typeCache);

            if (cfg == null)
            {
                Console.WriteLine("An attempt to create an OutsideRuntimeClient with null ClientConfiguration object.");
                throw new ArgumentException("OutsideRuntimeClient was attempted to be created with null ClientConfiguration object.", "cfg");
            }

            this.config = cfg;

            if (!LogManager.IsInitialized) LogManager.Initialize(config);
            StatisticsCollector.Initialize(config);
            SerializationManager.Initialize(cfg.SerializationProviders, cfg.FallbackSerializationProvider);
            this.assemblyProcessor.Initialize();

            logger = LogManager.GetLogger("OutsideRuntimeClient", LoggerType.Runtime);
            appLogger = LogManager.GetLogger("Application", LoggerType.Application);

            BufferPool.InitGlobalBufferPool(config);
            this.handshakeClientId = GrainId.NewClientId();

            tryResendMessage = TryResendMessage;
            unregisterCallback = msg => UnRegisterCallback(msg.Id);

            try
            {
                LoadAdditionalAssemblies();

                callbacks = new ConcurrentDictionary<CorrelationId, CallbackData>();
                localObjects = new ConcurrentDictionary<GuidId, LocalObjectData>();

                if (!secondary)
                {
                    UnobservedExceptionsHandlerClass.SetUnobservedExceptionHandler(UnhandledException);
                }
                AppDomain.CurrentDomain.DomainUnload += CurrentDomain_DomainUnload;

                // Ensure SerializationManager static constructor is called before AssemblyLoad event is invoked
                SerializationManager.GetDeserializer(typeof(String));

                clientProviderRuntime = new ClientProviderRuntime(grainFactory, null);
                statisticsProviderManager = new StatisticsProviderManager("Statistics", clientProviderRuntime);
                var statsProviderName = statisticsProviderManager.LoadProvider(config.ProviderConfigurations)
                    .WaitForResultWithThrow(initTimeout);
                if (statsProviderName != null)
                {
                    config.StatisticsProviderName = statsProviderName;
                }

                responseTimeout = Debugger.IsAttached ? Constants.DEFAULT_RESPONSE_TIMEOUT : config.ResponseTimeout;
                var localAddress = ClusterConfiguration.GetLocalIPAddress(config.PreferredFamily, config.NetInterface);

                // Client init / sign-on message
                logger.Info(ErrorCode.ClientInitializing, string.Format(
                    "{0} Initializing OutsideRuntimeClient on {1} at {2} Client Id = {3} {0}",
                    BARS, config.DNSHostName, localAddress, handshakeClientId));
                string startMsg = string.Format("{0} Starting OutsideRuntimeClient with runtime Version='{1}' in AppDomain={2}",
                    BARS, RuntimeVersion.Current, PrintAppDomainDetails());
                startMsg = string.Format("{0} Config= " + Environment.NewLine + " {1}", startMsg, config);
                logger.Info(ErrorCode.ClientStarting, startMsg);

                if (TestOnlyThrowExceptionDuringInit)
                {
                    throw new InvalidOperationException("TestOnlyThrowExceptionDuringInit");
                }

                config.CheckGatewayProviderSettings();

                var generation = -SiloAddress.AllocateNewGeneration(); // Client generations are negative
                var gatewayListProvider = GatewayProviderFactory.CreateGatewayListProvider(config)
                    .WithTimeout(initTimeout).Result;
                transport = new ProxiedMessageCenter(config, localAddress, generation, handshakeClientId, gatewayListProvider);

                if (StatisticsCollector.CollectThreadTimeTrackingStats)
                {
                    incomingMessagesThreadTimeTracking = new ThreadTrackingStatistic("ClientReceiver");
                }
            }
            catch (Exception exc)
            {
                if (logger != null) logger.Error(ErrorCode.Runtime_Error_100319, "OutsideRuntimeClient constructor failed.", exc);
                ConstructorReset();
                throw;
            }
        }

        private void StreamingInitialize()
        {
            var implicitSubscriberTable = transport.GetImplicitStreamSubscriberTable(grainFactory).Result;
            clientProviderRuntime.StreamingInitialize(implicitSubscriberTable);
            var streamProviderManager = new Streams.StreamProviderManager();
            streamProviderManager
                .LoadStreamProviders(
                    this.config.ProviderConfigurations,
                    clientProviderRuntime)
                .Wait();
            CurrentStreamProviderManager = streamProviderManager;
        }

        private void LoadAdditionalAssemblies()
        {
#if !NETSTANDARD_TODO
            var logger = LogManager.GetLogger("AssemblyLoader.Client", LoggerType.Runtime);

            var directories =
                new Dictionary<string, SearchOption>
                    {
                        {
                            Path.GetDirectoryName(typeof(OutsideRuntimeClient).GetTypeInfo().Assembly.Location),
                            SearchOption.AllDirectories
                        }
                    };
            var excludeCriteria =
                new AssemblyLoaderPathNameCriterion[]
                    {
                        AssemblyLoaderCriteria.ExcludeResourceAssemblies,
                        AssemblyLoaderCriteria.ExcludeSystemBinaries()
                    };
            var loadProvidersCriteria =
                new AssemblyLoaderReflectionCriterion[]
                    {
                        AssemblyLoaderCriteria.LoadTypesAssignableFrom(typeof(IProvider))
                    };

            this.assemblyProcessor.Initialize();
            AssemblyLoader.LoadAssemblies(directories, excludeCriteria, loadProvidersCriteria, logger);
#endif
        }

        private void UnhandledException(ISchedulingContext context, Exception exception)
        {
            logger.Error(ErrorCode.Runtime_Error_100007, String.Format("OutsideRuntimeClient caught an UnobservedException."), exception);
            logger.Assert(ErrorCode.Runtime_Error_100008, context == null, "context should be not null only inside OrleansRuntime and not on the client.");
        }

        public void Start()
        {
            lock (staticLock)
            {
                if (RuntimeClient.Current != null)
                    throw new InvalidOperationException("Can only have one RuntimeClient per AppDomain");
                RuntimeClient.Current = this;
            }
            StartInternal();

            logger.Info(ErrorCode.ProxyClient_StartDone, "{0} Started OutsideRuntimeClient with Global Client ID: {1}", BARS, CurrentActivationAddress.ToString() + ", client GUID ID: " + handshakeClientId);
        }

        // used for testing to (carefully!) allow two clients in the same process
        internal void StartInternal()
        {
            transport.Start();
            LogManager.MyIPEndPoint = transport.MyAddress.Endpoint; // transport.MyAddress is only set after transport is Started.
            CurrentActivationAddress = ActivationAddress.NewActivationAddress(transport.MyAddress, handshakeClientId);
            ClientStatistics = new ClientStatisticsManager(config);

            listeningCts = new CancellationTokenSource();
            var ct = listeningCts.Token;
            listenForMessages = true;

            // Keeping this thread handling it very simple for now. Just queue task on thread pool.
            Task.Factory.StartNew(() =>
                {
                    try
                    {
                        RunClientMessagePump(ct);
                    }
                    catch (Exception exc)
                    {
                        logger.Error(ErrorCode.Runtime_Error_100326, "RunClientMessagePump has thrown exception", exc);
                    }
                }
            );
            grainInterfaceMap = transport.GetTypeCodeMap(grainFactory).Result;

            ClientStatistics.Start(statisticsProviderManager, transport, clientId)
                .WaitWithThrow(initTimeout);

            StreamingInitialize();
        }

        private void RunClientMessagePump(CancellationToken ct)
        {
            if (StatisticsCollector.CollectThreadTimeTrackingStats)
            {
                incomingMessagesThreadTimeTracking.OnStartExecution();
            }
            while (listenForMessages)
            {
                var message = transport.WaitMessage(Message.Categories.Application, ct);

                if (message == null) // if wait was cancelled
                    break;
#if TRACK_DETAILED_STATS
                        if (StatisticsCollector.CollectThreadTimeTrackingStats)
                        {
                            incomingMessagesThreadTimeTracking.OnStartProcessing();
                        }
#endif

                // when we receive the first message, we update the
                // clientId for this client because it may have been modified to
                // include the cluster name
                if (!firstMessageReceived)
                {
                    firstMessageReceived = true;
                    if (!handshakeClientId.Equals(message.TargetGrain))
                    {
                        clientId = message.TargetGrain;
                        transport.UpdateClientId(clientId);
                        CurrentActivationAddress = ActivationAddress.GetAddress(transport.MyAddress, clientId, CurrentActivationAddress.Activation);
                    }
                    else
                    {
                        clientId = handshakeClientId;
                    }
                }

                switch (message.Direction)
                {
                    case Message.Directions.Response:
                        {
                            ReceiveResponse(message);
                            break;
                        }
                    case Message.Directions.OneWay:
                    case Message.Directions.Request:
                        {
                            this.DispatchToLocalObject(message);
                            break;
                        }
                    default:
                        logger.Error(ErrorCode.Runtime_Error_100327, String.Format("Message not supported: {0}.", message));
                        break;
                }
#if TRACK_DETAILED_STATS
                        if (StatisticsCollector.CollectThreadTimeTrackingStats)
                        {
                            incomingMessagesThreadTimeTracking.OnStopProcessing();
                            incomingMessagesThreadTimeTracking.IncrementNumberOfProcessed();
                        }
#endif
            }
            if (StatisticsCollector.CollectThreadTimeTrackingStats)
            {
                incomingMessagesThreadTimeTracking.OnStopExecution();
            }
        }

        private void DispatchToLocalObject(Message message)
        {
            LocalObjectData objectData;
            GuidId observerId = message.TargetObserverId;
            if (observerId == null)
            {
                logger.Error(
                    ErrorCode.ProxyClient_OGC_TargetNotFound_2,
                    String.Format("Did not find TargetObserverId header in the message = {0}. A request message to a client is expected to have an observerId.", message));
                return;
            }

            if (localObjects.TryGetValue(observerId, out objectData))
                this.InvokeLocalObjectAsync(objectData, message);
            else
            {
                logger.Error(
                    ErrorCode.ProxyClient_OGC_TargetNotFound,
                    String.Format(
                        "Unexpected target grain in request: {0}. Message={1}",
                        message.TargetGrain,
                        message));
            }
        }

        private void InvokeLocalObjectAsync(LocalObjectData objectData, Message message)
        {
            var obj = (IAddressable)objectData.LocalObject.Target;
            if (obj == null)
            {
                //// Remove from the dictionary record for the garbage collected object? But now we won't be able to detect invalid dispatch IDs anymore.
                logger.Warn(ErrorCode.Runtime_Error_100162,
                    String.Format("Object associated with Observer ID {0} has been garbage collected. Deleting object reference and unregistering it. Message = {1}", objectData.ObserverId, message));

                LocalObjectData ignore;
                // Try to remove. If it's not there, we don't care.
                localObjects.TryRemove(objectData.ObserverId, out ignore);
                return;
            }

            bool start;
            lock (objectData.Messages)
            {
                objectData.Messages.Enqueue(message);
                start = !objectData.Running;
                objectData.Running = true;
            }
            if (logger.IsVerbose) logger.Verbose("InvokeLocalObjectAsync {0} start {1}", message, start);
            if (start)
            {
                // we use Task.Run() to ensure that the message pump operates asynchronously
                // with respect to the current thread. see
                // http://channel9.msdn.com/Events/TechEd/Europe/2013/DEV-B317#fbid=aIWUq0ssW74
                // at position 54:45.
                //
                // according to the information posted at:
                // http://stackoverflow.com/questions/12245935/is-task-factory-startnew-guaranteed-to-use-another-thread-than-the-calling-thr
                // this idiom is dependent upon the a TaskScheduler not implementing the
                // override QueueTask as task inlining (as opposed to queueing). this seems
                // implausible to the author, since none of the .NET schedulers do this and
                // it is considered bad form (the OrleansTaskScheduler does not do this).
                //
                // if, for some reason this doesn't hold true, we can guarantee what we
                // want by passing a placeholder continuation token into Task.StartNew()
                // instead. i.e.:
                //
                // return Task.StartNew(() => ..., new CancellationToken());
                Func<Task> asyncFunc =
                    async () =>
                        await this.LocalObjectMessagePumpAsync(objectData);
                Task.Run(asyncFunc).Ignore();
            }
        }

        private async Task LocalObjectMessagePumpAsync(LocalObjectData objectData)
        {
            while (true)
            {
                try
                {
                    Message message;
                    lock (objectData.Messages)
                    {
                        if (objectData.Messages.Count == 0)
                        {
                            objectData.Running = false;
                            break;
                        }
                        message = objectData.Messages.Dequeue();
                    }

                    if (ExpireMessageIfExpired(message, MessagingStatisticsGroup.Phase.Invoke))
                        continue;

                    RequestContext.Import(message.RequestContextData);
                    var request = (InvokeMethodRequest)message.BodyObject;
                    var targetOb = (IAddressable)objectData.LocalObject.Target;
                    object resultObject = null;
                    Exception caught = null;
                    try
                    {
                        // exceptions thrown within this scope are not considered to be thrown from user code
                        // and not from runtime code.
                        var resultPromise = objectData.Invoker.Invoke(targetOb, request);
                        if (resultPromise != null) // it will be null for one way messages
                        {
                            resultObject = await resultPromise;
                        }
                    }
                    catch (Exception exc)
                    {
                        // the exception needs to be reported in the log or propagated back to the caller.
                        caught = exc;
                    }
                    if (caught != null)
                        this.ReportException(message, caught);
                    else if (message.Direction != Message.Directions.OneWay)
                        await this.SendResponseAsync(message, resultObject);
                }
                catch (Exception)
                {
                    // ignore, keep looping.
                }
            }
        }

        private static bool ExpireMessageIfExpired(Message message, MessagingStatisticsGroup.Phase phase)
        {
            if (message.IsExpired)
            {
                message.DropExpiredMessage(phase);
                return true;
            }
            return false;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private Task
            SendResponseAsync(
                Message message,
                object resultObject)
        {
            if (ExpireMessageIfExpired(message, MessagingStatisticsGroup.Phase.Respond))
                return TaskDone.Done;

            object deepCopy = null;
            try
            {
                // we're expected to notify the caller if the deep copy failed.
                deepCopy = SerializationManager.DeepCopy(resultObject);
            }
            catch (Exception exc2)
            {
                SendResponse(message, Response.ExceptionResponse(exc2));
                logger.Warn(
                    ErrorCode.ProxyClient_OGC_SendResponseFailed,
                    "Exception trying to send a response.", exc2);
                return TaskDone.Done;
            }

            // the deep-copy succeeded.
            SendResponse(message, new Response(deepCopy));
            return TaskDone.Done;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void ReportException(Message message, Exception exception)
        {
            var request = (InvokeMethodRequest)message.BodyObject;
            switch (message.Direction)
            {
                default:
                    throw new InvalidOperationException();
                case Message.Directions.OneWay:
                    {
                        logger.Error(
                            ErrorCode.ProxyClient_OGC_UnhandledExceptionInOneWayInvoke,
                            String.Format(
                                "Exception during invocation of notification method {0}, interface {1}. Ignoring exception because this is a one way request.",
                                request.MethodId,
                                request.InterfaceId),
                            exception);
                        break;
                    }
                case Message.Directions.Request:
                    {
                        Exception deepCopy = null;
                        try
                        {
                            // we're expected to notify the caller if the deep copy failed.
                            deepCopy = (Exception)SerializationManager.DeepCopy(exception);
                        }
                        catch (Exception ex2)
                        {
                            SendResponse(message, Response.ExceptionResponse(ex2));
                            logger.Warn(
                                ErrorCode.ProxyClient_OGC_SendExceptionResponseFailed,
                                "Exception trying to send an exception response", ex2);
                            return;
                        }
                        // the deep-copy succeeded.
                        var response = Response.ExceptionResponse(deepCopy);
                        SendResponse(message, response);
                        break;
                    }
            }
        }

        private void SendResponse(Message request, Response response)
        {
            var message = request.CreateResponseMessage();
            message.BodyObject = response;

            transport.SendMessage(message);
        }

        /// <summary>
        /// For testing only.
        /// </summary>
        public void Disconnect()
        {
            transport.Disconnect();
        }

        /// <summary>
        /// For testing only.
        /// </summary>
        public void Reconnect()
        {
            transport.Reconnect();
        }

        #region Implementation of IRuntimeClient

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope",
            Justification = "CallbackData is IDisposable but instances exist beyond lifetime of this method so cannot Dispose yet.")]
        public void SendRequest(GrainReference target, InvokeMethodRequest request, TaskCompletionSource<object> context, Action<Message, TaskCompletionSource<object>> callback, string debugContext = null, InvokeMethodOptions options = InvokeMethodOptions.None, string genericArguments = null)
        {
            var message = Message.CreateMessage(request, options);
            SendRequestMessage(target, message, context, callback, debugContext, options, genericArguments);
        }

        private void SendRequestMessage(GrainReference target, Message message, TaskCompletionSource<object> context, Action<Message, TaskCompletionSource<object>> callback, string debugContext = null, InvokeMethodOptions options = InvokeMethodOptions.None, string genericArguments = null)
        {
            var targetGrainId = target.GrainId;
            var oneWay = (options & InvokeMethodOptions.OneWay) != 0;
            message.SendingGrain = CurrentActivationAddress.Grain;
            message.SendingActivation = CurrentActivationAddress.Activation;
            message.TargetGrain = targetGrainId;
            if (!String.IsNullOrEmpty(genericArguments))
                message.GenericGrainType = genericArguments;

            if (targetGrainId.IsSystemTarget)
            {
                // If the silo isn't be supplied, it will be filled in by the sender to be the gateway silo
                message.TargetSilo = target.SystemTargetSilo;
                if (target.SystemTargetSilo != null)
                {
                    message.TargetActivation = ActivationId.GetSystemActivation(targetGrainId, target.SystemTargetSilo);
                }
            }
            // Client sending messages to another client (observer). Yes, we support that.
            if (target.IsObserverReference)
            {
                message.TargetObserverId = target.ObserverId;
            }

            if (debugContext != null)
            {
                message.DebugContext = debugContext;
            }
            if (message.IsExpirableMessage(config))
            {
                // don't set expiration for system target messages.
                message.TimeToLive = responseTimeout;
            }

            if (!oneWay)
            {
                var callbackData = new CallbackData(
                    callback,
                    tryResendMessage,
                    context,
                    message,
                    unregisterCallback,
                    config);
                callbacks.TryAdd(message.Id, callbackData);
                callbackData.StartTimer(responseTimeout);
            }

            if (logger.IsVerbose2) logger.Verbose2("Send {0}", message);
            transport.SendMessage(message);
        }

        private bool TryResendMessage(Message message)
        {
            if (!message.MayResend(config))
            {
                return false;
            }

            if (logger.IsVerbose) logger.Verbose("Resend {0}", message);

            message.ResendCount = message.ResendCount + 1;
            message.TargetHistory = message.GetTargetHistory();

            if (!message.TargetGrain.IsSystemTarget)
            {
                message.TargetActivation = null;
                message.TargetSilo = null;
                message.ClearTargetAddress();
            }

            transport.SendMessage(message);
            return true;
        }

        public void ReceiveResponse(Message response)
        {
            if (logger.IsVerbose2) logger.Verbose2("Received {0}", response);

            // ignore duplicate requests
            if (response.Result == Message.ResponseTypes.Rejection && response.RejectionType == Message.RejectionTypes.DuplicateRequest)
                return;

            CallbackData callbackData;
            var found = callbacks.TryGetValue(response.Id, out callbackData);
            if (found)
            {
                // We need to import the RequestContext here as well.
                // Unfortunately, it is not enough, since CallContext.LogicalGetData will not flow "up" from task completion source into the resolved task.
                // RequestContext.Import(response.RequestContextData);
                callbackData.DoCallback(response);
            }
            else
            {
                logger.Warn(ErrorCode.Runtime_Error_100011, "No callback for response message: " + response);
            }
        }

        private void UnRegisterCallback(CorrelationId id)
        {
            CallbackData ignore;
            callbacks.TryRemove(id, out ignore);
        }

        public void Reset(bool cleanup)
        {
            Utils.SafeExecute(() =>
            {
                if (logger != null)
                {
                    logger.Info("OutsideRuntimeClient.Reset(): client Id " + clientId);
                }
            });

            Utils.SafeExecute(() =>
            {
                if (clientProviderRuntime != null)
                {
                    clientProviderRuntime.Reset(cleanup).WaitWithThrow(resetTimeout);
                }
            }, logger, "Client.clientProviderRuntime.Reset");
            Utils.SafeExecute(() =>
            {
                if (StatisticsCollector.CollectThreadTimeTrackingStats)
                {
                    incomingMessagesThreadTimeTracking.OnStopExecution();
                }
            }, logger, "Client.incomingMessagesThreadTimeTracking.OnStopExecution");
            Utils.SafeExecute(() =>
            {
                if (transport != null)
                {
                    transport.PrepareToStop();
                }
            }, logger, "Client.PrepareToStop-Transport");

            listenForMessages = false;
            Utils.SafeExecute(() =>
            {
                if (listeningCts != null)
                {
                    listeningCts.Cancel();
                }
            }, logger, "Client.Stop-ListeningCTS");
            Utils.SafeExecute(() =>
                {
                    if (transport != null)
                    {
                        transport.Stop();
                    }
                }, logger, "Client.Stop-Transport");
            Utils.SafeExecute(() =>
            {
                if (ClientStatistics != null)
                {
                    ClientStatistics.Stop();
                }
            }, logger, "Client.Stop-ClientStatistics");
            ConstructorReset();
        }

        private void ConstructorReset()
        {
            Utils.SafeExecute(() =>
            {
                if (logger != null)
                {
                    logger.Info("OutsideRuntimeClient.ConstructorReset(): client Id " + clientId);
                }
            });

            try
            {
                UnobservedExceptionsHandlerClass.ResetUnobservedExceptionHandler();
            }
            catch (Exception) { }
            try
            {
                AppDomain.CurrentDomain.DomainUnload -= CurrentDomain_DomainUnload;
            }
            catch (Exception) { }
            try
            {
                if (clientProviderRuntime != null)
                {
                    clientProviderRuntime.Reset().WaitWithThrow(resetTimeout);
                }
            }
            catch (Exception) { }
            try
            {
                LogManager.UnInitialize();
            }
            catch (Exception) { }
        }

        public void SetResponseTimeout(TimeSpan timeout)
        {
            responseTimeout = timeout;
        }

        public TimeSpan GetResponseTimeout()
        {
            return responseTimeout;
        }
        
        public async Task ExecAsync(Func<Task> asyncFunction, ISchedulingContext context, string activityName)
        {
            await Task.Run(asyncFunction); // No grain context on client - run on .NET thread pool
        }

        public GrainReference CreateObjectReference(IAddressable obj, IGrainMethodInvoker invoker)
        {
            if (obj is GrainReference)
                throw new ArgumentException("Argument obj is already a grain reference.");

            GrainReference gr = GrainReference.NewObserverGrainReference(clientId, GuidId.GetNewGuidId());
            if (!localObjects.TryAdd(gr.ObserverId, new LocalObjectData(obj, gr.ObserverId, invoker)))
            {
                throw new ArgumentException(String.Format("Failed to add new observer {0} to localObjects collection.", gr), "gr");
            }
            return gr;
        }

        public void DeleteObjectReference(IAddressable obj)
        {
            if (!(obj is GrainReference))
                throw new ArgumentException("Argument reference is not a grain reference.");

            var reference = (GrainReference)obj;
            LocalObjectData ignore;
            if (!localObjects.TryRemove(reference.ObserverId, out ignore))
                throw new ArgumentException("Reference is not associated with a local object.", "reference");
        }

        #endregion Implementation of IRuntimeClient

        private void CurrentDomain_DomainUnload(object sender, EventArgs e)
        {
            try
            {
                logger.Warn(ErrorCode.ProxyClient_AppDomain_Unload,
                    String.Format("Current AppDomain={0} is unloading.", PrintAppDomainDetails()));
                LogManager.Flush();
            }
            catch (Exception)
            {
                // just ignore, make sure not to throw from here.
            }
        }

        private string PrintAppDomainDetails()
        {
#if NETSTANDARD_TODO
            return "N/A";
#else
            return string.Format("<AppDomain.Id={0}, AppDomain.FriendlyName={1}>", AppDomain.CurrentDomain.Id, AppDomain.CurrentDomain.FriendlyName);
#endif
        }

        private class LocalObjectData
        {
            internal WeakReference LocalObject { get; private set; }
            internal IGrainMethodInvoker Invoker { get; private set; }
            internal GuidId ObserverId { get; private set; }
            internal Queue<Message> Messages { get; private set; }
            internal bool Running { get; set; }

            internal LocalObjectData(IAddressable obj, GuidId observerId, IGrainMethodInvoker invoker)
            {
                LocalObject = new WeakReference(obj);
                ObserverId = observerId;
                Invoker = invoker;
                Messages = new Queue<Message>();
                Running = false;
            }
        }

        public void Dispose()
        {
            if (listeningCts != null)
            {
                listeningCts.Dispose();
                listeningCts = null;

                this.assemblyProcessor.Dispose();
            }

            transport.Dispose();
            if (ClientStatistics != null)
            {
                ClientStatistics.Dispose();
                ClientStatistics = null;
            }
            GC.SuppressFinalize(this);
        }

        public IGrainTypeResolver GrainTypeResolver
        {
            get { return grainInterfaceMap; }
        }

        public void BreakOutstandingMessagesToDeadSilo(SiloAddress deadSilo)
        {
            foreach (var callback in callbacks)
            {
                if (deadSilo.Equals(callback.Value.Message.TargetSilo))
                {
                    callback.Value.OnTargetSiloFail();
                }
            }
        }
    }
}