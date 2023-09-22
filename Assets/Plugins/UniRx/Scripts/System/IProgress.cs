// defined from .NET Framework 4.5 and NETFX_CORE

#if !(NETFX_CORE || NET461 || NETSTANDARD2_0 || UNITY_WSA_10_0)

using System;

namespace UniRx
{
    public interface IProgress<T>
    {
        void Report(T value);
    }

    public class Progress<T> : IProgress<T>
    {
        readonly Action<T> report;

        public Progress(Action<T> report)
        {
            this.report = report;
        }

        public void Report(T value)
        {
            report(value);
        }
    }
}

#endif