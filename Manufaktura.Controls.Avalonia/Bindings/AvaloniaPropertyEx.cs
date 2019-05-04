using Avalonia.Controls;
using System.Collections.Generic;

namespace Manufaktura.Controls.Avalonia.Bindings
{
    public static class AvaloniaPropertyEx
    {
        public static IEnumerable<Control> RemoveAllFrom(this IEnumerable<Control> controls, Canvas canvas)
        {
            foreach (var control in controls)
            {
                canvas.Children.Remove(control);
            }
            return controls;
        }
    }
}