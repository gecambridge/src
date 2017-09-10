#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("OrleansTestingHost, Version=1.4.2.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.Storage
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Storage.MemoryStorage))]
    internal class OrleansCodeGenOrleans_Storage_MemoryStorageSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Storage.MemoryStorage).@GetTypeInfo().@GetField("<Log>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Storage.MemoryStorage, global::Orleans.Runtime.Logger> setField4 = (global::System.Action<global::Orleans.Storage.MemoryStorage, global::Orleans.Runtime.Logger>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Storage.MemoryStorage).@GetTypeInfo().@GetField("<Name>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.String> setField3 = (global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Storage.MemoryStorage).@GetTypeInfo().@GetField("id", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Storage.MemoryStorage, global::System.Int32> getField1 = (global::System.Func<global::Orleans.Storage.MemoryStorage, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.Int32> setField1 = (global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Storage.MemoryStorage).@GetTypeInfo().@GetField("numStorageGrains", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Storage.MemoryStorage, global::System.Int32> getField0 = (global::System.Func<global::Orleans.Storage.MemoryStorage, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Storage.MemoryStorage).@GetTypeInfo().@GetField("storageGrains", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Storage.MemoryStorage, global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[]> getField2 = (global::System.Func<global::Orleans.Storage.MemoryStorage, global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[]> setField2 = (global::System.Action<global::Orleans.Storage.MemoryStorage, global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Storage.MemoryStorage input = ((global::Orleans.Storage.MemoryStorage)original);
            global::Orleans.Storage.MemoryStorage result = new global::Orleans.Storage.MemoryStorage();
            context.@RecordCopy(original, result);
            setField4(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Log, context));
            setField3(result, input.@Name);
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            setField2(result, (global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Storage.MemoryStorage input = (global::Orleans.Storage.MemoryStorage)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Log, context, typeof (global::Orleans.Runtime.Logger));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Storage.MemoryStorage result = new global::Orleans.Storage.MemoryStorage();
            context.@RecordObject(result);
            setField4(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Logger), context));
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField2(result, (global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Lazy<global::Orleans.Storage.IMemoryStorageGrain>[]), context));
            return (global::Orleans.Storage.MemoryStorage)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.TestingHost.TestClusterOptions))]
    internal class OrleansCodeGenOrleans_TestingHost_TestClusterOptionsSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.TestingHost.TestClusterOptions).@GetTypeInfo().@GetField("_clientConfiguration", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClientConfiguration> getField1 = (global::System.Func<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClientConfiguration>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClientConfiguration> setField1 = (global::System.Action<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClientConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.TestingHost.TestClusterOptions).@GetTypeInfo().@GetField("_clusterConfiguration", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClusterConfiguration> getField0 = (global::System.Func<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClusterConfiguration>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClusterConfiguration> setField0 = (global::System.Action<global::Orleans.TestingHost.TestClusterOptions, global::Orleans.Runtime.Configuration.ClusterConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.TestingHost.TestClusterOptions input = ((global::Orleans.TestingHost.TestClusterOptions)original);
            global::Orleans.TestingHost.TestClusterOptions result = new global::Orleans.TestingHost.TestClusterOptions();
            context.@RecordCopy(original, result);
            result.@BaseGatewayPort = input.@BaseGatewayPort;
            result.@BaseSiloPort = input.@BaseSiloPort;
            result.@ExtendedFallbackOptions = (global::Orleans.TestingHost.TestClusterOptions.FallbackOptions)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ExtendedFallbackOptions, context);
            setField1(result, (global::Orleans.Runtime.Configuration.ClientConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField0(result, (global::Orleans.Runtime.Configuration.ClusterConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.TestingHost.TestClusterOptions input = (global::Orleans.TestingHost.TestClusterOptions)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BaseGatewayPort, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BaseSiloPort, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ExtendedFallbackOptions, context, typeof (global::Orleans.TestingHost.TestClusterOptions.FallbackOptions));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Runtime.Configuration.ClientConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.TestingHost.TestClusterOptions result = new global::Orleans.TestingHost.TestClusterOptions();
            context.@RecordObject(result);
            result.@BaseGatewayPort = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BaseSiloPort = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@ExtendedFallbackOptions = (global::Orleans.TestingHost.TestClusterOptions.FallbackOptions)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.TestingHost.TestClusterOptions.FallbackOptions), context);
            setField1(result, (global::Orleans.Runtime.Configuration.ClientConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.ClientConfiguration), context));
            setField0(result, (global::Orleans.Runtime.Configuration.ClusterConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration), context));
            return (global::Orleans.TestingHost.TestClusterOptions)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ClientConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ClientConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field19 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("<DNSHostName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String> setField19 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field19);
        private static readonly global::System.Reflection.FieldInfo field27 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("<LimitManager>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::Orleans.Runtime.Configuration.LimitManager> setField27 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::Orleans.Runtime.Configuration.LimitManager>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field27);
        private static readonly global::System.Reflection.FieldInfo field47 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<MessageLossInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField47 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field47);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField47 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field47);
        private static readonly global::System.Reflection.FieldInfo field17 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("<NetInterface>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String> setField17 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field17);
        private static readonly global::System.Reflection.FieldInfo field18 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("<Port>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.Int32> setField18 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field18);
        private static readonly global::System.Reflection.FieldInfo field46 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<RejectionInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField46 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field46);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField46 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field46);
        private static readonly global::System.Reflection.FieldInfo field44 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<SerializationProviders>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>> setField44 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field44);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("<SourceFile>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("<TraceLevelOverrides>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>> setField11 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field11);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("creationTimestamp", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.DateTime> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.DateTime> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field48 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("isSiloConfig", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> getField48 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field48);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> setField48 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field48);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ClientConfiguration).@GetTypeInfo().@GetField("traceFilePattern", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ClientConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.ClientConfiguration input = ((global::Orleans.Runtime.Configuration.ClientConfiguration)original);
            global::Orleans.Runtime.Configuration.ClientConfiguration result = new global::Orleans.Runtime.Configuration.ClientConfiguration();
            context.@RecordCopy(original, result);
            result.@AdoInvariant = input.@AdoInvariant;
            result.@BufferPoolBufferSize = input.@BufferPoolBufferSize;
            result.@BufferPoolMaxSize = input.@BufferPoolMaxSize;
            result.@BufferPoolPreallocationSize = input.@BufferPoolPreallocationSize;
            result.@BulkMessageLimit = input.@BulkMessageLimit;
            result.@ClientDropTimeout = input.@ClientDropTimeout;
            result.@ClientSenderBuckets = input.@ClientSenderBuckets;
            result.@CustomGatewayProviderAssemblyName = input.@CustomGatewayProviderAssemblyName;
            setField19(result, input.@DNSHostName);
            result.@DataConnectionString = input.@DataConnectionString;
            result.@DefaultTraceLevel = input.@DefaultTraceLevel;
            result.@DeploymentId = input.@DeploymentId;
            result.@DropExpiredMessages = input.@DropExpiredMessages;
            result.@FallbackSerializationProvider = (global::System.Reflection.TypeInfo)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@FallbackSerializationProvider, context);
            result.@GatewayListRefreshPeriod = input.@GatewayListRefreshPeriod;
            result.@GatewayProvider = input.@GatewayProvider;
            result.@GatewaySenderQueues = input.@GatewaySenderQueues;
            result.@Gateways = (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Gateways, context);
            result.@LargeMessageWarningThreshold = input.@LargeMessageWarningThreshold;
            setField27(result, (global::Orleans.Runtime.Configuration.LimitManager)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@LimitManager, context));
            result.@MaxForwardCount = input.@MaxForwardCount;
            result.@MaxResendCount = input.@MaxResendCount;
            result.@MaxSocketAge = input.@MaxSocketAge;
            setField47(result, getField47(input));
            setField17(result, input.@NetInterface);
            result.@OpenConnectionTimeout = input.@OpenConnectionTimeout;
            setField18(result, input.@Port);
            result.@PreferedGatewayIndex = input.@PreferedGatewayIndex;
            result.@PreferredFamily = input.@PreferredFamily;
            result.@PropagateActivityId = input.@PropagateActivityId;
            result.@ProviderConfigurations = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ProviderConfigurations, context);
            setField46(result, getField46(input));
            result.@ResendOnTimeout = input.@ResendOnTimeout;
            result.@ResponseTimeout = input.@ResponseTimeout;
            setField44(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SerializationProviders, context));
            result.@SiloSenderQueues = input.@SiloSenderQueues;
            setField2(result, input.@SourceFile);
            result.@StatisticsCollectionLevel = input.@StatisticsCollectionLevel;
            result.@StatisticsLogWriteInterval = input.@StatisticsLogWriteInterval;
            result.@StatisticsMetricsTableWriteInterval = input.@StatisticsMetricsTableWriteInterval;
            result.@StatisticsPerfCountersWriteInterval = input.@StatisticsPerfCountersWriteInterval;
            result.@StatisticsProviderName = input.@StatisticsProviderName;
            result.@StatisticsWriteLogStatisticsToTable = input.@StatisticsWriteLogStatisticsToTable;
            result.@TraceFileName = input.@TraceFileName;
            setField11(result, (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@TraceLevelOverrides, context));
            result.@TraceToConsole = input.@TraceToConsole;
            setField1(result, getField1(input));
            setField48(result, getField48(input));
            setField0(result, getField0(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ClientConfiguration input = (global::Orleans.Runtime.Configuration.ClientConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AdoInvariant, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolBufferSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolMaxSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolPreallocationSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BulkMessageLimit, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientDropTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientSenderBuckets, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CustomGatewayProviderAssemblyName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DNSHostName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DataConnectionString, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultTraceLevel, context, typeof (global::Orleans.Runtime.Severity));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DropExpiredMessages, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FallbackSerializationProvider, context, typeof (global::System.Reflection.TypeInfo));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewayListRefreshPeriod, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewayProvider, context, typeof (global::Orleans.Runtime.Configuration.ClientConfiguration.GatewayProviderType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewaySenderQueues, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Gateways, context, typeof (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LargeMessageWarningThreshold, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LimitManager, context, typeof (global::Orleans.Runtime.Configuration.LimitManager));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxForwardCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxResendCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxSocketAge, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField47(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NetInterface, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@OpenConnectionTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Port, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PreferedGatewayIndex, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PreferredFamily, context, typeof (global::System.Net.Sockets.AddressFamily));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PropagateActivityId, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProviderConfigurations, context, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField46(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResendOnTimeout, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResponseTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SerializationProviders, context, typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloSenderQueues, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SourceFile, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsCollectionLevel, context, typeof (global::Orleans.Runtime.Configuration.StatisticsLevel));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsLogWriteInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsMetricsTableWriteInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsPerfCountersWriteInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsProviderName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsWriteLogStatisticsToTable, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceFileName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceLevelOverrides, context, typeof (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceToConsole, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField48(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.ClientConfiguration result = new global::Orleans.Runtime.Configuration.ClientConfiguration();
            context.@RecordObject(result);
            result.@AdoInvariant = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@BufferPoolBufferSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BufferPoolMaxSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BufferPoolPreallocationSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BulkMessageLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@ClientDropTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@ClientSenderBuckets = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@CustomGatewayProviderAssemblyName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField19(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            result.@DataConnectionString = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@DefaultTraceLevel = (global::Orleans.Runtime.Severity)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Severity), context);
            result.@DeploymentId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@DropExpiredMessages = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@FallbackSerializationProvider = (global::System.Reflection.TypeInfo)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Reflection.TypeInfo), context);
            result.@GatewayListRefreshPeriod = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@GatewayProvider = (global::Orleans.Runtime.Configuration.ClientConfiguration.GatewayProviderType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.ClientConfiguration.GatewayProviderType), context);
            result.@GatewaySenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@Gateways = (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>), context);
            result.@LargeMessageWarningThreshold = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            setField27(result, (global::Orleans.Runtime.Configuration.LimitManager)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.LimitManager), context));
            result.@MaxForwardCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxResendCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxSocketAge = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField47(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            setField17(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            result.@OpenConnectionTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField18(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            result.@PreferedGatewayIndex = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@PreferredFamily = (global::System.Net.Sockets.AddressFamily)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.Sockets.AddressFamily), context);
            result.@PropagateActivityId = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@ProviderConfigurations = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>), context);
            setField46(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            result.@ResendOnTimeout = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@ResponseTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField44(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>), context));
            result.@SiloSenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            result.@StatisticsCollectionLevel = (global::Orleans.Runtime.Configuration.StatisticsLevel)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.StatisticsLevel), context);
            result.@StatisticsLogWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@StatisticsMetricsTableWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@StatisticsPerfCountersWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@StatisticsProviderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StatisticsWriteLogStatisticsToTable = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@TraceFileName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField11(result, (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>), context));
            result.@TraceToConsole = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            setField1(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField48(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Runtime.Configuration.ClientConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.LimitManager))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_LimitManagerSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.LimitManager).@GetTypeInfo().@GetField("limitValues", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.LimitManager input = ((global::Orleans.Runtime.Configuration.LimitManager)original);
            global::Orleans.Runtime.Configuration.LimitManager result = new global::Orleans.Runtime.Configuration.LimitManager();
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.LimitManager input = (global::Orleans.Runtime.Configuration.LimitManager)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.LimitManager result = new global::Orleans.Runtime.Configuration.LimitManager();
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>), context));
            return (global::Orleans.Runtime.Configuration.LimitManager)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.LimitValue))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_LimitValueSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.LimitValue input = ((global::Orleans.Runtime.Configuration.LimitValue)original);
            global::Orleans.Runtime.Configuration.LimitValue result = new global::Orleans.Runtime.Configuration.LimitValue();
            context.@RecordCopy(original, result);
            result.@HardLimitThreshold = input.@HardLimitThreshold;
            result.@Name = input.@Name;
            result.@SoftLimitThreshold = input.@SoftLimitThreshold;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.LimitValue input = (global::Orleans.Runtime.Configuration.LimitValue)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HardLimitThreshold, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SoftLimitThreshold, context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.LimitValue result = new global::Orleans.Runtime.Configuration.LimitValue();
            context.@RecordObject(result);
            result.@HardLimitThreshold = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@SoftLimitThreshold = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            return (global::Orleans.Runtime.Configuration.LimitValue)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.TestingHost.TestClusterOptions.FallbackOptions))]
    internal class OrleansCodeGenOrleans_TestingHost_TestClusterOptionsSerializer_FallbackOptionsSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.TestingHost.TestClusterOptions.FallbackOptions input = ((global::Orleans.TestingHost.TestClusterOptions.FallbackOptions)original);
            global::Orleans.TestingHost.TestClusterOptions.FallbackOptions result = new global::Orleans.TestingHost.TestClusterOptions.FallbackOptions();
            context.@RecordCopy(original, result);
            result.@DataConnectionString = input.@DataConnectionString;
            result.@InitialSilosCount = input.@InitialSilosCount;
            result.@LogsFolder = input.@LogsFolder;
            result.@TraceToConsole = (global::System.Nullable<global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@TraceToConsole, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.TestingHost.TestClusterOptions.FallbackOptions input = (global::Orleans.TestingHost.TestClusterOptions.FallbackOptions)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DataConnectionString, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@InitialSilosCount, context, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LogsFolder, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceToConsole, context, typeof (global::System.Nullable<global::System.Boolean>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.TestingHost.TestClusterOptions.FallbackOptions result = new global::Orleans.TestingHost.TestClusterOptions.FallbackOptions();
            context.@RecordObject(result);
            result.@DataConnectionString = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@InitialSilosCount = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), context);
            result.@LogsFolder = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@TraceToConsole = (global::System.Nullable<global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Nullable<global::System.Boolean>), context);
            return (global::Orleans.TestingHost.TestClusterOptions.FallbackOptions)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.NodeConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_NodeConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("<DNSHostName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field15 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("<EnableWorkerThreadInjection>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> getField15 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field15);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> setField15 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field15);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("<IsPrimaryNode>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> setField9 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("<IsSeedNode>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> setField10 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field10);
        private static readonly global::System.Reflection.FieldInfo field18 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("<LimitManager>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::Orleans.Runtime.Configuration.LimitManager> setField18 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::Orleans.Runtime.Configuration.LimitManager>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field18);
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("<Subnet>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]> getField8 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field8);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]> setField8 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        private static readonly global::System.Reflection.FieldInfo field21 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("<TraceLevelOverrides>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>> setField21 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field21);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("creationTimestamp", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("siloName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field19 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetTypeInfo().@GetField("traceFilePattern", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> getField19 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field19);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> setField19 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field19);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.NodeConfiguration input = ((global::Orleans.Runtime.Configuration.NodeConfiguration)original);
            global::Orleans.Runtime.Configuration.NodeConfiguration result = new global::Orleans.Runtime.Configuration.NodeConfiguration();
            context.@RecordCopy(original, result);
            result.@ActivationSchedulingQuantum = input.@ActivationSchedulingQuantum;
            result.@AdditionalAssemblyDirectories = (global::System.Collections.Generic.Dictionary<global::System.String, global::System.IO.SearchOption>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@AdditionalAssemblyDirectories, context);
            result.@AddressType = input.@AddressType;
            result.@BulkMessageLimit = input.@BulkMessageLimit;
            setField2(result, input.@DNSHostName);
            result.@DefaultConnectionLimit = input.@DefaultConnectionLimit;
            result.@DefaultTraceLevel = input.@DefaultTraceLevel;
            result.@DelayWarningThreshold = input.@DelayWarningThreshold;
            setField15(result, getField15(input));
            result.@ExcludedGrainTypes = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ExcludedGrainTypes, context);
            result.@Expect100Continue = input.@Expect100Continue;
            result.@Generation = input.@Generation;
            result.@HostNameOrIPAddress = input.@HostNameOrIPAddress;
            setField9(result, input.@IsPrimaryNode);
            setField10(result, input.@IsSeedNode);
            result.@LargeMessageWarningThreshold = input.@LargeMessageWarningThreshold;
            setField18(result, (global::Orleans.Runtime.Configuration.LimitManager)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@LimitManager, context));
            result.@LoadSheddingEnabled = input.@LoadSheddingEnabled;
            result.@LoadSheddingLimit = input.@LoadSheddingLimit;
            result.@MaxActiveThreads = input.@MaxActiveThreads;
            result.@MinDotNetThreadPoolSize = input.@MinDotNetThreadPoolSize;
            result.@Port = input.@Port;
            result.@PropagateActivityId = input.@PropagateActivityId;
            result.@ProxyGatewayEndpoint = input.@ProxyGatewayEndpoint;
            result.@SiloShutdownEventName = input.@SiloShutdownEventName;
            result.@StartupTypeName = input.@StartupTypeName;
            result.@StatisticsCollectionLevel = input.@StatisticsCollectionLevel;
            result.@StatisticsLogWriteInterval = input.@StatisticsLogWriteInterval;
            result.@StatisticsMetricsTableWriteInterval = input.@StatisticsMetricsTableWriteInterval;
            result.@StatisticsPerfCountersWriteInterval = input.@StatisticsPerfCountersWriteInterval;
            result.@StatisticsProviderName = input.@StatisticsProviderName;
            result.@StatisticsWriteLogStatisticsToTable = input.@StatisticsWriteLogStatisticsToTable;
            setField8(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField8(input), context));
            result.@TraceFileName = input.@TraceFileName;
            setField21(result, (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@TraceLevelOverrides, context));
            result.@TraceToConsole = input.@TraceToConsole;
            result.@TurnWarningLengthThreshold = input.@TurnWarningLengthThreshold;
            result.@UseNagleAlgorithm = input.@UseNagleAlgorithm;
            setField0(result, getField0(input));
            setField1(result, getField1(input));
            setField19(result, getField19(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.NodeConfiguration input = (global::Orleans.Runtime.Configuration.NodeConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationSchedulingQuantum, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AdditionalAssemblyDirectories, context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.IO.SearchOption>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AddressType, context, typeof (global::System.Net.Sockets.AddressFamily));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BulkMessageLimit, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DNSHostName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultConnectionLimit, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultTraceLevel, context, typeof (global::Orleans.Runtime.Severity));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DelayWarningThreshold, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField15(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ExcludedGrainTypes, context, typeof (global::System.Collections.Generic.List<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Expect100Continue, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Generation, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostNameOrIPAddress, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsPrimaryNode, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsSeedNode, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LargeMessageWarningThreshold, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LimitManager, context, typeof (global::Orleans.Runtime.Configuration.LimitManager));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LoadSheddingEnabled, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LoadSheddingLimit, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxActiveThreads, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MinDotNetThreadPoolSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Port, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PropagateActivityId, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProxyGatewayEndpoint, context, typeof (global::System.Net.IPEndPoint));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloShutdownEventName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartupTypeName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsCollectionLevel, context, typeof (global::Orleans.Runtime.Configuration.StatisticsLevel));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsLogWriteInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsMetricsTableWriteInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsPerfCountersWriteInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsProviderName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsWriteLogStatisticsToTable, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField8(input), context, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceFileName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceLevelOverrides, context, typeof (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceToConsole, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TurnWarningLengthThreshold, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseNagleAlgorithm, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField19(input), context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.NodeConfiguration result = new global::Orleans.Runtime.Configuration.NodeConfiguration();
            context.@RecordObject(result);
            result.@ActivationSchedulingQuantum = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@AdditionalAssemblyDirectories = (global::System.Collections.Generic.Dictionary<global::System.String, global::System.IO.SearchOption>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.IO.SearchOption>), context);
            result.@AddressType = (global::System.Net.Sockets.AddressFamily)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.Sockets.AddressFamily), context);
            result.@BulkMessageLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            result.@DefaultConnectionLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@DefaultTraceLevel = (global::Orleans.Runtime.Severity)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Severity), context);
            result.@DelayWarningThreshold = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField15(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            result.@ExcludedGrainTypes = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.String>), context);
            result.@Expect100Continue = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@Generation = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@HostNameOrIPAddress = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField9(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField10(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            result.@LargeMessageWarningThreshold = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            setField18(result, (global::Orleans.Runtime.Configuration.LimitManager)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.LimitManager), context));
            result.@LoadSheddingEnabled = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@LoadSheddingLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxActiveThreads = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MinDotNetThreadPoolSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@Port = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@PropagateActivityId = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@ProxyGatewayEndpoint = (global::System.Net.IPEndPoint)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.IPEndPoint), context);
            result.@SiloShutdownEventName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StartupTypeName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StatisticsCollectionLevel = (global::Orleans.Runtime.Configuration.StatisticsLevel)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.StatisticsLevel), context);
            result.@StatisticsLogWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@StatisticsMetricsTableWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@StatisticsPerfCountersWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@StatisticsProviderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StatisticsWriteLogStatisticsToTable = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            setField8(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), context));
            result.@TraceFileName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField21(result, (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>), context));
            result.@TraceToConsole = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@TurnWarningLengthThreshold = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@UseNagleAlgorithm = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            setField0(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField19(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Runtime.Configuration.NodeConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ClusterConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("<Defaults>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.NodeConfiguration> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.NodeConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("<Globals>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("<IsRunningAsUnitTest>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean> getField7 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean> setField7 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("<Overrides>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>> setField4 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("<SourceFile>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("listeners", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>> getField6 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>> setField6 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("overrideXml", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>> getField5 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>> setField5 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetTypeInfo().@GetField("primaryNode", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint> getField3 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint> setField3 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.ClusterConfiguration input = ((global::Orleans.Runtime.Configuration.ClusterConfiguration)original);
            global::Orleans.Runtime.Configuration.ClusterConfiguration result = new global::Orleans.Runtime.Configuration.ClusterConfiguration();
            context.@RecordCopy(original, result);
            setField1(result, (global::Orleans.Runtime.Configuration.NodeConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Defaults, context));
            setField0(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Globals, context));
            setField7(result, getField7(input));
            setField4(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Overrides, context));
            setField2(result, input.@SourceFile);
            setField6(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input), context));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input), context));
            setField3(result, getField3(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ClusterConfiguration input = (global::Orleans.Runtime.Configuration.ClusterConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Defaults, context, typeof (global::Orleans.Runtime.Configuration.NodeConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Globals, context, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Overrides, context, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SourceFile, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Net.IPEndPoint));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.ClusterConfiguration result = new global::Orleans.Runtime.Configuration.ClusterConfiguration();
            context.@RecordObject(result);
            setField1(result, (global::Orleans.Runtime.Configuration.NodeConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.NodeConfiguration), context));
            setField0(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration), context));
            setField7(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField4(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>), context));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField6(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>), context));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>), context));
            setField3(result, (global::System.Net.IPEndPoint)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.IPEndPoint), context));
            return (global::Orleans.Runtime.Configuration.ClusterConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_GlobalConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("<Application>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ApplicationConfiguration> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ApplicationConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field29 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("<CollectionQuantum>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan> getField29 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetGetter(field29);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan> setField29 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field29);
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("<ExpectedClusterSizeConfigValue>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>> getField10 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field10);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>> setField10 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field10);
        private static readonly global::System.Reflection.FieldInfo field35 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("<MaxStorageBusyRetries>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Int32> setField35 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field35);
        private static readonly global::System.Reflection.FieldInfo field73 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<MessageLossInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField73 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field73);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField73 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field73);
        private static readonly global::System.Reflection.FieldInfo field49 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("<PerformDeadlockDetection>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> getField49 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field49);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> setField49 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field49);
        private static readonly global::System.Reflection.FieldInfo field72 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<RejectionInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField72 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field72);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField72 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field72);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("<SeedNodes>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field70 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<SerializationProviders>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>> setField70 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field70);
        private static readonly global::System.Reflection.FieldInfo field44 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("UseMockReminderTable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> getField44 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field44);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> setField44 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field44);
        private static readonly global::System.Reflection.FieldInfo field55 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("adoInvariantForReminders", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> getField55 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field55);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> setField55 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field55);
        private static readonly global::System.Reflection.FieldInfo field54 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("dataConnectionStringForReminders", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> getField54 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field54);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> setField54 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field54);
        private static readonly global::System.Reflection.FieldInfo field74 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("isSiloConfig", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> getField74 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field74);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> setField74 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field74);
        private static readonly global::System.Reflection.FieldInfo field39 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("livenessServiceType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType> getField39 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType>)global::Orleans.Serialization.SerializationManager.@GetGetter(field39);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType> setField39 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field39);
        private static readonly global::System.Reflection.FieldInfo field42 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetTypeInfo().@GetField("reminderServiceType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType> getField42 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType>)global::Orleans.Serialization.SerializationManager.@GetGetter(field42);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType> setField42 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field42);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration input = ((global::Orleans.Runtime.Configuration.GlobalConfiguration)original);
            global::Orleans.Runtime.Configuration.GlobalConfiguration result = (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration));
            context.@RecordCopy(original, result);
            result.@ActivationCountBasedPlacementChooseOutOf = input.@ActivationCountBasedPlacementChooseOutOf;
            result.@AdoInvariant = input.@AdoInvariant;
            setField0(result, (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Application, context));
            result.@AssumeHomogenousSilosForTesting = input.@AssumeHomogenousSilosForTesting;
            result.@BackgroundGossipInterval = input.@BackgroundGossipInterval;
            result.@BufferPoolBufferSize = input.@BufferPoolBufferSize;
            result.@BufferPoolMaxSize = input.@BufferPoolMaxSize;
            result.@BufferPoolPreallocationSize = input.@BufferPoolPreallocationSize;
            result.@CacheSize = input.@CacheSize;
            result.@CacheTTLExtensionFactor = input.@CacheTTLExtensionFactor;
            result.@ClientDropTimeout = input.@ClientDropTimeout;
            result.@ClientRegistrationRefresh = input.@ClientRegistrationRefresh;
            result.@ClientSenderBuckets = input.@ClientSenderBuckets;
            result.@ClusterId = input.@ClusterId;
            setField29(result, getField29(input));
            result.@DataConnectionString = input.@DataConnectionString;
            result.@DeathVoteExpirationTimeout = input.@DeathVoteExpirationTimeout;
            result.@DefaultMultiCluster = (global::System.Collections.Generic.IReadOnlyList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@DefaultMultiCluster, context);
            result.@DefaultPlacementStrategy = input.@DefaultPlacementStrategy;
            result.@DeploymentId = input.@DeploymentId;
            result.@DeploymentLoadPublisherRefreshTime = input.@DeploymentLoadPublisherRefreshTime;
            result.@DirectoryCachingStrategy = input.@DirectoryCachingStrategy;
            result.@DirectoryLazyDeregistrationDelay = input.@DirectoryLazyDeregistrationDelay;
            result.@DropExpiredMessages = input.@DropExpiredMessages;
            setField10(result, (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField10(input), context));
            result.@FallbackSerializationProvider = (global::System.Reflection.TypeInfo)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@FallbackSerializationProvider, context);
            result.@GatewaySenderQueues = input.@GatewaySenderQueues;
            result.@GlobalSingleInstanceNumberRetries = input.@GlobalSingleInstanceNumberRetries;
            result.@GlobalSingleInstanceRetryInterval = input.@GlobalSingleInstanceRetryInterval;
            result.@GossipChannels = (global::System.Collections.Generic.IReadOnlyList<global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GossipChannels, context);
            result.@GrainServiceConfigurations = (global::Orleans.Runtime.Configuration.GrainServiceConfigurations)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainServiceConfigurations, context);
            result.@IAmAliveTablePublishTimeout = input.@IAmAliveTablePublishTimeout;
            result.@InitialCacheTTL = input.@InitialCacheTTL;
            result.@LivenessEnabled = input.@LivenessEnabled;
            result.@MaxForwardCount = input.@MaxForwardCount;
            result.@MaxJoinAttemptTime = input.@MaxJoinAttemptTime;
            result.@MaxMultiClusterGateways = input.@MaxMultiClusterGateways;
            result.@MaxRequestProcessingTime = input.@MaxRequestProcessingTime;
            result.@MaxResendCount = input.@MaxResendCount;
            result.@MaxSocketAge = input.@MaxSocketAge;
            setField35(result, input.@MaxStorageBusyRetries);
            result.@MaximumCacheTTL = input.@MaximumCacheTTL;
            result.@MembershipTableAssembly = input.@MembershipTableAssembly;
            setField73(result, getField73(input));
            result.@MockReminderTableTimeout = input.@MockReminderTableTimeout;
            result.@NumMissedProbesLimit = input.@NumMissedProbesLimit;
            result.@NumMissedTableIAmAliveLimit = input.@NumMissedTableIAmAliveLimit;
            result.@NumProbedSilos = input.@NumProbedSilos;
            result.@NumVirtualBucketsConsistentRing = input.@NumVirtualBucketsConsistentRing;
            result.@NumVotesForDeathDeclaration = input.@NumVotesForDeathDeclaration;
            result.@OpenConnectionTimeout = input.@OpenConnectionTimeout;
            setField49(result, getField49(input));
            result.@ProbeTimeout = input.@ProbeTimeout;
            result.@ProviderConfigurations = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ProviderConfigurations, context);
            setField72(result, getField72(input));
            result.@ReminderTableAssembly = input.@ReminderTableAssembly;
            result.@ResendOnTimeout = input.@ResendOnTimeout;
            result.@ResponseTimeout = input.@ResponseTimeout;
            setField1(result, (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SeedNodes, context));
            setField70(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SerializationProviders, context));
            result.@ServiceId = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ServiceId, context);
            result.@SiloSenderQueues = input.@SiloSenderQueues;
            result.@Subnet = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Subnet, context);
            result.@TableRefreshTimeout = input.@TableRefreshTimeout;
            result.@TypeMapRefreshInterval = input.@TypeMapRefreshInterval;
            result.@UseGlobalSingleInstanceByDefault = input.@UseGlobalSingleInstanceByDefault;
            result.@UseLivenessGossip = input.@UseLivenessGossip;
            result.@UseVirtualBucketsConsistentRing = input.@UseVirtualBucketsConsistentRing;
            result.@ValidateInitialConnectivity = input.@ValidateInitialConnectivity;
            setField44(result, getField44(input));
            setField55(result, getField55(input));
            setField54(result, getField54(input));
            setField74(result, getField74(input));
            setField39(result, getField39(input));
            setField42(result, getField42(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration input = (global::Orleans.Runtime.Configuration.GlobalConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCountBasedPlacementChooseOutOf, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AdoInvariant, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Application, context, typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AssumeHomogenousSilosForTesting, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BackgroundGossipInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolBufferSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolMaxSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolPreallocationSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CacheSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CacheTTLExtensionFactor, context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientDropTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientRegistrationRefresh, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientSenderBuckets, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClusterId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField29(input), context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DataConnectionString, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeathVoteExpirationTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultMultiCluster, context, typeof (global::System.Collections.Generic.IReadOnlyList<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultPlacementStrategy, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentLoadPublisherRefreshTime, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DirectoryCachingStrategy, context, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.DirectoryCachingStrategyType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DirectoryLazyDeregistrationDelay, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DropExpiredMessages, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField10(input), context, typeof (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FallbackSerializationProvider, context, typeof (global::System.Reflection.TypeInfo));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewaySenderQueues, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GlobalSingleInstanceNumberRetries, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GlobalSingleInstanceRetryInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GossipChannels, context, typeof (global::System.Collections.Generic.IReadOnlyList<global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainServiceConfigurations, context, typeof (global::Orleans.Runtime.Configuration.GrainServiceConfigurations));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IAmAliveTablePublishTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@InitialCacheTTL, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LivenessEnabled, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxForwardCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxJoinAttemptTime, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxMultiClusterGateways, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxRequestProcessingTime, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxResendCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxSocketAge, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxStorageBusyRetries, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaximumCacheTTL, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MembershipTableAssembly, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField73(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MockReminderTableTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumMissedProbesLimit, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumMissedTableIAmAliveLimit, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumProbedSilos, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumVirtualBucketsConsistentRing, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumVotesForDeathDeclaration, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@OpenConnectionTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField49(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProbeTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProviderConfigurations, context, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField72(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderTableAssembly, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResendOnTimeout, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResponseTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SeedNodes, context, typeof (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SerializationProviders, context, typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ServiceId, context, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloSenderQueues, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Subnet, context, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TableRefreshTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TypeMapRefreshInterval, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseGlobalSingleInstanceByDefault, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseLivenessGossip, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseVirtualBucketsConsistentRing, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ValidateInitialConnectivity, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField44(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField55(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField54(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField74(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField39(input), context, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField42(input), context, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration result = (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration));
            context.@RecordObject(result);
            result.@ActivationCountBasedPlacementChooseOutOf = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@AdoInvariant = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField0(result, (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration), context));
            result.@AssumeHomogenousSilosForTesting = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@BackgroundGossipInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@BufferPoolBufferSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BufferPoolMaxSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BufferPoolPreallocationSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@CacheSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@CacheTTLExtensionFactor = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context);
            result.@ClientDropTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@ClientRegistrationRefresh = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@ClientSenderBuckets = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@ClusterId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField29(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context));
            result.@DataConnectionString = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@DeathVoteExpirationTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@DefaultMultiCluster = (global::System.Collections.Generic.IReadOnlyList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyList<global::System.String>), context);
            result.@DefaultPlacementStrategy = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@DeploymentId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@DeploymentLoadPublisherRefreshTime = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@DirectoryCachingStrategy = (global::Orleans.Runtime.Configuration.GlobalConfiguration.DirectoryCachingStrategyType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.DirectoryCachingStrategyType), context);
            result.@DirectoryLazyDeregistrationDelay = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@DropExpiredMessages = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            setField10(result, (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>), context));
            result.@FallbackSerializationProvider = (global::System.Reflection.TypeInfo)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Reflection.TypeInfo), context);
            result.@GatewaySenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@GlobalSingleInstanceNumberRetries = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@GlobalSingleInstanceRetryInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@GossipChannels = (global::System.Collections.Generic.IReadOnlyList<global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyList<global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration>), context);
            result.@GrainServiceConfigurations = (global::Orleans.Runtime.Configuration.GrainServiceConfigurations)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GrainServiceConfigurations), context);
            result.@IAmAliveTablePublishTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@InitialCacheTTL = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@LivenessEnabled = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@MaxForwardCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxJoinAttemptTime = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@MaxMultiClusterGateways = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxRequestProcessingTime = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@MaxResendCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxSocketAge = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField35(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            result.@MaximumCacheTTL = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@MembershipTableAssembly = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField73(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            result.@MockReminderTableTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@NumMissedProbesLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@NumMissedTableIAmAliveLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@NumProbedSilos = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@NumVirtualBucketsConsistentRing = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@NumVotesForDeathDeclaration = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@OpenConnectionTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField49(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            result.@ProbeTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@ProviderConfigurations = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>), context);
            setField72(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            result.@ReminderTableAssembly = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ResendOnTimeout = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@ResponseTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField1(result, (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>), context));
            setField70(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>), context));
            result.@ServiceId = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context);
            result.@SiloSenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@Subnet = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), context);
            result.@TableRefreshTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@TypeMapRefreshInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@UseGlobalSingleInstanceByDefault = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@UseLivenessGossip = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@UseVirtualBucketsConsistentRing = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@ValidateInitialConnectivity = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            setField44(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField55(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField54(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField74(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField39(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType), context));
            setField42(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType), context));
            return (global::Orleans.Runtime.Configuration.GlobalConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.GrainServiceConfigurations))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_GrainServiceConfigurationsSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.GrainServiceConfigurations input = ((global::Orleans.Runtime.Configuration.GrainServiceConfigurations)original);
            global::Orleans.Runtime.Configuration.GrainServiceConfigurations result = new global::Orleans.Runtime.Configuration.GrainServiceConfigurations();
            context.@RecordCopy(original, result);
            result.@GrainServices = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.IGrainServiceConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainServices, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.GrainServiceConfigurations input = (global::Orleans.Runtime.Configuration.GrainServiceConfigurations)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainServices, context, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.IGrainServiceConfiguration>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.GrainServiceConfigurations result = new global::Orleans.Runtime.Configuration.GrainServiceConfigurations();
            context.@RecordObject(result);
            result.@GrainServices = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.IGrainServiceConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.IGrainServiceConfiguration>), context);
            return (global::Orleans.Runtime.Configuration.GrainServiceConfigurations)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_GlobalConfigurationSerializer_GossipChannelConfigurationSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration input = ((global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration)original);
            global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration result = new global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration();
            context.@RecordCopy(original, result);
            result.@ChannelType = input.@ChannelType;
            result.@ConnectionString = input.@ConnectionString;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration input = (global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ChannelType, context, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ConnectionString, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration result = new global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration();
            context.@RecordObject(result);
            result.@ChannelType = (global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelType), context);
            result.@ConnectionString = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            return (global::Orleans.Runtime.Configuration.GlobalConfiguration.GossipChannelConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ConfigValue<>))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ConfigValueSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>).@GetTypeInfo().@GetField("IsDefaultValue", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>).@GetTypeInfo().@GetField("Value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, T> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, T>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, T> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, T>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.ConfigValue<T> input = ((global::Orleans.Runtime.Configuration.ConfigValue<T>)original);
            global::Orleans.Runtime.Configuration.ConfigValue<T> result = (global::Orleans.Runtime.Configuration.ConfigValue<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>));
            context.@RecordCopy(original, result);
            setField1(result, getField1(input));
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ConfigValue<T> input = (global::Orleans.Runtime.Configuration.ConfigValue<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.ConfigValue<T> result = (global::Orleans.Runtime.Configuration.ConfigValue<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>));
            context.@RecordObject(result);
            setField1(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), context));
            return (global::Orleans.Runtime.Configuration.ConfigValue<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ApplicationConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration).@GetTypeInfo().@GetField("classSpecific", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration).@GetTypeInfo().@GetField("defaults", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.ApplicationConfiguration input = ((global::Orleans.Runtime.Configuration.ApplicationConfiguration)original);
            global::Orleans.Runtime.Configuration.ApplicationConfiguration result = (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField1(result, (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ApplicationConfiguration input = (global::Orleans.Runtime.Configuration.ApplicationConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.ApplicationConfiguration result = (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration));
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>), context));
            setField1(result, (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration), context));
            return (global::Orleans.Runtime.Configuration.ApplicationConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_GrainTypeConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration).@GetTypeInfo().@GetField("<FullTypeName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.String> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration).@GetTypeInfo().@GetField("collectionAgeLimit", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration input = ((global::Orleans.Runtime.Configuration.GrainTypeConfiguration)original);
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration result = (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration));
            context.@RecordCopy(original, result);
            setField0(result, input.@FullTypeName);
            setField1(result, (global::System.Nullable<global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration input = (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FullTypeName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Nullable<global::System.TimeSpan>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration result = (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration));
            context.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.Nullable<global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Nullable<global::System.TimeSpan>), context));
            return (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ProviderCategoryConfigurationSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration input = ((global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)original);
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration result = (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration));
            context.@RecordCopy(original, result);
            result.@Name = input.@Name;
            result.@Providers = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Providers, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration input = (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Providers, context, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration result = (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration));
            context.@RecordObject(result);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Providers = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>), context);
            return (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)result;
        }
    }
}

namespace Orleans.TestingHost
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.TestingHost.IStorageFaultGrain))]
    internal class OrleansCodeGenStorageFaultGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.TestingHost.IStorageFaultGrain
    {
        protected @OrleansCodeGenStorageFaultGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStorageFaultGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1063077025;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.TestingHost.IStorageFaultGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1063077025 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1063077025:
                    switch (@methodId)
                    {
                        case -1742425208:
                            return "AddFaultOnRead";
                        case 1076776638:
                            return "AddFaultOnWrite";
                        case 1060314240:
                            return "AddFaultOnClear";
                        case 1083973229:
                            return "OnRead";
                        case -1297269938:
                            return "OnWrite";
                        case -1186059087:
                            return "OnClear";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1063077025 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @AddFaultOnRead(global::Orleans.Runtime.GrainReference @grainReference, global::System.Exception @exception)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1742425208, new global::System.Object[]{@grainReference, @exception});
        }

        public global::System.Threading.Tasks.Task @AddFaultOnWrite(global::Orleans.Runtime.GrainReference @grainReference, global::System.Exception @exception)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1076776638, new global::System.Object[]{@grainReference, @exception});
        }

        public global::System.Threading.Tasks.Task @AddFaultOnClear(global::Orleans.Runtime.GrainReference @grainReference, global::System.Exception @exception)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1060314240, new global::System.Object[]{@grainReference, @exception});
        }

        public global::System.Threading.Tasks.Task @OnRead(global::Orleans.Runtime.GrainReference @grainReference)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1083973229, new global::System.Object[]{@grainReference});
        }

        public global::System.Threading.Tasks.Task @OnWrite(global::Orleans.Runtime.GrainReference @grainReference)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1297269938, new global::System.Object[]{@grainReference});
        }

        public global::System.Threading.Tasks.Task @OnClear(global::Orleans.Runtime.GrainReference @grainReference)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1186059087, new global::System.Object[]{@grainReference});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.TestingHost.IStorageFaultGrain), -1063077025), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStorageFaultGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            if (@grain == null)
                throw new global::System.ArgumentNullException("grain");
            switch (interfaceId)
            {
                case -1063077025:
                    switch (methodId)
                    {
                        case -1742425208:
                            return ((global::Orleans.TestingHost.IStorageFaultGrain)@grain).@AddFaultOnRead((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.Exception)arguments[1]).@Box();
                        case 1076776638:
                            return ((global::Orleans.TestingHost.IStorageFaultGrain)@grain).@AddFaultOnWrite((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.Exception)arguments[1]).@Box();
                        case 1060314240:
                            return ((global::Orleans.TestingHost.IStorageFaultGrain)@grain).@AddFaultOnClear((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.Exception)arguments[1]).@Box();
                        case 1083973229:
                            return ((global::Orleans.TestingHost.IStorageFaultGrain)@grain).@OnRead((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                        case -1297269938:
                            return ((global::Orleans.TestingHost.IStorageFaultGrain)@grain).@OnWrite((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                        case -1186059087:
                            return ((global::Orleans.TestingHost.IStorageFaultGrain)@grain).@OnClear((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1063077025 + ",methodId=" + methodId);
                    }

                case -1277021679:
                    switch (methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1063077025;
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
