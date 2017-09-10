#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Orleans, Version=1.4.2.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainState<>))]
    internal class OrleansCodeGenOrleans_GrainStateSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.GrainState<T>).@GetTypeInfo().@GetField("State", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainState<T>, T> getField0 = (global::System.Func<global::Orleans.GrainState<T>, T>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.GrainState<T>, T> setField0 = (global::System.Action<global::Orleans.GrainState<T>, T>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.GrainState<T> input = ((global::Orleans.GrainState<T>)original);
            global::Orleans.GrainState<T> result = new global::Orleans.GrainState<T>();
            context.@RecordCopy(original, result);
            result.@ETag = input.@ETag;
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.GrainState<T> input = (global::Orleans.GrainState<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.GrainState<T> result = new global::Orleans.GrainState<T>();
            context.@RecordObject(result);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), context));
            return (global::Orleans.GrainState<T>)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.MembershipTableData))]
    internal class OrleansCodeGenOrleans_MembershipTableDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.MembershipTableData).@GetTypeInfo().@GetField("<Members>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>> setField0 = (global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.MembershipTableData).@GetTypeInfo().@GetField("<Version>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion> setField1 = (global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.MembershipTableData input = ((global::Orleans.MembershipTableData)original);
            global::Orleans.MembershipTableData result = (global::Orleans.MembershipTableData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.MembershipTableData));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Members, context));
            setField1(result, input.@Version);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.MembershipTableData input = (global::Orleans.MembershipTableData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Members, context, typeof (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Version, context, typeof (global::Orleans.TableVersion));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.MembershipTableData result = (global::Orleans.MembershipTableData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.MembershipTableData));
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>), context));
            setField1(result, (global::Orleans.TableVersion)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.TableVersion), context));
            return (global::Orleans.MembershipTableData)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ReminderData))]
    internal class OrleansCodeGenOrleans_ReminderDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.ReminderData).@GetTypeInfo().@GetField("<ETag>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderData, global::System.String> setField2 = (global::System.Action<global::Orleans.ReminderData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.ReminderData).@GetTypeInfo().@GetField("<GrainRef>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderData, global::Orleans.Runtime.GrainReference> setField0 = (global::System.Action<global::Orleans.ReminderData, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.ReminderData).@GetTypeInfo().@GetField("<ReminderName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderData, global::System.String> setField1 = (global::System.Action<global::Orleans.ReminderData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.ReminderData input = ((global::Orleans.ReminderData)original);
            global::Orleans.ReminderData result = (global::Orleans.ReminderData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.ReminderData));
            context.@RecordCopy(original, result);
            setField2(result, input.@ETag);
            setField0(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainRef, context));
            setField1(result, input.@ReminderName);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.ReminderData input = (global::Orleans.ReminderData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainRef, context, typeof (global::Orleans.Runtime.GrainReference));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderName, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.ReminderData result = (global::Orleans.ReminderData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.ReminderData));
            context.@RecordObject(result);
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField0(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.ReminderData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ObserverSubscriptionManager<>))]
    internal class OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer<T>
        where T : global::Orleans.IGrainObserver
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.ObserverSubscriptionManager<T>).@GetTypeInfo().@GetField("observers", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> getField0 = (global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> setField0 = (global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.ObserverSubscriptionManager<T> input = ((global::Orleans.ObserverSubscriptionManager<T>)original);
            global::Orleans.ObserverSubscriptionManager<T> result = new global::Orleans.ObserverSubscriptionManager<T>();
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.ObserverSubscriptionManager<T> input = (global::Orleans.ObserverSubscriptionManager<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.HashSet<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.ObserverSubscriptionManager<T> result = new global::Orleans.ObserverSubscriptionManager<T>();
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<T>), context));
            return (global::Orleans.ObserverSubscriptionManager<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse))]
    internal class OrleansCodeGenOrleans_SystemTargetInterfaces_RemoteClusterActivationResponseSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse).@GetTypeInfo().@GetField("<ResponseStatus>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse, global::Orleans.SystemTargetInterfaces.ActivationResponseStatus> setField0 = (global::System.Action<global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse, global::Orleans.SystemTargetInterfaces.ActivationResponseStatus>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse input = ((global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse)original);
            global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse result = (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse));
            context.@RecordCopy(original, result);
            result.@ClusterId = input.@ClusterId;
            result.@ExistingActivationAddress = input.@ExistingActivationAddress;
            result.@Owned = input.@Owned;
            result.@ResponseException = (global::System.Exception)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ResponseException, context);
            setField0(result, input.@ResponseStatus);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse input = (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClusterId, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ExistingActivationAddress, context, typeof (global::Orleans.GrainDirectory.AddressAndTag));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Owned, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResponseException, context, typeof (global::System.Exception));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResponseStatus, context, typeof (global::Orleans.SystemTargetInterfaces.ActivationResponseStatus));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse result = (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse));
            context.@RecordObject(result);
            result.@ClusterId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@ExistingActivationAddress = (global::Orleans.GrainDirectory.AddressAndTag)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.GrainDirectory.AddressAndTag), context);
            result.@Owned = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@ResponseException = (global::System.Exception)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Exception), context);
            setField0(result, (global::Orleans.SystemTargetInterfaces.ActivationResponseStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.SystemTargetInterfaces.ActivationResponseStatus), context));
            return (global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamIdentity))]
    internal class OrleansCodeGenOrleans_Streams_StreamIdentitySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamIdentity).@GetTypeInfo().@GetField("<Guid>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamIdentity, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Streams.StreamIdentity, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamIdentity).@GetTypeInfo().@GetField("<Namespace>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamIdentity, global::System.String> setField1 = (global::System.Action<global::Orleans.Streams.StreamIdentity, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.StreamIdentity input = ((global::Orleans.Streams.StreamIdentity)original);
            global::Orleans.Streams.StreamIdentity result = (global::Orleans.Streams.StreamIdentity)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamIdentity));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Guid, context));
            setField1(result, input.@Namespace);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamIdentity input = (global::Orleans.Streams.StreamIdentity)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Guid, context, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Namespace, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamIdentity result = (global::Orleans.Streams.StreamIdentity)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamIdentity));
            context.@RecordObject(result);
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Streams.StreamIdentity)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamHandshakeToken))]
    internal class OrleansCodeGenOrleans_Streams_StreamHandshakeTokenSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamHandshakeToken).@GetTypeInfo().@GetField("<Token>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken> setField0 = (global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.StreamHandshakeToken input = ((global::Orleans.Streams.StreamHandshakeToken)original);
            global::Orleans.Streams.StreamHandshakeToken result = new global::Orleans.Streams.StreamHandshakeToken();
            context.@RecordCopy(original, result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token, context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamHandshakeToken input = (global::Orleans.Streams.StreamHandshakeToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, context, typeof (global::Orleans.Streams.StreamSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamHandshakeToken result = new global::Orleans.Streams.StreamHandshakeToken();
            context.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), context));
            return (global::Orleans.Streams.StreamHandshakeToken)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StartToken))]
    internal class OrleansCodeGenOrleans_Streams_StartTokenSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamHandshakeToken).@GetTypeInfo().@GetField("<Token>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken> setField0 = (global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.StartToken input = ((global::Orleans.Streams.StartToken)original);
            global::Orleans.Streams.StartToken result = new global::Orleans.Streams.StartToken();
            context.@RecordCopy(original, result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token, context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StartToken input = (global::Orleans.Streams.StartToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, context, typeof (global::Orleans.Streams.StreamSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StartToken result = new global::Orleans.Streams.StartToken();
            context.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), context));
            return (global::Orleans.Streams.StartToken)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.DeliveryToken))]
    internal class OrleansCodeGenOrleans_Streams_DeliveryTokenSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamHandshakeToken).@GetTypeInfo().@GetField("<Token>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken> setField0 = (global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.DeliveryToken input = ((global::Orleans.Streams.DeliveryToken)original);
            global::Orleans.Streams.DeliveryToken result = new global::Orleans.Streams.DeliveryToken();
            context.@RecordCopy(original, result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token, context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.DeliveryToken input = (global::Orleans.Streams.DeliveryToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, context, typeof (global::Orleans.Streams.StreamSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.DeliveryToken result = new global::Orleans.Streams.DeliveryToken();
            context.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), context));
            return (global::Orleans.Streams.DeliveryToken)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<>))]
    internal class OrleansCodeGenOrleans_Streams_StreamSubscriptionHandleImplSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>).@GetTypeInfo().@GetField("filterWrapper", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper> getField1 = (global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper> setField1 = (global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>).@GetTypeInfo().@GetField("isRewindable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::System.Boolean> getField3 = (global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::System.Boolean> setField3 = (global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>).@GetTypeInfo().@GetField("streamImpl", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>> getField0 = (global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>> setField0 = (global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>).@GetTypeInfo().@GetField("subscriptionId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId> getField2 = (global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId> setField2 = (global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> input = ((global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)original);
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> result = (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>));
            context.@RecordCopy(original, result);
            setField1(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField3(result, getField3(input));
            setField0(result, getField0(input));
            setField2(result, getField2(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> input = (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Streams.StreamImpl<T>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::Orleans.Runtime.GuidId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> result = (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>));
            context.@RecordObject(result);
            setField1(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper), context));
            setField3(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField0(result, (global::Orleans.Streams.StreamImpl<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamImpl<T>), context));
            setField2(result, (global::Orleans.Runtime.GuidId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GuidId), context));
            return (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamConsumerCollection))]
    internal class OrleansCodeGenOrleans_Streams_StreamConsumerCollectionSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamConsumerCollection).@GetTypeInfo().@GetField("lastActivityTime", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerCollection, global::System.DateTime> getField1 = (global::System.Func<global::Orleans.Streams.StreamConsumerCollection, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerCollection, global::System.DateTime> setField1 = (global::System.Action<global::Orleans.Streams.StreamConsumerCollection, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamConsumerCollection).@GetTypeInfo().@GetField("queueData", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerCollection, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>> getField0 = (global::System.Func<global::Orleans.Streams.StreamConsumerCollection, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerCollection, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>> setField0 = (global::System.Action<global::Orleans.Streams.StreamConsumerCollection, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.StreamConsumerCollection input = ((global::Orleans.Streams.StreamConsumerCollection)original);
            global::Orleans.Streams.StreamConsumerCollection result = (global::Orleans.Streams.StreamConsumerCollection)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamConsumerCollection));
            context.@RecordCopy(original, result);
            setField1(result, getField1(input));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamConsumerCollection input = (global::Orleans.Streams.StreamConsumerCollection)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamConsumerCollection result = (global::Orleans.Streams.StreamConsumerCollection)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamConsumerCollection));
            context.@RecordObject(result);
            setField1(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GuidId, global::Orleans.Streams.StreamConsumerData>), context));
            return (global::Orleans.Streams.StreamConsumerCollection)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.FilterPredicateWrapperData))]
    internal class OrleansCodeGenOrleans_Streams_FilterPredicateWrapperDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.FilterPredicateWrapperData).@GetTypeInfo().@GetField("<FilterData>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.Object> setField0 = (global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.FilterPredicateWrapperData).@GetTypeInfo().@GetField("className", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> getField2 = (global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> setField2 = (global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.FilterPredicateWrapperData).@GetTypeInfo().@GetField("methodName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> getField1 = (global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> setField1 = (global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.FilterPredicateWrapperData input = ((global::Orleans.Streams.FilterPredicateWrapperData)original);
            global::Orleans.Streams.FilterPredicateWrapperData result = (global::Orleans.Streams.FilterPredicateWrapperData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.FilterPredicateWrapperData));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@FilterData, context));
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.FilterPredicateWrapperData input = (global::Orleans.Streams.FilterPredicateWrapperData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FilterData, context, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.FilterPredicateWrapperData result = (global::Orleans.Streams.FilterPredicateWrapperData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.FilterPredicateWrapperData));
            context.@RecordObject(result);
            setField0(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), context));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            return (global::Orleans.Streams.FilterPredicateWrapperData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.PersistentStreamProviderConfig))]
    internal class OrleansCodeGenOrleans_Streams_PersistentStreamProviderConfigSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.PersistentStreamProviderConfig input = ((global::Orleans.Streams.PersistentStreamProviderConfig)original);
            global::Orleans.Streams.PersistentStreamProviderConfig result = new global::Orleans.Streams.PersistentStreamProviderConfig();
            context.@RecordCopy(original, result);
            result.@BalancerType = input.@BalancerType;
            result.@GetQueueMsgsTimerPeriod = input.@GetQueueMsgsTimerPeriod;
            result.@InitQueueTimeout = input.@InitQueueTimeout;
            result.@MaxEventDeliveryTime = input.@MaxEventDeliveryTime;
            result.@PubSubType = input.@PubSubType;
            result.@SiloMaturityPeriod = input.@SiloMaturityPeriod;
            result.@StreamInactivityPeriod = input.@StreamInactivityPeriod;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.PersistentStreamProviderConfig input = (global::Orleans.Streams.PersistentStreamProviderConfig)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BalancerType, context, typeof (global::Orleans.Streams.StreamQueueBalancerType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GetQueueMsgsTimerPeriod, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@InitQueueTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxEventDeliveryTime, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PubSubType, context, typeof (global::Orleans.Streams.StreamPubSubType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloMaturityPeriod, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamInactivityPeriod, context, typeof (global::System.TimeSpan));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.PersistentStreamProviderConfig result = new global::Orleans.Streams.PersistentStreamProviderConfig();
            context.@RecordObject(result);
            result.@BalancerType = (global::Orleans.Streams.StreamQueueBalancerType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamQueueBalancerType), context);
            result.@GetQueueMsgsTimerPeriod = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@InitQueueTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@MaxEventDeliveryTime = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@PubSubType = (global::Orleans.Streams.StreamPubSubType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamPubSubType), context);
            result.@SiloMaturityPeriod = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@StreamInactivityPeriod = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            return (global::Orleans.Streams.PersistentStreamProviderConfig)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.OrFilter))]
    internal class OrleansCodeGenOrleans_Streams_OrFilterSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.OrFilter).@GetTypeInfo().@GetField("filters", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.OrFilter, global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>> getField0 = (global::System.Func<global::Orleans.Streams.OrFilter, global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.OrFilter, global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>> setField0 = (global::System.Action<global::Orleans.Streams.OrFilter, global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.OrFilter input = ((global::Orleans.Streams.OrFilter)original);
            global::Orleans.Streams.OrFilter result = (global::Orleans.Streams.OrFilter)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.OrFilter));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.OrFilter input = (global::Orleans.Streams.OrFilter)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.OrFilter result = (global::Orleans.Streams.OrFilter)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.OrFilter));
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Orleans.Streams.IStreamFilterPredicateWrapper>), context));
            return (global::Orleans.Streams.OrFilter)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.ImplicitStreamSubscriberTable))]
    internal class OrleansCodeGenOrleans_Streams_ImplicitStreamSubscriberTableSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.ImplicitStreamSubscriberTable).@GetTypeInfo().@GetField("table", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>> getField0 = (global::System.Func<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>> setField0 = (global::System.Action<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.ImplicitStreamSubscriberTable input = ((global::Orleans.Streams.ImplicitStreamSubscriberTable)original);
            global::Orleans.Streams.ImplicitStreamSubscriberTable result = new global::Orleans.Streams.ImplicitStreamSubscriberTable();
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.ImplicitStreamSubscriberTable input = (global::Orleans.Streams.ImplicitStreamSubscriberTable)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.ImplicitStreamSubscriberTable result = new global::Orleans.Streams.ImplicitStreamSubscriberTable();
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>), context));
            return (global::Orleans.Streams.ImplicitStreamSubscriberTable)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamImpl<>))]
    internal class OrleansCodeGenOrleans_Streams_StreamImplSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamImpl<T>).@GetTypeInfo().@GetField("isRewindable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean> getField1 = (global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean> setField1 = (global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamImpl<T>).@GetTypeInfo().@GetField("streamId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId> getField0 = (global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId> setField0 = (global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            // No deep copy required since Orleans.Streams.StreamImpl<T> is marked with the [Immutable] attribute.
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamImpl<T> input = (global::Orleans.Streams.StreamImpl<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Streams.StreamId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamImpl<T> result = new global::Orleans.Streams.StreamImpl<T>();
            context.@RecordObject(result);
            setField1(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField0(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), context));
            return (global::Orleans.Streams.StreamImpl<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamConsumerData))]
    internal class OrleansCodeGenOrleans_Streams_StreamConsumerDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Streams.StreamConsumerData).@GetTypeInfo().@GetField("Cursor", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor> getField4 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor> setField4 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Streams.StreamConsumerData).@GetTypeInfo().@GetField("Filter", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper> getField5 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper> setField5 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Streams.StreamConsumerData).@GetTypeInfo().@GetField("LastToken", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken> getField6 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken> setField6 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Streams.StreamConsumerData).@GetTypeInfo().@GetField("State", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState> getField3 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState> setField3 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.StreamConsumerData).@GetTypeInfo().@GetField("StreamConsumer", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension> getField2 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension> setField2 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamConsumerData).@GetTypeInfo().@GetField("StreamId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId> getField1 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId> setField1 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamConsumerData).@GetTypeInfo().@GetField("SubscriptionId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId> getField0 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId> setField0 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Streams.StreamConsumerData input = ((global::Orleans.Streams.StreamConsumerData)original);
            global::Orleans.Streams.StreamConsumerData result = (global::Orleans.Streams.StreamConsumerData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamConsumerData));
            context.@RecordCopy(original, result);
            setField4(result, (global::Orleans.Streams.IQueueCacheCursor)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input), context));
            setField5(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input), context));
            setField6(result, (global::Orleans.Streams.StreamHandshakeToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input), context));
            setField3(result, getField3(input));
            setField2(result, (global::Orleans.Streams.IStreamConsumerExtension)global::Orleans.Serialization.SerializationManager.@DeepCopyInner((getField2(input) == null || getField2(input) is global::Orleans.Runtime.GrainReference) ? getField2(input) : getField2(input).@AsReference<global::Orleans.Streams.IStreamConsumerExtension>(), context));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Streams.StreamConsumerData input = (global::Orleans.Streams.StreamConsumerData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::Orleans.Streams.IQueueCacheCursor));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::Orleans.Streams.StreamHandshakeToken));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::Orleans.Streams.StreamConsumerDataState));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::Orleans.Streams.IStreamConsumerExtension));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Streams.StreamId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Runtime.GuidId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Streams.StreamConsumerData result = (global::Orleans.Streams.StreamConsumerData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamConsumerData));
            context.@RecordObject(result);
            setField4(result, (global::Orleans.Streams.IQueueCacheCursor)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IQueueCacheCursor), context));
            setField5(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper), context));
            setField6(result, (global::Orleans.Streams.StreamHandshakeToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamHandshakeToken), context));
            setField3(result, (global::Orleans.Streams.StreamConsumerDataState)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamConsumerDataState), context));
            setField2(result, (global::Orleans.Streams.IStreamConsumerExtension)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamConsumerExtension), context));
            setField1(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), context));
            setField0(result, (global::Orleans.Runtime.GuidId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GuidId), context));
            return (global::Orleans.Streams.StreamConsumerData)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration))]
    internal class OrleansCodeGenOrleans_GrainDirectory_GlobalSingleInstanceRegistrationSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration input = ((global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration)original);
            global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration result = (global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration));
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration input = (global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration result = (global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration));
            context.@RecordObject(result);
            return (global::Orleans.GrainDirectory.GlobalSingleInstanceRegistration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainDirectory.AddressAndTag))]
    internal class OrleansCodeGenOrleans_GrainDirectory_AddressAndTagSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.GrainDirectory.AddressAndTag).@GetTypeInfo().@GetField("Address", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress> getField0 = (global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.GrainDirectory.AddressAndTag).@GetTypeInfo().@GetField("VersionTag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32> getField1 = (global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.GrainDirectory.AddressAndTag input = ((global::Orleans.GrainDirectory.AddressAndTag)original);
            global::Orleans.GrainDirectory.AddressAndTag result = default (global::Orleans.GrainDirectory.AddressAndTag);
            context.@RecordCopy(original, result);
            setField0(ref result, getField0(input));
            setField1(ref result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.GrainDirectory.AddressAndTag input = (global::Orleans.GrainDirectory.AddressAndTag)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Runtime.ActivationAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.GrainDirectory.AddressAndTag result = default (global::Orleans.GrainDirectory.AddressAndTag);
            setField0(ref result, (global::Orleans.Runtime.ActivationAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.ActivationAddress), context));
            setField1(ref result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            return (global::Orleans.GrainDirectory.AddressAndTag)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainDirectory.AddressesAndTag))]
    internal class OrleansCodeGenOrleans_GrainDirectory_AddressesAndTagSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.GrainDirectory.AddressesAndTag).@GetTypeInfo().@GetField("Addresses", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>> getField0 = (global::System.Func<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.GrainDirectory.AddressesAndTag).@GetTypeInfo().@GetField("VersionTag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Int32> getField1 = (global::System.Func<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Int32> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressesAndTag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.GrainDirectory.AddressesAndTag input = ((global::Orleans.GrainDirectory.AddressesAndTag)original);
            global::Orleans.GrainDirectory.AddressesAndTag result = default (global::Orleans.GrainDirectory.AddressesAndTag);
            context.@RecordCopy(original, result);
            setField0(ref result, (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField1(ref result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.GrainDirectory.AddressesAndTag input = (global::Orleans.GrainDirectory.AddressesAndTag)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.GrainDirectory.AddressesAndTag result = default (global::Orleans.GrainDirectory.AddressesAndTag);
            setField0(ref result, (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>), context));
            setField1(ref result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            return (global::Orleans.GrainDirectory.AddressesAndTag)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainDirectory.ClusterLocalRegistration))]
    internal class OrleansCodeGenOrleans_GrainDirectory_ClusterLocalRegistrationSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.GrainDirectory.ClusterLocalRegistration input = ((global::Orleans.GrainDirectory.ClusterLocalRegistration)original);
            global::Orleans.GrainDirectory.ClusterLocalRegistration result = (global::Orleans.GrainDirectory.ClusterLocalRegistration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.GrainDirectory.ClusterLocalRegistration));
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.GrainDirectory.ClusterLocalRegistration input = (global::Orleans.GrainDirectory.ClusterLocalRegistration)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.GrainDirectory.ClusterLocalRegistration result = (global::Orleans.GrainDirectory.ClusterLocalRegistration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.GrainDirectory.ClusterLocalRegistration));
            context.@RecordObject(result);
            return (global::Orleans.GrainDirectory.ClusterLocalRegistration)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.CodeGeneration.GeneratedAssembly))]
    internal class OrleansCodeGenOrleans_CodeGeneration_GeneratedAssemblySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.CodeGeneration.GeneratedAssembly input = ((global::Orleans.CodeGeneration.GeneratedAssembly)original);
            global::Orleans.CodeGeneration.GeneratedAssembly result = new global::Orleans.CodeGeneration.GeneratedAssembly();
            context.@RecordCopy(original, result);
            result.@DebugSymbolRawBytes = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@DebugSymbolRawBytes, context);
            result.@RawBytes = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@RawBytes, context);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.CodeGeneration.GeneratedAssembly input = (global::Orleans.CodeGeneration.GeneratedAssembly)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DebugSymbolRawBytes, context, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RawBytes, context, typeof (global::System.Byte[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.CodeGeneration.GeneratedAssembly result = new global::Orleans.CodeGeneration.GeneratedAssembly();
            context.@RecordObject(result);
            result.@DebugSymbolRawBytes = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), context);
            result.@RawBytes = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), context);
            return (global::Orleans.CodeGeneration.GeneratedAssembly)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.LoggerImpl))]
    internal class OrleansCodeGenOrleans_Runtime_LoggerImplSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("<Name>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.String> setField8 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("defaultCopiedCounter", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.Int32> getField0 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("flushInterval", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.TimeSpan> getField6 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.TimeSpan> setField6 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("lastBulkLogMessageFlush", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.DateTime> getField5 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.DateTime> setField5 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("lastFlush", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.DateTime> getField7 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.DateTime> setField7 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("loggerType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.LoggerType> getField3 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.LoggerType>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.LoggerType> setField3 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.LoggerType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("recentLogMessageCounts", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>> getField4 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>> setField4 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("severity", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.Severity> getField1 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.Severity>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.Severity> setField1 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::Orleans.Runtime.Severity>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.LoggerImpl).@GetTypeInfo().@GetField("useCustomSeverityLevel", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.Boolean> getField2 = (global::System.Func<global::Orleans.Runtime.LoggerImpl, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.Boolean> setField2 = (global::System.Action<global::Orleans.Runtime.LoggerImpl, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.LoggerImpl input = ((global::Orleans.Runtime.LoggerImpl)original);
            global::Orleans.Runtime.LoggerImpl result = (global::Orleans.Runtime.LoggerImpl)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.LoggerImpl));
            context.@RecordCopy(original, result);
            setField8(result, input.@Name);
            setField0(result, getField0(input));
            setField6(result, getField6(input));
            setField5(result, getField5(input));
            setField7(result, getField7(input));
            setField3(result, getField3(input));
            setField4(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input), context));
            setField1(result, getField1(input));
            setField2(result, getField2(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.LoggerImpl input = (global::Orleans.Runtime.LoggerImpl)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::Orleans.Runtime.LoggerType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Runtime.Severity));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.LoggerImpl result = (global::Orleans.Runtime.LoggerImpl)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.LoggerImpl));
            context.@RecordObject(result);
            setField8(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField6(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context));
            setField5(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField7(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField3(result, (global::Orleans.Runtime.LoggerType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.LoggerType), context));
            setField4(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>), context));
            setField1(result, (global::Orleans.Runtime.Severity)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Severity), context));
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            return (global::Orleans.Runtime.LoggerImpl)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.TypeFormattingOptions))]
    internal class OrleansCodeGenOrleans_Runtime_TypeFormattingOptionsSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.TypeFormattingOptions).@GetTypeInfo().@GetField("<IncludeGenericTypeParameters>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean> setField2 = (global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.TypeFormattingOptions).@GetTypeInfo().@GetField("<IncludeGlobal>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean> setField5 = (global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.TypeFormattingOptions).@GetTypeInfo().@GetField("<IncludeNamespace>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean> setField0 = (global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.TypeFormattingOptions).@GetTypeInfo().@GetField("<IncludeTypeParameters>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean> setField1 = (global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.TypeFormattingOptions).@GetTypeInfo().@GetField("<NameSuffix>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.String> setField4 = (global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.TypeFormattingOptions).@GetTypeInfo().@GetField("<NestedTypeSeparator>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Char> setField3 = (global::System.Action<global::Orleans.Runtime.TypeFormattingOptions, global::System.Char>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.TypeFormattingOptions input = ((global::Orleans.Runtime.TypeFormattingOptions)original);
            global::Orleans.Runtime.TypeFormattingOptions result = (global::Orleans.Runtime.TypeFormattingOptions)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.TypeFormattingOptions));
            context.@RecordCopy(original, result);
            setField2(result, input.@IncludeGenericTypeParameters);
            setField5(result, input.@IncludeGlobal);
            setField0(result, input.@IncludeNamespace);
            setField1(result, input.@IncludeTypeParameters);
            setField4(result, input.@NameSuffix);
            setField3(result, input.@NestedTypeSeparator);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.TypeFormattingOptions input = (global::Orleans.Runtime.TypeFormattingOptions)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IncludeGenericTypeParameters, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IncludeGlobal, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IncludeNamespace, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IncludeTypeParameters, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NameSuffix, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NestedTypeSeparator, context, typeof (global::System.Char));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.TypeFormattingOptions result = (global::Orleans.Runtime.TypeFormattingOptions)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.TypeFormattingOptions));
            context.@RecordObject(result);
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField5(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField0(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField1(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField3(result, (global::System.Char)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Char), context));
            return (global::Orleans.Runtime.TypeFormattingOptions)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SingleRange))]
    internal class OrleansCodeGenOrleans_Runtime_SingleRangeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.SingleRange).@GetTypeInfo().@GetField("begin", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32> getField0 = (global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32> setField0 = (global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.SingleRange).@GetTypeInfo().@GetField("end", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32> getField1 = (global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32> setField1 = (global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.SingleRange input = ((global::Orleans.Runtime.SingleRange)original);
            global::Orleans.Runtime.SingleRange result = (global::Orleans.Runtime.SingleRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SingleRange));
            context.@RecordCopy(original, result);
            setField0(result, getField0(input));
            setField1(result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.SingleRange input = (global::Orleans.Runtime.SingleRange)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.SingleRange result = (global::Orleans.Runtime.SingleRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SingleRange));
            context.@RecordObject(result);
            setField0(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), context));
            setField1(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), context));
            return (global::Orleans.Runtime.SingleRange)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GeneralMultiRange))]
    internal class OrleansCodeGenOrleans_Runtime_GeneralMultiRangeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GeneralMultiRange).@GetTypeInfo().@GetField("rangePercentage", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Double> getField2 = (global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Double> setField2 = (global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GeneralMultiRange).@GetTypeInfo().@GetField("rangeSize", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Int64> getField1 = (global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Int64> setField1 = (global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GeneralMultiRange).@GetTypeInfo().@GetField("ranges", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>> getField0 = (global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>> setField0 = (global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GeneralMultiRange input = ((global::Orleans.Runtime.GeneralMultiRange)original);
            global::Orleans.Runtime.GeneralMultiRange result = (global::Orleans.Runtime.GeneralMultiRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GeneralMultiRange));
            context.@RecordCopy(original, result);
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            setField0(result, (global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GeneralMultiRange input = (global::Orleans.Runtime.GeneralMultiRange)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GeneralMultiRange result = (global::Orleans.Runtime.GeneralMultiRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GeneralMultiRange));
            context.@RecordObject(result);
            setField2(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            setField1(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField0(result, (global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>), context));
            return (global::Orleans.Runtime.GeneralMultiRange)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.EquallyDividedMultiRange))]
    internal class OrleansCodeGenOrleans_Runtime_EquallyDividedMultiRangeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.EquallyDividedMultiRange).@GetTypeInfo().@GetField("multiRanges", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>> getField0 = (global::System.Func<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>> setField0 = (global::System.Action<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.EquallyDividedMultiRange).@GetTypeInfo().@GetField("rangePercentage", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Double> getField2 = (global::System.Func<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Double> setField2 = (global::System.Action<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.EquallyDividedMultiRange).@GetTypeInfo().@GetField("rangeSize", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Int64> getField1 = (global::System.Func<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Int64> setField1 = (global::System.Action<global::Orleans.Runtime.EquallyDividedMultiRange, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.EquallyDividedMultiRange input = ((global::Orleans.Runtime.EquallyDividedMultiRange)original);
            global::Orleans.Runtime.EquallyDividedMultiRange result = (global::Orleans.Runtime.EquallyDividedMultiRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.EquallyDividedMultiRange));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.EquallyDividedMultiRange input = (global::Orleans.Runtime.EquallyDividedMultiRange)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Int64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.EquallyDividedMultiRange result = (global::Orleans.Runtime.EquallyDividedMultiRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.EquallyDividedMultiRange));
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.IRingRangeInternal>), context));
            setField2(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            setField1(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            return (global::Orleans.Runtime.EquallyDividedMultiRange)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.RequestInvocationHistory))]
    internal class OrleansCodeGenOrleans_Runtime_RequestInvocationHistorySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.RequestInvocationHistory).@GetTypeInfo().@GetField("<ActivationId>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.ActivationId> setField1 = (global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.RequestInvocationHistory).@GetTypeInfo().@GetField("<DebugContext>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.RequestInvocationHistory).@GetTypeInfo().@GetField("<GrainId>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.GrainId> setField0 = (global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.RequestInvocationHistory input = ((global::Orleans.Runtime.RequestInvocationHistory)original);
            global::Orleans.Runtime.RequestInvocationHistory result = (global::Orleans.Runtime.RequestInvocationHistory)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RequestInvocationHistory));
            context.@RecordCopy(original, result);
            setField1(result, input.@ActivationId);
            setField2(result, input.@DebugContext);
            setField0(result, input.@GrainId);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.RequestInvocationHistory input = (global::Orleans.Runtime.RequestInvocationHistory)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationId, context, typeof (global::Orleans.Runtime.ActivationId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DebugContext, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainId, context, typeof (global::Orleans.Runtime.GrainId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.RequestInvocationHistory result = (global::Orleans.Runtime.RequestInvocationHistory)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RequestInvocationHistory));
            context.@RecordObject(result);
            setField1(result, (global::Orleans.Runtime.ActivationId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.ActivationId), context));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField0(result, (global::Orleans.Runtime.GrainId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainId), context));
            return (global::Orleans.Runtime.RequestInvocationHistory)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.UniqueKey))]
    internal class OrleansCodeGenOrleans_Runtime_UniqueKeySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.UniqueKey).@GetTypeInfo().@GetField("<KeyExt>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.String> setField3 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.UniqueKey).@GetTypeInfo().@GetField("<N0>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64> setField0 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.UniqueKey).@GetTypeInfo().@GetField("<N1>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64> setField1 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.UniqueKey).@GetTypeInfo().@GetField("<TypeCodeData>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64> setField2 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.UniqueKey input = ((global::Orleans.Runtime.UniqueKey)original);
            global::Orleans.Runtime.UniqueKey result = new global::Orleans.Runtime.UniqueKey();
            context.@RecordCopy(original, result);
            setField3(result, input.@KeyExt);
            setField0(result, input.@N0);
            setField1(result, input.@N1);
            setField2(result, input.@TypeCodeData);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.UniqueKey input = (global::Orleans.Runtime.UniqueKey)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@KeyExt, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@N0, context, typeof (global::System.UInt64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@N1, context, typeof (global::System.UInt64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TypeCodeData, context, typeof (global::System.UInt64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.UniqueKey result = new global::Orleans.Runtime.UniqueKey();
            context.@RecordObject(result);
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField0(result, (global::System.UInt64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt64), context));
            setField1(result, (global::System.UInt64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt64), context));
            setField2(result, (global::System.UInt64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt64), context));
            return (global::Orleans.Runtime.UniqueKey)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SystemPlacement))]
    internal class OrleansCodeGenOrleans_Runtime_SystemPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.SystemPlacement input = ((global::Orleans.Runtime.SystemPlacement)original);
            global::Orleans.Runtime.SystemPlacement result = (global::Orleans.Runtime.SystemPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SystemPlacement));
            context.@RecordCopy(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.SystemPlacement input = (global::Orleans.Runtime.SystemPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.SystemPlacement result = (global::Orleans.Runtime.SystemPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SystemPlacement));
            context.@RecordObject(result);
            return (global::Orleans.Runtime.SystemPlacement)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainInterfaceMap))]
    internal class OrleansCodeGenOrleans_Runtime_GrainInterfaceMapSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.GrainInterfaceMap).@GetTypeInfo().@GetField("defaultPlacementStrategy", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::Orleans.Runtime.PlacementStrategy> getField6 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::Orleans.Runtime.PlacementStrategy>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::Orleans.Runtime.PlacementStrategy> setField6 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::Orleans.Runtime.PlacementStrategy>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainInterfaceMap).@GetTypeInfo().@GetField("implementationIndex", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>> getField3 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>> setField3 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.GrainInterfaceMap).@GetTypeInfo().@GetField("loadedGrainAsemblies", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.String>> getField5 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.String>> setField5 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.GrainInterfaceMap).@GetTypeInfo().@GetField("localTestMode", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Boolean> getField4 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Boolean> setField4 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainInterfaceMap).@GetTypeInfo().@GetField("table", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>> getField1 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>> setField1 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainInterfaceMap).@GetTypeInfo().@GetField("typeToInterfaceData", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>> getField0 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>> setField0 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainInterfaceMap).@GetTypeInfo().@GetField("unordered", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.Int32>> getField2 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.Int32>> setField2 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap, global::System.Collections.Generic.HashSet<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GrainInterfaceMap input = ((global::Orleans.Runtime.GrainInterfaceMap)original);
            global::Orleans.Runtime.GrainInterfaceMap result = (global::Orleans.Runtime.GrainInterfaceMap)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainInterfaceMap));
            context.@RecordCopy(original, result);
            setField6(result, (global::Orleans.Runtime.PlacementStrategy)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input), context));
            setField3(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input), context));
            setField5(result, (global::System.Collections.Generic.HashSet<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input), context));
            setField4(result, getField4(input));
            setField1(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField2(result, (global::System.Collections.Generic.HashSet<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainInterfaceMap input = (global::Orleans.Runtime.GrainInterfaceMap)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), context, typeof (global::Orleans.Runtime.PlacementStrategy));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), context, typeof (global::System.Collections.Generic.HashSet<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Collections.Generic.HashSet<global::System.Int32>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GrainInterfaceMap result = (global::Orleans.Runtime.GrainInterfaceMap)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainInterfaceMap));
            context.@RecordObject(result);
            setField6(result, (global::Orleans.Runtime.PlacementStrategy)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.PlacementStrategy), context));
            setField3(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainClassData>), context));
            setField5(result, (global::System.Collections.Generic.HashSet<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::System.String>), context));
            setField4(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField1(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>), context));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData>), context));
            setField2(result, (global::System.Collections.Generic.HashSet<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::System.Int32>), context));
            return (global::Orleans.Runtime.GrainInterfaceMap)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainClassData))]
    internal class OrleansCodeGenOrleans_Runtime_GrainClassDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.GrainClassData).@GetTypeInfo().@GetField("<GrainClass>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.String> getField4 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.String> setField4 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainClassData).@GetTypeInfo().@GetField("<GrainTypeCode>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Int32> getField3 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Int32> setField3 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainClassData).@GetTypeInfo().@GetField("isGeneric", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Boolean> getField2 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Boolean> setField2 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainClassData).@GetTypeInfo().@GetField("placementStrategy", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy> getField0 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy> setField0 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainClassData).@GetTypeInfo().@GetField("registrationStrategy", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> getField1 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> setField1 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GrainClassData input = ((global::Orleans.Runtime.GrainClassData)original);
            global::Orleans.Runtime.GrainClassData result = (global::Orleans.Runtime.GrainClassData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainClassData));
            context.@RecordCopy(original, result);
            setField4(result, getField4(input));
            setField3(result, getField3(input));
            setField2(result, getField2(input));
            setField0(result, (global::Orleans.Runtime.PlacementStrategy)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField1(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainClassData input = (global::Orleans.Runtime.GrainClassData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::Orleans.Runtime.PlacementStrategy));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GrainClassData result = (global::Orleans.Runtime.GrainClassData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainClassData));
            context.@RecordObject(result);
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField3(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField0(result, (global::Orleans.Runtime.PlacementStrategy)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.PlacementStrategy), context));
            setField1(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy), context));
            return (global::Orleans.Runtime.GrainClassData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.TickStatus))]
    internal class OrleansCodeGenOrleans_Runtime_TickStatusSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.TickStatus).@GetTypeInfo().@GetField("<CurrentTickTime>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime> setField2 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.TickStatus).@GetTypeInfo().@GetField("<FirstTickTime>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.TickStatus).@GetTypeInfo().@GetField("<Period>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.TimeSpan> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.TickStatus input = ((global::Orleans.Runtime.TickStatus)original);
            global::Orleans.Runtime.TickStatus result = default (global::Orleans.Runtime.TickStatus);
            context.@RecordCopy(original, result);
            setField2(ref result, input.@CurrentTickTime);
            setField0(ref result, input.@FirstTickTime);
            setField1(ref result, input.@Period);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.TickStatus input = (global::Orleans.Runtime.TickStatus)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CurrentTickTime, context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FirstTickTime, context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Period, context, typeof (global::System.TimeSpan));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.TickStatus result = default (global::Orleans.Runtime.TickStatus);
            setField2(ref result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField0(ref result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField1(ref result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context));
            return (global::Orleans.Runtime.TickStatus)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SiloRuntimeStatistics))]
    internal class OrleansCodeGenOrleans_Runtime_SiloRuntimeStatisticsSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<ActivationCount>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<AvailableMemory>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single> setField6 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<ClientCount>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField10 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field10);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<CpuUsage>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single> setField5 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<DateTime>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.DateTime> setField13 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field13);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<IsOverloaded>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Boolean> setField9 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<MemoryUsage>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField7 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<ReceiveQueueLength>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField4 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<ReceivedMessages>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField11 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field11);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<RecentlyUsedActivationCount>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField1 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<RequestQueueLength>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField2 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<SendQueueLength>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField3 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<SentMessages>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField12 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field12);
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetTypeInfo().@GetField("<TotalPhysicalMemory>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField8 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.SiloRuntimeStatistics input = ((global::Orleans.Runtime.SiloRuntimeStatistics)original);
            global::Orleans.Runtime.SiloRuntimeStatistics result = (global::Orleans.Runtime.SiloRuntimeStatistics)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SiloRuntimeStatistics));
            context.@RecordCopy(original, result);
            setField0(result, input.@ActivationCount);
            setField6(result, input.@AvailableMemory);
            setField10(result, input.@ClientCount);
            setField5(result, input.@CpuUsage);
            setField13(result, input.@DateTime);
            setField9(result, input.@IsOverloaded);
            setField7(result, input.@MemoryUsage);
            setField4(result, input.@ReceiveQueueLength);
            setField11(result, input.@ReceivedMessages);
            setField1(result, input.@RecentlyUsedActivationCount);
            setField2(result, input.@RequestQueueLength);
            setField3(result, input.@SendQueueLength);
            setField12(result, input.@SentMessages);
            setField8(result, input.@TotalPhysicalMemory);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.SiloRuntimeStatistics input = (global::Orleans.Runtime.SiloRuntimeStatistics)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AvailableMemory, context, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientCount, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CpuUsage, context, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DateTime, context, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsOverloaded, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MemoryUsage, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceiveQueueLength, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceivedMessages, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RecentlyUsedActivationCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RequestQueueLength, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SendQueueLength, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SentMessages, context, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalPhysicalMemory, context, typeof (global::System.Int64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.SiloRuntimeStatistics result = (global::Orleans.Runtime.SiloRuntimeStatistics)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SiloRuntimeStatistics));
            context.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField6(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), context));
            setField10(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField5(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), context));
            setField13(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), context));
            setField9(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            setField7(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField4(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField11(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField2(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField3(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField12(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            setField8(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), context));
            return (global::Orleans.Runtime.SiloRuntimeStatistics)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainStatistic))]
    internal class OrleansCodeGenOrleans_Runtime_GrainStatisticSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GrainStatistic input = ((global::Orleans.Runtime.GrainStatistic)original);
            global::Orleans.Runtime.GrainStatistic result = new global::Orleans.Runtime.GrainStatistic();
            context.@RecordCopy(original, result);
            result.@ActivationCount = input.@ActivationCount;
            result.@GrainCount = input.@GrainCount;
            result.@GrainType = input.@GrainType;
            result.@SiloCount = input.@SiloCount;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainStatistic input = (global::Orleans.Runtime.GrainStatistic)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainType, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloCount, context, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GrainStatistic result = new global::Orleans.Runtime.GrainStatistic();
            context.@RecordObject(result);
            result.@ActivationCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@GrainCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@GrainType = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@SiloCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            return (global::Orleans.Runtime.GrainStatistic)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SimpleGrainStatistic))]
    internal class OrleansCodeGenOrleans_Runtime_SimpleGrainStatisticSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.SimpleGrainStatistic input = ((global::Orleans.Runtime.SimpleGrainStatistic)original);
            global::Orleans.Runtime.SimpleGrainStatistic result = new global::Orleans.Runtime.SimpleGrainStatistic();
            context.@RecordCopy(original, result);
            result.@ActivationCount = input.@ActivationCount;
            result.@GrainType = input.@GrainType;
            result.@SiloAddress = input.@SiloAddress;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.SimpleGrainStatistic input = (global::Orleans.Runtime.SimpleGrainStatistic)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainType, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, context, typeof (global::Orleans.Runtime.SiloAddress));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.SimpleGrainStatistic result = new global::Orleans.Runtime.SimpleGrainStatistic();
            context.@RecordObject(result);
            result.@ActivationCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@GrainType = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), context);
            return (global::Orleans.Runtime.SimpleGrainStatistic)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.DetailedGrainStatistic))]
    internal class OrleansCodeGenOrleans_Runtime_DetailedGrainStatisticSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.DetailedGrainStatistic input = ((global::Orleans.Runtime.DetailedGrainStatistic)original);
            global::Orleans.Runtime.DetailedGrainStatistic result = new global::Orleans.Runtime.DetailedGrainStatistic();
            context.@RecordCopy(original, result);
            result.@Category = input.@Category;
            result.@GrainIdentity = (global::Orleans.Core.IGrainIdentity)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainIdentity, context);
            result.@GrainType = input.@GrainType;
            result.@SiloAddress = input.@SiloAddress;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.DetailedGrainStatistic input = (global::Orleans.Runtime.DetailedGrainStatistic)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Category, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainIdentity, context, typeof (global::Orleans.Core.IGrainIdentity));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainType, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, context, typeof (global::Orleans.Runtime.SiloAddress));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.DetailedGrainStatistic result = new global::Orleans.Runtime.DetailedGrainStatistic();
            context.@RecordObject(result);
            result.@Category = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@GrainIdentity = (global::Orleans.Core.IGrainIdentity)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Core.IGrainIdentity), context);
            result.@GrainType = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), context);
            return (global::Orleans.Runtime.DetailedGrainStatistic)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.DetailedGrainReport))]
    internal class OrleansCodeGenOrleans_Runtime_DetailedGrainReportSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.DetailedGrainReport input = ((global::Orleans.Runtime.DetailedGrainReport)original);
            global::Orleans.Runtime.DetailedGrainReport result = new global::Orleans.Runtime.DetailedGrainReport();
            context.@RecordCopy(original, result);
            result.@Grain = input.@Grain;
            result.@GrainClassTypeName = input.@GrainClassTypeName;
            result.@LocalActivations = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@LocalActivations, context);
            result.@LocalCacheActivationAddresses = (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@LocalCacheActivationAddresses, context);
            result.@LocalDirectoryActivationAddresses = (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@LocalDirectoryActivationAddresses, context);
            result.@PrimaryForGrain = input.@PrimaryForGrain;
            result.@SiloAddress = input.@SiloAddress;
            result.@SiloName = input.@SiloName;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.DetailedGrainReport input = (global::Orleans.Runtime.DetailedGrainReport)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Grain, context, typeof (global::Orleans.Runtime.GrainId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainClassTypeName, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LocalActivations, context, typeof (global::System.Collections.Generic.List<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LocalCacheActivationAddresses, context, typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LocalDirectoryActivationAddresses, context, typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PrimaryForGrain, context, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, context, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloName, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.DetailedGrainReport result = new global::Orleans.Runtime.DetailedGrainReport();
            context.@RecordObject(result);
            result.@Grain = (global::Orleans.Runtime.GrainId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainId), context);
            result.@GrainClassTypeName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@LocalActivations = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.String>), context);
            result.@LocalCacheActivationAddresses = (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>), context);
            result.@LocalDirectoryActivationAddresses = (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>), context);
            result.@PrimaryForGrain = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), context);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), context);
            result.@SiloName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            return (global::Orleans.Runtime.DetailedGrainReport)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.GrainServiceConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_GrainServiceConfigurationSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.GrainServiceConfiguration input = ((global::Orleans.Runtime.Configuration.GrainServiceConfiguration)original);
            global::Orleans.Runtime.Configuration.GrainServiceConfiguration result = new global::Orleans.Runtime.Configuration.GrainServiceConfiguration();
            context.@RecordCopy(original, result);
            result.@Name = input.@Name;
            result.@Properties = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Properties, context);
            result.@ServiceType = input.@ServiceType;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.GrainServiceConfiguration input = (global::Orleans.Runtime.Configuration.GrainServiceConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Properties, context, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ServiceType, context, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.GrainServiceConfiguration result = new global::Orleans.Runtime.Configuration.GrainServiceConfiguration();
            context.@RecordObject(result);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            result.@Properties = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>), context);
            result.@ServiceType = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context);
            return (global::Orleans.Runtime.Configuration.GrainServiceConfiguration)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_MessagingConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field17 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<MessageLossInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField17 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field17);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField17 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field17);
        private static readonly global::System.Reflection.FieldInfo field16 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<RejectionInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField16 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field16);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField16 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field16);
        private static readonly global::System.Reflection.FieldInfo field14 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("<SerializationProviders>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>> setField14 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field14);
        private static readonly global::System.Reflection.FieldInfo field18 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetTypeInfo().@GetField("isSiloConfig", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> getField18 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field18);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> setField18 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field18);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.MessagingConfiguration input = ((global::Orleans.Runtime.Configuration.MessagingConfiguration)original);
            global::Orleans.Runtime.Configuration.MessagingConfiguration result = (global::Orleans.Runtime.Configuration.MessagingConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration));
            context.@RecordCopy(original, result);
            result.@BufferPoolBufferSize = input.@BufferPoolBufferSize;
            result.@BufferPoolMaxSize = input.@BufferPoolMaxSize;
            result.@BufferPoolPreallocationSize = input.@BufferPoolPreallocationSize;
            result.@ClientDropTimeout = input.@ClientDropTimeout;
            result.@ClientSenderBuckets = input.@ClientSenderBuckets;
            result.@DropExpiredMessages = input.@DropExpiredMessages;
            result.@FallbackSerializationProvider = (global::System.Reflection.TypeInfo)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@FallbackSerializationProvider, context);
            result.@GatewaySenderQueues = input.@GatewaySenderQueues;
            result.@MaxForwardCount = input.@MaxForwardCount;
            result.@MaxResendCount = input.@MaxResendCount;
            result.@MaxSocketAge = input.@MaxSocketAge;
            setField17(result, getField17(input));
            result.@OpenConnectionTimeout = input.@OpenConnectionTimeout;
            setField16(result, getField16(input));
            result.@ResendOnTimeout = input.@ResendOnTimeout;
            result.@ResponseTimeout = input.@ResponseTimeout;
            setField14(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SerializationProviders, context));
            result.@SiloSenderQueues = input.@SiloSenderQueues;
            setField18(result, getField18(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.MessagingConfiguration input = (global::Orleans.Runtime.Configuration.MessagingConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolBufferSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolMaxSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolPreallocationSize, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientDropTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientSenderBuckets, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DropExpiredMessages, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FallbackSerializationProvider, context, typeof (global::System.Reflection.TypeInfo));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewaySenderQueues, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxForwardCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxResendCount, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxSocketAge, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField17(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@OpenConnectionTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField16(input), context, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResendOnTimeout, context, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResponseTimeout, context, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SerializationProviders, context, typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloSenderQueues, context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField18(input), context, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.MessagingConfiguration result = (global::Orleans.Runtime.Configuration.MessagingConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration));
            context.@RecordObject(result);
            result.@BufferPoolBufferSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BufferPoolMaxSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@BufferPoolPreallocationSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@ClientDropTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            result.@ClientSenderBuckets = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@DropExpiredMessages = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@FallbackSerializationProvider = (global::System.Reflection.TypeInfo)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Reflection.TypeInfo), context);
            result.@GatewaySenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxForwardCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxResendCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            result.@MaxSocketAge = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField17(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            result.@OpenConnectionTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField16(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), context));
            result.@ResendOnTimeout = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context);
            result.@ResponseTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), context);
            setField14(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>), context));
            result.@SiloSenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context);
            setField18(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), context));
            return (global::Orleans.Runtime.Configuration.MessagingConfiguration)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ProviderConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetTypeInfo().@GetField("<Name>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String> setField3 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetTypeInfo().@GetField("<Type>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetTypeInfo().@GetField("childConfigurations", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetTypeInfo().@GetField("properties", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetTypeInfo().@GetField("readonlyCopyOfProperties", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>> getField4 = (global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>> setField4 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.Configuration.ProviderConfiguration input = ((global::Orleans.Runtime.Configuration.ProviderConfiguration)original);
            global::Orleans.Runtime.Configuration.ProviderConfiguration result = (global::Orleans.Runtime.Configuration.ProviderConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration));
            context.@RecordCopy(original, result);
            setField3(result, input.@Name);
            setField2(result, input.@Type);
            setField1(result, (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            setField0(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField4(result, (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ProviderConfiguration input = (global::Orleans.Runtime.Configuration.ProviderConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Type, context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), context, typeof (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.Configuration.ProviderConfiguration result = (global::Orleans.Runtime.Configuration.ProviderConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration));
            context.@RecordObject(result);
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>), context));
            setField0(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>), context));
            setField4(result, (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>), context));
            return (global::Orleans.Runtime.Configuration.ProviderConfiguration)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection))]
    internal class OrleansCodeGenOrleans_Providers_Streams_SimpleMessageStream_SimpleMessageStreamProducerExtensionSerializer_StreamConsumerExtensionCollectionSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection).@GetTypeInfo().@GetField("consumers", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>> getField0 = (global::System.Func<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>> setField0 = (global::System.Action<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection).@GetTypeInfo().@GetField("logger", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Runtime.Logger> getField2 = (global::System.Func<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Runtime.Logger>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Runtime.Logger> setField2 = (global::System.Action<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Runtime.Logger>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection).@GetTypeInfo().@GetField("streamPubSub", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Streams.IStreamPubSub> getField1 = (global::System.Func<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Streams.IStreamPubSub>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Streams.IStreamPubSub> setField1 = (global::System.Action<global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection, global::Orleans.Streams.IStreamPubSub>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection input = ((global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection)original);
            global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection result = (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection));
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            setField2(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input), context));
            setField1(result, (global::Orleans.Streams.IStreamPubSub)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection input = (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::Orleans.Runtime.Logger));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::Orleans.Streams.IStreamPubSub));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection result = (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection));
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Concurrent.ConcurrentDictionary<global::Orleans.Runtime.GuidId, global::System.Tuple<global::Orleans.Streams.IStreamConsumerExtension, global::Orleans.Streams.IStreamFilterPredicateWrapper>>), context));
            setField2(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Logger), context));
            setField1(result, (global::Orleans.Streams.IStreamPubSub)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamPubSub), context));
            return (global::Orleans.Providers.Streams.SimpleMessageStream.SimpleMessageStreamProducerExtension.StreamConsumerExtensionCollection)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData))]
    internal class OrleansCodeGenOrleans_Runtime_GrainInterfaceMapSerializer_GrainInterfaceDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData).@GetTypeInfo().@GetField("<GrainInterface>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.String> getField2 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData).@GetTypeInfo().@GetField("<InterfaceId>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Int32> getField1 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Int32> setField1 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData).@GetTypeInfo().@GetField("<PrimaryImplementation>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::Orleans.Runtime.GrainClassData> getField3 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::Orleans.Runtime.GrainClassData>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::Orleans.Runtime.GrainClassData> setField3 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::Orleans.Runtime.GrainClassData>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData).@GetTypeInfo().@GetField("implementations", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>> getField0 = (global::System.Func<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>> setField0 = (global::System.Action<global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData, global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData input = ((global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData)original);
            global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData result = (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData));
            context.@RecordCopy(original, result);
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            setField3(result, (global::Orleans.Runtime.GrainClassData)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input), context));
            setField0(result, (global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData input = (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), context, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), context, typeof (global::Orleans.Runtime.GrainClassData));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData result = (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData));
            context.@RecordObject(result);
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), context));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField3(result, (global::Orleans.Runtime.GrainClassData)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainClassData), context));
            setField0(result, (global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::Orleans.Runtime.GrainClassData>), context));
            return (global::Orleans.Runtime.GrainInterfaceMap.GrainInterfaceData)result;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Serialization.TypeSerializer.TypeKey))]
    internal class OrleansCodeGenOrleans_Serialization_TypeSerializerSerializer_TypeKeySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Serialization.TypeSerializer.TypeKey).@GetTypeInfo().@GetField("HashCode", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Int32> getField0 = (global::System.Func<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Int32> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Serialization.TypeSerializer.TypeKey).@GetTypeInfo().@GetField("TypeName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Byte[]> getField1 = (global::System.Func<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Byte[]> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Serialization.TypeSerializer.TypeKey, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.Serialization.TypeSerializer.TypeKey input = ((global::Orleans.Serialization.TypeSerializer.TypeKey)original);
            global::Orleans.Serialization.TypeSerializer.TypeKey result = default (global::Orleans.Serialization.TypeSerializer.TypeKey);
            context.@RecordCopy(original, result);
            setField0(ref result, getField0(input));
            setField1(ref result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input), context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.Serialization.TypeSerializer.TypeKey input = (global::Orleans.Serialization.TypeSerializer.TypeKey)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), context, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), context, typeof (global::System.Byte[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.Serialization.TypeSerializer.TypeKey result = default (global::Orleans.Serialization.TypeSerializer.TypeKey);
            setField0(ref result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), context));
            setField1(ref result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), context));
            return (global::Orleans.Serialization.TypeSerializer.TypeKey)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IMembershipTableGrain))]
    internal class OrleansCodeGenMembershipTableGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.IMembershipTableGrain
    {
        protected @OrleansCodeGenMembershipTableGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMembershipTableGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1256503757;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IMembershipTableGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1256503757;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1256503757:
                    switch (@methodId)
                    {
                        case 1014315343:
                            return "InitializeMembershipTable";
                        case 106897969:
                            return "DeleteMembershipTableEntries";
                        case -1440482971:
                            return "ReadRow";
                        case 572429157:
                            return "ReadAll";
                        case -1925884676:
                            return "InsertRow";
                        case 1964092804:
                            return "UpdateRow";
                        case -1315256828:
                            return "UpdateIAmAlive";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1256503757 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @InitializeMembershipTable(global::Orleans.Runtime.Configuration.GlobalConfiguration @globalConfiguration, global::System.Boolean @tryInitTableVersion, global::Orleans.Runtime.Logger @logger)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1014315343, new global::System.Object[]{@globalConfiguration, @tryInitTableVersion, @logger});
        }

        public global::System.Threading.Tasks.Task @DeleteMembershipTableEntries(global::System.String @deploymentId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(106897969, new global::System.Object[]{@deploymentId});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> @ReadRow(global::Orleans.Runtime.SiloAddress @key)
        {
            return base.@InvokeMethodAsync<global::Orleans.MembershipTableData>(-1440482971, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> @ReadAll()
        {
            return base.@InvokeMethodAsync<global::Orleans.MembershipTableData>(572429157, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @InsertRow(global::Orleans.MembershipEntry @entry, global::Orleans.TableVersion @tableVersion)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1925884676, new global::System.Object[]{@entry, @tableVersion});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @UpdateRow(global::Orleans.MembershipEntry @entry, global::System.String @etag, global::Orleans.TableVersion @tableVersion)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1964092804, new global::System.Object[]{@entry, @etag, @tableVersion});
        }

        public global::System.Threading.Tasks.Task @UpdateIAmAlive(global::Orleans.MembershipEntry @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1315256828, new global::System.Object[]{@entry});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.IMembershipTableGrain), -1256503757), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMembershipTableGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -1256503757:
                    switch (methodId)
                    {
                        case 1014315343:
                            return ((global::Orleans.IMembershipTableGrain)@grain).@InitializeMembershipTable((global::Orleans.Runtime.Configuration.GlobalConfiguration)arguments[0], (global::System.Boolean)arguments[1], (global::Orleans.Runtime.Logger)arguments[2]).@Box();
                        case 106897969:
                            return ((global::Orleans.IMembershipTableGrain)@grain).@DeleteMembershipTableEntries((global::System.String)arguments[0]).@Box();
                        case -1440482971:
                            return ((global::Orleans.IMembershipTableGrain)@grain).@ReadRow((global::Orleans.Runtime.SiloAddress)arguments[0]).@Box();
                        case 572429157:
                            return ((global::Orleans.IMembershipTableGrain)@grain).@ReadAll().@Box();
                        case -1925884676:
                            return ((global::Orleans.IMembershipTableGrain)@grain).@InsertRow((global::Orleans.MembershipEntry)arguments[0], (global::Orleans.TableVersion)arguments[1]).@Box();
                        case 1964092804:
                            return ((global::Orleans.IMembershipTableGrain)@grain).@UpdateRow((global::Orleans.MembershipEntry)arguments[0], (global::System.String)arguments[1], (global::Orleans.TableVersion)arguments[2]).@Box();
                        case -1315256828:
                            return ((global::Orleans.IMembershipTableGrain)@grain).@UpdateIAmAlive((global::Orleans.MembershipEntry)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1256503757 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1256503757;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IReminderTableGrain))]
    internal class OrleansCodeGenReminderTableGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.IReminderTableGrain
    {
        protected @OrleansCodeGenReminderTableGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenReminderTableGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1135060418;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IReminderTableGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1135060418;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1135060418:
                    switch (@methodId)
                    {
                        case -2145584474:
                            return "Init";
                        case -355259193:
                            return "ReadRows";
                        case -497403264:
                            return "ReadRows";
                        case 1312340311:
                            return "ReadRow";
                        case -1664645999:
                            return "UpsertRow";
                        case -1912556377:
                            return "RemoveRow";
                        case 120951690:
                            return "TestOnlyClearTable";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1135060418 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Init(global::Orleans.Runtime.Configuration.GlobalConfiguration @config, global::Orleans.Runtime.Logger @logger)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2145584474, new global::System.Object[]{@config, @logger});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.ReminderTableData> @ReadRows(global::Orleans.Runtime.GrainReference @key)
        {
            return base.@InvokeMethodAsync<global::Orleans.ReminderTableData>(-355259193, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.ReminderTableData> @ReadRows(global::System.UInt32 @begin, global::System.UInt32 @end)
        {
            return base.@InvokeMethodAsync<global::Orleans.ReminderTableData>(-497403264, new global::System.Object[]{@begin, @end});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.ReminderEntry> @ReadRow(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName)
        {
            return base.@InvokeMethodAsync<global::Orleans.ReminderEntry>(1312340311, new global::System.Object[]{@grainRef, @reminderName});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UpsertRow(global::Orleans.ReminderEntry @entry)
        {
            return base.@InvokeMethodAsync<global::System.String>(-1664645999, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @RemoveRow(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName, global::System.String @eTag)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1912556377, new global::System.Object[]{@grainRef, @reminderName, @eTag});
        }

        public global::System.Threading.Tasks.Task @TestOnlyClearTable()
        {
            return base.@InvokeMethodAsync<global::System.Object>(120951690, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.IReminderTableGrain), -1135060418), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenReminderTableGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -1135060418:
                    switch (methodId)
                    {
                        case -2145584474:
                            return ((global::Orleans.IReminderTableGrain)@grain).@Init((global::Orleans.Runtime.Configuration.GlobalConfiguration)arguments[0], (global::Orleans.Runtime.Logger)arguments[1]).@Box();
                        case -355259193:
                            return ((global::Orleans.IReminderTableGrain)@grain).@ReadRows((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                        case -497403264:
                            return ((global::Orleans.IReminderTableGrain)@grain).@ReadRows((global::System.UInt32)arguments[0], (global::System.UInt32)arguments[1]).@Box();
                        case 1312340311:
                            return ((global::Orleans.IReminderTableGrain)@grain).@ReadRow((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1]).@Box();
                        case -1664645999:
                            return ((global::Orleans.IReminderTableGrain)@grain).@UpsertRow((global::Orleans.ReminderEntry)arguments[0]).@Box();
                        case -1912556377:
                            return ((global::Orleans.IReminderTableGrain)@grain).@RemoveRow((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1], (global::System.String)arguments[2]).@Box();
                        case 120951690:
                            return ((global::Orleans.IReminderTableGrain)@grain).@TestOnlyClearTable().@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1135060418 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1135060418;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ReminderTableData))]
    internal class OrleansCodeGenOrleans_ReminderTableDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.ReminderTableData).@GetTypeInfo().@GetField("<Reminders>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderTableData, global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>> setField0 = (global::System.Action<global::Orleans.ReminderTableData, global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Orleans.ReminderTableData input = ((global::Orleans.ReminderTableData)original);
            global::Orleans.ReminderTableData result = new global::Orleans.ReminderTableData();
            context.@RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Reminders, context));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Orleans.ReminderTableData input = (global::Orleans.ReminderTableData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Reminders, context, typeof (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Orleans.ReminderTableData result = new global::Orleans.ReminderTableData();
            context.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>), context));
            return (global::Orleans.ReminderTableData)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IReminderService))]
    internal class OrleansCodeGenReminderServiceReference : global::Orleans.Runtime.GrainReference, global::Orleans.IReminderService
    {
        protected @OrleansCodeGenReminderServiceReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenReminderServiceReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1450843817;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IReminderService";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1450843817 || @interfaceId == 1569206711;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1450843817:
                    switch (@methodId)
                    {
                        case 1420312199:
                            return "Start";
                        case -1505116304:
                            return "Stop";
                        case 1588772828:
                            return "RegisterOrUpdateReminder";
                        case 622645164:
                            return "UnregisterReminder";
                        case 2144663751:
                            return "GetReminder";
                        case -1913437315:
                            return "GetReminders";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1450843817 + ",methodId=" + @methodId);
                    }

                case 1569206711:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1569206711 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Start()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1420312199, null);
        }

        public global::System.Threading.Tasks.Task @Stop()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1505116304, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.IGrainReminder> @RegisterOrUpdateReminder(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName, global::System.TimeSpan @dueTime, global::System.TimeSpan @period)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.IGrainReminder>(1588772828, new global::System.Object[]{@grainRef, @reminderName, @dueTime, @period});
        }

        public global::System.Threading.Tasks.Task @UnregisterReminder(global::Orleans.Runtime.IGrainReminder @reminder)
        {
            return base.@InvokeMethodAsync<global::System.Object>(622645164, new global::System.Object[]{@reminder});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.IGrainReminder> @GetReminder(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.IGrainReminder>(2144663751, new global::System.Object[]{@grainRef, @reminderName});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.IGrainReminder>> @GetReminders(global::Orleans.Runtime.GrainReference @grainRef)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.IGrainReminder>>(-1913437315, new global::System.Object[]{@grainRef});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.IReminderService), 1450843817), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenReminderServiceMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 1450843817:
                    switch (methodId)
                    {
                        case 1420312199:
                            return ((global::Orleans.IReminderService)@grain).@Start().@Box();
                        case -1505116304:
                            return ((global::Orleans.IReminderService)@grain).@Stop().@Box();
                        case 1588772828:
                            return ((global::Orleans.IReminderService)@grain).@RegisterOrUpdateReminder((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1], (global::System.TimeSpan)arguments[2], (global::System.TimeSpan)arguments[3]).@Box();
                        case 622645164:
                            return ((global::Orleans.IReminderService)@grain).@UnregisterReminder((global::Orleans.Runtime.IGrainReminder)arguments[0]).@Box();
                        case 2144663751:
                            return ((global::Orleans.IReminderService)@grain).@GetReminder((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1]).@Box();
                        case -1913437315:
                            return ((global::Orleans.IReminderService)@grain).@GetReminders((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1450843817 + ",methodId=" + methodId);
                    }

                case 1569206711:
                    switch (methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1569206711 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1450843817;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.ISiloControl))]
    internal class OrleansCodeGenSiloControlReference : global::Orleans.Runtime.GrainReference, global::Orleans.ISiloControl
    {
        protected @OrleansCodeGenSiloControlReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenSiloControlReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -48122956;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.ISiloControl";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -48122956;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -48122956:
                    switch (@methodId)
                    {
                        case 1328855378:
                            return "Ping";
                        case -1376618190:
                            return "SetSystemLogLevel";
                        case -1564002097:
                            return "SetAppLogLevel";
                        case 1478092477:
                            return "SetLogLevel";
                        case 1478133812:
                            return "ForceGarbageCollection";
                        case -2082132213:
                            return "ForceActivationCollection";
                        case 20725113:
                            return "ForceRuntimeStatisticsCollection";
                        case 1041905033:
                            return "GetRuntimeStatistics";
                        case 174208232:
                            return "GetGrainStatistics";
                        case -113560866:
                            return "GetDetailedGrainStatistics";
                        case -1434082603:
                            return "GetSimpleGrainStatistics";
                        case 903115134:
                            return "GetDetailedGrainReport";
                        case 1634125253:
                            return "UpdateConfiguration";
                        case -1863883354:
                            return "UpdateStreamProviders";
                        case -1522955713:
                            return "GetActivationCount";
                        case -1426691790:
                            return "SendControlCommandToProvider";
                        case -104793710:
                            return "GetGrainTypeList";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -48122956 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Ping(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1328855378, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @SetSystemLogLevel(global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1376618190, new global::System.Object[]{@traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetAppLogLevel(global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1564002097, new global::System.Object[]{@traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetLogLevel(global::System.String @logName, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1478092477, new global::System.Object[]{@logName, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @ForceGarbageCollection()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1478133812, null);
        }

        public global::System.Threading.Tasks.Task @ForceActivationCollection(global::System.TimeSpan @ageLimit)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2082132213, new global::System.Object[]{@ageLimit});
        }

        public global::System.Threading.Tasks.Task @ForceRuntimeStatisticsCollection()
        {
            return base.@InvokeMethodAsync<global::System.Object>(20725113, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics> @GetRuntimeStatistics()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SiloRuntimeStatistics>(1041905033, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.String, global::System.Int32>>> @GetGrainStatistics()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.String, global::System.Int32>>>(174208232, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.DetailedGrainStatistic>> @GetDetailedGrainStatistics(global::System.String[] @types)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.DetailedGrainStatistic>>(-113560866, new global::System.Object[]{@types});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> @GetSimpleGrainStatistics()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(-1434082603, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.DetailedGrainReport> @GetDetailedGrainReport(global::Orleans.Runtime.GrainId @grainId)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.DetailedGrainReport>(903115134, new global::System.Object[]{@grainId});
        }

        public global::System.Threading.Tasks.Task @UpdateConfiguration(global::System.String @configuration)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1634125253, new global::System.Object[]{@configuration});
        }

        public global::System.Threading.Tasks.Task @UpdateStreamProviders(global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration> @streamProviderConfigurations)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1863883354, new global::System.Object[]{@streamProviderConfigurations});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetActivationCount()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1522955713, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @SendControlCommandToProvider(global::System.String @providerTypeFullName, global::System.String @providerName, global::System.Int32 @command, global::System.Object @arg)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1426691790, new global::System.Object[]{@providerTypeFullName, @providerName, @command, @arg});
        }

        public global::System.Threading.Tasks.Task<global::System.String[]> @GetGrainTypeList()
        {
            return base.@InvokeMethodAsync<global::System.String[]>(-104793710, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.ISiloControl), -48122956), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenSiloControlMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -48122956:
                    switch (methodId)
                    {
                        case 1328855378:
                            return ((global::Orleans.ISiloControl)@grain).@Ping((global::System.String)arguments[0]).@Box();
                        case -1376618190:
                            return ((global::Orleans.ISiloControl)@grain).@SetSystemLogLevel((global::System.Int32)arguments[0]).@Box();
                        case -1564002097:
                            return ((global::Orleans.ISiloControl)@grain).@SetAppLogLevel((global::System.Int32)arguments[0]).@Box();
                        case 1478092477:
                            return ((global::Orleans.ISiloControl)@grain).@SetLogLevel((global::System.String)arguments[0], (global::System.Int32)arguments[1]).@Box();
                        case 1478133812:
                            return ((global::Orleans.ISiloControl)@grain).@ForceGarbageCollection().@Box();
                        case -2082132213:
                            return ((global::Orleans.ISiloControl)@grain).@ForceActivationCollection((global::System.TimeSpan)arguments[0]).@Box();
                        case 20725113:
                            return ((global::Orleans.ISiloControl)@grain).@ForceRuntimeStatisticsCollection().@Box();
                        case 1041905033:
                            return ((global::Orleans.ISiloControl)@grain).@GetRuntimeStatistics().@Box();
                        case 174208232:
                            return ((global::Orleans.ISiloControl)@grain).@GetGrainStatistics().@Box();
                        case -113560866:
                            return ((global::Orleans.ISiloControl)@grain).@GetDetailedGrainStatistics((global::System.String[])arguments[0]).@Box();
                        case -1434082603:
                            return ((global::Orleans.ISiloControl)@grain).@GetSimpleGrainStatistics().@Box();
                        case 903115134:
                            return ((global::Orleans.ISiloControl)@grain).@GetDetailedGrainReport((global::Orleans.Runtime.GrainId)arguments[0]).@Box();
                        case 1634125253:
                            return ((global::Orleans.ISiloControl)@grain).@UpdateConfiguration((global::System.String)arguments[0]).@Box();
                        case -1863883354:
                            return ((global::Orleans.ISiloControl)@grain).@UpdateStreamProviders((global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)arguments[0]).@Box();
                        case -1522955713:
                            return ((global::Orleans.ISiloControl)@grain).@GetActivationCount().@Box();
                        case -1426691790:
                            return ((global::Orleans.ISiloControl)@grain).@SendControlCommandToProvider((global::System.String)arguments[0], (global::System.String)arguments[1], (global::System.Int32)arguments[2], (global::System.Object)arguments[3]);
                        case -104793710:
                            return ((global::Orleans.ISiloControl)@grain).@GetGrainTypeList().@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -48122956 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -48122956;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IRemindable))]
    internal class OrleansCodeGenRemindableReference : global::Orleans.Runtime.GrainReference, global::Orleans.IRemindable
    {
        protected @OrleansCodeGenRemindableReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenRemindableReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -831689659;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IRemindable";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -831689659;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -831689659:
                    switch (@methodId)
                    {
                        case -1573596583:
                            return "ReceiveReminder";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -831689659 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @ReceiveReminder(global::System.String @reminderName, global::Orleans.Runtime.TickStatus @status)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1573596583, new global::System.Object[]{@reminderName, @status});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.IRemindable), -831689659), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenRemindableMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -831689659:
                    switch (methodId)
                    {
                        case -1573596583:
                            return ((global::Orleans.IRemindable)@grain).@ReceiveReminder((global::System.String)arguments[0], (global::Orleans.Runtime.TickStatus)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -831689659 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -831689659;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IGrainWithStringKey))]
    internal class OrleansCodeGenGrainWithStringKeyReference : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainWithStringKey
    {
        protected @OrleansCodeGenGrainWithStringKeyReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenGrainWithStringKeyReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1277021679;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IGrainWithStringKey";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
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
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.IGrainWithStringKey), -1277021679), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenGrainWithStringKeyMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                return -1277021679;
            }
        }
    }
}

namespace Orleans.SystemTargetInterfaces
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory))]
    internal class OrleansCodeGenClusterGrainDirectoryReference : global::Orleans.Runtime.GrainReference, global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory
    {
        protected @OrleansCodeGenClusterGrainDirectoryReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClusterGrainDirectoryReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1561817977;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1561817977;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1561817977:
                    switch (@methodId)
                    {
                        case -273580082:
                            return "ProcessActivationRequest";
                        case -244486227:
                            return "ProcessActivationRequestBatch";
                        case -475182299:
                            return "ProcessDeactivations";
                        case -997234097:
                            return "ProcessDeletion";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1561817977 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse> @ProcessActivationRequest(global::Orleans.Runtime.GrainId @grain, global::System.String @requestClusterId, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse>(-273580082, new global::System.Object[]{@grain, @requestClusterId, @hopCount});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse[]> @ProcessActivationRequestBatch(global::Orleans.Runtime.GrainId[] @grains, global::System.String @sendingClusterId)
        {
            return base.@InvokeMethodAsync<global::Orleans.SystemTargetInterfaces.RemoteClusterActivationResponse[]>(-244486227, new global::System.Object[]{@grains, @sendingClusterId});
        }

        public global::System.Threading.Tasks.Task @ProcessDeactivations(global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress> @addresses)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-475182299, new global::System.Object[]{@addresses});
        }

        public global::System.Threading.Tasks.Task @ProcessDeletion(global::Orleans.Runtime.GrainId @grainId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-997234097, new global::System.Object[]{@grainId});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory), -1561817977), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClusterGrainDirectoryMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -1561817977:
                    switch (methodId)
                    {
                        case -273580082:
                            return ((global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory)@grain).@ProcessActivationRequest((global::Orleans.Runtime.GrainId)arguments[0], (global::System.String)arguments[1], (global::System.Int32)arguments[2]).@Box();
                        case -244486227:
                            return ((global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory)@grain).@ProcessActivationRequestBatch((global::Orleans.Runtime.GrainId[])arguments[0], (global::System.String)arguments[1]).@Box();
                        case -475182299:
                            return ((global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory)@grain).@ProcessDeactivations((global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)arguments[0]).@Box();
                        case -997234097:
                            return ((global::Orleans.SystemTargetInterfaces.IClusterGrainDirectory)@grain).@ProcessDeletion((global::Orleans.Runtime.GrainId)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1561817977 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1561817977;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.SystemTargetInterfaces.ILogConsistencyProtocolGateway))]
    internal class OrleansCodeGenLogConsistencyProtocolGatewayReference : global::Orleans.Runtime.GrainReference, global::Orleans.SystemTargetInterfaces.ILogConsistencyProtocolGateway
    {
        protected @OrleansCodeGenLogConsistencyProtocolGatewayReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenLogConsistencyProtocolGatewayReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -722087067;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.SystemTargetInterfaces.ILogConsistencyProtocolGateway";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -722087067;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -722087067:
                    switch (@methodId)
                    {
                        case -188290352:
                            return "RelayMessage";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -722087067 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MultiCluster.ILogConsistencyProtocolMessage> @RelayMessage(global::Orleans.Runtime.GrainId @id, global::Orleans.MultiCluster.ILogConsistencyProtocolMessage @payload)
        {
            return base.@InvokeMethodAsync<global::Orleans.MultiCluster.ILogConsistencyProtocolMessage>(-188290352, new global::System.Object[]{@id, @payload});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.SystemTargetInterfaces.ILogConsistencyProtocolGateway), -722087067), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenLogConsistencyProtocolGatewayMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -722087067:
                    switch (methodId)
                    {
                        case -188290352:
                            return ((global::Orleans.SystemTargetInterfaces.ILogConsistencyProtocolGateway)@grain).@RelayMessage((global::Orleans.Runtime.GrainId)arguments[0], (global::Orleans.MultiCluster.ILogConsistencyProtocolMessage)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -722087067 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -722087067;
            }
        }
    }
}

namespace Orleans.Streams
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IStreamQueueBalanceListener))]
    internal class OrleansCodeGenStreamQueueBalanceListenerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IStreamQueueBalanceListener
    {
        protected @OrleansCodeGenStreamQueueBalanceListenerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStreamQueueBalanceListenerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 2106004533;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IStreamQueueBalanceListener";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 2106004533;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 2106004533:
                    switch (@methodId)
                    {
                        case -1790343421:
                            return "QueueDistributionChangeNotification";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 2106004533 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @QueueDistributionChangeNotification()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1790343421, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Streams.IStreamQueueBalanceListener), 2106004533), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStreamQueueBalanceListenerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 2106004533:
                    switch (methodId)
                    {
                        case -1790343421:
                            return ((global::Orleans.Streams.IStreamQueueBalanceListener)@grain).@QueueDistributionChangeNotification().@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 2106004533 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 2106004533;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IPersistentStreamPullingAgent))]
    internal class OrleansCodeGenPersistentStreamPullingAgentReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IPersistentStreamPullingAgent
    {
        protected @OrleansCodeGenPersistentStreamPullingAgentReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPersistentStreamPullingAgentReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -2083502648;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IPersistentStreamPullingAgent";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -2083502648 || @interfaceId == 939373632;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -2083502648:
                    switch (@methodId)
                    {
                        case 1817704332:
                            return "Initialize";
                        case -2097507506:
                            return "Shutdown";
                        case 1447414468:
                            return "AddSubscriber";
                        case -1759922013:
                            return "RemoveSubscriber";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2083502648 + ",methodId=" + @methodId);
                    }

                case 939373632:
                    switch (@methodId)
                    {
                        case 1447414468:
                            return "AddSubscriber";
                        case -1759922013:
                            return "RemoveSubscriber";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Initialize(global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter> @queueAdapter, global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapterCache> @queueAdapterCache, global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IStreamFailureHandler> @deliveryFailureHandler)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1817704332, new global::System.Object[]{@queueAdapter, @queueAdapterCache, @deliveryFailureHandler});
        }

        public global::System.Threading.Tasks.Task @Shutdown()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2097507506, null);
        }

        public global::System.Threading.Tasks.Task @AddSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer, global::Orleans.Streams.IStreamFilterPredicateWrapper @filter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1447414468, new global::System.Object[]{@subscriptionId, @streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer, @filter}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }

        public global::System.Threading.Tasks.Task @RemoveSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1759922013, new global::System.Object[]{@subscriptionId, @streamId}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Streams.IPersistentStreamPullingAgent), -2083502648), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPersistentStreamPullingAgentMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker, global::Orleans.CodeGeneration.IGrainExtensionMethodInvoker
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
                case -2083502648:
                    switch (methodId)
                    {
                        case 1817704332:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@Initialize((global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter>)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapterCache>)arguments[1], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IStreamFailureHandler>)arguments[2]).@Box();
                        case -2097507506:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@Shutdown().@Box();
                        case 1447414468:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                        case -1759922013:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2083502648 + ",methodId=" + methodId);
                    }

                case 939373632:
                    switch (methodId)
                    {
                        case 1447414468:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                        case -1759922013:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -2083502648;
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IGrainExtension @extension, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            if (@extension == null)
                throw new global::System.ArgumentNullException("extension");
            switch (interfaceId)
            {
                case -2083502648:
                    switch (methodId)
                    {
                        case 1817704332:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@Initialize((global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter>)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapterCache>)arguments[1], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IStreamFailureHandler>)arguments[2]).@Box();
                        case -2097507506:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@Shutdown().@Box();
                        case 1447414468:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                        case -1759922013:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2083502648 + ",methodId=" + methodId);
                    }

                case 939373632:
                    switch (methodId)
                    {
                        case 1447414468:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                        case -1759922013:
                            return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IPersistentStreamPullingManager))]
    internal class OrleansCodeGenPersistentStreamPullingManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IPersistentStreamPullingManager
    {
        protected @OrleansCodeGenPersistentStreamPullingManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPersistentStreamPullingManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 789366386;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IPersistentStreamPullingManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 789366386;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 789366386:
                    switch (@methodId)
                    {
                        case -166879657:
                            return "Initialize";
                        case -1505116304:
                            return "Stop";
                        case -981473487:
                            return "StartAgents";
                        case -1266241283:
                            return "StopAgents";
                        case -906698655:
                            return "ExecuteCommand";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 789366386 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Initialize(global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter> @queueAdapter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-166879657, new global::System.Object[]{@queueAdapter});
        }

        public global::System.Threading.Tasks.Task @Stop()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1505116304, null);
        }

        public global::System.Threading.Tasks.Task @StartAgents()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-981473487, null);
        }

        public global::System.Threading.Tasks.Task @StopAgents()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1266241283, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @ExecuteCommand(global::Orleans.Providers.Streams.Common.PersistentStreamProviderCommand @command, global::System.Object @arg)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-906698655, new global::System.Object[]{@command, @arg});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Streams.IPersistentStreamPullingManager), 789366386), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPersistentStreamPullingManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 789366386:
                    switch (methodId)
                    {
                        case -166879657:
                            return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@Initialize((global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter>)arguments[0]).@Box();
                        case -1505116304:
                            return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@Stop().@Box();
                        case -981473487:
                            return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@StartAgents().@Box();
                        case -1266241283:
                            return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@StopAgents().@Box();
                        case -906698655:
                            return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@ExecuteCommand((global::Orleans.Providers.Streams.Common.PersistentStreamProviderCommand)arguments[0], (global::System.Object)arguments[1]);
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 789366386 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 789366386;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IStreamConsumerExtension))]
    internal class OrleansCodeGenStreamConsumerExtensionReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IStreamConsumerExtension
    {
        protected @OrleansCodeGenStreamConsumerExtensionReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStreamConsumerExtensionReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1208535911;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IStreamConsumerExtension";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1208535911;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1208535911:
                    switch (@methodId)
                    {
                        case 29402488:
                            return "DeliverImmutable";
                        case 162788949:
                            return "DeliverMutable";
                        case -388181897:
                            return "DeliverBatch";
                        case -627903062:
                            return "CompleteStream";
                        case -1893107802:
                            return "ErrorInStream";
                        case -1402418353:
                            return "GetSequenceToken";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1208535911 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.StreamHandshakeToken> @DeliverImmutable(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Concurrency.Immutable<global::System.Object> @item, global::Orleans.Streams.StreamSequenceToken @currentToken, global::Orleans.Streams.StreamHandshakeToken @handshakeToken)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.StreamHandshakeToken>(29402488, new global::System.Object[]{@subscriptionId, @item, @currentToken, @handshakeToken});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.StreamHandshakeToken> @DeliverMutable(global::Orleans.Runtime.GuidId @subscriptionId, global::System.Object @item, global::Orleans.Streams.StreamSequenceToken @currentToken, global::Orleans.Streams.StreamHandshakeToken @handshakeToken)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.StreamHandshakeToken>(162788949, new global::System.Object[]{@subscriptionId, @item, @currentToken, @handshakeToken});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.StreamHandshakeToken> @DeliverBatch(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IBatchContainer> @item, global::Orleans.Streams.StreamHandshakeToken @handshakeToken)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.StreamHandshakeToken>(-388181897, new global::System.Object[]{@subscriptionId, @item, @handshakeToken});
        }

        public global::System.Threading.Tasks.Task @CompleteStream(global::Orleans.Runtime.GuidId @subscriptionId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-627903062, new global::System.Object[]{@subscriptionId});
        }

        public global::System.Threading.Tasks.Task @ErrorInStream(global::Orleans.Runtime.GuidId @subscriptionId, global::System.Exception @exc)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1893107802, new global::System.Object[]{@subscriptionId, @exc});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.StreamHandshakeToken> @GetSequenceToken(global::Orleans.Runtime.GuidId @subscriptionId)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.StreamHandshakeToken>(-1402418353, new global::System.Object[]{@subscriptionId});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Streams.IStreamConsumerExtension), 1208535911), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStreamConsumerExtensionMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker, global::Orleans.CodeGeneration.IGrainExtensionMethodInvoker
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
                case 1208535911:
                    switch (methodId)
                    {
                        case 29402488:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@DeliverImmutable((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::System.Object>)arguments[1], (global::Orleans.Streams.StreamSequenceToken)arguments[2], (global::Orleans.Streams.StreamHandshakeToken)arguments[3]).@Box();
                        case 162788949:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@DeliverMutable((global::Orleans.Runtime.GuidId)arguments[0], (global::System.Object)arguments[1], (global::Orleans.Streams.StreamSequenceToken)arguments[2], (global::Orleans.Streams.StreamHandshakeToken)arguments[3]).@Box();
                        case -388181897:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@DeliverBatch((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IBatchContainer>)arguments[1], (global::Orleans.Streams.StreamHandshakeToken)arguments[2]).@Box();
                        case -627903062:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@CompleteStream((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                        case -1893107802:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@ErrorInStream((global::Orleans.Runtime.GuidId)arguments[0], (global::System.Exception)arguments[1]).@Box();
                        case -1402418353:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@GetSequenceToken((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1208535911 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1208535911;
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IGrainExtension @extension, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            if (@extension == null)
                throw new global::System.ArgumentNullException("extension");
            switch (interfaceId)
            {
                case 1208535911:
                    switch (methodId)
                    {
                        case 29402488:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@DeliverImmutable((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::System.Object>)arguments[1], (global::Orleans.Streams.StreamSequenceToken)arguments[2], (global::Orleans.Streams.StreamHandshakeToken)arguments[3]).@Box();
                        case 162788949:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@DeliverMutable((global::Orleans.Runtime.GuidId)arguments[0], (global::System.Object)arguments[1], (global::Orleans.Streams.StreamSequenceToken)arguments[2], (global::Orleans.Streams.StreamHandshakeToken)arguments[3]).@Box();
                        case -388181897:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@DeliverBatch((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IBatchContainer>)arguments[1], (global::Orleans.Streams.StreamHandshakeToken)arguments[2]).@Box();
                        case -627903062:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@CompleteStream((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                        case -1893107802:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@ErrorInStream((global::Orleans.Runtime.GuidId)arguments[0], (global::System.Exception)arguments[1]).@Box();
                        case -1402418353:
                            return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@GetSequenceToken((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1208535911 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IStreamProducerExtension))]
    internal class OrleansCodeGenStreamProducerExtensionReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IStreamProducerExtension
    {
        protected @OrleansCodeGenStreamProducerExtensionReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStreamProducerExtensionReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 939373632;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IStreamProducerExtension";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 939373632;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 939373632:
                    switch (@methodId)
                    {
                        case 1447414468:
                            return "AddSubscriber";
                        case -1759922013:
                            return "RemoveSubscriber";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @AddSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer, global::Orleans.Streams.IStreamFilterPredicateWrapper @filter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1447414468, new global::System.Object[]{@subscriptionId, @streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer, @filter}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }

        public global::System.Threading.Tasks.Task @RemoveSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1759922013, new global::System.Object[]{@subscriptionId, @streamId}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Streams.IStreamProducerExtension), 939373632), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStreamProducerExtensionMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker, global::Orleans.CodeGeneration.IGrainExtensionMethodInvoker
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
                case 939373632:
                    switch (methodId)
                    {
                        case 1447414468:
                            return ((global::Orleans.Streams.IStreamProducerExtension)@grain).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                        case -1759922013:
                            return ((global::Orleans.Streams.IStreamProducerExtension)@grain).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 939373632;
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IGrainExtension @extension, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            if (@extension == null)
                throw new global::System.ArgumentNullException("extension");
            switch (interfaceId)
            {
                case 939373632:
                    switch (methodId)
                    {
                        case 1447414468:
                            return ((global::Orleans.Streams.IStreamProducerExtension)@extension).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                        case -1759922013:
                            return ((global::Orleans.Streams.IStreamProducerExtension)@extension).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IPubSubRendezvousGrain))]
    internal class OrleansCodeGenPubSubRendezvousGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IPubSubRendezvousGrain
    {
        protected @OrleansCodeGenPubSubRendezvousGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPubSubRendezvousGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1746702088;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IPubSubRendezvousGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1746702088;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1746702088:
                    switch (@methodId)
                    {
                        case 912534711:
                            return "RegisterProducer";
                        case 1454606735:
                            return "UnregisterProducer";
                        case 1134142912:
                            return "RegisterConsumer";
                        case 1942100900:
                            return "UnregisterConsumer";
                        case 687623645:
                            return "ProducerCount";
                        case 1754136586:
                            return "ConsumerCount";
                        case -1264954998:
                            return "DiagGetConsumers";
                        case 1980500241:
                            return "Validate";
                        case 2028422179:
                            return "GetAllSubscriptions";
                        case -984771197:
                            return "FaultSubscription";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1746702088 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.ISet<global::Orleans.Streams.PubSubSubscriptionState>> @RegisterProducer(global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamProducerExtension @streamProducer)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.ISet<global::Orleans.Streams.PubSubSubscriptionState>>(912534711, new global::System.Object[]{@streamId, @streamProducer is global::Orleans.Grain ? @streamProducer.@AsReference<global::Orleans.Streams.IStreamProducerExtension>() : @streamProducer});
        }

        public global::System.Threading.Tasks.Task @UnregisterProducer(global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamProducerExtension @streamProducer)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1454606735, new global::System.Object[]{@streamId, @streamProducer is global::Orleans.Grain ? @streamProducer.@AsReference<global::Orleans.Streams.IStreamProducerExtension>() : @streamProducer});
        }

        public global::System.Threading.Tasks.Task @RegisterConsumer(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer, global::Orleans.Streams.IStreamFilterPredicateWrapper @filter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1134142912, new global::System.Object[]{@subscriptionId, @streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer, @filter});
        }

        public global::System.Threading.Tasks.Task @UnregisterConsumer(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1942100900, new global::System.Object[]{@subscriptionId, @streamId});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @ProducerCount(global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(687623645, new global::System.Object[]{@streamId});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @ConsumerCount(global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1754136586, new global::System.Object[]{@streamId});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.PubSubSubscriptionState[]> @DiagGetConsumers(global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.PubSubSubscriptionState[]>(-1264954998, new global::System.Object[]{@streamId});
        }

        public global::System.Threading.Tasks.Task @Validate()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1980500241, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.GuidId>> @GetAllSubscriptions(global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.GuidId>>(2028422179, new global::System.Object[]{@streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer});
        }

        public global::System.Threading.Tasks.Task @FaultSubscription(global::Orleans.Runtime.GuidId @subscriptionId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-984771197, new global::System.Object[]{@subscriptionId});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Streams.IPubSubRendezvousGrain), 1746702088), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPubSubRendezvousGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 1746702088:
                    switch (methodId)
                    {
                        case 912534711:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@RegisterProducer((global::Orleans.Streams.StreamId)arguments[0], (global::Orleans.Streams.IStreamProducerExtension)arguments[1]).@Box();
                        case 1454606735:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@UnregisterProducer((global::Orleans.Streams.StreamId)arguments[0], (global::Orleans.Streams.IStreamProducerExtension)arguments[1]).@Box();
                        case 1134142912:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@RegisterConsumer((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                        case 1942100900:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@UnregisterConsumer((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                        case 687623645:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@ProducerCount((global::Orleans.Streams.StreamId)arguments[0]).@Box();
                        case 1754136586:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@ConsumerCount((global::Orleans.Streams.StreamId)arguments[0]).@Box();
                        case -1264954998:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@DiagGetConsumers((global::Orleans.Streams.StreamId)arguments[0]).@Box();
                        case 1980500241:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@Validate().@Box();
                        case 2028422179:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@GetAllSubscriptions((global::Orleans.Streams.StreamId)arguments[0], (global::Orleans.Streams.IStreamConsumerExtension)arguments[1]).@Box();
                        case -984771197:
                            return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@FaultSubscription((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1746702088 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1746702088;
            }
        }
    }
}

namespace Orleans.Services
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Services.IGrainService))]
    internal class OrleansCodeGenGrainServiceReference : global::Orleans.Runtime.GrainReference, global::Orleans.Services.IGrainService
    {
        protected @OrleansCodeGenGrainServiceReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenGrainServiceReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1569206711;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Services.IGrainService";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1569206711;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1569206711:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1569206711 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Services.IGrainService), 1569206711), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenGrainServiceMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 1569206711:
                    switch (methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1569206711 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1569206711;
            }
        }
    }
}

namespace Orleans.Storage
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Storage.IMemoryStorageGrain))]
    internal class OrleansCodeGenMemoryStorageGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Storage.IMemoryStorageGrain
    {
        protected @OrleansCodeGenMemoryStorageGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMemoryStorageGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 577125491;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Storage.IMemoryStorageGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 577125491;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 577125491:
                    switch (@methodId)
                    {
                        case -1395809340:
                            return "ReadStateAsync";
                        case -771347504:
                            return "WriteStateAsync";
                        case 1872309868:
                            return "DeleteStateAsync";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 577125491 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.IGrainState> @ReadStateAsync(global::System.String @stateStore, global::System.String @grainStoreKey)
        {
            return base.@InvokeMethodAsync<global::Orleans.IGrainState>(-1395809340, new global::System.Object[]{@stateStore, @grainStoreKey});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @WriteStateAsync(global::System.String @grainType, global::System.String @grainId, global::Orleans.IGrainState @grainState)
        {
            return base.@InvokeMethodAsync<global::System.String>(-771347504, new global::System.Object[]{@grainType, @grainId, @grainState});
        }

        public global::System.Threading.Tasks.Task @DeleteStateAsync(global::System.String @stateStore, global::System.String @grainStoreKey, global::System.String @eTag)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1872309868, new global::System.Object[]{@stateStore, @grainStoreKey, @eTag});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Storage.IMemoryStorageGrain), 577125491), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMemoryStorageGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 577125491:
                    switch (methodId)
                    {
                        case -1395809340:
                            return ((global::Orleans.Storage.IMemoryStorageGrain)@grain).@ReadStateAsync((global::System.String)arguments[0], (global::System.String)arguments[1]).@Box();
                        case -771347504:
                            return ((global::Orleans.Storage.IMemoryStorageGrain)@grain).@WriteStateAsync((global::System.String)arguments[0], (global::System.String)arguments[1], (global::Orleans.IGrainState)arguments[2]).@Box();
                        case 1872309868:
                            return ((global::Orleans.Storage.IMemoryStorageGrain)@grain).@DeleteStateAsync((global::System.String)arguments[0], (global::System.String)arguments[1], (global::System.String)arguments[2]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 577125491 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 577125491;
            }
        }
    }
}

namespace Orleans.Runtime
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IStreamProviderManagerAgent))]
    internal class OrleansCodeGenStreamProviderManagerAgentReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IStreamProviderManagerAgent
    {
        protected @OrleansCodeGenStreamProviderManagerAgentReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStreamProviderManagerAgentReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1370071947;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IStreamProviderManagerAgent";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1370071947;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1370071947:
                    switch (@methodId)
                    {
                        case -1863883354:
                            return "UpdateStreamProviders";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1370071947 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @UpdateStreamProviders(global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration> @streamProviderConfigurations)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1863883354, new global::System.Object[]{@streamProviderConfigurations});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IStreamProviderManagerAgent), -1370071947), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStreamProviderManagerAgentMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -1370071947:
                    switch (methodId)
                    {
                        case -1863883354:
                            return ((global::Orleans.Runtime.IStreamProviderManagerAgent)@grain).@UpdateStreamProviders((global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1370071947 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1370071947;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IMultiClusterGossipService))]
    internal class OrleansCodeGenMultiClusterGossipServiceReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IMultiClusterGossipService
    {
        protected @OrleansCodeGenMultiClusterGossipServiceReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMultiClusterGossipServiceReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 890050216;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IMultiClusterGossipService";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 890050216;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 890050216:
                    switch (@methodId)
                    {
                        case 498259458:
                            return "Publish";
                        case -1827952751:
                            return "Synchronize";
                        case 2090338612:
                            return "FindLaggingSilos";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 890050216 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Publish(global::Orleans.Runtime.IMultiClusterGossipData @gossipData, global::System.Boolean @forwardLocally)
        {
            return base.@InvokeMethodAsync<global::System.Object>(498259458, new global::System.Object[]{@gossipData, @forwardLocally});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.IMultiClusterGossipData> @Synchronize(global::Orleans.Runtime.IMultiClusterGossipData @gossipData)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.IMultiClusterGossipData>(-1827952751, new global::System.Object[]{@gossipData});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.SiloAddress>> @FindLaggingSilos(global::Orleans.MultiCluster.MultiClusterConfiguration @expected, global::System.Boolean @forwardLocally)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.SiloAddress>>(2090338612, new global::System.Object[]{@expected, @forwardLocally});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IMultiClusterGossipService), 890050216), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMultiClusterGossipServiceMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 890050216:
                    switch (methodId)
                    {
                        case 498259458:
                            return ((global::Orleans.Runtime.IMultiClusterGossipService)@grain).@Publish((global::Orleans.Runtime.IMultiClusterGossipData)arguments[0], (global::System.Boolean)arguments[1]).@Box();
                        case -1827952751:
                            return ((global::Orleans.Runtime.IMultiClusterGossipService)@grain).@Synchronize((global::Orleans.Runtime.IMultiClusterGossipData)arguments[0]).@Box();
                        case 2090338612:
                            return ((global::Orleans.Runtime.IMultiClusterGossipService)@grain).@FindLaggingSilos((global::Orleans.MultiCluster.MultiClusterConfiguration)arguments[0], (global::System.Boolean)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 890050216 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 890050216;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.ICancellationSourcesExtension))]
    internal class OrleansCodeGenCancellationSourcesExtensionReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ICancellationSourcesExtension
    {
        protected @OrleansCodeGenCancellationSourcesExtensionReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenCancellationSourcesExtensionReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 720338163;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.ICancellationSourcesExtension";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 720338163;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 720338163:
                    switch (@methodId)
                    {
                        case 13100051:
                            return "CancelRemoteToken";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 720338163 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @CancelRemoteToken(global::Orleans.GrainCancellationToken @token)
        {
            return base.@InvokeMethodAsync<global::System.Object>(13100051, new global::System.Object[]{@token}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.ICancellationSourcesExtension), 720338163), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenCancellationSourcesExtensionMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker, global::Orleans.CodeGeneration.IGrainExtensionMethodInvoker
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
                case 720338163:
                    switch (methodId)
                    {
                        case 13100051:
                            return ((global::Orleans.Runtime.ICancellationSourcesExtension)@grain).@CancelRemoteToken((global::Orleans.GrainCancellationToken)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 720338163 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 720338163;
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IGrainExtension @extension, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            if (@extension == null)
                throw new global::System.ArgumentNullException("extension");
            switch (interfaceId)
            {
                case 720338163:
                    switch (methodId)
                    {
                        case 13100051:
                            return ((global::Orleans.Runtime.ICancellationSourcesExtension)@extension).@CancelRemoteToken((global::Orleans.GrainCancellationToken)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 720338163 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IClusterTypeManager))]
    internal class OrleansCodeGenClusterTypeManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IClusterTypeManager
    {
        protected @OrleansCodeGenClusterTypeManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClusterTypeManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1666714017;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IClusterTypeManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1666714017;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1666714017:
                    switch (@methodId)
                    {
                        case -354330729:
                            return "GetClusterTypeCodeMap";
                        case 1918315851:
                            return "GetImplicitStreamSubscriberTable";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1666714017 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.IGrainTypeResolver> @GetClusterTypeCodeMap()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.IGrainTypeResolver>(-354330729, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.ImplicitStreamSubscriberTable> @GetImplicitStreamSubscriberTable(global::Orleans.Runtime.SiloAddress @silo)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.ImplicitStreamSubscriberTable>(1918315851, new global::System.Object[]{@silo});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IClusterTypeManager), -1666714017), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClusterTypeManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -1666714017:
                    switch (methodId)
                    {
                        case -354330729:
                            return ((global::Orleans.Runtime.IClusterTypeManager)@grain).@GetClusterTypeCodeMap().@Box();
                        case 1918315851:
                            return ((global::Orleans.Runtime.IClusterTypeManager)@grain).@GetImplicitStreamSubscriberTable((global::Orleans.Runtime.SiloAddress)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1666714017 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1666714017;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.ISiloTypeManager))]
    internal class OrleansCodeGenSiloTypeManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ISiloTypeManager
    {
        protected @OrleansCodeGenSiloTypeManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenSiloTypeManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -895522402;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.ISiloTypeManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -895522402;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -895522402:
                    switch (@methodId)
                    {
                        case -1669561441:
                            return "GetSiloTypeCodeMap";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -895522402 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.GrainInterfaceMap> @GetSiloTypeCodeMap()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.GrainInterfaceMap>(-1669561441, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.ISiloTypeManager), -895522402), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenSiloTypeManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -895522402:
                    switch (methodId)
                    {
                        case -1669561441:
                            return ((global::Orleans.Runtime.ISiloTypeManager)@grain).@GetSiloTypeCodeMap().@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -895522402 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -895522402;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.ICatalog))]
    internal class OrleansCodeGenCatalogReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ICatalog
    {
        protected @OrleansCodeGenCatalogReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenCatalogReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -2124089409;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.ICatalog";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -2124089409;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -2124089409:
                    switch (@methodId)
                    {
                        case -1850604271:
                            return "DeleteActivations";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2124089409 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @DeleteActivations(global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress> @activationAddresses)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1850604271, new global::System.Object[]{@activationAddresses});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.ICatalog), -2124089409), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenCatalogMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -2124089409:
                    switch (methodId)
                    {
                        case -1850604271:
                            return ((global::Orleans.Runtime.ICatalog)@grain).@DeleteActivations((global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2124089409 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -2124089409;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IManagementGrain))]
    internal class OrleansCodeGenManagementGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IManagementGrain
    {
        protected @OrleansCodeGenManagementGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenManagementGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1734666656;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IManagementGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1734666656;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1734666656:
                    switch (@methodId)
                    {
                        case 1788323731:
                            return "GetHosts";
                        case -327337804:
                            return "GetDetailedHosts";
                        case 1345873229:
                            return "SetSystemLogLevel";
                        case -648657983:
                            return "SetAppLogLevel";
                        case -1683776832:
                            return "SetLogLevel";
                        case 2002650463:
                            return "ForceGarbageCollection";
                        case 316388927:
                            return "ForceActivationCollection";
                        case -2082132213:
                            return "ForceActivationCollection";
                        case 531832239:
                            return "ForceRuntimeStatisticsCollection";
                        case -1055610598:
                            return "GetRuntimeStatistics";
                        case -1446411211:
                            return "GetSimpleGrainStatistics";
                        case -1434082603:
                            return "GetSimpleGrainStatistics";
                        case 1395944208:
                            return "GetDetailedGrainStatistics";
                        case -1868174702:
                            return "GetGrainActivationCount";
                        case -1030672010:
                            return "GetTotalActivationCount";
                        case -1426691790:
                            return "SendControlCommandToProvider";
                        case -1529190212:
                            return "UpdateConfiguration";
                        case -1973022536:
                            return "UpdateStreamProviders";
                        case 246468652:
                            return "GetActiveGrainTypes";
                        case 1155837862:
                            return "GetMultiClusterGateways";
                        case -608062787:
                            return "GetMultiClusterConfiguration";
                        case -872738379:
                            return "FindLaggingSilos";
                        case -1494753748:
                            return "InjectMultiClusterConfiguration";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1734666656 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>> @GetHosts(global::System.Boolean @onlyActive)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>>(1788323731, new global::System.Object[]{@onlyActive});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MembershipEntry[]> @GetDetailedHosts(global::System.Boolean @onlyActive)
        {
            return base.@InvokeMethodAsync<global::Orleans.MembershipEntry[]>(-327337804, new global::System.Object[]{@onlyActive});
        }

        public global::System.Threading.Tasks.Task @SetSystemLogLevel(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1345873229, new global::System.Object[]{@hostsIds, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetAppLogLevel(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-648657983, new global::System.Object[]{@hostsIds, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetLogLevel(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.String @logName, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1683776832, new global::System.Object[]{@hostsIds, @logName, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @ForceGarbageCollection(global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2002650463, new global::System.Object[]{@hostsIds});
        }

        public global::System.Threading.Tasks.Task @ForceActivationCollection(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.TimeSpan @ageLimit)
        {
            return base.@InvokeMethodAsync<global::System.Object>(316388927, new global::System.Object[]{@hostsIds, @ageLimit});
        }

        public global::System.Threading.Tasks.Task @ForceActivationCollection(global::System.TimeSpan @ageLimit)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2082132213, new global::System.Object[]{@ageLimit});
        }

        public global::System.Threading.Tasks.Task @ForceRuntimeStatisticsCollection(global::Orleans.Runtime.SiloAddress[] @siloAddresses)
        {
            return base.@InvokeMethodAsync<global::System.Object>(531832239, new global::System.Object[]{@siloAddresses});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics[]> @GetRuntimeStatistics(global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SiloRuntimeStatistics[]>(-1055610598, new global::System.Object[]{@hostsIds});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> @GetSimpleGrainStatistics(global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(-1446411211, new global::System.Object[]{@hostsIds});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> @GetSimpleGrainStatistics()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(-1434082603, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.DetailedGrainStatistic[]> @GetDetailedGrainStatistics(global::System.String[] @types, global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.DetailedGrainStatistic[]>(1395944208, new global::System.Object[]{@types, @hostsIds});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetGrainActivationCount(global::Orleans.Runtime.GrainReference @grainReference)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1868174702, new global::System.Object[]{@grainReference});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetTotalActivationCount()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1030672010, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Object[]> @SendControlCommandToProvider(global::System.String @providerTypeFullName, global::System.String @providerName, global::System.Int32 @command, global::System.Object @arg)
        {
            return base.@InvokeMethodAsync<global::System.Object[]>(-1426691790, new global::System.Object[]{@providerTypeFullName, @providerName, @command, @arg});
        }

        public global::System.Threading.Tasks.Task @UpdateConfiguration(global::Orleans.Runtime.SiloAddress[] @hostIds, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> @configuration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> @tracing)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1529190212, new global::System.Object[]{@hostIds, @configuration, @tracing});
        }

        public global::System.Threading.Tasks.Task @UpdateStreamProviders(global::Orleans.Runtime.SiloAddress[] @hostIds, global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration> @streamProviderConfigurations)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1973022536, new global::System.Object[]{@hostIds, @streamProviderConfigurations});
        }

        public global::System.Threading.Tasks.Task<global::System.String[]> @GetActiveGrainTypes(global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::System.String[]>(246468652, new global::System.Object[]{@hostsIds});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.MultiCluster.IMultiClusterGatewayInfo>> @GetMultiClusterGateways()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.MultiCluster.IMultiClusterGatewayInfo>>(1155837862, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MultiCluster.MultiClusterConfiguration> @GetMultiClusterConfiguration()
        {
            return base.@InvokeMethodAsync<global::Orleans.MultiCluster.MultiClusterConfiguration>(-608062787, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.SiloAddress>> @FindLaggingSilos()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.SiloAddress>>(-872738379, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MultiCluster.MultiClusterConfiguration> @InjectMultiClusterConfiguration(global::System.Collections.Generic.IEnumerable<global::System.String> @clusters, global::System.String @comment, global::System.Boolean @checkForLaggingSilosFirst)
        {
            return base.@InvokeMethodAsync<global::Orleans.MultiCluster.MultiClusterConfiguration>(-1494753748, new global::System.Object[]{@clusters, @comment, @checkForLaggingSilosFirst});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IManagementGrain), -1734666656), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenManagementGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -1734666656:
                    switch (methodId)
                    {
                        case 1788323731:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetHosts((global::System.Boolean)arguments[0]).@Box();
                        case -327337804:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetDetailedHosts((global::System.Boolean)arguments[0]).@Box();
                        case 1345873229:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@SetSystemLogLevel((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.Int32)arguments[1]).@Box();
                        case -648657983:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@SetAppLogLevel((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.Int32)arguments[1]).@Box();
                        case -1683776832:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@SetLogLevel((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.String)arguments[1], (global::System.Int32)arguments[2]).@Box();
                        case 2002650463:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceGarbageCollection((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                        case 316388927:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceActivationCollection((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.TimeSpan)arguments[1]).@Box();
                        case -2082132213:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceActivationCollection((global::System.TimeSpan)arguments[0]).@Box();
                        case 531832239:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceRuntimeStatisticsCollection((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                        case -1055610598:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetRuntimeStatistics((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                        case -1446411211:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetSimpleGrainStatistics((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                        case -1434082603:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetSimpleGrainStatistics().@Box();
                        case 1395944208:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetDetailedGrainStatistics((global::System.String[])arguments[0], (global::Orleans.Runtime.SiloAddress[])arguments[1]).@Box();
                        case -1868174702:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetGrainActivationCount((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                        case -1030672010:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetTotalActivationCount().@Box();
                        case -1426691790:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@SendControlCommandToProvider((global::System.String)arguments[0], (global::System.String)arguments[1], (global::System.Int32)arguments[2], (global::System.Object)arguments[3]).@Box();
                        case -1529190212:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@UpdateConfiguration((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)arguments[1], (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)arguments[2]).@Box();
                        case -1973022536:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@UpdateStreamProviders((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)arguments[1]).@Box();
                        case 246468652:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetActiveGrainTypes((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                        case 1155837862:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetMultiClusterGateways().@Box();
                        case -608062787:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetMultiClusterConfiguration().@Box();
                        case -872738379:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@FindLaggingSilos().@Box();
                        case -1494753748:
                            return ((global::Orleans.Runtime.IManagementGrain)@grain).@InjectMultiClusterConfiguration((global::System.Collections.Generic.IEnumerable<global::System.String>)arguments[0], (global::System.String)arguments[1], (global::System.Boolean)arguments[2]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1734666656 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1734666656;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IMembershipService))]
    internal class OrleansCodeGenMembershipServiceReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IMembershipService
    {
        protected @OrleansCodeGenMembershipServiceReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMembershipServiceReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1380110596;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IMembershipService";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1380110596;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1380110596:
                    switch (@methodId)
                    {
                        case -378592564:
                            return "SiloStatusChangeNotification";
                        case 667017:
                            return "Ping";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1380110596 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SiloStatusChangeNotification(global::Orleans.Runtime.SiloAddress @updatedSilo, global::Orleans.Runtime.SiloStatus @status)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-378592564, new global::System.Object[]{@updatedSilo, @status});
        }

        public global::System.Threading.Tasks.Task @Ping(global::System.Int32 @pingNumber)
        {
            return base.@InvokeMethodAsync<global::System.Object>(667017, new global::System.Object[]{@pingNumber});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IMembershipService), 1380110596), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMembershipServiceMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case 1380110596:
                    switch (methodId)
                    {
                        case -378592564:
                            return ((global::Orleans.Runtime.IMembershipService)@grain).@SiloStatusChangeNotification((global::Orleans.Runtime.SiloAddress)arguments[0], (global::Orleans.Runtime.SiloStatus)arguments[1]).@Box();
                        case 667017:
                            return ((global::Orleans.Runtime.IMembershipService)@grain).@Ping((global::System.Int32)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1380110596 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1380110596;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IRemoteGrainDirectory))]
    internal class OrleansCodeGenRemoteGrainDirectoryReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IRemoteGrainDirectory
    {
        protected @OrleansCodeGenRemoteGrainDirectoryReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenRemoteGrainDirectoryReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -185679256;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IRemoteGrainDirectory";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -185679256;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -185679256:
                    switch (@methodId)
                    {
                        case 1407273934:
                            return "RegisterMany";
                        case 1942504603:
                            return "LookUpMany";
                        case -2026920982:
                            return "AcceptHandoffPartition";
                        case 1987552759:
                            return "RemoveHandoffPartition";
                        case 171163638:
                            return "RegisterAsync";
                        case 2089179563:
                            return "UnregisterAsync";
                        case 1470448647:
                            return "UnregisterManyAsync";
                        case -1888800139:
                            return "DeleteGrainAsync";
                        case -1272744289:
                            return "LookupAsync";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -185679256 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @RegisterMany(global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress> @addresses, global::System.Boolean @singleActivation)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1407273934, new global::System.Object[]{@addresses, @singleActivation});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>>>> @LookUpMany(global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>> @grainAndETagList)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>>>>(1942504603, new global::System.Object[]{@grainAndETagList});
        }

        public global::System.Threading.Tasks.Task @AcceptHandoffPartition(global::Orleans.Runtime.SiloAddress @source, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IGrainInfo> @partition, global::System.Boolean @isFullCopy)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2026920982, new global::System.Object[]{@source, @partition, @isFullCopy});
        }

        public global::System.Threading.Tasks.Task @RemoveHandoffPartition(global::Orleans.Runtime.SiloAddress @source)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1987552759, new global::System.Object[]{@source});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> @RegisterAsync(global::Orleans.Runtime.ActivationAddress @address, global::System.Boolean @singleActivation, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainDirectory.AddressAndTag>(171163638, new global::System.Object[]{@address, @singleActivation, @hopCount});
        }

        public global::System.Threading.Tasks.Task @UnregisterAsync(global::Orleans.Runtime.ActivationAddress @address, global::Orleans.GrainDirectory.UnregistrationCause @cause, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2089179563, new global::System.Object[]{@address, @cause, @hopCount});
        }

        public global::System.Threading.Tasks.Task @UnregisterManyAsync(global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress> @addresses, global::Orleans.GrainDirectory.UnregistrationCause @cause, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1470448647, new global::System.Object[]{@addresses, @cause, @hopCount});
        }

        public global::System.Threading.Tasks.Task @DeleteGrainAsync(global::Orleans.Runtime.GrainId @grainId, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1888800139, new global::System.Object[]{@grainId, @hopCount});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressesAndTag> @LookupAsync(global::Orleans.Runtime.GrainId @grainId, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainDirectory.AddressesAndTag>(-1272744289, new global::System.Object[]{@grainId, @hopCount});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IRemoteGrainDirectory), -185679256), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenRemoteGrainDirectoryMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -185679256:
                    switch (methodId)
                    {
                        case 1407273934:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@RegisterMany((global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)arguments[0], (global::System.Boolean)arguments[1]).@Box();
                        case 1942504603:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@LookUpMany((global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>>)arguments[0]).@Box();
                        case -2026920982:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@AcceptHandoffPartition((global::Orleans.Runtime.SiloAddress)arguments[0], (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IGrainInfo>)arguments[1], (global::System.Boolean)arguments[2]).@Box();
                        case 1987552759:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@RemoveHandoffPartition((global::Orleans.Runtime.SiloAddress)arguments[0]).@Box();
                        case 171163638:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@RegisterAsync((global::Orleans.Runtime.ActivationAddress)arguments[0], (global::System.Boolean)arguments[1], (global::System.Int32)arguments[2]).@Box();
                        case 2089179563:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@UnregisterAsync((global::Orleans.Runtime.ActivationAddress)arguments[0], (global::Orleans.GrainDirectory.UnregistrationCause)arguments[1], (global::System.Int32)arguments[2]).@Box();
                        case 1470448647:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@UnregisterManyAsync((global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)arguments[0], (global::Orleans.GrainDirectory.UnregistrationCause)arguments[1], (global::System.Int32)arguments[2]).@Box();
                        case -1888800139:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@DeleteGrainAsync((global::Orleans.Runtime.GrainId)arguments[0], (global::System.Int32)arguments[1]).@Box();
                        case -1272744289:
                            return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@LookupAsync((global::Orleans.Runtime.GrainId)arguments[0], (global::System.Int32)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -185679256 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -185679256;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IDeploymentLoadPublisher))]
    internal class OrleansCodeGenDeploymentLoadPublisherReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IDeploymentLoadPublisher
    {
        protected @OrleansCodeGenDeploymentLoadPublisherReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenDeploymentLoadPublisherReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -300889017;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IDeploymentLoadPublisher";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -300889017;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -300889017:
                    switch (@methodId)
                    {
                        case 1787332004:
                            return "UpdateRuntimeStatistics";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -300889017 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @UpdateRuntimeStatistics(global::Orleans.Runtime.SiloAddress @siloAddress, global::Orleans.Runtime.SiloRuntimeStatistics @siloStats)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1787332004, new global::System.Object[]{@siloAddress, @siloStats});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IDeploymentLoadPublisher), -300889017), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenDeploymentLoadPublisherMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -300889017:
                    switch (methodId)
                    {
                        case 1787332004:
                            return ((global::Orleans.Runtime.IDeploymentLoadPublisher)@grain).@UpdateRuntimeStatistics((global::Orleans.Runtime.SiloAddress)arguments[0], (global::Orleans.Runtime.SiloRuntimeStatistics)arguments[1]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -300889017 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -300889017;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IClientObserverRegistrar))]
    internal class OrleansCodeGenClientObserverRegistrarReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IClientObserverRegistrar
    {
        protected @OrleansCodeGenClientObserverRegistrarReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientObserverRegistrarReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -241055592;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IClientObserverRegistrar";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -241055592;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -241055592:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -241055592 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.Runtime.IClientObserverRegistrar), -241055592), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientObserverRegistrarMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -241055592:
                    switch (methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -241055592 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -241055592;
            }
        }
    }
}

namespace Orleans.MultiCluster
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant))]
    internal class OrleansCodeGenLogConsistencyProtocolParticipantReference : global::Orleans.Runtime.GrainReference, global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant
    {
        protected @OrleansCodeGenLogConsistencyProtocolParticipantReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenLogConsistencyProtocolParticipantReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -287197741;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -287197741;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -287197741:
                    switch (@methodId)
                    {
                        case -1525860629:
                            return "OnProtocolMessageReceived";
                        case 1901663931:
                            return "OnMultiClusterConfigurationChange";
                        case -1247892728:
                            return "PreActivateProtocolParticipant";
                        case -1886574590:
                            return "PostActivateProtocolParticipant";
                        case -1865234009:
                            return "DeactivateProtocolParticipant";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -287197741 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MultiCluster.ILogConsistencyProtocolMessage> @OnProtocolMessageReceived(global::Orleans.MultiCluster.ILogConsistencyProtocolMessage @payload)
        {
            return base.@InvokeMethodAsync<global::Orleans.MultiCluster.ILogConsistencyProtocolMessage>(-1525860629, new global::System.Object[]{@payload}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }

        public global::System.Threading.Tasks.Task @OnMultiClusterConfigurationChange(global::Orleans.MultiCluster.MultiClusterConfiguration @next)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1901663931, new global::System.Object[]{@next}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }

        public global::System.Threading.Tasks.Task @PreActivateProtocolParticipant()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1247892728, null);
        }

        public global::System.Threading.Tasks.Task @PostActivateProtocolParticipant()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1886574590, null);
        }

        public global::System.Threading.Tasks.Task @DeactivateProtocolParticipant()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1865234009, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.4.2.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant), -287197741), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenLogConsistencyProtocolParticipantMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                case -287197741:
                    switch (methodId)
                    {
                        case -1525860629:
                            return ((global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant)@grain).@OnProtocolMessageReceived((global::Orleans.MultiCluster.ILogConsistencyProtocolMessage)arguments[0]).@Box();
                        case 1901663931:
                            return ((global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant)@grain).@OnMultiClusterConfigurationChange((global::Orleans.MultiCluster.MultiClusterConfiguration)arguments[0]).@Box();
                        case -1247892728:
                            return ((global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant)@grain).@PreActivateProtocolParticipant().@Box();
                        case -1886574590:
                            return ((global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant)@grain).@PostActivateProtocolParticipant().@Box();
                        case -1865234009:
                            return ((global::Orleans.MultiCluster.ILogConsistencyProtocolParticipant)@grain).@DeactivateProtocolParticipant().@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -287197741 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -287197741;
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
