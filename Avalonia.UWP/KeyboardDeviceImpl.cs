using Avalonia.Input;

namespace Avalonia.UWP
{
    internal class KeyboardDeviceImpl : IKeyboardDevice
    {
        public IInputElement FocusedElement => throw new System.NotImplementedException();

        public void SetFocusedElement(IInputElement element, NavigationMethod method, InputModifiers modifiers)
        {
            throw new System.NotImplementedException();
        }
    }
}