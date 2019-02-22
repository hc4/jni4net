#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public readonly ref struct JniGlobalHandleNs
    {
        internal readonly IntPtr handle;
    }

    public struct JniGlobalHandle
    {
        public static readonly JniGlobalHandle Zero = new JniGlobalHandle(IntPtr.Zero, null);

        private IntPtr handle;
        private JavaVM javaVM;

        public IntPtr Handle => handle;
        public JavaVM JavaVM => javaVM;

        public JniGlobalHandle(IntPtr handle, JavaVM javaVm)
        {
            this.handle = handle;
            this.javaVM = javaVm;
        }

        internal void CheckNotInitialized()
        {
            if (handle != IntPtr.Zero)
            {
                throw new InvalidOperationException("Handle already initialized");
            }
        }

        public static bool IsNull(JniGlobalHandle gref)
        {
            return gref.Handle == IntPtr.Zero;
        }
        
        internal bool Release()
        {
            try
            {
                if (handle != IntPtr.Zero)
                {
                    JNIEnv env = JNIEnv.GetEnvNoThrow(javaVM);
                    if (env == null)
                    {
                        return false;
                    }
                    env.DeleteGlobalRef(this);
                }
                return true;
            }
            finally
            {
                handle = IntPtr.Zero;
            }
        }
    }
}