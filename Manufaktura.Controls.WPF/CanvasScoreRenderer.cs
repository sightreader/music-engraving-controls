using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Manufaktura.Controls.WPF
{
    class CanvasScoreRenderer : ScoreRenderer<Canvas>
    {
        public CanvasScoreRenderer(Canvas canvas) : base(canvas) 
        {
        }

        public override void DrawString(string text, Model.FontStyles fontStyle, Primitives.Point location, Primitives.Color color)
        {
            throw new NotImplementedException();
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen)
        {
            throw new NotImplementedException();
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen)
        {
            throw new NotImplementedException();
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen)
        {
            throw new NotImplementedException();
        }
    }
}
