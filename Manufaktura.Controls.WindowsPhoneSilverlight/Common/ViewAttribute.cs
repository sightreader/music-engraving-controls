using System;

namespace Manufaktura.Controls.WindowsPhoneSilverlight.Common
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