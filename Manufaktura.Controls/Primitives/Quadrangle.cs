namespace Manufaktura.Controls.Primitives
{
    public struct Quadrangle
    {
        public Quadrangle(Point ne, Point nw, Point se, Point sw) : this()
        {
            NE = ne;
            NW = nw;
            SE = se;
            SW = sw;
        }

        public Point NE { get; set; }
        public Point NW { get; set; }
        public Point SE { get; set; }
        public Point SW { get; set; }
    }
}