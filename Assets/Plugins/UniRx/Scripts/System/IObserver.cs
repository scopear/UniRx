// defined from .NET Framework 4.0 and NETFX_CORE

#if !(NETFX_CORE || NET461 || NETSTANDARD2_0 || UNITY_WSA_10_0)

using System;

namespace UniRx
{
    public interface IObserver<T>
    {
        void OnCompleted();
        void OnError(Exception error);
        void OnNext(T value);
    }
}

#endif