using Manufaktura.Music.Extensions;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents pen settings used to draw objects.
    /// </summary>
    public struct Pen
    {
        /// <summary>
        /// Pen color
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Pen thickness
        /// </summary>
        public double Thickness { get; set; }

        /// <summary>
        /// Z-index
        /// </summary>
        public double ZIndex { get; set; }

        public Pen(Color color, double thickness, double zIndex)
            : this()
        {
            Thickness = thickness;
            Color = color;
            ZIndex = zIndex;
        }

        public Pen(Color color, double thickness)
            : this(color, thickness, 0)
        {
        }

        public Pen(Color color)
            : this(color, 1, 0)
        {
        }

        /// <summary>
        /// Converts pen settings to CSS style
        /// </summary>
        /// <returns></returns>
        public string ToCss()
        {
            return string.Format("fill:none;stroke:rgb({0},{1},{2});stroke-width:{3}", Color.R.ToStringInvariant(),
                Color.G.ToStringInvariant(),
                Color.B.ToStringInvariant(),
                Thickness.ToStringInvariant());
        }
    }
}