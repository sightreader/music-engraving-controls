using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manufaktura.Music.Extensions;

namespace Manufaktura.Controls.Primitives
{
    public struct Pen
    {
        public double Thickness { get; set; }
        public Color Color { get; set; }
        public double ZIndex { get; set; }

        public Pen(Color color, double thickness, double zIndex)
            : this()
        {
            Thickness = thickness;
            Color = color;
            ZIndex = zIndex;
        }

        public Pen(Color color, double thickness) : this(color, thickness, 0) { }

        public Pen(Color color) : this(color, 1, 0) { }

        public string ToCss()
        {
            return string.Format("fill:none;stroke:rgb({0},{1},{2});stroke-width:{3}", Color.R.ToStringInvariant(),
                Color.G.ToStringInvariant(),
                Color.B.ToStringInvariant(),
                Thickness.ToStringInvariant());
        }
    }
}
