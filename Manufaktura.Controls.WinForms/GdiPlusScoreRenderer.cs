using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Manufaktura.Controls.WinForms
{
    class GdiPlusScoreRenderer : ScoreRenderer<Graphics>
    {
        private Dictionary<Model.FontStyles, Font> _fonts = new Dictionary<Model.FontStyles, Font>();

        public override void DrawString(string text, Model.FontStyles fontStyle, Primitives.Point location)
        {
            Canvas.DrawString(text, _fonts[fontStyle], Brushes.Black, new PointF((float)location.X, (float)location.Y));
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, double thickness)
        {
            Canvas.DrawLine(new Pen(Brushes.Black, (float)thickness), new Point((int)startPoint.X, (int)startPoint.Y), new Point((int)endPoint.X, (int)endPoint.Y));
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, double thickness)
        {
            Canvas.DrawArc(new Pen(Brushes.Black, (float)thickness), new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height), (float)startAngle, (float)sweepAngle);
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, double thickness)
        {
            Canvas.DrawBezier(new Pen(Brushes.Black, (float)thickness), new Point((int)p1.X, (int)p1.Y), new Point((int)p2.X, (int)p2.Y), new Point((int)p3.X, (int)p3.Y), new Point((int)p4.X, (int)p4.Y));
        }
    }
}
