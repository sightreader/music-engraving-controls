namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents a 2D size.
    /// </summary>
    public struct Size
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public Size(double width, double height)
            : this()
        {
            this.Width = width;
            this.Height = height;
        }
    }
}