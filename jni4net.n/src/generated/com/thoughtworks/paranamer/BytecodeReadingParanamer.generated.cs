//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.thoughtworks.paranamer
{


    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class BytecodeReadingParanamer : global::java.lang.Object
    {

        internal new static global::java.lang.Class staticClass;

        internal static global::net.sf.jni4net.jni.MethodId j4n_lookupParameterNames0;

        internal static global::net.sf.jni4net.jni.MethodId j4n_lookupParameterNames1;

        internal static global::net.sf.jni4net.jni.MethodId j4n_getParameterNames2;

        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorBytecodeReadingParanamer3;

        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public BytecodeReadingParanamer() :
                base(((global::net.sf.jni4net.jni.JNIEnv)(null)))
        {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using (new global::net.sf.jni4net.jni.LocalFrame(@__env, 10))
            {
                @__env.NewObject(global::com.thoughtworks.paranamer.BytecodeReadingParanamer.staticClass, global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n__ctorBytecodeReadingParanamer3, this);
            }
        }

        protected BytecodeReadingParanamer(global::net.sf.jni4net.jni.JNIEnv @__env) :
                base(@__env)
        {
        }

        public new static global::java.lang.Class _class
        {
            get
            {
                return global::com.thoughtworks.paranamer.BytecodeReadingParanamer.staticClass;
            }
        }

        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
        {
            global::com.thoughtworks.paranamer.BytecodeReadingParanamer.staticClass = @__class;
            global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n_lookupParameterNames0 = @__env.GetMethodID(global::com.thoughtworks.paranamer.BytecodeReadingParanamer.staticClass, "lookupParameterNames", "(Ljava/lang/reflect/AccessibleObject;)[Ljava/lang/String;");
            global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n_lookupParameterNames1 = @__env.GetMethodID(global::com.thoughtworks.paranamer.BytecodeReadingParanamer.staticClass, "lookupParameterNames", "(Ljava/lang/reflect/AccessibleObject;Z)[Ljava/lang/String;");
            global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n_getParameterNames2 = @__env.GetMethodID(global::com.thoughtworks.paranamer.BytecodeReadingParanamer.staticClass, "getParameterNames", "(Ljava/lang/reflect/Method;)[Ljava/lang/String;");
            global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n__ctorBytecodeReadingParanamer3 = @__env.GetMethodID(global::com.thoughtworks.paranamer.BytecodeReadingParanamer.staticClass, "<init>", "()V");
        }

        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/reflect/AccessibleObject;)[Ljava/lang/String;")]
        public virtual global::java.lang.String[] lookupParameterNames(global::java.lang.reflect.AccessibleObject methodOrConstructor)
        {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using (new global::net.sf.jni4net.jni.LocalFrame(@__env, 12))
            {
                return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n_lookupParameterNames0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(methodOrConstructor)));
            }
        }

        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/reflect/AccessibleObject;Z)[Ljava/lang/String;")]
        public virtual global::java.lang.String[] lookupParameterNames(global::java.lang.reflect.AccessibleObject methodOrCtor, bool throwExceptionIfMissing)
        {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using (new global::net.sf.jni4net.jni.LocalFrame(@__env, 14))
            {
                return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n_lookupParameterNames1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(methodOrCtor), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(throwExceptionIfMissing)));
            }
        }

        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/reflect/Method;)[Ljava/lang/String;")]
        public virtual global::java.lang.String[] getParameterNames(global::java.lang.reflect.Method method)
        {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using (new global::net.sf.jni4net.jni.LocalFrame(@__env, 12))
            {
                return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.thoughtworks.paranamer.BytecodeReadingParanamer.j4n_getParameterNames2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(method)));
            }
        }

        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
        {

            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
            {
                return new global::com.thoughtworks.paranamer.BytecodeReadingParanamer(@__env);
            }
        }
    }
    #endregion
}
