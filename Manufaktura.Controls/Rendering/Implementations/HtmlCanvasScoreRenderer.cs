using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlCanvasScoreRenderer : ScoreRenderer<StringBuilder>
    {
        public HtmlCanvasScoreRenderer(StringBuilder stringBuilder) : base(stringBuilder)
        {
            stringBuilder.AppendLine("<canvas id=\"myCanvas\" width=\"578\" height=\"200\"></canvas>");
            stringBuilder.AppendLine("<script>");
            stringBuilder.AppendLine("var canvas = document.getElementById('myCanvas');");
            stringBuilder.AppendLine("var context = canvas.getContext('2d');");
        }

        public override void DrawString(string text, Model.FontStyles fontStyle, Primitives.Point location, Primitives.Color color, Model.MusicalSymbol owner)
        {
            //Canvas.AppendLine("context.font = 'italic 40pt Calibri';");
            //Canvas.AppendLine("context.fillText('Hello World!', 150, 100);");
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
            Canvas.AppendLine("context.beginPath();");
            Canvas.AppendLine(string.Format("context.moveTo({0}, {1});", startPoint.X, startPoint.Y));
            Canvas.AppendLine(string.Format("context.lineTo({0}, {1});", endPoint.X, endPoint.Y));
            Canvas.AppendLine("context.stroke();");
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
        }
    }
}
