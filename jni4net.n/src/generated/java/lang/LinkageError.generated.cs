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
    [global::net.sf.jni4net.attributes.JavaClassAttribute("java.lang.LinkageError")]
    [global::System.SerializableAttribute()]
    public partial class LinkageError : global::java.lang.Error {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorLinkageError0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorLinkageError1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorLinkageError2;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public LinkageError() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.lang.LinkageError.staticClass, global::java.lang.LinkageError.j4n__ctorLinkageError0, this);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public LinkageError(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.LinkageError.staticClass, global::java.lang.LinkageError.j4n__ctorLinkageError1, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public LinkageError(global::java.lang.String par0, global::java.lang.Throwable par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::java.lang.LinkageError.staticClass, global::java.lang.LinkageError.j4n__ctorLinkageError2, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
            }
        }
        
        protected LinkageError(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected LinkageError(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.LinkageError.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.LinkageError.staticClass = @__class;
            global::java.lang.LinkageError.j4n__ctorLinkageError0 = @__env.GetMethodID(global::java.lang.LinkageError.staticClass, "<init>", "()V");
            global::java.lang.LinkageError.j4n__ctorLinkageError1 = @__env.GetMethodID(global::java.lang.LinkageError.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.LinkageError.j4n__ctorLinkageError2 = @__env.GetMethodID(global::java.lang.LinkageError.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.LinkageError(@__env);
            }
        }
    }
    #endregion
}
