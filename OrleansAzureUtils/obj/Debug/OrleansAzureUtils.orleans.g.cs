#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("OrleansAzureUtils, Version=1.4.2.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.Providers.Streams.AzureQueue
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2))]
    internal class OrleansCodeGenOrleans_Providers_Streams_AzureQueue_AzureQueueBatchContainerV2Serializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2).@GetTypeInfo().@GetField("<StreamGuid>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Guid> setField3 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2).@GetTypeInfo().@GetField("<StreamNamespace>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.String> setField4 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2).@GetTypeInfo().@GetField("events", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.List<global::System.Object>> getField1 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.List<global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.List<global::System.Object>> setField1 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.List<global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2).@GetTypeInfo().@GetField("requestContext", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> getField2 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> setField2 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2).@GetTypeInfo().@GetField("sequenceToken", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::Orleans.Providers.Streams.Common.EventSequenceTokenV2> getField0 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::Orleans.Providers.Streams.Common.EventSequenceTokenV2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::Orleans.Providers.Streams.Common.EventSequenceTokenV2> setField0 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2, global::Orleans.Providers.Streams.Common.EventSequenceTokenV2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2 input = ((global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2)original);
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2 result = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2));
            context.@RecordCopy(original, result);
            setField3(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@StreamGuid, context));
            setField4(result, input.@StreamNamespace);
            setField1(result, (global::System.Collections.Generic.List<global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField2(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField0(result, (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2 input = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamGuid, context, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamNamespace, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Collections.Generic.List<global::System.Object>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2 result = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2));
            context.@RecordObject(result);
            setField3(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context));
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.Collections.Generic.List<global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Object>), context));
            setField2(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>), context));
            setField0(result, (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2), context));
            return (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainerV2)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2))]
    internal class OrleansCodeGenOrleans_Providers_Streams_Common_EventSequenceTokenV2Serializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2).@GetTypeInfo().@GetField("<EventIndex>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Common.EventSequenceTokenV2, global::System.Int32> setField1 = (global::System.Action<global::Orleans.Providers.Streams.Common.EventSequenceTokenV2, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2).@GetTypeInfo().@GetField("<SequenceNumber>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Common.EventSequenceTokenV2, global::System.Int64> setField0 = (global::System.Action<global::Orleans.Providers.Streams.Common.EventSequenceTokenV2, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceTokenV2 input = ((global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)original);
            global::Orleans.Providers.Streams.Common.EventSequenceTokenV2 result = (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2));
            context.@RecordCopy(original, result);
            setField1(result, input.@EventIndex);
            setField0(result, input.@SequenceNumber);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceTokenV2 input = (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventIndex, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SequenceNumber, context, typeof (global::System.Int64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceTokenV2 result = (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2));
            context.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField0(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            return (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.AzureUtils.ClientMetricsData))]
    internal class OrleansCodeGenOrleans_AzureUtils_ClientMetricsDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field16 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledRead>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField16 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field16);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField16 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field16);
        private static readonly global::System.Reflection.FieldInfo field15 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledWrite>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField15 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field15);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField15 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field15);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.AzureUtils.ClientMetricsData input = ((global::Orleans.AzureUtils.ClientMetricsData)original);
            global::Orleans.AzureUtils.ClientMetricsData result = new global::Orleans.AzureUtils.ClientMetricsData();
            context.@RecordCopy(original, result);
            result.@Address = input.@Address;
            result.@CPU = input.@CPU;
            result.@ClientId = input.@ClientId;
            setField16(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField16(input), context));
            setField15(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField15(input), context));
            result.@ConnectedGatewayCount = input.@ConnectedGatewayCount;
            result.@DeploymentId = input.@DeploymentId;
            result.@ETag = input.@ETag;
            result.@HostName = input.@HostName;
            result.@MemoryUsage = input.@MemoryUsage;
            result.@PartitionKey = input.@PartitionKey;
            result.@ReceiveQueue = input.@ReceiveQueue;
            result.@ReceivedMessages = input.@ReceivedMessages;
            result.@RowKey = input.@RowKey;
            result.@SendQueue = input.@SendQueue;
            result.@SentMessages = input.@SentMessages;
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Timestamp, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.AzureUtils.ClientMetricsData input = (global::Orleans.AzureUtils.ClientMetricsData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Address, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CPU, context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField16(input), context, typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField15(input), context, typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ConnectedGatewayCount, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MemoryUsage, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PartitionKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceiveQueue, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceivedMessages, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RowKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SendQueue, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SentMessages, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Timestamp, context, typeof (global::System.DateTimeOffset));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.AzureUtils.ClientMetricsData result = new global::Orleans.AzureUtils.ClientMetricsData();
            context.@RecordObject(result);
            result.@Address = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@CPU = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context);
            result.@ClientId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField16(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            setField15(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            result.@ConnectedGatewayCount = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@DeploymentId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@HostName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@MemoryUsage = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@PartitionKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ReceiveQueue = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@ReceivedMessages = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@RowKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@SendQueue = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@SentMessages = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTimeOffset), context);
            return (global::Orleans.AzureUtils.ClientMetricsData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.AzureUtils.SiloMetricsData))]
    internal class OrleansCodeGenOrleans_AzureUtils_SiloMetricsDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field21 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledRead>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField21 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field21);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField21 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field21);
        private static readonly global::System.Reflection.FieldInfo field20 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledWrite>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField20 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field20);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField20 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field20);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.AzureUtils.SiloMetricsData input = ((global::Orleans.AzureUtils.SiloMetricsData)original);
            global::Orleans.AzureUtils.SiloMetricsData result = new global::Orleans.AzureUtils.SiloMetricsData();
            context.@RecordCopy(original, result);
            result.@Activations = input.@Activations;
            result.@Address = input.@Address;
            result.@CPU = input.@CPU;
            result.@ClientCount = input.@ClientCount;
            setField21(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField21(input), context));
            setField20(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField20(input), context));
            result.@DeploymentId = input.@DeploymentId;
            result.@ETag = input.@ETag;
            result.@GatewayAddress = input.@GatewayAddress;
            result.@HostName = input.@HostName;
            result.@LoadShedding = input.@LoadShedding;
            result.@MemoryUsage = input.@MemoryUsage;
            result.@PartitionKey = input.@PartitionKey;
            result.@ReceiveQueue = input.@ReceiveQueue;
            result.@ReceivedMessages = input.@ReceivedMessages;
            result.@RecentlyUsedActivations = input.@RecentlyUsedActivations;
            result.@RequestQueue = input.@RequestQueue;
            result.@RowKey = input.@RowKey;
            result.@SendQueue = input.@SendQueue;
            result.@SentMessages = input.@SentMessages;
            result.@SiloName = input.@SiloName;
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Timestamp, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.AzureUtils.SiloMetricsData input = (global::Orleans.AzureUtils.SiloMetricsData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Activations, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Address, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CPU, context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientCount, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField21(input), context, typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField20(input), context, typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewayAddress, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LoadShedding, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MemoryUsage, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PartitionKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceiveQueue, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceivedMessages, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RecentlyUsedActivations, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RequestQueue, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RowKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SendQueue, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SentMessages, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Timestamp, context, typeof (global::System.DateTimeOffset));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.AzureUtils.SiloMetricsData result = new global::Orleans.AzureUtils.SiloMetricsData();
            context.@RecordObject(result);
            result.@Activations = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@Address = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@CPU = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context);
            result.@ClientCount = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            setField21(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            setField20(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            result.@DeploymentId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@GatewayAddress = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@HostName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@LoadShedding = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@MemoryUsage = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@PartitionKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ReceiveQueue = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@ReceivedMessages = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@RecentlyUsedActivations = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@RequestQueue = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@RowKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@SendQueue = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@SentMessages = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            result.@SiloName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTimeOffset), context);
            return (global::Orleans.AzureUtils.SiloMetricsData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.AzureUtils.StatsTableData))]
    internal class OrleansCodeGenOrleans_AzureUtils_StatsTableDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledRead>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField13 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field13);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField13 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field13);
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledWrite>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField12 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field12);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField12 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field12);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.AzureUtils.StatsTableData input = ((global::Orleans.AzureUtils.StatsTableData)original);
            global::Orleans.AzureUtils.StatsTableData result = new global::Orleans.AzureUtils.StatsTableData();
            context.@RecordCopy(original, result);
            result.@Address = input.@Address;
            setField13(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField13(input), context));
            setField12(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField12(input), context));
            result.@DeploymentId = input.@DeploymentId;
            result.@ETag = input.@ETag;
            result.@HostName = input.@HostName;
            result.@IsDelta = input.@IsDelta;
            result.@Name = input.@Name;
            result.@PartitionKey = input.@PartitionKey;
            result.@RowKey = input.@RowKey;
            result.@StatValue = input.@StatValue;
            result.@Statistic = input.@Statistic;
            result.@Time = input.@Time;
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Timestamp, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.AzureUtils.StatsTableData input = (global::Orleans.AzureUtils.StatsTableData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Address, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField13(input), context, typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField12(input), context, typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsDelta, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PartitionKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RowKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatValue, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Statistic, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Time, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Timestamp, context, typeof (global::System.DateTimeOffset));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.AzureUtils.StatsTableData result = new global::Orleans.AzureUtils.StatsTableData();
            context.@RecordObject(result);
            result.@Address = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField13(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            setField12(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            result.@DeploymentId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@HostName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@IsDelta = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@PartitionKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@RowKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StatValue = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Statistic = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Time = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTimeOffset), context);
            return (global::Orleans.AzureUtils.StatsTableData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer))]
    internal class OrleansCodeGenOrleans_Providers_Streams_AzureQueue_AzureQueueBatchContainerSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer).@GetTypeInfo().@GetField("<StreamGuid>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Guid> setField3 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer).@GetTypeInfo().@GetField("<StreamNamespace>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.String> setField4 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer).@GetTypeInfo().@GetField("events", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.List<global::System.Object>> getField1 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.List<global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.List<global::System.Object>> setField1 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.List<global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer).@GetTypeInfo().@GetField("requestContext", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> getField2 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> setField2 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer).@GetTypeInfo().@GetField("sequenceToken", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceToken> getField0 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceToken> setField0 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer input = ((global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer)original);
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer result = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer));
            context.@RecordCopy(original, result);
            setField3(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@StreamGuid, context));
            setField4(result, input.@StreamNamespace);
            setField1(result, (global::System.Collections.Generic.List<global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField2(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField0(result, (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer input = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamGuid, context, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamNamespace, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Collections.Generic.List<global::System.Object>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer result = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer));
            context.@RecordObject(result);
            setField3(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context));
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.Collections.Generic.List<global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Object>), context));
            setField2(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>), context));
            setField0(result, (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken), context));
            return (global::Orleans.Providers.Streams.AzureQueue.AzureQueueBatchContainer)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken))]
    internal class OrleansCodeGenOrleans_Providers_Streams_Common_EventSequenceTokenSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceToken input = ((global::Orleans.Providers.Streams.Common.EventSequenceToken)original);
            global::Orleans.Providers.Streams.Common.EventSequenceToken result = (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken));
            context.@RecordCopy(original, result);
            result.@EventIndex = input.@EventIndex;
            result.@SequenceNumber = input.@SequenceNumber;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceToken input = (global::Orleans.Providers.Streams.Common.EventSequenceToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventIndex, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SequenceNumber, context, typeof (global::System.Int64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceToken result = (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken));
            context.@RecordObject(result);
            result.@EventIndex = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@SequenceNumber = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context);
            return (global::Orleans.Providers.Streams.Common.EventSequenceToken)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1))]
    internal class OrleansCodeGenOrleans_Providers_Streams_AzureQueue_AzureQueueDataAdapterV1Serializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1 input = ((global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1)original);
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1 result = new global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1();
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1 input = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1 result = new global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1();
            context.@RecordObject(result);
            return (global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV1)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<>))]
    internal class OrleansCodeGenOrleans_Providers_Streams_AzureQueue_AzureQueueAdapterFactorySerializer<TDataAdapter>
        where TDataAdapter : global::Orleans.Providers.Streams.AzureQueue.IAzureQueueDataAdapter, new ()
    {
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("<StreamFailureHandlerFactory>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>> getField8 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field8);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>> setField8 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("adapterCache", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.IQueueAdapterCache> getField7 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.IQueueAdapterCache>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.IQueueAdapterCache> setField7 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.IQueueAdapterCache>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("cacheSize", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32> getField3 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32> setField3 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("dataConnectionString", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String> getField1 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String> setField1 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("deploymentId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String> getField0 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String> setField0 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("messageVisibilityTimeout", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Nullable<global::System.TimeSpan>> getField5 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Nullable<global::System.TimeSpan>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Nullable<global::System.TimeSpan>> setField5 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Nullable<global::System.TimeSpan>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("numQueues", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32> getField4 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32> setField4 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("providerName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String> getField2 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String> setField2 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>).@GetTypeInfo().@GetField("streamQueueMapper", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.HashRingBasedStreamQueueMapper> getField6 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.HashRingBasedStreamQueueMapper>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.HashRingBasedStreamQueueMapper> setField6 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>, global::Orleans.Streams.HashRingBasedStreamQueueMapper>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter> input = ((global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>)original);
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter> result = new global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>();
            context.@RecordCopy(original, result);
            setField8(result, (global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField8(input), context));
            setField7(result, (global::Orleans.Streams.IQueueAdapterCache)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField7(input), context));
            setField3(result, getField3(input));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            setField5(result, (global::System.Nullable<global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input), context));
            setField4(result, getField4(input));
            setField2(result, getField2(input));
            setField6(result, (global::Orleans.Streams.HashRingBasedStreamQueueMapper)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter> input = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField8(input), context, typeof (global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), context, typeof (global::Orleans.Streams.IQueueAdapterCache));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::System.Nullable<global::System.TimeSpan>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::Orleans.Streams.HashRingBasedStreamQueueMapper));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter> result = new global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>();
            context.@RecordObject(result);
            setField8(result, (global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::Orleans.Streams.QueueId, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>), context));
            setField7(result, (global::Orleans.Streams.IQueueAdapterCache)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IQueueAdapterCache), context));
            setField3(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField5(result, (global::System.Nullable<global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Nullable<global::System.TimeSpan>), context));
            setField4(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField6(result, (global::Orleans.Streams.HashRingBasedStreamQueueMapper)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.HashRingBasedStreamQueueMapper), context));
            return (global::Orleans.Providers.Streams.AzureQueue.AzureQueueAdapterFactory<TDataAdapter>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.HashRingBasedStreamQueueMapper))]
    internal class OrleansCodeGenOrleans_Streams_HashRingBasedStreamQueueMapperSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.HashRingBasedStreamQueueMapper).@GetTypeInfo().@GetField("hashRing", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>> getField1 = (global::System.Func<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>> setField1 = (global::System.Action<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.HashRingBasedStreamQueueMapper).@GetTypeInfo().@GetField("numQueues", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::System.Int32> getField0 = (global::System.Func<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Streams.HashRingBasedStreamQueueMapper, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.HashRingBasedStreamQueueMapper input = ((global::Orleans.Streams.HashRingBasedStreamQueueMapper)original);
            global::Orleans.Streams.HashRingBasedStreamQueueMapper result = (global::Orleans.Streams.HashRingBasedStreamQueueMapper)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.HashRingBasedStreamQueueMapper));
            context.@RecordCopy(original, result);
            setField1(result, (global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField0(result, getField0(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.HashRingBasedStreamQueueMapper input = (global::Orleans.Streams.HashRingBasedStreamQueueMapper)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.HashRingBasedStreamQueueMapper result = (global::Orleans.Streams.HashRingBasedStreamQueueMapper)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.HashRingBasedStreamQueueMapper));
            context.@RecordObject(result);
            setField1(result, (global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.HashRing<global::Orleans.Streams.QueueId>), context));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            return (global::Orleans.Streams.HashRingBasedStreamQueueMapper)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.HashRing<>))]
    internal class OrleansCodeGenOrleans_Runtime_HashRingSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.HashRing<T>).@GetTypeInfo().@GetField("lockable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.HashRing<T>, global::System.Object> getField1 = (global::System.Func<global::Orleans.Runtime.HashRing<T>, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.HashRing<T>, global::System.Object> setField1 = (global::System.Action<global::Orleans.Runtime.HashRing<T>, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.HashRing<T>).@GetTypeInfo().@GetField("sortedRingList", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.HashRing<T>, global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>> getField0 = (global::System.Func<global::Orleans.Runtime.HashRing<T>, global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.HashRing<T>, global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>> setField0 = (global::System.Action<global::Orleans.Runtime.HashRing<T>, global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.HashRing<T> input = ((global::Orleans.Runtime.HashRing<T>)original);
            global::Orleans.Runtime.HashRing<T> result = (global::Orleans.Runtime.HashRing<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.HashRing<T>));
            context.@RecordCopy(original, result);
            setField1(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField0(result, (global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.HashRing<T> input = (global::Orleans.Runtime.HashRing<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.HashRing<T> result = (global::Orleans.Runtime.HashRing<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.HashRing<T>));
            context.@RecordObject(result);
            setField1(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), context));
            setField0(result, (global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.IRingIdentifier<T>>), context));
            return (global::Orleans.Runtime.HashRing<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.QueueId))]
    internal class OrleansCodeGenOrleans_Streams_QueueIdSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.QueueId).@GetTypeInfo().@GetField("queueId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32> getField1 = (global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32> setField1 = (global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.QueueId).@GetTypeInfo().@GetField("queueNamePrefix", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.QueueId, global::System.String> getField0 = (global::System.Func<global::Orleans.Streams.QueueId, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.QueueId, global::System.String> setField0 = (global::System.Action<global::Orleans.Streams.QueueId, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.QueueId).@GetTypeInfo().@GetField("uniformHashCache", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32> getField2 = (global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32> setField2 = (global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            // No deep copy required since Orleans.Streams.QueueId is marked with the [Immutable] attribute.
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.QueueId input = (global::Orleans.Streams.QueueId)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.QueueId result = (global::Orleans.Streams.QueueId)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.QueueId));
            context.@RecordObject(result);
            setField1(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), context));
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField2(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), context));
            return (global::Orleans.Streams.QueueId)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2))]
    internal class OrleansCodeGenOrleans_Providers_Streams_AzureQueue_AzureQueueDataAdapterV2Serializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2 input = ((global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2)original);
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2 result = new global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2();
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2 input = (global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2 result = new global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2();
            context.@RecordObject(result);
            return (global::Orleans.Providers.Streams.AzureQueue.AzureQueueDataAdapterV2)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory))]
    internal class OrleansCodeGenOrleans_Providers_Streams_AzureQueue_SimpleAzureQueueAdapterFactorySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory).@GetTypeInfo().@GetField("dataConnectionString", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String> getField0 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String> setField0 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory).@GetTypeInfo().@GetField("providerName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String> getField2 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String> setField2 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory).@GetTypeInfo().@GetField("queueName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String> getField1 = (global::System.Func<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String> setField1 = (global::System.Action<global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory input = ((global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory)original);
            global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory result = new global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory();
            context.@RecordCopy(original, result);
            setField0(result, getField0(input));
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory input = (global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory result = new global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory();
            context.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Providers.Streams.AzureQueue.SimpleAzureQueueAdapterFactory)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.ReminderService.ReminderTableEntry))]
    internal class OrleansCodeGenOrleans_Runtime_ReminderService_ReminderTableEntrySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledRead>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField12 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field12);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField12 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field12);
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Microsoft.WindowsAzure.Storage.Table.TableEntity).@GetTypeInfo().@GetField("<CompiledWrite>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> getField11 = (global::System.Func<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field11);
        private static readonly global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>> setField11 = (global::System.Action<global::Microsoft.WindowsAzure.Storage.Table.TableEntity, global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field11);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.ReminderService.ReminderTableEntry input = ((global::Orleans.Runtime.ReminderService.ReminderTableEntry)original);
            global::Orleans.Runtime.ReminderService.ReminderTableEntry result = new global::Orleans.Runtime.ReminderService.ReminderTableEntry();
            context.@RecordCopy(original, result);
            setField12(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField12(input), context));
            setField11(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField11(input), context));
            result.@DeploymentId = input.@DeploymentId;
            result.@ETag = input.@ETag;
            result.@GrainRefConsistentHash = input.@GrainRefConsistentHash;
            result.@GrainReference = input.@GrainReference;
            result.@PartitionKey = input.@PartitionKey;
            result.@Period = input.@Period;
            result.@ReminderName = input.@ReminderName;
            result.@RowKey = input.@RowKey;
            result.@ServiceId = input.@ServiceId;
            result.@StartAt = input.@StartAt;
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Timestamp, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.ReminderService.ReminderTableEntry input = (global::Orleans.Runtime.ReminderService.ReminderTableEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField12(input), context, typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField11(input), context, typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainRefConsistentHash, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainReference, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PartitionKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Period, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RowKey, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ServiceId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartAt, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Timestamp, context, typeof (global::System.DateTimeOffset));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.ReminderService.ReminderTableEntry result = new global::Orleans.Runtime.ReminderService.ReminderTableEntry();
            context.@RecordObject(result);
            setField12(result, (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Action<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            setField11(result, (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::System.Object, global::Microsoft.WindowsAzure.Storage.OperationContext, global::System.Collections.Generic.IDictionary<global::System.String, global::Microsoft.WindowsAzure.Storage.Table.EntityProperty>>), context));
            result.@DeploymentId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@GrainRefConsistentHash = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@GrainReference = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@PartitionKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Period = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ReminderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@RowKey = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ServiceId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StartAt = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Timestamp = (global::System.DateTimeOffset)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTimeOffset), context);
            return (global::Orleans.Runtime.ReminderService.ReminderTableEntry)result;
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
