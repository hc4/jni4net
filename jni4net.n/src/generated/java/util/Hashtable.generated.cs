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
    [global::net.sf.jni4net.attributes.JavaClassAttribute("java.util.Hashtable")]
    public partial class Hashtable : global::java.util.Dictionary, global::java.util.Map, global::java.lang.Cloneable, global::java.io.Serializable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_remove0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_values1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_clear2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_replace3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_replace4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_replaceAll5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_entrySet6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_putAll7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_putIfAbsent8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_forEach9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_keySet10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compute11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_computeIfAbsent12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_computeIfPresent13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_containsKey14;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_containsValue15;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getOrDefault16;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_merge17;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_contains18;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorHashtable19;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorHashtable20;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorHashtable21;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorHashtable22;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;)V")]
        public Hashtable(global::java.util.Map par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.j4n__ctorHashtable19, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Hashtable() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.j4n__ctorHashtable20, this);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public Hashtable(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.j4n__ctorHashtable21, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IF)V")]
        public Hashtable(int par0, float par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.j4n__ctorHashtable22, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        protected Hashtable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.Hashtable.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.Hashtable.staticClass = @__class;
            global::java.util.Hashtable.j4n_remove0 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
            global::java.util.Hashtable.j4n_values1 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;");
            global::java.util.Hashtable.j4n_clear2 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "clear", "()V");
            global::java.util.Hashtable.j4n_replace3 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Hashtable.j4n_replace4 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
            global::java.util.Hashtable.j4n_replaceAll5 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "replaceAll", "(Ljava/util/function/BiFunction;)V");
            global::java.util.Hashtable.j4n_entrySet6 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;");
            global::java.util.Hashtable.j4n_putAll7 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V");
            global::java.util.Hashtable.j4n_putIfAbsent8 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Hashtable.j4n_forEach9 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "forEach", "(Ljava/util/function/BiConsumer;)V");
            global::java.util.Hashtable.j4n_keySet10 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;");
            global::java.util.Hashtable.j4n_compute11 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "compute", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
            global::java.util.Hashtable.j4n_computeIfAbsent12 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "computeIfAbsent", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;");
            global::java.util.Hashtable.j4n_computeIfPresent13 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "computeIfPresent", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
            global::java.util.Hashtable.j4n_containsKey14 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable.j4n_containsValue15 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable.j4n_getOrDefault16 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Hashtable.j4n_merge17 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "merge", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/O" +
                    "bject;");
            global::java.util.Hashtable.j4n_contains18 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable.j4n__ctorHashtable19 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
            global::java.util.Hashtable.j4n__ctorHashtable20 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "()V");
            global::java.util.Hashtable.j4n__ctorHashtable21 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
            global::java.util.Hashtable.j4n__ctorHashtable22 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
        public virtual bool remove(global::java.lang.Object arg0, global::java.lang.Object arg1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable.j4n_remove0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        public virtual global::java.util.Collection values() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_values1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void clear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::java.util.Hashtable.j4n_clear2);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object replace(global::java.lang.Object arg0, global::java.lang.Object arg1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_replace3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z")]
        public virtual bool replace(global::java.lang.Object arg0, global::java.lang.Object arg1, global::java.lang.Object arg2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable.j4n_replace4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg2))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/function/BiFunction;)V")]
        public virtual void replaceAll(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Hashtable.j4n_replaceAll5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        public virtual global::java.util.Set entrySet() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_entrySet6));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;)V")]
        public virtual void putAll(global::java.util.Map arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Hashtable.j4n_putAll7, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, arg0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object putIfAbsent(global::java.lang.Object arg0, global::java.lang.Object arg1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_putIfAbsent8, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/function/BiConsumer;)V")]
        public virtual void forEach(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Hashtable.j4n_forEach9, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        public virtual global::java.util.Set keySet() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_keySet10));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object compute(global::java.lang.Object arg0, global::java.lang.Object arg1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_compute11, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object computeIfAbsent(global::java.lang.Object arg0, global::java.lang.Object arg1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_computeIfAbsent12, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object computeIfPresent(global::java.lang.Object arg0, global::java.lang.Object arg1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_computeIfPresent13, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool containsKey(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable.j4n_containsKey14, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool containsValue(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable.j4n_containsValue15, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object getOrDefault(global::java.lang.Object arg0, global::java.lang.Object arg1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_getOrDefault16, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/O" +
            "bject;")]
        public virtual global::java.lang.Object merge(global::java.lang.Object arg0, global::java.lang.Object arg1, global::java.lang.Object arg2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable.j4n_merge17, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool contains(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable.j4n_contains18, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.Hashtable(@__env);
            }
        }
    }
    #endregion
}
