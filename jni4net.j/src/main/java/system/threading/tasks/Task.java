// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.threading.tasks;

@net.sf.jni4net.attributes.ClrType
public class Task extends system.Object implements system.IAsyncResult, system.IDisposable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Task(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/Action;)V")
    public Task(system.MulticastDelegate action) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask0(this, action);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/Action;LSystem/Threading/CancellationToken;)V")
    public Task(system.MulticastDelegate action, system.ValueType cancellationToken) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask1(this, action, cancellationToken);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/Action;LSystem/Threading/Tasks/TaskCreationOptions;)V")
    public Task(system.MulticastDelegate action, system.Enum creationOptions) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask2(this, action, creationOptions);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/Action;LSystem/Threading/CancellationToken;LSystem/Threading/Tasks/TaskCreationOptions;)V")
    public Task(system.MulticastDelegate action, system.ValueType cancellationToken, system.Enum creationOptions) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask3(this, action, cancellationToken, creationOptions);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("([[LSystem/Action`1;LSystem/Object;)V")
    public Task(system.MulticastDelegate action, system.Object state) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask4(this, action, state);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("([[LSystem/Action`1;LSystem/Object;LSystem/Threading/CancellationToken;)V")
    public Task(system.MulticastDelegate action, system.Object state, system.ValueType cancellationToken) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask5(this, action, state, cancellationToken);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("([[LSystem/Action`1;LSystem/Object;LSystem/Threading/Tasks/TaskCreationOptions;)V")
    public Task(system.MulticastDelegate action, system.Object state, system.Enum creationOptions) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask6(this, action, state, creationOptions);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("([[LSystem/Action`1;LSystem/Object;LSystem/Threading/CancellationToken;LSystem/Threading/Tasks/TaskCreationOptions;)V")
    public Task(system.MulticastDelegate action, system.Object state, system.ValueType cancellationToken, system.Enum creationOptions) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.threading.tasks.Task.__ctorTask7(this, action, state, cancellationToken, creationOptions);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;)V")
    private native static void __ctorTask0(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;Lsystem/ValueType;)V")
    private native static void __ctorTask1(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;Lsystem/Enum;)V")
    private native static void __ctorTask2(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action, system.Enum creationOptions);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;Lsystem/ValueType;Lsystem/Enum;)V")
    private native static void __ctorTask3(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action, system.ValueType cancellationToken, system.Enum creationOptions);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;Lsystem/Object;)V")
    private native static void __ctorTask4(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action, system.Object state);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;Lsystem/Object;Lsystem/ValueType;)V")
    private native static void __ctorTask5(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action, system.Object state, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;Lsystem/Object;Lsystem/Enum;)V")
    private native static void __ctorTask6(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action, system.Object state, system.Enum creationOptions);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/MulticastDelegate;Lsystem/Object;Lsystem/ValueType;Lsystem/Enum;)V")
    private native static void __ctorTask7(net.sf.jni4net.inj.IClrProxy thiz, system.MulticastDelegate action, system.Object state, system.ValueType cancellationToken, system.Enum creationOptions);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isCompleted();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/WaitHandle;")
    public native system.MarshalByRefObject getAsyncWaitHandle();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object getAsyncState();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getCompletedSynchronously();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Dispose();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Start();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Threading/Tasks/TaskScheduler;)V")
    public native void Start(system.Object scheduler);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void RunSynchronously();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Threading/Tasks/TaskScheduler;)V")
    public native void RunSynchronously(system.Object scheduler);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getId();
    
    @net.sf.jni4net.attributes.ClrMethod("()[[LSystem/Nullable`1;")
    public native static system.ValueType getCurrentId();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/AggregateException;")
    public native system.Object getException();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/Tasks/TaskStatus;")
    public native system.Enum getStatus();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isCanceled();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/Tasks/TaskCreationOptions;")
    public native system.Enum getCreationOptions();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/Tasks/TaskFactory;")
    public native static system.Object getFactory();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task getCompletedTask();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFaulted();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Runtime/CompilerServices/TaskAwaiter;")
    public native system.ValueType GetAwaiter();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)LSystem/Runtime/CompilerServices/ConfiguredTaskAwaitable;")
    public native system.ValueType ConfigureAwait(boolean continueOnCapturedContext);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Runtime/CompilerServices/YieldAwaitable;")
    public native static system.ValueType Yield();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Wait();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/TimeSpan;)Z")
    public native boolean Wait(system.ValueType timeout);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)Z")
    public native boolean Wait(int millisecondsTimeout);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILSystem/Threading/CancellationToken;)Z")
    public native boolean Wait(int millisecondsTimeout, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("([[LSystem/Action`1;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction);
    
    @net.sf.jni4net.attributes.ClrMethod("([[LSystem/Action`1;LSystem/Threading/CancellationToken;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("([[LSystem/Action`1;LSystem/Threading/Tasks/TaskScheduler;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.Object scheduler);
    
    @net.sf.jni4net.attributes.ClrMethod("([[LSystem/Action`1;LSystem/Threading/Tasks/TaskContinuationOptions;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.Enum continuationOptions);
    
    @net.sf.jni4net.attributes.ClrMethod("([[LSystem/Action`1;LSystem/Threading/CancellationToken;LSystem/Threading/Tasks/TaskContinuationOptions;LSystem/Threading/Tasks/TaskScheduler;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.ValueType cancellationToken, system.Enum continuationOptions, system.Object scheduler);
    
    @net.sf.jni4net.attributes.ClrMethod("([[[LSystem/Action`2;LSystem/Object;LSystem/Threading/CancellationToken;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.Object state, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("([[[LSystem/Action`2;LSystem/Object;LSystem/Threading/Tasks/TaskScheduler;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.Object state, system.Object scheduler);
    
    @net.sf.jni4net.attributes.ClrMethod("([[[LSystem/Action`2;LSystem/Object;LSystem/Threading/Tasks/TaskContinuationOptions;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.Object state, system.Enum continuationOptions);
    
    @net.sf.jni4net.attributes.ClrMethod("([[[LSystem/Action`2;LSystem/Object;LSystem/Threading/CancellationToken;LSystem/Threading/Tasks/TaskContinuationOptions;LSystem/Threading/Tasks/TaskScheduler;)LSystem/Threading/Tasks/Task;")
    public native system.threading.tasks.Task ContinueWith(system.MulticastDelegate continuationAction, system.Object state, system.ValueType cancellationToken, system.Enum continuationOptions, system.Object scheduler);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;)V")
    public native static void WaitAll(system.threading.tasks.Task[] tasks);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;LSystem/TimeSpan;)Z")
    public native static boolean WaitAll(system.threading.tasks.Task[] tasks, system.ValueType timeout);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;I)Z")
    public native static boolean WaitAll(system.threading.tasks.Task[] tasks, int millisecondsTimeout);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;ILSystem/Threading/CancellationToken;)Z")
    public native static boolean WaitAll(system.threading.tasks.Task[] tasks, int millisecondsTimeout, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;)I")
    public native static int WaitAny(system.threading.tasks.Task[] tasks);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;LSystem/TimeSpan;)I")
    public native static int WaitAny(system.threading.tasks.Task[] tasks, system.ValueType timeout);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;I)I")
    public native static int WaitAny(system.threading.tasks.Task[] tasks, int millisecondsTimeout);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;ILSystem/Threading/CancellationToken;)I")
    public native static int WaitAny(system.threading.tasks.Task[] tasks, int millisecondsTimeout, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Exception;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task FromException(system.Exception exception);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Action;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task Run(system.MulticastDelegate action);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Action;LSystem/Threading/CancellationToken;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task Run(system.MulticastDelegate action, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/TimeSpan;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task Delay(system.ValueType delay);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/TimeSpan;LSystem/Threading/CancellationToken;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task Delay(system.ValueType delay, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task Delay(int millisecondsDelay);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILSystem/Threading/CancellationToken;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task Delay(int millisecondsDelay, system.ValueType cancellationToken);
    
    @net.sf.jni4net.attributes.ClrMethod("([[LSystem/Collections/Generic/IEnumerable`1;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task WhenAll(system.collections.IEnumerable tasks);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task WhenAll(system.threading.tasks.Task[] tasks);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Threading/Tasks/Task;)[[LSystem/Threading/Tasks/Task`1;")
    public native static system.threading.tasks.Task WhenAny(system.threading.tasks.Task[] tasks);
    
    @net.sf.jni4net.attributes.ClrMethod("([[LSystem/Collections/Generic/IEnumerable`1;)[[LSystem/Threading/Tasks/Task`1;")
    public native static system.threading.tasks.Task WhenAny(system.collections.IEnumerable tasks);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Threading/CancellationToken;)LSystem/Threading/Tasks/Task;")
    public native static system.threading.tasks.Task FromCanceled(system.ValueType cancellationToken);
    
    public static system.Type typeof() {
        return system.threading.tasks.Task.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.threading.tasks.Task.staticType = staticType;
    }
    //</generated-proxy>
}
