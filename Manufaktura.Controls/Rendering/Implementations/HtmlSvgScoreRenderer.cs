using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlSvgScoreRenderer : HtmlScoreRenderer<XElement>
    {
        public HtmlSvgScoreRenderer()
            : base(null)
        {
        }

        public HtmlSvgScoreRenderer(XElement element, string svgCanvasName, HtmlScoreRendererSettings settings)
            : base(element)
        {
            Settings = settings;
        }


        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, Model.MusicalSymbol owner)
        {
            var element = new XElement("text",
                new XAttribute("x", location.X.ToStringInvariant()),
                new XAttribute("y", location.Y.ToStringInvariant()),
                new XAttribute("style", string.Format("font-color:{0};", color.ToCss())));
            element.Value = text;
            Canvas.Add(element);
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, Model.MusicalSymbol owner)
        {
            var element = new XElement("line",
                new XAttribute("x1", startPoint.X.ToStringInvariant()),
                new XAttribute("y1", startPoint.Y.ToStringInvariant()),
                new XAttribute("x2", endPoint.X.ToStringInvariant()),
                new XAttribute("y2", endPoint.Y.ToStringInvariant()),
                new XAttribute("style", pen.ToCss()));

            Canvas.Add(element);
        }

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, Model.MusicalSymbol owner)
        {
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, Model.MusicalSymbol owner)
        {
            var element = new XElement("path",
                new XAttribute("d", string.Format("M{0},{1} C{2},{3} {4},{5} {6},{7}",
                    p1.X.ToStringInvariant(),
                    p1.Y.ToStringInvariant(),
                    p2.X.ToStringInvariant(),
                    p2.Y.ToStringInvariant(),
                    p3.X.ToStringInvariant(),
                    p3.Y.ToStringInvariant(),
                    p4.X.ToStringInvariant(),
                    p4.Y.ToStringInvariant())),
                new XAttribute("style", pen.ToCss()));

            Canvas.Add(element);
        }
    }
}
