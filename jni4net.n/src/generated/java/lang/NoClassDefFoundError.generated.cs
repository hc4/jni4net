//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute("java.lang.NoClassDefFoundError")]
    [global::System.SerializableAttribute()]
    public partial class NoClassDefFoundError : global::java.lang.LinkageError {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorNoClassDefFoundError0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorNoClassDefFoundError1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public NoClassDefFoundError() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError.j4n__ctorNoClassDefFoundError0, this);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public NoClassDefFoundError(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError.j4n__ctorNoClassDefFoundError1, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        protected NoClassDefFoundError(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected NoClassDefFoundError(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.NoClassDefFoundError.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.NoClassDefFoundError.staticClass = @__class;
            global::java.lang.NoClassDefFoundError.j4n__ctorNoClassDefFoundError0 = @__env.GetMethodID(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "()V");
            global::java.lang.NoClassDefFoundError.j4n__ctorNoClassDefFoundError1 = @__env.GetMethodID(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.NoClassDefFoundError(@__env);
            }
        }
    }
    #endregion
}
