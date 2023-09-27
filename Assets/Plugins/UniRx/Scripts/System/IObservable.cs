// defined from .NET Framework 4.0 and NETFX_CORE

using System;

#if !(NETFX_CORE || NET461 || NETSTANDARD2_0 || UNITY_WSA_10_0)

namespace UniRx
{
    public interface IObservable<T>
    {
        IDisposable Subscribe(IObserver<T> observer);
    }
}

#endif

namespace UniRx
{
    public interface IGroupedObservable<TKey, TElement> : IObservable<TElement>
    {
        TKey Key { get; }
    }
}