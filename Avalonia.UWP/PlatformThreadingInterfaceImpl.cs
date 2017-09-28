using System;
using System.Threading;
using Avalonia.Platform;

namespace Avalonia.UWP
{
    internal class PlatformThreadingInterfaceImpl : IPlatformThreadingInterface
    {
        public bool CurrentThreadIsLoopThread => throw new NotImplementedException();

        public event Action Signaled;

        public void RunLoop(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Signal()
        {
            throw new NotImplementedException();
        }

        public IDisposable StartTimer(TimeSpan interval, Action tick)
        {
            throw new NotImplementedException();
        }
    }
}