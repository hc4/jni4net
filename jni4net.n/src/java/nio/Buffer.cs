﻿#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.nio
{
    public partial class Buffer
    {
        public void Limit(int par0)
        {
            JNIEnv @__env = Env;
            @__env.DeleteLocalRef(@__env.CallObjectMethodPtr(this, j4n_limit1, Convertor.ParPrimC2J(par0)));
        }

        public void Position(int par0)
        {
            JNIEnv @__env = Env;
            @__env.DeleteLocalRef(@__env.CallObjectMethodPtr(this, j4n_position8, Convertor.ParPrimC2J(par0)));
        }

    }
}
