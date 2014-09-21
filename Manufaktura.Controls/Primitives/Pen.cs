using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Primitives
{
    public struct Pen
    {
        public double Thickness { get; set; }
        public Color Color { get; set; }
        public double ZIndex { get; set; }

        public Pen(Color color, double thickness, double zIndex) : this()
        {
            Thickness = thickness;
            Color = color;
            ZIndex = zIndex;
        }

        public Pen(Color color, double thickness) : this(color, thickness, 0) { }

        public Pen(Color color) : this(color, 1, 0) { }
    }
}
