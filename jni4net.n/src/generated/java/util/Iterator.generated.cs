//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute("java.util.Iterator")]
    public partial interface Iterator {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void remove();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool hasNext();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        global::java.lang.Object next();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/function/Consumer;)V")]
        void forEachRemaining(global::java.lang.Object arg0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Iterator_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::java.util.@__Iterator.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.util.Iterator), typeof(global::java.util.Iterator_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.util.Iterator), typeof(global::java.util.Iterator_))]
    internal sealed partial class @__Iterator : global::java.lang.Object, global::java.util.Iterator {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_remove0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_hasNext1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_next2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_forEachRemaining3;
        
        private @__Iterator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.@__Iterator.staticClass = @__class;
            global::java.util.@__Iterator.j4n_remove0 = @__env.GetMethodID(global::java.util.@__Iterator.staticClass, "remove", "()V");
            global::java.util.@__Iterator.j4n_hasNext1 = @__env.GetMethodID(global::java.util.@__Iterator.staticClass, "hasNext", "()Z");
            global::java.util.@__Iterator.j4n_next2 = @__env.GetMethodID(global::java.util.@__Iterator.staticClass, "next", "()Ljava/lang/Object;");
            global::java.util.@__Iterator.j4n_forEachRemaining3 = @__env.GetMethodID(global::java.util.@__Iterator.staticClass, "forEachRemaining", "(Ljava/util/function/Consumer;)V");
        }
        
        public void remove() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::java.util.@__Iterator.j4n_remove0);
            }
        }
        
        public bool hasNext() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Iterator.j4n_hasNext1)));
            }
        }
        
        public global::java.lang.Object next() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Iterator.j4n_next2));
            }
        }
        
        public void forEachRemaining(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.@__Iterator.j4n_forEachRemaining3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Iterator);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "remove", "remove0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "hasNext", "hasNext1", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "next", "next2", "()Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "forEachRemaining", "forEachRemaining3", "(Ljava/util/function/Consumer;)V"));
            return methods;
        }
        
        private static void remove0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Iterator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Iterator>(@__env, @__obj);
            @__real.remove();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool hasNext1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::java.util.Iterator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Iterator>(@__env, @__obj);
            @__return = ((bool)(@__real.hasNext()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle next2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/Object;
            // ()Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::java.util.Iterator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Iterator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.next());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void forEachRemaining3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle arg0) {
            // (Ljava/util/function/Consumer;)V
            // (Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Iterator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Iterator>(@__env, @__obj);
            @__real.forEachRemaining(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, arg0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.@__Iterator(@__env);
            }
        }
    }
    #endregion
}
