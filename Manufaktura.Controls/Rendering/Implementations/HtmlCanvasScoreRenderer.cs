using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlCanvasScoreRenderer : ScoreRenderer<StringBuilder>
    {
        public Dictionary<FontStyles, HtmlFontInfo> Fonts { get; private set; }

        public HtmlCanvasScoreRenderer(StringBuilder stringBuilder, Dictionary<FontStyles, HtmlFontInfo> fonts, string canvasName = null, bool addFontFaceDeclaration = true)
            : base(stringBuilder)
        {
            Fonts = fonts;

            if (addFontFaceDeclaration)
            {
                stringBuilder.AppendLine("<style type=\"text/css\">");
                foreach (var font in Fonts.Values)
                {
                    stringBuilder.AppendLine("@font-face {");
                    stringBuilder.AppendLine(string.Format("font-family: '{0}';", font.Name));
                    stringBuilder.AppendLine(string.Format("src: url('{0}') format('{1}');", font.Uri, GetFormatFromUri(font.Uri)));
                    stringBuilder.AppendLine("}");
                }
                stringBuilder.AppendLine("</style>");
            }

            stringBuilder.AppendLine(string.Format("<canvas id=\"{0}\" width=\"778\" height=\"200\"></canvas>", string.IsNullOrWhiteSpace(canvasName) ? "myCanvas" : canvasName));
            stringBuilder.AppendLine("<script>");
            stringBuilder.AppendLine(string.Format("var canvas = document.getElementById('{0}');", string.IsNullOrWhiteSpace(canvasName) ? "myCanvas" : canvasName));
            stringBuilder.AppendLine("var context = canvas.getContext('2d');");
        }

        public override void DrawString(string text, FontStyles fontStyle, Primitives.Point location, Primitives.Color color, Model.MusicalSymbol owner)
        {
            if (!Fonts.ContainsKey(fontStyle)) return;   //Nie ma takiego fontu zdefiniowanego. Nie rysuj.

            double locationY = location.Y + 25d;
            double locationX = location.X + 3d;
            Canvas.AppendLine(string.Format("context.font = '{0}pt {1}';", Fonts[fontStyle].Size.ToString(CultureInfo.InvariantCulture), Fonts[fontStyle].Name));
            Canvas.AppendLine(string.Format("context.fillText('{0}', {1}, {2});", text, locationX.ToString(CultureInfo.InvariantCulture), locationY.ToString(CultureInfo.InvariantCulture)));
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
            Canvas.AppendLine("context.beginPath();");
            Canvas.AppendLine(string.Format("context.moveTo({0}, {1});", startPoint.X.ToString(CultureInfo.InvariantCulture), startPoint.Y.ToString(CultureInfo.InvariantCulture)));
            Canvas.AppendLine(string.Format("context.lineTo({0}, {1});", endPoint.X.ToString(CultureInfo.InvariantCulture), endPoint.Y.ToString(CultureInfo.InvariantCulture)));
            Canvas.AppendLine("context.stroke();");
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
        }

        private string GetFormatFromUri(string uri)
        {
            uri = uri.ToLower();
            if (uri.EndsWith("ttf")) return "truetype";
            if (uri.EndsWith("woff")) return "woff";
            return null;
        }

        public struct HtmlFontInfo
        {
            public string Name { get; private set; }
            public string Uri { get; private set; }
            public double Size { get; private set; }

            public HtmlFontInfo(string name, string uri, double size) : this()
            {
                Name = name;
                Uri = uri;
                Size = size;
            }

        }
    }
}
