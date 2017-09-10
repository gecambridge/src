#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("OrleansRuntime, Version=1.4.2.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.Streams
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.PubSubGrainState))]
    internal class OrleansCodeGenOrleans_Streams_PubSubGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.PubSubGrainState input = ((global::Orleans.Streams.PubSubGrainState)original);
            global::Orleans.Streams.PubSubGrainState result = new global::Orleans.Streams.PubSubGrainState();
            context.@RecordCopy(original, result);
            result.@Consumers = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubSubscriptionState>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Consumers, context);
            result.@Producers = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubPublisherState>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Producers, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.PubSubGrainState input = (global::Orleans.Streams.PubSubGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Consumers, context, typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubSubscriptionState>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Producers, context, typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubPublisherState>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.PubSubGrainState result = new global::Orleans.Streams.PubSubGrainState();
            context.@RecordObject(result);
            result.@Consumers = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubSubscriptionState>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubSubscriptionState>), context);
            result.@Producers = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubPublisherState>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.PubSubPublisherState>), context);
            return (global::Orleans.Streams.PubSubGrainState)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.PubSubSubscriptionState))]
    internal class OrleansCodeGenOrleans_Streams_PubSubSubscriptionStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetTypeInfo().@GetField("Stream", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId> getField1 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId> setField1 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetTypeInfo().@GetField("SubscriptionId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId> getField0 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId> setField0 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetTypeInfo().@GetField("consumerReference", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference> getField2 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference> setField2 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetTypeInfo().@GetField("filterWrapper", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object> getField3 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object> setField3 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetTypeInfo().@GetField("state", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates> getField4 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates> setField4 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.PubSubSubscriptionState input = ((global::Orleans.Streams.PubSubSubscriptionState)original);
            global::Orleans.Streams.PubSubSubscriptionState result = (global::Orleans.Streams.PubSubSubscriptionState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubSubscriptionState));
            context.@RecordCopy(original, result);
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            setField2(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input), context));
            setField4(result, getField4(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.PubSubSubscriptionState input = (global::Orleans.Streams.PubSubSubscriptionState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Streams.StreamId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Runtime.GuidId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::Orleans.Runtime.GrainReference));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.PubSubSubscriptionState result = (global::Orleans.Streams.PubSubSubscriptionState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubSubscriptionState));
            context.@RecordObject(result);
            setField1(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), context));
            setField0(result, (global::Orleans.Runtime.GuidId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GuidId), context));
            setField2(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), context));
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), context));
            setField4(result, (global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates), context));
            return (global::Orleans.Streams.PubSubSubscriptionState)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamId))]
    internal class OrleansCodeGenOrleans_Streams_StreamIdSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamId).@GetTypeInfo().@GetField("key", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey> getField0 = (global::System.Func<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey> setField0 = (global::System.Action<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            // No deep copy required since Orleans.Streams.StreamId is marked with the [Immutable] attribute.
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamId input = (global::Orleans.Streams.StreamId)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Streams.StreamIdInternerKey));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamId result = (global::Orleans.Streams.StreamId)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamId));
            context.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamIdInternerKey)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamIdInternerKey), context));
            return (global::Orleans.Streams.StreamId)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamIdInternerKey))]
    internal class OrleansCodeGenOrleans_Streams_StreamIdInternerKeySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamIdInternerKey).@GetTypeInfo().@GetField("Guid", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid> getField0 = (global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.StreamIdInternerKey).@GetTypeInfo().@GetField("Namespace", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String> getField2 = (global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String> setField2 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamIdInternerKey).@GetTypeInfo().@GetField("ProviderName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String> getField1 = (global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            // No deep copy required since Orleans.Streams.StreamIdInternerKey is marked with the [Immutable] attribute.
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamIdInternerKey input = (global::Orleans.Streams.StreamIdInternerKey)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamIdInternerKey result = default (global::Orleans.Streams.StreamIdInternerKey);
            setField0(ref result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context));
            setField2(ref result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(ref result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Streams.StreamIdInternerKey)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GenericGrainTypeData))]
    internal class OrleansCodeGenOrleans_Runtime_GenericGrainTypeDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<GrainClass>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String> getField3 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String> setField3 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsReentrant>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField6 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField6 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsStatelessWorker>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField7 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField7 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<MayInterleave>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>> getField8 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field8);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>> setField8 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<MultiClusterRegistrationStrategy>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> getField9 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetGetter(field9);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> setField9 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<RemoteInterfaceTypes>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> getField4 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> setField4 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<StateObjectType>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField5 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField5 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<Type>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField2 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField2 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GenericGrainTypeData).@GetTypeInfo().@GetField("activationType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> getField0 = (global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> setField0 = (global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GenericGrainTypeData).@GetTypeInfo().@GetField("stateObjectType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> getField1 = (global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> setField1 = (global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GenericGrainTypeData input = ((global::Orleans.Runtime.GenericGrainTypeData)original);
            global::Orleans.Runtime.GenericGrainTypeData result = (global::Orleans.Runtime.GenericGrainTypeData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GenericGrainTypeData));
            context.@RecordCopy(original, result);
            setField3(result, getField3(input));
            setField6(result, getField6(input));
            setField7(result, getField7(input));
            setField8(result, (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField8(input), context));
            setField9(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField9(input), context));
            setField4(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input), context));
            setField5(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input), context));
            setField2(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField1(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GenericGrainTypeData input = (global::Orleans.Runtime.GenericGrainTypeData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField8(input), context, typeof (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField9(input), context, typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::System.Collections.Generic.List<global::System.Type>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Type));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GenericGrainTypeData result = (global::Orleans.Runtime.GenericGrainTypeData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GenericGrainTypeData));
            context.@RecordObject(result);
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField6(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField7(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField8(result, (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>), context));
            setField9(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy), context));
            setField4(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Type>), context));
            setField5(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), context));
            setField2(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), context));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), context));
            setField1(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), context));
            return (global::Orleans.Runtime.GenericGrainTypeData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainTypeData))]
    internal class OrleansCodeGenOrleans_Runtime_GrainTypeDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<GrainClass>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String> getField1 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String> setField1 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsReentrant>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField4 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField4 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsStatelessWorker>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField5 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField5 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<MayInterleave>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>> getField6 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>> setField6 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<MultiClusterRegistrationStrategy>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> getField7 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> setField7 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<RemoteInterfaceTypes>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> getField2 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> setField2 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<StateObjectType>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField3 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField3 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<Type>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField0 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField0 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GrainTypeData input = ((global::Orleans.Runtime.GrainTypeData)original);
            global::Orleans.Runtime.GrainTypeData result = (global::Orleans.Runtime.GrainTypeData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainTypeData));
            context.@RecordCopy(original, result);
            setField1(result, getField1(input));
            setField4(result, getField4(input));
            setField5(result, getField5(input));
            setField6(result, (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input), context));
            setField7(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField7(input), context));
            setField2(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField3(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input), context));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainTypeData input = (global::Orleans.Runtime.GrainTypeData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), context, typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Collections.Generic.List<global::System.Type>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Type));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GrainTypeData result = (global::Orleans.Runtime.GrainTypeData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainTypeData));
            context.@RecordObject(result);
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField4(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField5(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField6(result, (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Func<global::Orleans.CodeGeneration.InvokeMethodRequest, global::System.Boolean>), context));
            setField7(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy), context));
            setField2(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Type>), context));
            setField3(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), context));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), context));
            return (global::Orleans.Runtime.GrainTypeData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable))]
    internal class OrleansCodeGenOrleans_Runtime_MembershipService_InMemoryMembershipTableSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable).@GetTypeInfo().@GetField("lastETagCounter", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64> getField2 = (global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64> setField2 = (global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable).@GetTypeInfo().@GetField("siloTable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>> getField0 = (global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>> setField0 = (global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable).@GetTypeInfo().@GetField("tableVersion", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion> getField1 = (global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion> setField1 = (global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable input = ((global::Orleans.Runtime.MembershipService.InMemoryMembershipTable)original);
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable result = new global::Orleans.Runtime.MembershipService.InMemoryMembershipTable();
            context.@RecordCopy(original, result);
            setField2(result, getField2(input));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField1(result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable input = (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.TableVersion));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable result = new global::Orleans.Runtime.MembershipService.InMemoryMembershipTable();
            context.@RecordObject(result);
            setField2(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>), context));
            setField1(result, (global::Orleans.TableVersion)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.TableVersion), context));
            return (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.TableVersion))]
    internal class OrleansCodeGenOrleans_TableVersionSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.TableVersion).@GetTypeInfo().@GetField("<Version>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.TableVersion, global::System.Int32> setField0 = (global::System.Action<global::Orleans.TableVersion, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.TableVersion).@GetTypeInfo().@GetField("<VersionEtag>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.TableVersion, global::System.String> setField1 = (global::System.Action<global::Orleans.TableVersion, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            // No deep copy required since Orleans.TableVersion is marked with the [Immutable] attribute.
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.TableVersion input = (global::Orleans.TableVersion)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Version, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@VersionEtag, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.TableVersion result = (global::Orleans.TableVersion)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.TableVersion));
            context.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.TableVersion)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.MembershipEntry))]
    internal class OrleansCodeGenOrleans_MembershipEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.MembershipEntry input = ((global::Orleans.MembershipEntry)original);
            global::Orleans.MembershipEntry result = new global::Orleans.MembershipEntry();
            context.@RecordCopy(original, result);
            result.@FaultZone = input.@FaultZone;
            result.@HostName = input.@HostName;
            result.@IAmAliveTime = input.@IAmAliveTime;
            result.@ProxyPort = input.@ProxyPort;
            result.@RoleName = input.@RoleName;
            result.@SiloAddress = input.@SiloAddress;
            result.@SiloName = input.@SiloName;
            result.@StartTime = input.@StartTime;
            result.@Status = input.@Status;
            result.@SuspectTimes = (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SuspectTimes, context);
            result.@UpdateZone = input.@UpdateZone;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.MembershipEntry input = (global::Orleans.MembershipEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FaultZone, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IAmAliveTime, context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProxyPort, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RoleName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, context, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartTime, context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, context, typeof (global::Orleans.Runtime.SiloStatus));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SuspectTimes, context, typeof (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UpdateZone, context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.MembershipEntry result = new global::Orleans.MembershipEntry();
            context.@RecordObject(result);
            result.@FaultZone = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@HostName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@IAmAliveTime = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context);
            result.@ProxyPort = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@RoleName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), context);
            result.@SiloName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StartTime = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context);
            result.@Status = (global::Orleans.Runtime.SiloStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloStatus), context);
            result.@SuspectTimes = (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>), context);
            result.@UpdateZone = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            return (global::Orleans.MembershipEntry)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.RandomPlacement))]
    internal class OrleansCodeGenOrleans_Runtime_RandomPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.RandomPlacement input = ((global::Orleans.Runtime.RandomPlacement)original);
            global::Orleans.Runtime.RandomPlacement result = (global::Orleans.Runtime.RandomPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RandomPlacement));
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.RandomPlacement input = (global::Orleans.Runtime.RandomPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.RandomPlacement result = (global::Orleans.Runtime.RandomPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RandomPlacement));
            context.@RecordObject(result);
            return (global::Orleans.Runtime.RandomPlacement)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.PreferLocalPlacement))]
    internal class OrleansCodeGenOrleans_Runtime_PreferLocalPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.PreferLocalPlacement input = ((global::Orleans.Runtime.PreferLocalPlacement)original);
            global::Orleans.Runtime.PreferLocalPlacement result = (global::Orleans.Runtime.PreferLocalPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.PreferLocalPlacement));
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.PreferLocalPlacement input = (global::Orleans.Runtime.PreferLocalPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.PreferLocalPlacement result = (global::Orleans.Runtime.PreferLocalPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.PreferLocalPlacement));
            context.@RecordObject(result);
            return (global::Orleans.Runtime.PreferLocalPlacement)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.StatelessWorkerPlacement))]
    internal class OrleansCodeGenOrleans_Runtime_StatelessWorkerPlacementSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.StatelessWorkerPlacement).@GetTypeInfo().@GetField("<MaxLocal>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.StatelessWorkerPlacement input = ((global::Orleans.Runtime.StatelessWorkerPlacement)original);
            global::Orleans.Runtime.StatelessWorkerPlacement result = (global::Orleans.Runtime.StatelessWorkerPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.StatelessWorkerPlacement));
            context.@RecordCopy(original, result);
            setField0(result, input.@MaxLocal);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.StatelessWorkerPlacement input = (global::Orleans.Runtime.StatelessWorkerPlacement)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxLocal, context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.StatelessWorkerPlacement result = (global::Orleans.Runtime.StatelessWorkerPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.StatelessWorkerPlacement));
            context.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            return (global::Orleans.Runtime.StatelessWorkerPlacement)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.ActivationCountBasedPlacement))]
    internal class OrleansCodeGenOrleans_Runtime_ActivationCountBasedPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.ActivationCountBasedPlacement input = ((global::Orleans.Runtime.ActivationCountBasedPlacement)original);
            global::Orleans.Runtime.ActivationCountBasedPlacement result = (global::Orleans.Runtime.ActivationCountBasedPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.ActivationCountBasedPlacement));
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.ActivationCountBasedPlacement input = (global::Orleans.Runtime.ActivationCountBasedPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.ActivationCountBasedPlacement result = (global::Orleans.Runtime.ActivationCountBasedPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.ActivationCountBasedPlacement));
            context.@RecordObject(result);
            return (global::Orleans.Runtime.ActivationCountBasedPlacement)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainDirectory.ActivationInfo))]
    internal class OrleansCodeGenOrleans_Runtime_GrainDirectory_ActivationInfoSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainDirectory.ActivationInfo).@GetTypeInfo().@GetField("<SiloAddress>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.GrainDirectory.ActivationInfo, global::Orleans.Runtime.SiloAddress> setField0 = (global::System.Action<global::Orleans.Runtime.GrainDirectory.ActivationInfo, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainDirectory.ActivationInfo).@GetTypeInfo().@GetField("<TimeCreated>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.GrainDirectory.ActivationInfo, global::System.DateTime> setField1 = (global::System.Action<global::Orleans.Runtime.GrainDirectory.ActivationInfo, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GrainDirectory.ActivationInfo input = ((global::Orleans.Runtime.GrainDirectory.ActivationInfo)original);
            global::Orleans.Runtime.GrainDirectory.ActivationInfo result = (global::Orleans.Runtime.GrainDirectory.ActivationInfo)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainDirectory.ActivationInfo));
            context.@RecordCopy(original, result);
            result.@RegistrationStatus = input.@RegistrationStatus;
            setField0(result, input.@SiloAddress);
            setField1(result, input.@TimeCreated);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainDirectory.ActivationInfo input = (global::Orleans.Runtime.GrainDirectory.ActivationInfo)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RegistrationStatus, context, typeof (global::Orleans.GrainDirectory.GrainDirectoryEntryStatus));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, context, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TimeCreated, context, typeof (global::System.DateTime));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GrainDirectory.ActivationInfo result = (global::Orleans.Runtime.GrainDirectory.ActivationInfo)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainDirectory.ActivationInfo));
            context.@RecordObject(result);
            result.@RegistrationStatus = (global::Orleans.GrainDirectory.GrainDirectoryEntryStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.GrainDirectory.GrainDirectoryEntryStatus), context);
            setField0(result, (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), context));
            setField1(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            return (global::Orleans.Runtime.GrainDirectory.ActivationInfo)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainDirectory.GrainInfo))]
    internal class OrleansCodeGenOrleans_Runtime_GrainDirectory_GrainInfoSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainDirectory.GrainInfo).@GetTypeInfo().@GetField("<Instances>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.GrainDirectory.GrainInfo, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.ActivationId, global::Orleans.Runtime.IActivationInfo>> setField0 = (global::System.Action<global::Orleans.Runtime.GrainDirectory.GrainInfo, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.ActivationId, global::Orleans.Runtime.IActivationInfo>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainDirectory.GrainInfo).@GetTypeInfo().@GetField("<SingleInstance>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.GrainDirectory.GrainInfo, global::System.Boolean> setField2 = (global::System.Action<global::Orleans.Runtime.GrainDirectory.GrainInfo, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainDirectory.GrainInfo).@GetTypeInfo().@GetField("<VersionTag>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.GrainDirectory.GrainInfo, global::System.Int32> setField1 = (global::System.Action<global::Orleans.Runtime.GrainDirectory.GrainInfo, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GrainDirectory.GrainInfo input = ((global::Orleans.Runtime.GrainDirectory.GrainInfo)original);
            global::Orleans.Runtime.GrainDirectory.GrainInfo result = (global::Orleans.Runtime.GrainDirectory.GrainInfo)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainDirectory.GrainInfo));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.ActivationId, global::Orleans.Runtime.IActivationInfo>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Instances, context));
            setField2(result, input.@SingleInstance);
            setField1(result, input.@VersionTag);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainDirectory.GrainInfo input = (global::Orleans.Runtime.GrainDirectory.GrainInfo)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Instances, context, typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.ActivationId, global::Orleans.Runtime.IActivationInfo>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SingleInstance, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@VersionTag, context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GrainDirectory.GrainInfo result = (global::Orleans.Runtime.GrainDirectory.GrainInfo)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainDirectory.GrainInfo));
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.ActivationId, global::Orleans.Runtime.IActivationInfo>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.ActivationId, global::Orleans.Runtime.IActivationInfo>), context));
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            return (global::Orleans.Runtime.GrainDirectory.GrainInfo)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData))]
    internal class OrleansCodeGenOrleans_Runtime_MultiClusterNetwork_MultiClusterDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData).@GetTypeInfo().@GetField("<Configuration>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::Orleans.MultiCluster.MultiClusterConfiguration> setField1 = (global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::Orleans.MultiCluster.MultiClusterConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData).@GetTypeInfo().@GetField("<Gateways>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>> setField0 = (global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData input = ((global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData)original);
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData result = new global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData();
            context.@RecordCopy(original, result);
            setField1(result, (global::Orleans.MultiCluster.MultiClusterConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Configuration, context));
            setField0(result, (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Gateways, context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData input = (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Configuration, context, typeof (global::Orleans.MultiCluster.MultiClusterConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Gateways, context, typeof (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData result = new global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData();
            context.@RecordObject(result);
            setField1(result, (global::Orleans.MultiCluster.MultiClusterConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration), context));
            setField0(result, (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>), context));
            return (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration))]
    internal class OrleansCodeGenOrleans_MultiCluster_MultiClusterConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.MultiCluster.MultiClusterConfiguration).@GetTypeInfo().@GetField("<AdminTimestamp>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.DateTime> setField0 = (global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.MultiCluster.MultiClusterConfiguration).@GetTypeInfo().@GetField("<Clusters>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.Collections.Generic.IReadOnlyList<global::System.String>> setField1 = (global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.Collections.Generic.IReadOnlyList<global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.MultiCluster.MultiClusterConfiguration).@GetTypeInfo().@GetField("<Comment>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.MultiCluster.MultiClusterConfiguration input = ((global::Orleans.MultiCluster.MultiClusterConfiguration)original);
            global::Orleans.MultiCluster.MultiClusterConfiguration result = (global::Orleans.MultiCluster.MultiClusterConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration));
            context.@RecordCopy(original, result);
            setField0(result, input.@AdminTimestamp);
            setField1(result, (global::System.Collections.Generic.IReadOnlyList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Clusters, context));
            setField2(result, input.@Comment);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.MultiCluster.MultiClusterConfiguration input = (global::Orleans.MultiCluster.MultiClusterConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AdminTimestamp, context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Clusters, context, typeof (global::System.Collections.Generic.IReadOnlyList<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Comment, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.MultiCluster.MultiClusterConfiguration result = (global::Orleans.MultiCluster.MultiClusterConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration));
            context.@RecordObject(result);
            setField0(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField1(result, (global::System.Collections.Generic.IReadOnlyList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyList<global::System.String>), context));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.MultiCluster.MultiClusterConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry))]
    internal class OrleansCodeGenOrleans_Runtime_MultiClusterNetwork_GatewayEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry input = ((global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry)original);
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry result = new global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry();
            context.@RecordCopy(original, result);
            result.@ClusterId = input.@ClusterId;
            result.@HeartbeatTimestamp = input.@HeartbeatTimestamp;
            result.@SiloAddress = input.@SiloAddress;
            result.@Status = input.@Status;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry input = (global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClusterId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HeartbeatTimestamp, context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, context, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, context, typeof (global::Orleans.MultiCluster.GatewayStatus));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry result = new global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry();
            context.@RecordObject(result);
            result.@ClusterId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@HeartbeatTimestamp = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), context);
            result.@Status = (global::Orleans.MultiCluster.GatewayStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.MultiCluster.GatewayStatus), context);
            return (global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable))]
    internal class OrleansCodeGenOrleans_Runtime_ReminderService_InMemoryRemindersTableSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable).@GetTypeInfo().@GetField("reminderTable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>> getField0 = (global::System.Func<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>> setField0 = (global::System.Action<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable input = ((global::Orleans.Runtime.ReminderService.InMemoryRemindersTable)original);
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable result = new global::Orleans.Runtime.ReminderService.InMemoryRemindersTable();
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable input = (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable result = new global::Orleans.Runtime.ReminderService.InMemoryRemindersTable();
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>), context));
            return (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ReminderEntry))]
    internal class OrleansCodeGenOrleans_ReminderEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.ReminderEntry input = ((global::Orleans.ReminderEntry)original);
            global::Orleans.ReminderEntry result = new global::Orleans.ReminderEntry();
            context.@RecordCopy(original, result);
            result.@ETag = input.@ETag;
            result.@GrainRef = (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainRef, context);
            result.@Period = input.@Period;
            result.@ReminderName = input.@ReminderName;
            result.@StartAt = input.@StartAt;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.ReminderEntry input = (global::Orleans.ReminderEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainRef, context, typeof (global::Orleans.Runtime.GrainReference));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Period, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartAt, context, typeof (global::System.DateTime));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.ReminderEntry result = new global::Orleans.ReminderEntry();
            context.@RecordObject(result);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@GrainRef = (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), context);
            result.@Period = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@ReminderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@StartAt = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context);
            return (global::Orleans.ReminderEntry)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.OutgoingClientMessage))]
    internal class OrleansCodeGenOrleans_Runtime_OutgoingClientMessageSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>).@GetTypeInfo().@GetField("m_Item1", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.GrainId> getField0 = (global::System.Func<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.GrainId> setField0 = (global::System.Action<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>).@GetTypeInfo().@GetField("m_Item2", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.Message> getField1 = (global::System.Func<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.Message>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.Message> setField1 = (global::System.Action<global::System.Tuple<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.Message>, global::Orleans.Runtime.Message>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.OutgoingClientMessage input = ((global::Orleans.Runtime.OutgoingClientMessage)original);
            global::Orleans.Runtime.OutgoingClientMessage result = (global::Orleans.Runtime.OutgoingClientMessage)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.OutgoingClientMessage));
            context.@RecordCopy(original, result);
            setField0(result, getField0(input));
            setField1(result, (global::Orleans.Runtime.Message)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.OutgoingClientMessage input = (global::Orleans.Runtime.OutgoingClientMessage)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Runtime.GrainId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Runtime.Message));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.OutgoingClientMessage result = (global::Orleans.Runtime.OutgoingClientMessage)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.OutgoingClientMessage));
            context.@RecordObject(result);
            setField0(result, (global::Orleans.Runtime.GrainId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainId), context));
            setField1(result, (global::Orleans.Runtime.Message)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Message), context));
            return (global::Orleans.Runtime.OutgoingClientMessage)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Message))]
    internal class OrleansCodeGenOrleans_Runtime_MessageSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.Message).@GetTypeInfo().@GetField("<Headers>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.Message.HeadersContainer> getField5 = (global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.Message.HeadersContainer>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.Message.HeadersContainer> setField5 = (global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.Message.HeadersContainer>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Message).@GetTypeInfo().@GetField("bodyBytes", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>> getField0 = (global::System.Func<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>> setField0 = (global::System.Action<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Message).@GetTypeInfo().@GetField("bodyObject", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Message, global::System.Object> getField2 = (global::System.Func<global::Orleans.Runtime.Message, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.Message, global::System.Object> setField2 = (global::System.Action<global::Orleans.Runtime.Message, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Message).@GetTypeInfo().@GetField("headerBytes", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>> getField1 = (global::System.Func<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>> setField1 = (global::System.Action<global::Orleans.Runtime.Message, global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.Message).@GetTypeInfo().@GetField("sendingAddress", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress> getField4 = (global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress> setField4 = (global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.Message).@GetTypeInfo().@GetField("targetAddress", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress> getField3 = (global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress> setField3 = (global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.Message).@GetTypeInfo().@GetField("timeInterval", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.ITimeInterval> getField6 = (global::System.Func<global::Orleans.Runtime.Message, global::Orleans.Runtime.ITimeInterval>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.ITimeInterval> setField6 = (global::System.Action<global::Orleans.Runtime.Message, global::Orleans.Runtime.ITimeInterval>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Message input = ((global::Orleans.Runtime.Message)original);
            global::Orleans.Runtime.Message result = new global::Orleans.Runtime.Message();
            context.@RecordCopy(original, result);
            setField5(result, (global::Orleans.Runtime.Message.HeadersContainer)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input), context));
            setField0(result, (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField2(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField1(result, (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField4(result, getField4(input));
            setField3(result, getField3(input));
            setField6(result, (global::Orleans.Runtime.ITimeInterval)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Message input = (global::Orleans.Runtime.Message)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::Orleans.Runtime.Message.HeadersContainer));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::Orleans.Runtime.ActivationAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::Orleans.Runtime.ActivationAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::Orleans.Runtime.ITimeInterval));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Message result = new global::Orleans.Runtime.Message();
            context.@RecordObject(result);
            setField5(result, (global::Orleans.Runtime.Message.HeadersContainer)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Message.HeadersContainer), context));
            setField0(result, (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>), context));
            setField2(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), context));
            setField1(result, (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.ArraySegment<global::System.Byte>>), context));
            setField4(result, (global::Orleans.Runtime.ActivationAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.ActivationAddress), context));
            setField3(result, (global::Orleans.Runtime.ActivationAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.ActivationAddress), context));
            setField6(result, (global::Orleans.Runtime.ITimeInterval)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.ITimeInterval), context));
            return (global::Orleans.Runtime.Message)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.PubSubPublisherState))]
    internal class OrleansCodeGenOrleans_Streams_PubSubPublisherStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.PubSubPublisherState).@GetTypeInfo().@GetField("Stream", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId> getField0 = (global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId> setField0 = (global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.PubSubPublisherState).@GetTypeInfo().@GetField("producerReference", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference> getField1 = (global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference> setField1 = (global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.PubSubPublisherState input = ((global::Orleans.Streams.PubSubPublisherState)original);
            global::Orleans.Streams.PubSubPublisherState result = (global::Orleans.Streams.PubSubPublisherState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubPublisherState));
            context.@RecordCopy(original, result);
            setField0(result, getField0(input));
            setField1(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.PubSubPublisherState input = (global::Orleans.Streams.PubSubPublisherState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Streams.StreamId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Runtime.GrainReference));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.PubSubPublisherState result = (global::Orleans.Streams.PubSubPublisherState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubPublisherState));
            context.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), context));
            setField1(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), context));
            return (global::Orleans.Streams.PubSubPublisherState)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GuidId))]
    internal class OrleansCodeGenOrleans_Runtime_GuidIdSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GuidId).@GetTypeInfo().@GetField("Guid", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GuidId, global::System.Guid> getField0 = (global::System.Func<global::Orleans.Runtime.GuidId, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GuidId, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Runtime.GuidId, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            // No deep copy required since Orleans.Runtime.GuidId is marked with the [Immutable] attribute.
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GuidId input = (global::Orleans.Runtime.GuidId)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Guid));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GuidId result = (global::Orleans.Runtime.GuidId)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GuidId));
            context.@RecordObject(result);
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context));
            return (global::Orleans.Runtime.GuidId)result;
        }
    }
}

namespace Orleans.Runtime.TestHooks
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget))]
    internal class OrleansCodeGenTestHooksSystemTargetReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget
    {
        protected @OrleansCodeGenTestHooksSystemTargetReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenTestHooksSystemTargetReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 383906679;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 383906679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 383906679:
                    switch (@methodId)
                    {
                        case 422095460:
                            return "GetConsistentRingPrimaryTargetSilo";
                        case 1646576267:
                            return "GetConsistentRingProviderDiagnosticInfo";
                        case -1227463277:
                            return "HasStatisticsProvider";
                        case -1192584229:
                            return "GetServiceId";
                        case 826375526:
                            return "GetStorageProviderNames";
                        case -288139957:
                            return "GetStreamProviderNames";
                        case 1513961598:
                            return "GetAllSiloProviderNames";
                        case 158805531:
                            return "UnregisterGrainForTesting";
                        case 123416339:
                            return "LatchIsOverloaded";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 383906679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloAddress> @GetConsistentRingPrimaryTargetSilo(global::System.UInt32 @key)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SiloAddress>(422095460, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetConsistentRingProviderDiagnosticInfo()
        {
            return base.@InvokeMethodAsync<global::System.String>(1646576267, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @HasStatisticsProvider()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1227463277, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Guid> @GetServiceId()
        {
            return base.@InvokeMethodAsync<global::System.Guid>(-1192584229, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.ICollection<global::System.String>> @GetStorageProviderNames()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.ICollection<global::System.String>>(826375526, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.ICollection<global::System.String>> @GetStreamProviderNames()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.ICollection<global::System.String>>(-288139957, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.ICollection<global::System.String>> @GetAllSiloProviderNames()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.ICollection<global::System.String>>(1513961598, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @UnregisterGrainForTesting(global::Orleans.Runtime.GrainId @grain)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(158805531, new global::System.Object[]{@grain});
        }

        public global::System.Threading.Tasks.Task @LatchIsOverloaded(global::System.Boolean @overloaded, global::System.TimeSpan @latchPeriod)
        {
            return base.@InvokeMethodAsync<global::System.Object>(123416339, new global::System.Object[]{@overloaded, @latchPeriod});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget), 383906679), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenTestHooksSystemTargetMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 383906679:
                    switch (methodId)
                    {
                        case 422095460:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@GetConsistentRingPrimaryTargetSilo((global::System.UInt32)arguments[0]).@Box();
                        case 1646576267:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@GetConsistentRingProviderDiagnosticInfo().@Box();
                        case -1227463277:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@HasStatisticsProvider().@Box();
                        case -1192584229:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@GetServiceId().@Box();
                        case 826375526:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@GetStorageProviderNames().@Box();
                        case -288139957:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@GetStreamProviderNames().@Box();
                        case 1513961598:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@GetAllSiloProviderNames().@Box();
                        case 158805531:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@UnregisterGrainForTesting((global::Orleans.Runtime.GrainId)arguments[0]).@Box();
                        case 123416339:
                            return ((global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget)@grain).@LatchIsOverloaded((global::System.Boolean)arguments[0], (global::System.TimeSpan)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 383906679 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 383906679;
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
