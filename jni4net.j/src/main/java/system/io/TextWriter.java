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
public class TextWriter extends system.MarshalByRefObject implements system.IDisposable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected TextWriter(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected TextWriter() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Dispose();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/IFormatProvider;")
    public native system.IFormatProvider getFormatProvider();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Close();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Flush();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Text/Encoding;")
    public native system.Object getEncoding();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getNewLine();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)V")
    public native void setNewLine(java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IO/TextWriter;)LSystem/IO/TextWriter;")
    public native static system.io.TextWriter Synchronized(system.io.TextWriter writer);
    
    @net.sf.jni4net.attributes.ClrMethod("(C)V")
    public native void Write(char value);
    
    @net.sf.jni4net.attributes.ClrMethod("([C)V")
    public native void Write(char[] buffer);
    
    @net.sf.jni4net.attributes.ClrMethod("([CII)V")
    public native void Write(char[] buffer, int index, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native void Write(boolean value);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native void Write(int value);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)V")
    public native void Write(long value);
    
    @net.sf.jni4net.attributes.ClrMethod("(F)V")
    public native void Write(float value);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)V")
    public native void Write(double value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)V")
    public native void Write(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)V")
    public native void Write(java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)V")
    public native void Write(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Object;)V")
    public native void Write(java.lang.String format, system.Object arg0);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Object;LSystem/Object;)V")
    public native void Write(java.lang.String format, system.Object arg0, system.Object arg1);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Object;LSystem/Object;LSystem/Object;)V")
    public native void Write(java.lang.String format, system.Object arg0, system.Object arg1, system.Object arg2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;[LSystem/Object;)V")
    public native void Write(java.lang.String format, system.Object[] arg);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void WriteLine();
    
    @net.sf.jni4net.attributes.ClrMethod("(C)V")
    public native void WriteLine(char value);
    
    @net.sf.jni4net.attributes.ClrMethod("([C)V")
    public native void WriteLine(char[] buffer);
    
    @net.sf.jni4net.attributes.ClrMethod("([CII)V")
    public native void WriteLine(char[] buffer, int index, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native void WriteLine(boolean value);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native void WriteLine(int value);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)V")
    public native void WriteLine(long value);
    
    @net.sf.jni4net.attributes.ClrMethod("(F)V")
    public native void WriteLine(float value);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)V")
    public native void WriteLine(double value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)V")
    public native void WriteLine(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)V")
    public native void WriteLine(java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)V")
    public native void WriteLine(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Object;)V")
    public native void WriteLine(java.lang.String format, system.Object arg0);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Object;LSystem/Object;)V")
    public native void WriteLine(java.lang.String format, system.Object arg0, system.Object arg1);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Object;LSystem/Object;LSystem/Object;)V")
    public native void WriteLine(java.lang.String format, system.Object arg0, system.Object arg1, system.Object arg2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;[LSystem/Object;)V")
    public native void WriteLine(java.lang.String format, system.Object[] arg);
    
    @net.sf.jni4net.attributes.ClrMethod("(C)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteAsync(char value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteAsync(java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("([C)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteAsync(char[] buffer);
    
    @net.sf.jni4net.attributes.ClrMethod("([CII)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteAsync(char[] buffer, int index, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("(C)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteLineAsync(char value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteLineAsync(java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("([C)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteLineAsync(char[] buffer);
    
    @net.sf.jni4net.attributes.ClrMethod("([CII)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteLineAsync(char[] buffer, int index, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task WriteLineAsync();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task FlushAsync();
    
    public static system.Type typeof() {
        return system.io.TextWriter.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.io.TextWriter.staticType = staticType;
    }
    //</generated-proxy>
}
