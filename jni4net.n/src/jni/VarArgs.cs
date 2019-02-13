﻿using System.Runtime.InteropServices;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs1
    {
        public Value Arg0;

        public VarArgs1(Value arg0)
        {
            Arg0 = arg0;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs2
    {
        public Value Arg0;
        public Value Arg1;

        public VarArgs2(Value arg0, Value arg1)
        {
            Arg0 = arg0;
            Arg1 = arg1;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs3
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;

        public VarArgs3(Value arg0, Value arg1, Value arg2)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs4
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;

        public VarArgs4(Value arg0, Value arg1, Value arg2, Value arg3)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs5
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;
        public Value Arg4;

        public VarArgs5(Value arg0, Value arg1, Value arg2, Value arg3, Value arg4)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs6
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;
        public Value Arg4;
        public Value Arg5;

        public VarArgs6(Value arg0, Value arg1, Value arg2, Value arg3, Value arg4, Value arg5)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
            Arg5 = arg5;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs7
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;
        public Value Arg4;
        public Value Arg5;
        public Value Arg6;

        public VarArgs7(Value arg0, Value arg1, Value arg2, Value arg3, Value arg4, Value arg5, Value arg6)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
            Arg5 = arg5;
            Arg6 = arg6;
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    internal ref struct VarArgs8
    {
        public Value Arg0;
        public Value Arg1;
        public Value Arg2;
        public Value Arg3;
        public Value Arg4;
        public Value Arg5;
        public Value Arg6;
        public Value Arg7;

        public VarArgs8(Value arg0, Value arg1, Value arg2, Value arg3, Value arg4, Value arg5, Value arg6, Value arg7)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
            Arg5 = arg5;
            Arg6 = arg6;
            Arg7 = arg7;
        }
    }
}