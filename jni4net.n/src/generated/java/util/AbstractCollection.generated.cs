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
    [global::net.sf.jni4net.attributes.JavaClassAttribute("java.util.AbstractCollection")]
    public partial class AbstractCollection : global::java.lang.Object, global::java.util.Collection, global::java.lang.Iterable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_add0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_remove1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_clear2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_contains3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isEmpty4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_iterator5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_size6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toArray7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toArray8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_spliterator9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_addAll10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_stream11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_containsAll12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_removeAll13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_removeIf14;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_retainAll15;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_parallelStream16;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_forEach17;
        
        protected AbstractCollection(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.AbstractCollection.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.AbstractCollection.staticClass = @__class;
            global::java.util.AbstractCollection.j4n_add0 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z");
            global::java.util.AbstractCollection.j4n_remove1 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z");
            global::java.util.AbstractCollection.j4n_clear2 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "clear", "()V");
            global::java.util.AbstractCollection.j4n_contains3 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z");
            global::java.util.AbstractCollection.j4n_isEmpty4 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z");
            global::java.util.AbstractCollection.j4n_iterator5 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;");
            global::java.util.AbstractCollection.j4n_size6 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "size", "()I");
            global::java.util.AbstractCollection.j4n_toArray7 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
            global::java.util.AbstractCollection.j4n_toArray8 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;");
            global::java.util.AbstractCollection.j4n_spliterator9 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "spliterator", "()Ljava/util/Spliterator;");
            global::java.util.AbstractCollection.j4n_addAll10 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z");
            global::java.util.AbstractCollection.j4n_stream11 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "stream", "()Ljava/util/stream/Stream;");
            global::java.util.AbstractCollection.j4n_containsAll12 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
            global::java.util.AbstractCollection.j4n_removeAll13 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
            global::java.util.AbstractCollection.j4n_removeIf14 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "removeIf", "(Ljava/util/function/Predicate;)Z");
            global::java.util.AbstractCollection.j4n_retainAll15 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
            global::java.util.AbstractCollection.j4n_parallelStream16 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "parallelStream", "()Ljava/util/stream/Stream;");
            global::java.util.AbstractCollection.j4n_forEach17 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "forEach", "(Ljava/util/function/Consumer;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool add(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_add0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool remove(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_remove1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void clear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::java.util.AbstractCollection.j4n_clear2);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool contains(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_contains3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isEmpty() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_isEmpty4)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Iterator;")]
        public virtual global::java.util.Iterator iterator() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection.j4n_iterator5));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int size() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.AbstractCollection.j4n_size6)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;")]
        public virtual global::java.lang.Object[] toArray(global::java.lang.Object[] arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.Object[], global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection.j4n_toArray7, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<global::java.lang.Object[], global::java.lang.Object>(@__env, arg0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Object;")]
        public virtual global::java.lang.Object[] toArray() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.Object[], global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection.j4n_toArray8));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Spliterator;")]
        public virtual global::java.lang.Object spliterator() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection.j4n_spliterator9));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        public virtual bool addAll(global::java.util.Collection arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_addAll10, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/stream/Stream;")]
        public virtual global::java.lang.Object stream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection.j4n_stream11));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        public virtual bool containsAll(global::java.util.Collection arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_containsAll12, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        public virtual bool removeAll(global::java.util.Collection arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_removeAll13, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/function/Predicate;)Z")]
        public virtual bool removeIf(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_removeIf14, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        public virtual bool retainAll(global::java.util.Collection arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.AbstractCollection.j4n_retainAll15, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, arg0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/stream/Stream;")]
        public virtual global::java.lang.Object parallelStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection.j4n_parallelStream16));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/function/Consumer;)V")]
        public virtual void forEach(global::java.lang.Object arg0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.AbstractCollection.j4n_forEach17, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, arg0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.AbstractCollection(@__env);
            }
        }
    }
    #endregion
}