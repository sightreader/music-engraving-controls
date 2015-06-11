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
            if (!TypedSettings.Fonts.ContainsKey(fontStyle)) return;   //Nie ma takiego fontu zdefiniowanego. Nie rysuj.

            double locationX = location.X + 3.5d + TypedSettings.MusicalFontShiftX;
            double locationY;
            switch (fontStyle)
            {
                case MusicFontStyles.MusicFont:
                    locationY = location.Y + 25d + TypedSettings.MusicalFontShiftY;
                    break;
                case MusicFontStyles.GraceNoteFont:
                    locationY = location.Y + 17.5d + TypedSettings.MusicalFontShiftY;
                    locationX += 0.7d;
                    break;
                default:
                    locationY = location.Y + 13d + TypedSettings.MusicalFontShiftY;
                    break;
            }

            var element = new XElement("text",
                new XAttribute("x", locationX.ToStringInvariant()),
                new XAttribute("y", locationY.ToStringInvariant()),
                new XAttribute("style", string.Format("font-color:{0}; font-size:{1}; font-family: {2};",
                    color.ToCss(), 
                    TypedSettings.Fonts[fontStyle].Size.ToStringInvariant(),
                    TypedSettings.Fonts[fontStyle].Name)));
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
            var element = new XElement("path",
                new XAttribute("d", string.Format("M{0},{1} A{2},{3} {4} {5},{6} {7},{8}",
                    rect.X.ToStringInvariant(),
                    rect.Y.ToStringInvariant(),
                    rect.Height.ToStringInvariant(),
                    rect.Width.ToStringInvariant(),
                    startAngle.ToStringInvariant(),
                    0,
                    1,
                    (rect.X + rect.Width).ToStringInvariant(),
                    (rect.Y + rect.Height).ToStringInvariant())),
                new XAttribute("style", pen.ToCss()));

            Canvas.Add(element);
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
