//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Security {
    
    
    #region Component Designer generated code 
    public partial class IEvidenceFactory_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.Security.@__IEvidenceFactory.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Security.IEvidenceFactory), typeof(global::System.Security.IEvidenceFactory_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Security.IEvidenceFactory), typeof(global::System.Security.IEvidenceFactory_))]
    internal sealed partial class @__IEvidenceFactory : global::java.lang.Object, global::System.Security.IEvidenceFactory {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_Evidence0;
        
        private @__IEvidenceFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public global::System.Security.Policy.Evidence Evidence {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Security.Policy.Evidence>(@__env, @__env.CallObjectMethodPtr(this, global::System.Security.@__IEvidenceFactory.j4n_Evidence0));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Security.@__IEvidenceFactory.staticClass = @__class;
            global::System.Security.@__IEvidenceFactory.j4n_Evidence0 = @__env.GetMethodID(global::System.Security.@__IEvidenceFactory.staticClass, "getEvidence", "()Lsystem/Object;");
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IEvidenceFactory);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getEvidence", "Evidence0", "()Lsystem/Object;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Evidence0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Security/Policy/Evidence;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Security.IEvidenceFactory @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Security.IEvidenceFactory>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Security.Policy.Evidence>(@__env, @__real.Evidence);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Security.@__IEvidenceFactory(@__env);
            }
        }
    }
    #endregion
}
