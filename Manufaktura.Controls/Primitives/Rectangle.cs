using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents a rectangle on 2D surface.
    /// </summary>
    public struct Rectangle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double x, double y, double width, double height) : this()
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }
    }
}
