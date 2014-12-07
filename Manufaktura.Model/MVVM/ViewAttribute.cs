using Manufaktura.Model.MVVM;
using System;
using System.Net;

namespace Manufaktura.Controls.Silverlight.Common
{
    public class ViewAttribute : Attribute
    {
        public Type ViewType { get; protected set; }
        public ViewKinds? ViewKind { get; protected set; }

        public ViewAttribute(Type viewType)
        {
            ViewType = viewType;
        }

        public ViewAttribute(Type viewType, ViewKinds viewKind) : this(viewType)
        {
            ViewKind = viewKind; 
        }
    }
}
