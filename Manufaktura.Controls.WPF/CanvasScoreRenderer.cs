using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WPF
{
    public class CanvasScoreRenderer : ScoreRenderer<Canvas>
    {
        private Dictionary<Primitives.Pen, Pen> _penCache = new Dictionary<Primitives.Pen, Pen>();
        public Dictionary<FrameworkElement, MusicalSymbol> OwnershipDictionary { get; private set; }

        public CanvasScoreRenderer(Canvas canvas)
            : base(canvas)
        {
            OwnershipDictionary = new Dictionary<FrameworkElement, MusicalSymbol>();
        }


        private Pen ConvertPen(Primitives.Pen pen)
        {
            Pen wpfPen;
            if (_penCache.ContainsKey(pen)) wpfPen = _penCache[pen];
            else
            {
                wpfPen = new Pen(new SolidColorBrush(ConvertColor(pen.Color)), pen.Thickness);
                _penCache.Add(pen, wpfPen);
            }
            return wpfPen;
        }

        private Color ConvertColor(Primitives.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private Point ConvertPoint(Primitives.Point point)
        {
            return new Point(point.X, point.Y);
        }

        public override void DrawString(string text, Model.FontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
        {
            TextBlock textBlock = new TextBlock();
            Typeface typeface = Fonts.Get(fontStyle);
            textBlock.FontSize = Fonts.GetSize(fontStyle);
            textBlock.FontFamily = typeface.FontFamily;
            textBlock.FontStretch = typeface.Stretch;
            textBlock.FontStyle = typeface.Style;
            textBlock.FontWeight = typeface.Weight;
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(ConvertColor(color));
            textBlock.Visibility = BoolToVisibility(owner.IsVisible);
            System.Windows.Controls.Canvas.SetLeft(textBlock, location.X + 3d);
            System.Windows.Controls.Canvas.SetTop(textBlock, location.Y);
            Canvas.Children.Add(textBlock);

            OwnershipDictionary.Add(textBlock, owner);
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
        {
            var line = new Line();
            line.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
            line.X1 = startPoint.X;
            line.X2 = endPoint.X;
            line.Y1 = startPoint.Y;
            line.Y2 = endPoint.Y;
            line.StrokeThickness = pen.Thickness;
            line.Visibility = BoolToVisibility(owner.IsVisible);
            Canvas.Children.Add(line);

            OwnershipDictionary.Add(line, owner);
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
        {
            PathGeometry pathGeom = new PathGeometry();
            PathFigure pf = new PathFigure();
            pf.StartPoint = new Point(rect.X, rect.Y);
            ArcSegment arcSeg = new ArcSegment();
            arcSeg.Point = new Point(rect.X + rect.Width, rect.Y);
            arcSeg.RotationAngle = startAngle;
            arcSeg.Size = new Size(rect.Width, rect.Height);
            arcSeg.SweepDirection = sweepAngle < 180 ? SweepDirection.Counterclockwise : SweepDirection.Clockwise;
            arcSeg.IsLargeArc = sweepAngle > 180;
            pf.Segments.Add(arcSeg);
            pathGeom.Figures.Add(pf);

            Path path = new Path();
            path.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
            path.StrokeThickness = pen.Thickness;
            path.Data = pathGeom;
            path.Visibility = BoolToVisibility(owner.IsVisible);
            Canvas.Children.Add(path);

            OwnershipDictionary.Add(path, owner);
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
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
            path.StrokeThickness = pen.Thickness;
            path.Data = pathGeom;
            path.Visibility = BoolToVisibility(owner.IsVisible);
            Canvas.Children.Add(path);

            OwnershipDictionary.Add(path, owner);
        }

        private Visibility BoolToVisibility(bool isVisible)
        {
            return isVisible ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
