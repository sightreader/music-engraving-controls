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

        public Pen(Color color, double thickness) : this()
        {
            Thickness = thickness;
            Color = color;
        }

        public Pen(Color color) : this(color, 1) { }
    }
}
