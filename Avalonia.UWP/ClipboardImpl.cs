using Avalonia.Input.Platform;
using System.Threading.Tasks;

namespace Avalonia.UWP
{
    public class ClipboardImpl : IClipboard
    {
        public Task<string> GetTextAsync() => Task.FromResult("");

        public Task SetTextAsync(string text) => Task.CompletedTask;

        public Task ClearAsync() => Task.CompletedTask;
    }
}