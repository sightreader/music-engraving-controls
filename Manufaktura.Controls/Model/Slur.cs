using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a slur.
    /// </summary>
    public class Slur : IHasCustomXPosition, IHasCustomYPosition
    {
        public Slur()
        {
            Type = NoteSlurType.None;
        }

        public Slur(NoteSlurType type)
        {
            Type = type;
        }

        public double? BezierX { get; set; }
        public double? BezierY { get; set; }

        public Point BezierControlPoint => BezierX.HasValue && BezierY.HasValue ? new Point(BezierX.Value, BezierY.Value) : default(Point);
        public double? DefaultXPosition { get; set; }
        public double? DefaultYPosition { get; set; }
        public bool IsDefinedAsBezierCurve => false;// DefaultXPosition.HasValue && DefaultYPosition.HasValue && BezierX.HasValue && BezierY.HasValue;
        public int Number { get; set; }
        public VerticalPlacement? Placement { get; set; }
        public Point BezierStartOrEndPoint => DefaultXPosition.HasValue && DefaultYPosition.HasValue ? new Point(DefaultXPosition.Value, DefaultYPosition.Value) : default(Point);
        public NoteSlurType Type { get; set; }
    }
}