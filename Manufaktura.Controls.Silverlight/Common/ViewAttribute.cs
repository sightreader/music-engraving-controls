using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.Silverlight.Common
{
    public class ViewAttribute : Attribute
    {
        public Type ViewType { get; protected set; }

        public ViewAttribute(Type viewType)
        {
            ViewType = viewType;
        }
    }
}
