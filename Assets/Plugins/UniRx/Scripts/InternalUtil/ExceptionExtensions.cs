namespace UniRx.InternalUtil
{
	using System;

	internal static class ExceptionExtensions
	{
		public static void Throw(this Exception exception)
		{
#if (NET461 || NETSTANDARD2_0)
			System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(exception).Throw();
#endif
            throw exception;
		}
	}
}
