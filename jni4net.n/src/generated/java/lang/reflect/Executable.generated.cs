//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute("java.lang.reflect.Executable")]
    public partial class Executable : global::java.lang.reflect.AccessibleObject, global::java.lang.reflect.Member, global::java.lang.reflect.GenericDeclaration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getModifiers0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getName1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getDeclaringClass2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isSynthetic3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTypeParameters4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getParameterTypes5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toGenericString6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getAnnotatedParameterTypes7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getParameterAnnotations8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getParameterCount9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isVarArgs10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getAnnotatedReturnType11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getExceptionTypes12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getGenericExceptionTypes13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getGenericParameterTypes14;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getAnnotatedExceptionTypes15;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getAnnotatedReceiverType16;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getParameters17;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_PUBLIC18;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_DECLARED19;
        
        protected Executable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Executable.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Executable.staticClass, global::java.lang.reflect.Executable.j4n_PUBLIC18)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DECLARED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Executable.staticClass, global::java.lang.reflect.Executable.j4n_DECLARED19)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.Executable.staticClass = @__class;
            global::java.lang.reflect.Executable.j4n_getModifiers0 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getModifiers", "()I");
            global::java.lang.reflect.Executable.j4n_getName1 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.Executable.j4n_getDeclaringClass2 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
            global::java.lang.reflect.Executable.j4n_isSynthetic3 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "isSynthetic", "()Z");
            global::java.lang.reflect.Executable.j4n_getTypeParameters4 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
            global::java.lang.reflect.Executable.j4n_getParameterTypes5 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Executable.j4n_toGenericString6 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "toGenericString", "()Ljava/lang/String;");
            global::java.lang.reflect.Executable.j4n_getAnnotatedParameterTypes7 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getAnnotatedParameterTypes", "()[Ljava/lang/reflect/AnnotatedType;");
            global::java.lang.reflect.Executable.j4n_getParameterAnnotations8 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.Executable.j4n_getParameterCount9 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getParameterCount", "()I");
            global::java.lang.reflect.Executable.j4n_isVarArgs10 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "isVarArgs", "()Z");
            global::java.lang.reflect.Executable.j4n_getAnnotatedReturnType11 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getAnnotatedReturnType", "()Ljava/lang/reflect/AnnotatedType;");
            global::java.lang.reflect.Executable.j4n_getExceptionTypes12 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Executable.j4n_getGenericExceptionTypes13 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Executable.j4n_getGenericParameterTypes14 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Executable.j4n_getAnnotatedExceptionTypes15 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getAnnotatedExceptionTypes", "()[Ljava/lang/reflect/AnnotatedType;");
            global::java.lang.reflect.Executable.j4n_getAnnotatedReceiverType16 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getAnnotatedReceiverType", "()Ljava/lang/reflect/AnnotatedType;");
            global::java.lang.reflect.Executable.j4n_getParameters17 = @__env.GetMethodID(global::java.lang.reflect.Executable.staticClass, "getParameters", "()[Ljava/lang/reflect/Parameter;");
            global::java.lang.reflect.Executable.j4n_PUBLIC18 = @__env.GetStaticFieldID(global::java.lang.reflect.Executable.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Executable.j4n_DECLARED19 = @__env.GetStaticFieldID(global::java.lang.reflect.Executable.staticClass, "DECLARED", "I");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getModifiers() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.reflect.Executable.j4n_getModifiers0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getName1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getDeclaringClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getDeclaringClass2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isSynthetic() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Executable.j4n_isSynthetic3)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/TypeVariable;")]
        public virtual global::java.lang.reflect.TypeVariable[] getTypeParameters() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.reflect.TypeVariable[], global::java.lang.reflect.TypeVariable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getTypeParameters4));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual global::java.lang.Class[] getParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getParameterTypes5));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toGenericString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_toGenericString6));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/AnnotatedType;")]
        public virtual global::java.lang.reflect.AnnotatedElement[] getAnnotatedParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.reflect.AnnotatedElement[], global::java.lang.reflect.AnnotatedElement>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getAnnotatedParameterTypes7));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[[Ljava/lang/annotation/Annotation;")]
        public virtual global::java.lang.annotation.Annotation[][] getParameterAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJp2C<global::java.lang.annotation.Annotation[][], global::java.lang.annotation.Annotation[]>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getParameterAnnotations8));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getParameterCount() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.reflect.Executable.j4n_getParameterCount9)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isVarArgs() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Executable.j4n_isVarArgs10)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/AnnotatedType;")]
        public virtual global::java.lang.reflect.AnnotatedElement getAnnotatedReturnType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.AnnotatedElement>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getAnnotatedReturnType11));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual global::java.lang.Class[] getExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getExceptionTypes12));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual global::java.lang.reflect.Type[] getGenericExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getGenericExceptionTypes13));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual global::java.lang.reflect.Type[] getGenericParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getGenericParameterTypes14));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/AnnotatedType;")]
        public virtual global::java.lang.reflect.AnnotatedElement[] getAnnotatedExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.reflect.AnnotatedElement[], global::java.lang.reflect.AnnotatedElement>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getAnnotatedExceptionTypes15));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/AnnotatedType;")]
        public virtual global::java.lang.reflect.AnnotatedElement getAnnotatedReceiverType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.AnnotatedElement>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getAnnotatedReceiverType16));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Parameter;")]
        public virtual global::java.lang.reflect.Parameter[] getParameters() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<global::java.lang.reflect.Parameter[], global::java.lang.reflect.Parameter>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Executable.j4n_getParameters17));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.Executable(@__env);
            }
        }
    }
    #endregion
}