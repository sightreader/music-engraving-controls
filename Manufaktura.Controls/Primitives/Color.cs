using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manufaktura.Music.Extensions;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents a color in RGB color space.
    /// </summary>
    public struct Color
    {
        public static Color Black { get { return new Color(0, 0, 0, 255); } }
        public static Color Red   { get { return new Color(255, 0, 0, 255); } }

        /// <summary>
        /// Alpha value
        /// </summary>
        public byte A { get; set; }
        /// <summary>
        /// Red value
        /// </summary>
        public byte R { get; set; }
        /// <summary>
        /// Green value
        /// </summary>
        public byte G { get; set; }
        /// <summary>
        /// Blue value
        /// </summary>
        public byte B { get; set; }

        public Color(byte r, byte g, byte b, byte a) : this()
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        /// <summary>
        /// Converts color to CSS format
        /// </summary>
        /// <returns></returns>
        public string ToCss()
        {
            return string.Format("rgb({0},{1},{2})", 
                R.ToStringInvariant(),
                G.ToStringInvariant(),
                B.ToStringInvariant());
        }

        
    }
}
