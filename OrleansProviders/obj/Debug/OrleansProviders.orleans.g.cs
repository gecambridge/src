#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("OrleansProviders, Version=1.4.2.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.Providers.Streams.Common
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer))]
    internal class OrleansCodeGenOrleans_Providers_Streams_Generator_GeneratedBatchContainerSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<Payload>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Object> setField3 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<RealToken>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceTokenV2> setField2 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceTokenV2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<StreamGuid>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<StreamNamespace>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.String> setField1 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer input = ((global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)original);
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer result = (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer));
            context.@RecordCopy(original, result);
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Payload, context));
            setField2(result, (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@RealToken, context));
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@StreamGuid, context));
            setField1(result, input.@StreamNamespace);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer input = (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Payload, context, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RealToken, context, typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamGuid, context, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamNamespace, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer result = (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer));
            context.@RecordObject(result);
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), context));
            setField2(result, (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Common.EventSequenceTokenV2), context));
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.MemoryBatchContainer<>))]
    internal class OrleansCodeGenOrleans_Providers_MemoryBatchContainerSerializer<TSerializer>
        where TSerializer : global::Orleans.Providers.IMemoryMessageBodySerializer, new ()
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.MemoryBatchContainer<TSerializer>).@GetTypeInfo().@GetField("realToken", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryBatchContainer<TSerializer>, global::Orleans.Providers.Streams.Common.EventSequenceToken> getField0 = (global::System.Func<global::Orleans.Providers.MemoryBatchContainer<TSerializer>, global::Orleans.Providers.Streams.Common.EventSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryBatchContainer<TSerializer>, global::Orleans.Providers.Streams.Common.EventSequenceToken> setField0 = (global::System.Action<global::Orleans.Providers.MemoryBatchContainer<TSerializer>, global::Orleans.Providers.Streams.Common.EventSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.MemoryBatchContainer<TSerializer> input = ((global::Orleans.Providers.MemoryBatchContainer<TSerializer>)original);
            global::Orleans.Providers.MemoryBatchContainer<TSerializer> result = (global::Orleans.Providers.MemoryBatchContainer<TSerializer>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.MemoryBatchContainer<TSerializer>));
            context.@RecordCopy(original, result);
            result.@MessageData = (global::Orleans.Providers.MemoryMessageData)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@MessageData, context);
            setField0(result, (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.MemoryBatchContainer<TSerializer> input = (global::Orleans.Providers.MemoryBatchContainer<TSerializer>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MessageData, context, typeof (global::Orleans.Providers.MemoryMessageData));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.MemoryBatchContainer<TSerializer> result = (global::Orleans.Providers.MemoryBatchContainer<TSerializer>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.MemoryBatchContainer<TSerializer>));
            context.@RecordObject(result);
            result.@MessageData = (global::Orleans.Providers.MemoryMessageData)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.MemoryMessageData), context);
            setField0(result, (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken), context));
            return (global::Orleans.Providers.MemoryBatchContainer<TSerializer>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.DefaultMemoryMessageBodySerializer))]
    internal class OrleansCodeGenOrleans_Providers_DefaultMemoryMessageBodySerializerSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.DefaultMemoryMessageBodySerializer input = ((global::Orleans.Providers.DefaultMemoryMessageBodySerializer)original);
            global::Orleans.Providers.DefaultMemoryMessageBodySerializer result = new global::Orleans.Providers.DefaultMemoryMessageBodySerializer();
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.DefaultMemoryMessageBodySerializer input = (global::Orleans.Providers.DefaultMemoryMessageBodySerializer)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.DefaultMemoryMessageBodySerializer result = new global::Orleans.Providers.DefaultMemoryMessageBodySerializer();
            context.@RecordObject(result);
            return (global::Orleans.Providers.DefaultMemoryMessageBodySerializer)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.MemoryMessageBody))]
    internal class OrleansCodeGenOrleans_Providers_MemoryMessageBodySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.MemoryMessageBody).@GetTypeInfo().@GetField("<Events>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.MemoryMessageBody, global::System.Collections.Generic.List<global::System.Object>> setField0 = (global::System.Action<global::Orleans.Providers.MemoryMessageBody, global::System.Collections.Generic.List<global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.MemoryMessageBody).@GetTypeInfo().@GetField("<RequestContext>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.MemoryMessageBody, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> setField1 = (global::System.Action<global::Orleans.Providers.MemoryMessageBody, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.MemoryMessageBody input = ((global::Orleans.Providers.MemoryMessageBody)original);
            global::Orleans.Providers.MemoryMessageBody result = (global::Orleans.Providers.MemoryMessageBody)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.MemoryMessageBody));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.List<global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Events, context));
            setField1(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@RequestContext, context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.MemoryMessageBody input = (global::Orleans.Providers.MemoryMessageBody)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Events, context, typeof (global::System.Collections.Generic.List<global::System.Object>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RequestContext, context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.MemoryMessageBody result = (global::Orleans.Providers.MemoryMessageBody)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.MemoryMessageBody));
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.List<global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Object>), context));
            setField1(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>), context));
            return (global::Orleans.Providers.MemoryMessageBody)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.MemoryMessageData))]
    internal class OrleansCodeGenOrleans_Providers_MemoryMessageDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.MemoryMessageData).@GetTypeInfo().@GetField("Payload", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.ArraySegment<global::System.Byte>> getField3 = (global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.ArraySegment<global::System.Byte>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.ArraySegment<global::System.Byte>> setField3 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.ArraySegment<global::System.Byte>>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.MemoryMessageData).@GetTypeInfo().@GetField("SequenceNumber", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.Int64> getField2 = (global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.Int64> setField2 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.MemoryMessageData).@GetTypeInfo().@GetField("StreamGuid", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.Guid> getField0 = (global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.Guid> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.MemoryMessageData).@GetTypeInfo().@GetField("StreamNamespace", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.String> getField1 = (global::System.Func<global::Orleans.Providers.MemoryMessageData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.String> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Providers.MemoryMessageData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.MemoryMessageData input = ((global::Orleans.Providers.MemoryMessageData)original);
            global::Orleans.Providers.MemoryMessageData result = default (global::Orleans.Providers.MemoryMessageData);
            context.@RecordCopy(original, result);
            setField3(ref result, (global::System.ArraySegment<global::System.Byte>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input), context));
            setField2(ref result, getField2(input));
            setField0(ref result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField1(ref result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.MemoryMessageData input = (global::Orleans.Providers.MemoryMessageData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.ArraySegment<global::System.Byte>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.MemoryMessageData result = default (global::Orleans.Providers.MemoryMessageData);
            setField3(ref result, (global::System.ArraySegment<global::System.Byte>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.ArraySegment<global::System.Byte>), context));
            setField2(ref result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField0(ref result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context));
            setField1(ref result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Providers.MemoryMessageData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.MemoryAdapterFactory<>))]
    internal class OrleansCodeGenOrleans_Providers_MemoryAdapterFactorySerializer<TSerializer>
        where TSerializer : global::Orleans.Providers.IMemoryMessageBodySerializer, new ()
    {
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("<StreamFailureHandlerFactory>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>> getField10 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field10);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>> setField10 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field10);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("adapterConfig", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.MemoryAdapterConfig> getField6 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.MemoryAdapterConfig>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.MemoryAdapterConfig> setField6 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.MemoryAdapterConfig>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("bufferPool", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>> getField3 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>> setField3 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("grainFactory", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.IGrainFactory> getField9 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.IGrainFactory>)global::Orleans.Serialization.SerializationManager.@GetGetter(field9);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.IGrainFactory> setField9 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.IGrainFactory>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("logger", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Runtime.Logger> getField7 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Runtime.Logger>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Runtime.Logger> setField7 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Runtime.Logger>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("providerName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.String> getField8 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field8);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.String> setField8 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("queueGrains", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>> getField2 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>> setField2 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("serializer", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.IMemoryMessageBodySerializer> getField0 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.IMemoryMessageBodySerializer>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.IMemoryMessageBodySerializer> setField0 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Providers.IMemoryMessageBodySerializer>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("serviceProvider", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.IServiceProvider> getField5 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.IServiceProvider>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.IServiceProvider> setField5 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::System.IServiceProvider>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("streamFailureHandler", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamFailureHandler> getField4 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamFailureHandler>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamFailureHandler> setField4 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamFailureHandler>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>).@GetTypeInfo().@GetField("streamQueueMapper", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamQueueMapper> getField1 = (global::System.Func<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamQueueMapper>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamQueueMapper> setField1 = (global::System.Action<global::Orleans.Providers.MemoryAdapterFactory<TSerializer>, global::Orleans.Streams.IStreamQueueMapper>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.MemoryAdapterFactory<TSerializer> input = ((global::Orleans.Providers.MemoryAdapterFactory<TSerializer>)original);
            global::Orleans.Providers.MemoryAdapterFactory<TSerializer> result = new global::Orleans.Providers.MemoryAdapterFactory<TSerializer>();
            context.@RecordCopy(original, result);
            setField10(result, (global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField10(input), context));
            setField6(result, (global::Orleans.Providers.MemoryAdapterConfig)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input), context));
            setField3(result, (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input), context));
            setField9(result, (global::Orleans.IGrainFactory)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField9(input), context));
            setField7(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField7(input), context));
            setField8(result, getField8(input));
            setField2(result, (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField0(result, (global::Orleans.Providers.IMemoryMessageBodySerializer)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField5(result, (global::System.IServiceProvider)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input), context));
            setField4(result, (global::Orleans.Streams.IStreamFailureHandler)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input), context));
            setField1(result, (global::Orleans.Streams.IStreamQueueMapper)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.MemoryAdapterFactory<TSerializer> input = (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField10(input), context, typeof (global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::Orleans.Providers.MemoryAdapterConfig));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField9(input), context, typeof (global::Orleans.IGrainFactory));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), context, typeof (global::Orleans.Runtime.Logger));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField8(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Providers.IMemoryMessageBodySerializer));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::System.IServiceProvider));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::Orleans.Streams.IStreamFailureHandler));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Streams.IStreamQueueMapper));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.MemoryAdapterFactory<TSerializer> result = new global::Orleans.Providers.MemoryAdapterFactory<TSerializer>();
            context.@RecordObject(result);
            setField10(result, (global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::Orleans.Streams.IStreamFailureHandler>>), context));
            setField6(result, (global::Orleans.Providers.MemoryAdapterConfig)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.MemoryAdapterConfig), context));
            setField3(result, (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>), context));
            setField9(result, (global::Orleans.IGrainFactory)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.IGrainFactory), context));
            setField7(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Logger), context));
            setField8(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField2(result, (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Streams.QueueId, global::Orleans.Providers.IMemoryStreamQueueGrain>), context));
            setField0(result, (global::Orleans.Providers.IMemoryMessageBodySerializer)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.IMemoryMessageBodySerializer), context));
            setField5(result, (global::System.IServiceProvider)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.IServiceProvider), context));
            setField4(result, (global::Orleans.Streams.IStreamFailureHandler)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamFailureHandler), context));
            setField1(result, (global::Orleans.Streams.IStreamQueueMapper)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamQueueMapper), context));
            return (global::Orleans.Providers.MemoryAdapterFactory<TSerializer>)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.MemoryAdapterConfig))]
    internal class OrleansCodeGenOrleans_Providers_MemoryAdapterConfigSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.MemoryAdapterConfig).@GetTypeInfo().@GetField("<StreamProviderName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.MemoryAdapterConfig, global::System.String> setField0 = (global::System.Action<global::Orleans.Providers.MemoryAdapterConfig, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.MemoryAdapterConfig input = ((global::Orleans.Providers.MemoryAdapterConfig)original);
            global::Orleans.Providers.MemoryAdapterConfig result = (global::Orleans.Providers.MemoryAdapterConfig)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.MemoryAdapterConfig));
            context.@RecordCopy(original, result);
            result.@CacheSizeMb = input.@CacheSizeMb;
            setField0(result, input.@StreamProviderName);
            result.@TotalQueueCount = input.@TotalQueueCount;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.MemoryAdapterConfig input = (global::Orleans.Providers.MemoryAdapterConfig)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CacheSizeMb, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamProviderName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalQueueCount, context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.MemoryAdapterConfig result = (global::Orleans.Providers.MemoryAdapterConfig)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.MemoryAdapterConfig));
            context.@RecordObject(result);
            result.@CacheSizeMb = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            result.@TotalQueueCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            return (global::Orleans.Providers.MemoryAdapterConfig)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Generator.GeneratedEvent))]
    internal class OrleansCodeGenOrleans_Providers_Streams_Generator_GeneratedEventSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedEvent input = ((global::Orleans.Providers.Streams.Generator.GeneratedEvent)original);
            global::Orleans.Providers.Streams.Generator.GeneratedEvent result = new global::Orleans.Providers.Streams.Generator.GeneratedEvent();
            context.@RecordCopy(original, result);
            result.@EventType = input.@EventType;
            result.@Payload = (global::System.Int32[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Payload, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedEvent input = (global::Orleans.Providers.Streams.Generator.GeneratedEvent)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventType, context, typeof (global::Orleans.Providers.Streams.Generator.GeneratedEvent.GeneratedEventType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Payload, context, typeof (global::System.Int32[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedEvent result = new global::Orleans.Providers.Streams.Generator.GeneratedEvent();
            context.@RecordObject(result);
            result.@EventType = (global::Orleans.Providers.Streams.Generator.GeneratedEvent.GeneratedEventType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Generator.GeneratedEvent.GeneratedEventType), context);
            result.@Payload = (global::System.Int32[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32[]), context);
            return (global::Orleans.Providers.Streams.Generator.GeneratedEvent)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig))]
    internal class OrleansCodeGenOrleans_Providers_Streams_Generator_SimpleGeneratorConfigSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig input = ((global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig)original);
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig result = new global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig();
            context.@RecordCopy(original, result);
            result.@EventsInStream = input.@EventsInStream;
            result.@StreamNamespace = input.@StreamNamespace;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig input = (global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventsInStream, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamNamespace, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig result = new global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig();
            context.@RecordObject(result);
            result.@EventsInStream = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@StreamNamespace = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            return (global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Common.FixedSizeBuffer))]
    internal class OrleansCodeGenOrleans_Providers_Streams_Common_FixedSizeBufferSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.Common.FixedSizeBuffer).@GetTypeInfo().@GetField("blockSize", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32> getField2 = (global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32> setField2 = (global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.Common.FixedSizeBuffer).@GetTypeInfo().@GetField("buffer", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Byte[]> getField0 = (global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Byte[]> setField0 = (global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.Common.FixedSizeBuffer).@GetTypeInfo().@GetField("count", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32> getField1 = (global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32> setField1 = (global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Providers.Streams.Common.PooledResource<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>).@GetTypeInfo().@GetField("pool", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.Common.PooledResource<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>> getField4 = (global::System.Func<global::Orleans.Providers.Streams.Common.PooledResource<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Common.PooledResource<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>> setField4 = (global::System.Action<global::Orleans.Providers.Streams.Common.PooledResource<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>, global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.Streams.Common.FixedSizeBuffer).@GetTypeInfo().@GetField("purgeAction", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Action<global::System.IDisposable>> getField3 = (global::System.Func<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Action<global::System.IDisposable>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Action<global::System.IDisposable>> setField3 = (global::System.Action<global::Orleans.Providers.Streams.Common.FixedSizeBuffer, global::System.Action<global::System.IDisposable>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.Common.FixedSizeBuffer input = ((global::Orleans.Providers.Streams.Common.FixedSizeBuffer)original);
            global::Orleans.Providers.Streams.Common.FixedSizeBuffer result = (global::Orleans.Providers.Streams.Common.FixedSizeBuffer)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Common.FixedSizeBuffer));
            context.@RecordCopy(original, result);
            setField2(result, getField2(input));
            setField0(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField1(result, getField1(input));
            setField4(result, (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input), context));
            setField3(result, (global::System.Action<global::System.IDisposable>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Common.FixedSizeBuffer input = (global::Orleans.Providers.Streams.Common.FixedSizeBuffer)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Action<global::System.IDisposable>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.Common.FixedSizeBuffer result = (global::Orleans.Providers.Streams.Common.FixedSizeBuffer)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.Common.FixedSizeBuffer));
            context.@RecordObject(result);
            setField2(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField0(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), context));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField4(result, (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Common.IObjectPool<global::Orleans.Providers.Streams.Common.FixedSizeBuffer>), context));
            setField3(result, (global::System.Action<global::System.IDisposable>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Action<global::System.IDisposable>), context));
            return (global::Orleans.Providers.Streams.Common.FixedSizeBuffer)result;
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
}

namespace Orleans.Providers
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Providers.IMemoryStreamQueueGrain))]
    internal class OrleansCodeGenMemoryStreamQueueGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Providers.IMemoryStreamQueueGrain
    {
        protected @OrleansCodeGenMemoryStreamQueueGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMemoryStreamQueueGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1158152105;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Providers.IMemoryStreamQueueGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1158152105;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1158152105:
                    switch (@methodId)
                    {
                        case -184141324:
                            return "Enqueue";
                        case -2107064239:
                            return "Dequeue";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1158152105 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Enqueue(global::Orleans.Providers.MemoryMessageData @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-184141324, new global::System.Object[]{@data});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Providers.MemoryMessageData>> @Dequeue(global::System.Int32 @maxCount)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Providers.MemoryMessageData>>(-2107064239, new global::System.Object[]{@maxCount});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Providers.IMemoryStreamQueueGrain), 1158152105), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMemoryStreamQueueGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 1158152105:
                    switch (methodId)
                    {
                        case -184141324:
                            return ((global::Orleans.Providers.IMemoryStreamQueueGrain)@grain).@Enqueue((global::Orleans.Providers.MemoryMessageData)arguments[0]).@Box();
                        case -2107064239:
                            return ((global::Orleans.Providers.IMemoryStreamQueueGrain)@grain).@Dequeue((global::System.Int32)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1158152105 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1158152105;
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
