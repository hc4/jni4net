#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using java.io;
using net.sf.jni4net;
using net.sf.jni4net.adaptors;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.lang
{
    [Serializable]
    partial class Throwable : global::System.Exception, IJvmProxy
    {
        internal JniGlobalHandle jvmHandle;

        protected Throwable(SerializationInfo info, StreamingContext context)
        {
            byte[] data = (byte[])info.GetValue("exception", typeof(byte[]));
            using (var bai = Adapt.Disposable(new ByteArrayInputStream(data)))
            {
                using (var ois = Adapt.Disposable(new ObjectInputStream(bai.Real)))
                {
                    Object exception = ois.Real.readObject();
                    ((IJvmProxy)this).Copy(JNIEnv.ThreadEnv, exception.jvmHandle);
                }
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            using (var bao = Adapt.Disposable(new ByteArrayOutputStream()))
            {
                using (var oos = Adapt.Disposable(new ObjectOutputStream(bao.Real)))
                {
                    oos.Real.writeObject(Bridge.Cast<Object>(this));
                    byte[] data = bao.Real.toByteArray();
                    info.AddValue("exception", data);
                }
            }
        }

        protected internal Throwable(JNIEnv env)
        {
        }

        protected JNIEnv Env
        {
            get { return JNIEnv.GetEnvForVm(jvmHandle.JavaVM); }
        }

#if !JNI4NET_MINI
        public string JavaStackTrace
        {
            get
            {
                var sb = new global::System.Text.StringBuilder();
                StackTraceElement[] objects = getStackTrace();
                foreach (StackTraceElement element in objects)
                {
                    sb.Append("   at ");
                    sb.Append(element.getClassName());
                    sb.Append('.');
                    sb.Append(element.getMethodName());
                    sb.Append("()");

                    var file = element.getFileName();
                    if (file != default(String))
                    {
                        sb.Append(" in ");
                        sb.Append(file);

                        var line = element.getLineNumber();
                        if (line >= 0)
                        {
                            sb.Append(':');
                            sb.Append(line);
                        }
                    }

                    sb.Append(Environment.NewLine);
                }
                return sb.ToString();
            }
        }
#else
        //TODO
#endif

        public override string StackTrace
            => JavaStackTrace + "--- End of Java stack trace ---" + Environment.NewLine + base.StackTrace;

        public override string Message => getMessage();

        #region IJvmProxy Members

        JniGlobalHandle IJvmProxy.JvmHandle => jvmHandle;

        void IJvmProxy.Init(JNIEnv env, JniLocalHandle obj)
        {
            jvmHandle.CheckNotInitialized();
            jvmHandle = env.NewGlobalRef(obj);
            env.DeleteLocalRef(obj);
        }

        void IJvmProxy.Copy(JNIEnv env, JniGlobalHandle obj)
        {
            jvmHandle.CheckNotInitialized();
            jvmHandle = env.NewGlobalRef(obj);
        }

        void IJvmProxy.Release()
        {
            if (jvmHandle.Release())
            {
                GC.SuppressFinalize(this);
            }
        }

        ~Throwable()
        {
            jvmHandle.Release();
        }

        #endregion

        public void Invoke(string method, string signature, params object[] args)
        {
            Env.CallVoidMethod(this, method, signature, args);
        }

        public TRes Invoke<TRes>(string method, string signature, params object[] args)
        {
            return Env.CallMethod<TRes>(this, method, signature, args);
        }

        public TRes InvokeGet<TRes>(string method, string signature, params object[] args)
        {
            return Env.GetField<TRes>(this, method, signature);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Throwable;
            if (other == null)
            {
                return false;
            }
            var value = new Value { _object = ((IJvmProxy)other).JvmHandle };
            //TODO optimize
            return Env.CallBooleanMethod(this, "equals", "(Ljava/lang/Object;)Z", value);
        }

        public override int GetHashCode()
        {
            //TODO optimizie
            return Env.CallIntMethod(this, "hashCode", "()I");
        }

        public static bool operator ==(Throwable a, IJvmProxy b)
        {
            if ((object)a == null && b == null)
                return true;
            if ((object)a == null || b == null)
                return false;
            return a.Env.IsSameObject(a, b);
            //return a.jvmHandle == b.jvmHandle;
        }

        public static bool operator !=(Throwable a, IJvmProxy b)
        {
            if ((object)a == null && b == null)
                return false;
            if ((object)a == null || b == null)
                return true;
            return !a.Env.IsSameObject(a, b);
            //return a.jvmHandle != b.jvmHandle;
        }

        public override string ToString()
        {
            JNIEnv env = Env;
            if ((j4n_toString6 == null))
            {
                j4n_toString6 = env.GetMethodID(((IJvmProxy)this).getClass(), "toString", "()Ljava/lang/String;");
            }

            return toString() + Environment.NewLine + StackTrace;
        }


#if !JNI4NET_MINI
        public void SetStackTrace(StackTrace trace)
        {
            try
            {
                StackTraceElement[] current = getStackTrace();
                var st = new StackTraceElement[current.Length + trace.FrameCount];
                for (int i = 0; i < current.Length; i++)
                {
                    st[i] = current[i];
                }
                for (int i = 0; i < trace.FrameCount; i++)
                {
                    StackFrame frame = trace.GetFrame(i);
                    string type = frame.GetMethod().DeclaringType.FullName;
                    string method = frame.GetMethod().Name + "()";
                    string file = frame.GetFileName();
                    int number = frame.GetFileLineNumber();
                    st[i + current.Length] = new StackTraceElement(type, method, file == null ? "" : file, number);
                }
                setStackTrace(st);
            }
            catch (Exception)
            {
                //ignore
            }
        }
#else
        //TODO
#endif
    }
}