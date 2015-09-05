using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Manufaktura.Controls.WPF
{
    public class DispatcherCanvasScoreRenderer : CanvasScoreRenderer
    {
        private readonly Dispatcher dispatcher;

        public DispatcherPriority Priority { get; set; }

        public DispatcherCanvasScoreRenderer(Dispatcher dispatcher, Canvas canvas)
            : base(canvas)
        {
            this.dispatcher = dispatcher;
            Priority = DispatcherPriority.Background;
        }

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner)
        {
            dispatcher.BeginInvoke(new Action<Rectangle, double, double, Pen, MusicalSymbol>(base.DrawArc), Priority, rect, startAngle, sweepAngle, pen, owner);
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner)
        {
            dispatcher.BeginInvoke(new Action<Point, Point, Point, Point, Pen, MusicalSymbol>(base.DrawBezier), p1, p2, p3, p4, pen, owner);
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner)
        {
            dispatcher.BeginInvoke(new Action<Point, Point, Pen, MusicalSymbol>(base.DrawLine), startPoint, endPoint, pen, owner);
        }

        public override void DrawString(string text, Model.Fonts.MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner)
        {
            dispatcher.BeginInvoke(new Action<string, Model.Fonts.MusicFontStyles, Point, Color, MusicalSymbol>(base.DrawString), text, fontStyle, location, color, owner);
        }
    }
}