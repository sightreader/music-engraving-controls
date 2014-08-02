using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.Silverlight
{
    class CanvasScoreRenderer : ScoreRenderer<Canvas>
    {

        public CanvasScoreRenderer(Canvas canvas)
            : base(canvas)
        {
        }

        private Color ConvertColor(Primitives.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private Point ConvertPoint(Primitives.Point point)
        {
            return new Point(point.X, point.Y);
        }

        public override void DrawString(string text, Model.FontStyles fontStyle, Primitives.Point location, Primitives.Color color)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.FontSize = Fonts.GetSize(fontStyle);
            textBlock.FontFamily = Fonts.Get(fontStyle);
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(ConvertColor(color));
            System.Windows.Controls.Canvas.SetLeft(textBlock, location.X + 3d);
            System.Windows.Controls.Canvas.SetTop(textBlock, location.Y);
            Canvas.Children.Add(textBlock);
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen)
        {
            var line = new Line();
            line.Stroke = new SolidColorBrush(ConvertColor(pen.Color));

            line.X1 = startPoint.X;
            line.X2 = endPoint.X;
            line.Y1 = startPoint.Y;
            line.Y2 = endPoint.Y;

            line.StrokeThickness = pen.Thickness;
            Canvas.Children.Add(line);
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen)
        {
            PathGeometry pathGeom = new PathGeometry();
            PathFigure pf = new PathFigure();
            pf.StartPoint = new Point(rect.X, rect.Y);
            ArcSegment arcSeg = new ArcSegment();
            arcSeg.Point = new Point(rect.X + rect.Width, rect.Y + rect.Height);
            arcSeg.RotationAngle = startAngle;
            pf.Segments.Add(arcSeg);
            pathGeom.Figures.Add(pf);

            Path path = new Path();
            path.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
            path.Data = pathGeom;
            Canvas.Children.Add(path);
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen)
        {
            PathGeometry pathGeom = new PathGeometry();
            PathFigure pf = new PathFigure();
            pf.StartPoint = new Point(p1.X, p1.Y);
            BezierSegment bezierSegment = new BezierSegment();
            bezierSegment.Point1 = ConvertPoint(p2);
            bezierSegment.Point2 = ConvertPoint(p3);
            bezierSegment.Point3 = ConvertPoint(p4);
            pf.Segments.Add(bezierSegment);
            pathGeom.Figures.Add(pf);

            Path path = new Path();
            path.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
            path.Data = pathGeom;
            Canvas.Children.Add(path);
        }
    }
}
