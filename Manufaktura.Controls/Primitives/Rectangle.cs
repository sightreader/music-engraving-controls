using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents a rectangle on 2D surface.
    /// </summary>
    public struct Rectangle
    {
        public Rectangle(double x, double y, double width, double height)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public double Height { get; set; }

        public Point Location => new Point(X, Y);
        public Size Size => new Size(Width, Height);
        public double Width { get; set; }

        public double X { get; set; }

        public double Y { get; set; }
        /// <summary>
        /// Translates Rectangle according to page margins
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public Rectangle Translate(ScorePage page)
        {
            return new Primitives.Rectangle(this.X + (page.MarginLeft ?? 0),
                                            this.Y + (page.MarginTop ?? 0),
                                            this.Width, this.Height);
        }
    }
}