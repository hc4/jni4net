// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.io;

@net.sf.jni4net.attributes.ClrType
public class FileStream extends system.io.Stream {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected FileStream(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/IO/FileMode;)V")
    public FileStream(java.lang.String path, system.Enum mode) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream0(this, path, mode);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;)V")
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream1(this, path, mode, access);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;)V")
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream2(this, path, mode, access, share);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;I)V")
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream3(this, path, mode, access, share, bufferSize);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;ILSystem/IO/FileOptions;)V")
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, system.Enum options) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream4(this, path, mode, access, share, bufferSize, options);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;IZ)V")
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, boolean useAsync) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream5(this, path, mode, access, share, bufferSize, useAsync);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/IO/FileMode;LSystem/Security/AccessControl/FileSystemRights;LSystem/IO/FileShare;ILSystem/IO/FileOptions;LSystem/Security/AccessControl/FileSecurity;)V")
    public FileStream(java.lang.String path, system.Enum mode, system.Enum rights, system.Enum share, int bufferSize, system.Enum options, system.Object fileSecurity) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream6(this, path, mode, rights, share, bufferSize, options, fileSecurity);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/IntPtr;LSystem/IO/FileAccess;)V")
    public FileStream(long handle, system.Enum access) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream7(this, handle, access);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/IntPtr;LSystem/IO/FileAccess;Z)V")
    public FileStream(long handle, system.Enum access, boolean ownsHandle) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream8(this, handle, access, ownsHandle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/IntPtr;LSystem/IO/FileAccess;ZI)V")
    public FileStream(long handle, system.Enum access, boolean ownsHandle, int bufferSize) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream9(this, handle, access, ownsHandle, bufferSize);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/IntPtr;LSystem/IO/FileAccess;ZIZ)V")
    public FileStream(long handle, system.Enum access, boolean ownsHandle, int bufferSize, boolean isAsync) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream10(this, handle, access, ownsHandle, bufferSize, isAsync);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;)V")
    public FileStream(system.Object handle, system.Enum access) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream11(this, handle, access);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;I)V")
    public FileStream(system.Object handle, system.Enum access, int bufferSize) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream12(this, handle, access, bufferSize);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;IZ)V")
    public FileStream(system.Object handle, system.Enum access, int bufferSize, boolean isAsync) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.io.FileStream.__ctorFileStream13(this, handle, access, bufferSize, isAsync);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Enum;)V")
    private native static void __ctorFileStream0(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String path, system.Enum mode);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V")
    private native static void __ctorFileStream1(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String path, system.Enum mode, system.Enum access);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;)V")
    private native static void __ctorFileStream2(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String path, system.Enum mode, system.Enum access, system.Enum share);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;I)V")
    private native static void __ctorFileStream3(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;)V")
    private native static void __ctorFileStream4(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, system.Enum options);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;IZ)V")
    private native static void __ctorFileStream5(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, boolean useAsync);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;Lsystem/Object;)V")
    private native static void __ctorFileStream6(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String path, system.Enum mode, system.Enum rights, system.Enum share, int bufferSize, system.Enum options, system.Object fileSecurity);
    
    @net.sf.jni4net.attributes.ClrMethod("(JLsystem/Enum;)V")
    private native static void __ctorFileStream7(net.sf.jni4net.inj.IClrProxy thiz, long handle, system.Enum access);
    
    @net.sf.jni4net.attributes.ClrMethod("(JLsystem/Enum;Z)V")
    private native static void __ctorFileStream8(net.sf.jni4net.inj.IClrProxy thiz, long handle, system.Enum access, boolean ownsHandle);
    
    @net.sf.jni4net.attributes.ClrMethod("(JLsystem/Enum;ZI)V")
    private native static void __ctorFileStream9(net.sf.jni4net.inj.IClrProxy thiz, long handle, system.Enum access, boolean ownsHandle, int bufferSize);
    
    @net.sf.jni4net.attributes.ClrMethod("(JLsystem/Enum;ZIZ)V")
    private native static void __ctorFileStream10(net.sf.jni4net.inj.IClrProxy thiz, long handle, system.Enum access, boolean ownsHandle, int bufferSize, boolean isAsync);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/Object;Lsystem/Enum;)V")
    private native static void __ctorFileStream11(net.sf.jni4net.inj.IClrProxy thiz, system.Object handle, system.Enum access);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/Object;Lsystem/Enum;I)V")
    private native static void __ctorFileStream12(net.sf.jni4net.inj.IClrProxy thiz, system.Object handle, system.Enum access, int bufferSize);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/Object;Lsystem/Enum;IZ)V")
    private native static void __ctorFileStream13(net.sf.jni4net.inj.IClrProxy thiz, system.Object handle, system.Enum access, int bufferSize, boolean isAsync);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isAsync();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getName();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Security/AccessControl/FileSecurity;")
    public native system.Object GetAccessControl();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Security/AccessControl/FileSecurity;)V")
    public native void SetAccessControl(system.Object fileSecurity);
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native void Flush(boolean flushToDisk);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/IntPtr;")
    public native long getHandle();
    
    @net.sf.jni4net.attributes.ClrMethod("()LMicrosoft/Win32/SafeHandles/SafeFileHandle;")
    public native system.Object getSafeFileHandle();
    
    @net.sf.jni4net.attributes.ClrMethod("(JJ)V")
    public native void Lock(long position, long length);
    
    @net.sf.jni4net.attributes.ClrMethod("(JJ)V")
    public native void Unlock(long position, long length);
    
    public static system.Type typeof() {
        return system.io.FileStream.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.io.FileStream.staticType = staticType;
    }
    //</generated-proxy>
}
