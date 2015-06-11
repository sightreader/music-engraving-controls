using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manufaktura.Music.Extensions;

namespace Manufaktura.Controls.Primitives
{
    public struct Color
    {
        public static Color Black { get { return new Color(0, 0, 0, 255); } }
        public static Color Red   { get { return new Color(255, 0, 0, 255); } }

        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Color(byte r, byte g, byte b, byte a) : this()
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public string ToCss()
        {
            return string.Format("rgb({0},{1},{2})", 
                R.ToStringInvariant(),
                G.ToStringInvariant(),
                B.ToStringInvariant());
        }

        
    }
}
