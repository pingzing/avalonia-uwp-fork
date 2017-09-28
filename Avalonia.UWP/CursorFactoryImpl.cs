using Avalonia.Input;
using Avalonia.Platform;
using System;

namespace Avalonia.UWP
{
    internal class CursorFactoryImpl : IStandardCursorFactory
    {
        public IPlatformHandle GetCursor(StandardCursorType cursorType) => new PlatformHandle(IntPtr.Zero, "STUB");
    }
}