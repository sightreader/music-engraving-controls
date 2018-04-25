using Manufaktura.Controls.Primitives;
using System;

namespace Manufaktura.Controls.Rendering.Snippets
{
    public struct TupletBracketDefinition
    {
        public TupletBracketDefinition(double startX, double startY, double endX, double endY)
        {
            StartPoint = new Point(startX, startY);
            EndPoint = new Point(endX, endY);
            Width = Point.Distance(StartPoint, EndPoint);
            Angle =  Point.BeamAngle(StartPoint, EndPoint);
            Point25 = StartPoint.TranslateByAngleOld(Angle, Width * 0.25);
            MidPoint = StartPoint.TranslateByAngleOld(Angle, Width * 0.5);
            Point75 = StartPoint.TranslateByAngleOld(Angle, Width * 0.75);
        }

        public double Angle { get; private set; }
        public Point EndPoint { get; private set; }
        public Point MidPoint { get; private set; }
        public Point Point25 { get; private set; }
        public Point Point75 { get; private set; }
        public Point StartPoint { get; private set; }
        public double Width { get; private set; }
    }
}