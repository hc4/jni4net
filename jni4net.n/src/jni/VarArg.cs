using System.Runtime.InteropServices;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Sequential)]
    public ref struct VarArg1
    {
        public Value Arg0;

        public VarArg1(Value arg0)
        {
            Arg0 = arg0;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public ref struct VarArg2
    {
        public Value Arg0;
        public Value Arg1;

        public VarArg2(Value arg0, Value arg1)
        {
            Arg0 = arg0;
            Arg1 = arg1;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public ref struct VarArg3
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;

        public VarArg3(Value arg0, Value arg1, Value arg2)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public ref struct VarArg4
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;

        public VarArg4(Value arg0, Value arg1, Value arg2, Value arg3)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public ref struct VarArg5
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;
        public Value Arg4;

        public VarArg5(Value arg0, Value arg1, Value arg2, Value arg3, Value arg4)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public ref struct VarArg6
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;
        public Value Arg4;
        public Value Arg5;

        public VarArg6(Value arg0, Value arg1, Value arg2, Value arg3, Value arg4, Value arg5)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
            Arg5 = arg5;
        }
    }
}