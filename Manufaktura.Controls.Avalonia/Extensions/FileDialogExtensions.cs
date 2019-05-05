using Avalonia.Controls;
using System.Collections.Generic;

namespace Manufaktura.Controls.Avalonia.Extensions
{
    public static class FileDialogExtensions
    {
        public static void AddFilter(this FileDialog dialog, string formatName, string extension)
        {
            dialog.Filters.Add(new FileDialogFilter { Extensions = new List<string> { extension.TrimStart('.') }, Name = formatName });
        }
    }
}