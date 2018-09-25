﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ProxyProfiler.Interfaces
{
    internal interface IProfilerAttribute : _Attribute
    {
        Type ProfileType { get; }

        void OnBeforeInvoke<T>(T profiler, MethodInfo methodToInvoke) where T : class, new();

        void OnAfterInvoke<T>(T profiler, MethodInfo invokedMethod, object invokeResult) where T : class, new();

        void OnInvokeException<T>(T profiler, MethodInfo invokedMethod, Exception exception) where T : class, new();
    }
}