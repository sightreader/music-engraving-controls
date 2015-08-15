using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents a 2D point.
    /// </summary>
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y) : this()
        {
            this.X = x;
            this.Y = y;
        }

    }
}
