using System;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public readonly struct ClassKey : IEquatable<ClassKey>
    {
        private readonly Class cls;

        private ClassKey(Class cls)
        {
            this.cls = cls;
        }

        public static implicit operator ClassKey(Class cls)
        {
            return new ClassKey(cls);
        }

        public override int GetHashCode()
        {
            return cls.GetHashCode();
        }

        public bool Equals(ClassKey other)
        {
            var env = JNIEnv.GetEnvForVm(cls.jvmHandle.javaVM);
            using (new LocalFrame(env, 12))
            {
                return env.CallBooleanMethod(cls, java.lang.Object.j4n_equals3, new Value{_object=other.cls.jvmHandle});
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is ClassKey key)
            {
                return Equals(key);
            }

            return false;
        }
    }
}