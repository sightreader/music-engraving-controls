using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Extensions;
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
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, Model.MusicalSymbol owner)
        {
            string html = string.Format("<text x=\"{0}\" y=\"{1}\" fill=\"{2}\">{3}</text>", 
                location.X.ToStringInvariant(), 
                location.Y.ToStringInvariant(),
                "black",
                text);
            Canvas.Append(html);
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, Model.MusicalSymbol owner)
        {
            string html = string.Format("<line x1=\"{0}\" y1=\"{1}\" x2=\"{2}\" y2=\"{3}\" style=\"stroke:rgb({4},{5},{6});stroke-width:{7}\" />",
                startPoint.X.ToStringInvariant(),
                startPoint.Y.ToStringInvariant(),
                endPoint.X.ToStringInvariant(),
                endPoint.Y.ToStringInvariant(),
                pen.Color.R.ToStringInvariant(),
                pen.Color.G.ToStringInvariant(),
                pen.Color.B.ToStringInvariant(),
                pen.Thickness.ToStringInvariant()
                );
            Canvas.Append(html);
        }

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, Model.MusicalSymbol owner)
        {
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, Model.MusicalSymbol owner)
        {
        }
    }
}
