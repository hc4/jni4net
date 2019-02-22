using System;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.lang
{
    public abstract class JavaObjectBase : IJvmHandle
    {
        internal JniGlobalHandle jvmHandle;

        JniGlobalHandle IJvmHandle.JvmHandle => jvmHandle;

        protected JNIEnv Env => JNIEnv.GetEnvForVm(jvmHandle.JavaVM);

        #region Reference handling

        #region IJvmProxy Members
        
        void IJvmHandle.Init(JNIEnv env, JniLocalHandle obj)
        {
            jvmHandle.CheckNotInitialized();
            jvmHandle = env.NewGlobalRef(obj);
            env.DeleteLocalRef(obj);
        }

        void IJvmHandle.Copy(JNIEnv env, JniGlobalHandle obj)
        {
            jvmHandle.CheckNotInitialized();
            jvmHandle = env.NewGlobalRef(obj);
        }

        #endregion

        #endregion

        void IJvmHandle.Release()
        {
            if (jvmHandle.Release())
            {
                GC.SuppressFinalize(this);
            }
        }

        ~JavaObjectBase()
        {
            jvmHandle.Release();
        }
    }
}