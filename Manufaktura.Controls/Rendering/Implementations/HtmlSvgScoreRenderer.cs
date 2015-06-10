using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlSvgScoreRenderer : HtmlScoreRenderer
    {
        public HtmlSvgScoreRenderer() : base(null)
        {
        }

        public HtmlSvgScoreRenderer(StringBuilder stringBuilder, string svgCanvasName, HtmlScoreRendererSettings settings)
            : base(stringBuilder)
        {
            Settings = settings;

            stringBuilder.AppendLine(string.Format("var canvas = document.getElementById('{0}');", svgCanvasName));
            stringBuilder.AppendLine("var context = canvas.getContext('2d');");
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, Model.MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, Model.MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, Model.MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, Model.MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }
    }
}
