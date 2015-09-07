using Manufaktura.Controls.Model;

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

        public Point Translate(ScorePage page)
        {
            return new Point(this.X + (page.MarginLeft ?? 0), this.Y + (page.MarginTop ?? 0));
        }
    }
}