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
    public partial class MemberInfo_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__MemberInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.MemberInfo), typeof(global::System.Reflection.MemberInfo_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.MemberInfo), typeof(global::System.Reflection.MemberInfo_))]
    internal sealed partial class @__MemberInfo : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__MemberInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__MemberInfo.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__MemberInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes0", "(Lsystem/Type;Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes1", "(Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "IsDefined", "IsDefined2", "(Lsystem/Type;Z)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeInfoCount", "GetTypeInfoCount3", "(Lnet/sf/jni4net/Out;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeInfo", "GetTypeInfo4", "(IIJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetIDsOfNames", "GetIDsOfNames5", "(Lnet/sf/jni4net/Ref;JIIJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke", "Invoke6", "(ILnet/sf/jni4net/Ref;ISJJJJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMemberType", "MemberType7", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "Name8", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDeclaringType", "DeclaringType9", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReflectedType", "ReflectedType10", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCustomAttributes", "CustomAttributes11", "()Lsystem/collections/IEnumerable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributesData", "GetCustomAttributesData12", "()Lsystem/collections/IList;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetadataToken", "MetadataToken13", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getModule", "Module14", "()Lsystem/Object;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCustomAttributes0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle attributeType, bool inherit) {
            // (Lsystem/Type;Z)[Lsystem/Object;
            // (LSystem/Type;Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
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
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
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
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
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
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).GetTypeInfoCount(out __out_pcTInfo);
            net.sf.jni4net.Out.SetValue<uint>(@__env, pcTInfo, @__out_pcTInfo);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void GetTypeInfo4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, uint iTInfo, uint lcid, global::System.IntPtr ppTInfo) {
            // (IIJ)V
            // (LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).GetTypeInfo(iTInfo, lcid, ppTInfo);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void GetIDsOfNames5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle riid, global::System.IntPtr rgszNames, uint cNames, uint lcid, global::System.IntPtr rgDispId) {
            // (Lnet/sf/jni4net/Ref;JIIJ)V
            // (LSystem/Guid;LSystem/IntPtr;LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__ref_riid = net.sf.jni4net.Ref.GetValue<global::System.Guid>(@__env, riid);
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).GetIDsOfNames(ref __ref_riid, rgszNames, cNames, lcid, rgDispId);
            net.sf.jni4net.Ref.SetValue<global::System.Guid>(@__env, riid, @__ref_riid);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Invoke6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, uint dispIdMember, global::net.sf.jni4net.utils.JniLocalHandle riid, uint lcid, short wFlags, global::System.IntPtr pDispParams, global::System.IntPtr pVarResult, global::System.IntPtr pExcepInfo, global::System.IntPtr puArgErr) {
            // (ILnet/sf/jni4net/Ref;ISJJJJ)V
            // (LSystem/UInt32;LSystem/Guid;LSystem/UInt32;SLSystem/IntPtr;LSystem/IntPtr;LSystem/IntPtr;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__ref_riid = net.sf.jni4net.Ref.GetValue<global::System.Guid>(@__env, riid);
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).Invoke(dispIdMember, ref __ref_riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            net.sf.jni4net.Ref.SetValue<global::System.Guid>(@__env, riid, @__ref_riid);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle MemberType7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/MemberTypes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MemberTypes>(@__env, ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).MemberType);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Name8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).Name);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle DeclaringType9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Type>(@__env, ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).DeclaringType);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ReflectedType10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Type>(@__env, ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).ReflectedType);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CustomAttributes11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/collections/IEnumerable;
            // ()[[LSystem/Collections/Generic/IEnumerable`1;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>>(@__env, @__real.CustomAttributes);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCustomAttributesData12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/collections/IList;
            // ()[[LSystem/Collections/Generic/IList`1;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>(@__env, @__real.GetCustomAttributesData());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int MetadataToken13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = ((int)(@__real.MetadataToken));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Module14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Reflection/Module;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.Module>(@__env, @__real.Module);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__MemberInfo(@__env);
            }
        }
    }
    #endregion
}
