//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class ParameterInfo_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__ParameterInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.ParameterInfo), typeof(global::System.Reflection.ParameterInfo_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.ParameterInfo), typeof(global::System.Reflection.ParameterInfo_))]
    internal sealed partial class @__ParameterInfo : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__ParameterInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__ParameterInfo.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ParameterInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes0", "(Lsystem/Type;Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes1", "(Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "IsDefined", "IsDefined2", "(Lsystem/Type;Z)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeInfoCount", "GetTypeInfoCount3", "(Lnet/sf/jni4net/Out;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeInfo", "GetTypeInfo4", "(IIJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetIDsOfNames", "GetIDsOfNames5", "(Lnet/sf/jni4net/Ref;JIIJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke", "Invoke6", "(ILnet/sf/jni4net/Ref;ISJJJJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetRealObject", "GetRealObject7", "(Lsystem/runtime/serialization/StreamingContext;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getParameterType", "ParameterType8", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "Name9", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getHasDefaultValue", "HasDefaultValue10", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDefaultValue", "DefaultValue11", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRawDefaultValue", "RawDefaultValue12", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getPosition", "Position13", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAttributes", "Attributes14", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMember", "Member15", "()Lsystem/reflection/MemberInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isIn", "IsIn16", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isOut", "IsOut17", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isLcid", "IsLcid18", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isRetval", "IsRetval19", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isOptional", "IsOptional20", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetadataToken", "MetadataToken21", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetRequiredCustomModifiers", "GetRequiredCustomModifiers22", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetOptionalCustomModifiers", "GetOptionalCustomModifiers23", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCustomAttributes", "CustomAttributes24", "()Lsystem/collections/IEnumerable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributesData", "GetCustomAttributesData25", "()Lsystem/collections/IList;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCustomAttributes0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle attributeType, bool inherit) {
            // (Lsystem/Type;Z)[Lsystem/Object;
            // (LSystem/Type;Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCustomAttributes1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool inherit) {
            // (Z)[Lsystem/Object;
            // (Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(inherit));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsDefined2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle attributeType, bool inherit) {
            // (Lsystem/Type;Z)Z
            // (LSystem/Type;Z)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((bool)(((global::System.Reflection.ICustomAttributeProvider)(@__real)).IsDefined(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void GetTypeInfoCount3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle pcTInfo) {
            // (Lnet/sf/jni4net/Out;)V
            // (LSystem/UInt32;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            uint @__out_pcTInfo;
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._ParameterInfo)(@__real)).GetTypeInfoCount(out __out_pcTInfo);
            net.sf.jni4net.Out.SetValue<uint>(@__env, pcTInfo, @__out_pcTInfo);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void GetTypeInfo4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, uint iTInfo, uint lcid, global::System.IntPtr ppTInfo) {
            // (IIJ)V
            // (LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._ParameterInfo)(@__real)).GetTypeInfo(iTInfo, lcid, ppTInfo);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void GetIDsOfNames5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle riid, global::System.IntPtr rgszNames, uint cNames, uint lcid, global::System.IntPtr rgDispId) {
            // (Lnet/sf/jni4net/Ref;JIIJ)V
            // (LSystem/Guid;LSystem/IntPtr;LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__ref_riid = net.sf.jni4net.Ref.GetValue<global::System.Guid>(@__env, riid);
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._ParameterInfo)(@__real)).GetIDsOfNames(ref __ref_riid, rgszNames, cNames, lcid, rgDispId);
            net.sf.jni4net.Ref.SetValue<global::System.Guid>(@__env, riid, @__ref_riid);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Invoke6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, uint dispIdMember, global::net.sf.jni4net.utils.JniLocalHandle riid, uint lcid, short wFlags, global::System.IntPtr pDispParams, global::System.IntPtr pVarResult, global::System.IntPtr pExcepInfo, global::System.IntPtr puArgErr) {
            // (ILnet/sf/jni4net/Ref;ISJJJJ)V
            // (LSystem/UInt32;LSystem/Guid;LSystem/UInt32;SLSystem/IntPtr;LSystem/IntPtr;LSystem/IntPtr;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__ref_riid = net.sf.jni4net.Ref.GetValue<global::System.Guid>(@__env, riid);
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._ParameterInfo)(@__real)).Invoke(dispIdMember, ref __ref_riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            net.sf.jni4net.Ref.SetValue<global::System.Guid>(@__env, riid, @__ref_riid);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetRealObject7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle context) {
            // (Lsystem/runtime/serialization/StreamingContext;)Lsystem/Object;
            // (LSystem/Runtime/Serialization/StreamingContext;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, ((global::System.Runtime.Serialization.IObjectReference)(@__real)).GetRealObject(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Runtime.Serialization.StreamingContext>(@__env, context)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ParameterType8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Type>(@__env, @__real.ParameterType);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Name9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.Name);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool HasDefaultValue10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((bool)(@__real.HasDefaultValue));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle DefaultValue11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.DefaultValue);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle RawDefaultValue12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.RawDefaultValue);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int Position13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((int)(@__real.Position));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Attributes14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/ParameterAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.ParameterAttributes>(@__env, @__real.Attributes);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Member15(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/reflection/MemberInfo;
            // ()LSystem/Reflection/MemberInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MemberInfo>(@__env, @__real.Member);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsIn16(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((bool)(@__real.IsIn));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsOut17(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((bool)(@__real.IsOut));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsLcid18(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((bool)(@__real.IsLcid));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsRetval19(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((bool)(@__real.IsRetval));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsOptional20(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((bool)(@__real.IsOptional));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int MetadataToken21(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = ((int)(@__real.MetadataToken));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetRequiredCustomModifiers22(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<global::System.Type[], global::System.Type>(@__env, @__real.GetRequiredCustomModifiers());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetOptionalCustomModifiers23(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<global::System.Type[], global::System.Type>(@__env, @__real.GetOptionalCustomModifiers());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CustomAttributes24(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/collections/IEnumerable;
            // ()[[LSystem/Collections/Generic/IEnumerable`1;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>>(@__env, @__real.CustomAttributes);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCustomAttributesData25(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/collections/IList;
            // ()[[LSystem/Collections/Generic/IList`1;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>(@__env, @__real.GetCustomAttributesData());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__ParameterInfo(@__env);
            }
        }
    }
    #endregion
}
