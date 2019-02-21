#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Security.Permissions;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
    public partial class Registry
    {
        public static RegistryRecord GetRecord(JNIEnv env, JniHandle obj, Class iface)
        {
            registryLock.EnterUpgradeableReadLock();
            try
            {
                RegistryRecord res;
                if (knownJVM.TryGetValue(iface, out res))
                {
                    return res;
                }
                Type clr = IsCLR(iface, obj, env);


                registryLock.EnterWriteLock();
                try
                {
                    if (clr != null)
                    {
                        return ResolveNew(clr);
                    }
                    return ResolveNew(iface);
                }
                finally
                {
                    registryLock.ExitWriteLock();
                }
            }
            finally
            {
                registryLock.ExitUpgradeableReadLock();
            }
        }

        public static RegistryRecord GetRecord(object obj)
        {
            Type iface = obj.GetType();
            registryLock.EnterUpgradeableReadLock();
            try
            {
                RegistryRecord res;
                if (knownCLR.TryGetValue(iface, out res))
                {
                    return res;
                }

                registryLock.EnterWriteLock();
                try
                {
                    if (obj is IJvmProxy proxy)
                    {
                        return ResolveNew(proxy.getClass());
                    }

                    return ResolveNew(iface);
                }
                finally
                {
                    registryLock.ExitWriteLock();
                }
            }
            finally
            {
                registryLock.ExitUpgradeableReadLock();
            }
        }

        internal static RegistryRecord GetCLRRecord(Type iface)
        {
            if (registryLock.IsWriteLockHeld)
            {
                return GetCLRRecordNoLock(iface);
            }

            registryLock.EnterReadLock();
            try
            {
                if (knownCLR.TryGetValue(iface, out var res))
                {
                    return res;
                }
            }
            finally
            {
                registryLock.ExitReadLock();
            }

            registryLock.EnterWriteLock();
            try
            {
                return GetCLRRecordNoLock(iface);
            }
            finally
            {
                registryLock.ExitWriteLock();
            }
        }

        private static RegistryRecord GetCLRRecordNoLock(Type iface)
        {
            if (knownCLR.TryGetValue(iface, out var res))
            {
                return res;
            }

            return ResolveNew(iface);
        }

        internal static RegistryRecord GetJVMRecord(Class iface)
        {
            if (registryLock.IsWriteLockHeld)
            {
                return GetJVMRecordNoLock(iface);
            }

            registryLock.EnterReadLock();
            try
            {
                if (knownJVM.TryGetValue(iface, out var res))
                {
                    return res;
                }
            }
            finally
            {
                registryLock.ExitReadLock();
            }

            registryLock.EnterWriteLock();
            try
            {
                return GetJVMRecordNoLock(iface);
            }
            finally
            {
                registryLock.ExitWriteLock();
            }
        }

        private static RegistryRecord GetJVMRecordNoLock(Class iface)
        {
            if (knownJVM.TryGetValue(iface, out var res))
            {
                return res;
            }
            return ResolveNew(iface);
        }

        private static Type IsCLR(Class iface, JniHandle obj, JNIEnv env)
        {
            if (IClrProxy_._class.isAssignableFrom(iface))
            {
                object real = __IClrProxy.GetObject(env, obj);
                return real.GetType();
            }
            return null;
        }
    }
}