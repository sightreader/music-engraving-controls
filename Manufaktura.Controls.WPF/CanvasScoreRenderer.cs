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
    class CanvasScoreRenderer : ScoreRenderer<Canvas>
    {
        private Dictionary<Primitives.Pen, Pen> _penCache = new Dictionary<Primitives.Pen, Pen>();

        public CanvasScoreRenderer(Canvas canvas) : base(canvas) 
        {
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

        public override void DrawString(string text, Model.FontStyles fontStyle, Primitives.Point location, Primitives.Color color)
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
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen)
        {
        }
    }
}
