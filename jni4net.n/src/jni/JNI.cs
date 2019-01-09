#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace net.sf.jni4net.jni
{
    internal static unsafe class JNI
    {
        public const int JNI_VERSION_1_1 = 0x00010001;
        public const int JNI_VERSION_1_2 = 0x00010002;
        public const int JNI_VERSION_1_4 = 0x00010004;
        public const int JNI_VERSION_1_6 = 0x00010006;

        private const string JRE_REGISTRY_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Runtime Environment";
        private const string JDK_REGISTRY_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Development Kit";
        private const string JAVA_HOME_ENV = "JAVA_HOME";
        private const string ARCH_ENV = "PROCESSOR_ARCHITECTURE";

        private static Dll dll;

        /*static JNI()
        {
            Init();
        }*/

        [EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
        [RegistryPermission(SecurityAction.Assert, Read = JRE_REGISTRY_KEY)]
        [RegistryPermission(SecurityAction.Assert, Read = JDK_REGISTRY_KEY)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SkipVerification)]
        private static void Init()
        {
            if (dll == null)
            {
                string findJvmDir = FindJvmDir();
//                AddEnvironmentPath(findJvmDir);
                var args = new JavaVMInitArgs();
                try
                {
                    //just load DLL
                    var dll = new Dll(findJvmDir);
                    try
                    {
                        dll.GetDefaultJavaVMInitArgs(&args);
                    }
                    catch
                    {
                        dll.Dispose();
                        throw;
                    }

                    JNI.dll = dll;
                }
                catch (BadImageFormatException ex)
                {
                    // it didn't help, throw original exception
                    throw new JNIException("Can't initialize jni4net. (32bit vs 64bit JVM vs CLR ?)"
                                           + "\nCLR architecture: " + ((IntPtr.Size == 8) ? "64bit" : "32bit")
                                           + "\nJAVA_HOME: " + (Bridge.Setup == null || Bridge.Setup.JavaHome == null
                                                                    ? "null"
                                                                    : Path.GetFullPath(Bridge.Setup.JavaHome))
                                           , ex);
                }
            }
        }

        internal static void Reset()
        {
            dll?.Dispose();
            dll = null;
        }

        private static string FindJvmDir()
        {
            string directory = null;
            if (string.IsNullOrEmpty(Bridge.Setup.JavaHome))
            {
                Bridge.Setup.JavaHome = Environment.GetEnvironmentVariable(JAVA_HOME_ENV);

                if (string.IsNullOrEmpty(Bridge.Setup.JavaHome))
                {
                    Bridge.Setup.JavaHome = null;
                }
                else
                {
                    try
                    {
                        Bridge.Setup.JavaHome = Path.GetFullPath(Bridge.Setup.JavaHome.Replace("\"", ""));
                    }
                    catch (Exception ex)
                    {
                        throw new JNIException("JAVA_HOME environment variable is incorrect: " + Bridge.Setup.JavaHome, ex);
                    }
                }
            }

            if (Bridge.Setup.JavaHome == null)
            {
                throw new JNIException("JAVA_HOME environment variable is not set");
            }

            if (!string.IsNullOrEmpty(directory) && Directory.Exists(directory))
            {
                return directory;
            }
            directory = Path.Combine(Bridge.Setup.JavaHome, @"bin\client\");

            if (!string.IsNullOrEmpty(directory) && Directory.Exists(directory))
            {
                return directory;
            }
            directory = Path.Combine(Bridge.Setup.JavaHome, @"bin\server\");

            if (!string.IsNullOrEmpty(directory) && Directory.Exists(directory))
            {
                return directory;
            }
            directory = Path.Combine(Bridge.Setup.JavaHome, @"jre\bin\client\");

            if (!string.IsNullOrEmpty(directory) && Directory.Exists(directory))
            {
                return directory;
            }
            directory = Path.Combine(Bridge.Setup.JavaHome, @"jre\bin\server\");

            if (!string.IsNullOrEmpty(directory) && Directory.Exists(directory))
            {
                return directory;
            }
            directory = Path.Combine(Bridge.Setup.JavaHome, @"jre\bin\classic\");

            if (!string.IsNullOrEmpty(directory) && Directory.Exists(directory))
            {
                return directory;
            }

            throw new JNIException("JAVA_HOME environment variable points to an invalid location: " + Bridge.Setup.JavaHome);
        }

        private static bool IsRunningOnUnix()
        {
            int p = (int)Environment.OSVersion.Platform;
            return ((p == 4) || (p == 6) || (p == 128));
        }

        public static void CreateJavaVM(out JNIEnv env, params string[] options)
        {
            CreateJavaVM(out env, false, options);
        }

        public static void CreateJavaVM(out JNIEnv env, bool attachIfExists, params string[] options)
        {
            Init();
            IntPtr njvm;
            IntPtr nenv;
            var args = new JavaVMInitArgs();
            args.version = JNI_VERSION_1_4;

            if (options.Length > 0)
            {
                args.nOptions = options.Length;
                var opt = new JavaVMOption[options.Length];
                for (int i = 0; i < options.Length; i++)
                {
                    opt[i].optionString = Marshal.StringToHGlobalAnsi(options[i]);
                }
                fixed (JavaVMOption* a = &opt[0])
                {
                    args.options = a;
                }
            }
            JNIResult result;
            if (attachIfExists)
            {
                IntPtr njvma;
                int count;
                result = dll.GetCreatedJavaVMs(out njvma, 1, out count);
                if (result != JNIResult.JNI_OK)
                {
                    throw new JNIException("Can't enumerate current JVMs " + result);
                }
                if (count > 0)
                {
                    njvm = njvma;
                    var jvm = new JavaVM(njvm);
                    result = jvm.AttachCurrentThread(out env, args);
                    if (result != JNIResult.JNI_OK)
                    {
                        throw new JNIException("Can't join current JVM " + result);
                    }
                    return;
                }
            }
            result = dll.CreateJavaVM(out njvm, out nenv, &args);
            if (result != JNIResult.JNI_OK)
            {
                Console.Error.WriteLine("Can't load JVM (already have one ?)");
                throw new JNIException("Can't load JVM (already have one ?) " + result);
            }

            env = new JNIEnv(nenv, njvm);
        }

        private static void AddEnvironmentPath(string jvm)
        {
            string path = Environment.GetEnvironmentVariable("PATH") ?? string.Empty;
            if (!path.StartsWith(jvm))
            {
                path = jvm + Path.PathSeparator + path;
                Environment.SetEnvironmentVariable("PATH", path);
            }
        }

        #region Nested type: Dll

        private sealed class Dll : IDisposable
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult JNI_CreateJavaVM(out IntPtr pvm, out IntPtr penv, JavaVMInitArgs* args);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult JNI_GetCreatedJavaVMs(out IntPtr pvm, int size, [Out] out int size2);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult JNI_GetDefaultJavaVMInitArgs(JavaVMInitArgs* args);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr LoadLibrary(string lpFilename);

            [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
            private static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern bool FreeLibrary(IntPtr hModule);

            private readonly IntPtr _pLib;

            public readonly JNI_CreateJavaVM CreateJavaVM;
            public readonly JNI_GetCreatedJavaVMs GetCreatedJavaVMs;
            public readonly JNI_GetDefaultJavaVMInitArgs GetDefaultJavaVMInitArgs;

            public Dll(string dir)
            {
                var libPath = Path.Combine(dir, "jvm.dll");
                _pLib = LoadLibrary(libPath);
                if (_pLib == IntPtr.Zero)
                {
                    throw new Exception("Failed to load JVM from " + libPath);
                }

                CreateJavaVM = FindMethod<JNI_CreateJavaVM>(nameof(JNI_CreateJavaVM));
                GetCreatedJavaVMs = FindMethod<JNI_GetCreatedJavaVMs>(nameof(JNI_GetCreatedJavaVMs));
                GetDefaultJavaVMInitArgs = FindMethod<JNI_GetDefaultJavaVMInitArgs>(nameof(JNI_GetDefaultJavaVMInitArgs));
            }

            private T FindMethod<T>(string name)
            {
                var result = GetProcAddress(_pLib, name);
                if (result == IntPtr.Zero)
                {
                    int error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(error, name + " not found");
                }

                return Marshal.GetDelegateForFunctionPointer<T>(result);
            }
            
            public void Dispose()
            {
                FreeLibrary(_pLib);
            }
        }

        #endregion
    }
}