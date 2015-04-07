using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlCanvasScoreRenderer : ScoreRenderer<StringBuilder>
    {
        public HtmlScoreRendererSettings TypedSettings { get { return Settings as HtmlScoreRendererSettings; } }

        public HtmlCanvasScoreRenderer(StringBuilder stringBuilder, string canvasName, HtmlScoreRendererSettings settings)
            : base(stringBuilder)
        {
            Settings = settings;

            stringBuilder.AppendLine(string.Format("var canvas = document.getElementById('{0}');", canvasName));
            stringBuilder.AppendLine("var context = canvas.getContext('2d');");
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, Model.MusicalSymbol owner)
        {
            if (!TypedSettings.Fonts.ContainsKey(fontStyle)) return;   //Nie ma takiego fontu zdefiniowanego. Nie rysuj.

            double locationX = location.X + 3d;
            double locationY;
            switch (fontStyle)
            {
                case MusicFontStyles.MusicFont:
                    locationY = location.Y + 25d;
                    break;
                case MusicFontStyles.GraceNoteFont:
                    locationY = location.Y + 17.5d;
                    locationX += 0.7d;
                    break;
                default:
                    locationY = location.Y + 14d;
                    break;
            }
            
            Canvas.AppendLine(string.Format("context.font = '{0}pt {1}';", TypedSettings.Fonts[fontStyle].Size.ToString(CultureInfo.InvariantCulture), TypedSettings.Fonts[fontStyle].Name));
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
            Canvas.AppendLine("context.beginPath();");
            Canvas.AppendLine(string.Format("context.arc({0},{1},{2},{3},{4});", rect.X.ToString(CultureInfo.InvariantCulture), rect.Y.ToString(CultureInfo.InvariantCulture),
                rect.Height.ToString(CultureInfo.InvariantCulture), 
                UsefulMath.GradToRadians(startAngle).ToString(CultureInfo.InvariantCulture), 
                UsefulMath.GradToRadians(sweepAngle).ToString(CultureInfo.InvariantCulture)));
            Canvas.AppendLine("context.stroke();");
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
            Canvas.AppendLine("context.beginPath();");
            Canvas.AppendLine(string.Format("context.moveTo({0}, {1});", p1.X.ToString(CultureInfo.InvariantCulture), p1.Y.ToString(CultureInfo.InvariantCulture)));
            Canvas.AppendLine(string.Format("context.bezierCurveTo({0},{1},{2},{3},{4},{5});", 
                p2.X.ToString(CultureInfo.InvariantCulture),
                p2.Y.ToString(CultureInfo.InvariantCulture), 
                p3.X.ToString(CultureInfo.InvariantCulture),
                p3.Y.ToString(CultureInfo.InvariantCulture), 
                p4.X.ToString(CultureInfo.InvariantCulture), 
                p4.Y.ToString(CultureInfo.InvariantCulture)));
            Canvas.AppendLine("context.stroke();");
        }
    }
    public struct HtmlFontInfo
    {
        public string Name { get; private set; }
        public string Uri { get; private set; }
        public double Size { get; private set; }

        public HtmlFontInfo(string name, string uri, double size)
            : this()
        {
            Name = name;
            Uri = uri;
            Size = size;
        }

    }
}
