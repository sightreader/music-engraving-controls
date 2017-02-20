using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Extensions;
using Manufaktura.Music.Model;
using System.Collections.Generic;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
	public struct HtmlFontInfo
	{
		public HtmlFontInfo(string name, double size, params string[] uris)
			: this()
		{
			Uris = new List<string>();
			Name = name;
			Uris.AddRange(uris);
			Size = size;
		}

		public string Name { get; private set; }

		public double Size { get; private set; }

		public List<string> Uris { get; private set; }
	}

	public class HtmlCanvasScoreRenderer : HtmlScoreRenderer<StringBuilder>
	{
		public HtmlCanvasScoreRenderer()
			: base(null)
		{
		}

		public HtmlCanvasScoreRenderer(StringBuilder stringBuilder, string canvasName, HtmlScoreRendererSettings settings)
			: base(stringBuilder)
		{
			Settings = settings;

			stringBuilder.AppendLine(string.Format("var canvas = document.getElementById('{0}');", canvasName));
			stringBuilder.AppendLine("var context = canvas.getContext('2d');");
		}

		public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, Model.MusicalSymbol owner)
		{
			Canvas.AppendLine("context.beginPath();");
			Canvas.AppendLine(string.Format("context.arc({0},{1},{2},{3},{4});", rect.X.ToStringInvariant(), rect.Y.ToStringInvariant(),
				rect.Height.ToStringInvariant(),
				UsefulMath.GradToRadians(startAngle).ToStringInvariant(),
				UsefulMath.GradToRadians(sweepAngle).ToStringInvariant()));
			Canvas.AppendLine("context.stroke();");

            if (rect.X + rect.Width > ActualWidth) ActualWidth = rect.X + rect.Width;
            if (rect.Y + rect.Height > ActualHeight) ActualHeight = rect.Y + rect.Height;
        }

		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, Model.MusicalSymbol owner)
		{
			Canvas.AppendLine("context.beginPath();");
			Canvas.AppendLine(string.Format("context.moveTo({0}, {1});", p1.X.ToStringInvariant(), p1.Y.ToStringInvariant()));
			Canvas.AppendLine(string.Format("context.bezierCurveTo({0},{1},{2},{3},{4},{5});",
				p2.X.ToStringInvariant(),
				p2.Y.ToStringInvariant(),
				p3.X.ToStringInvariant(),
				p3.Y.ToStringInvariant(),
				p4.X.ToStringInvariant(),
				p4.Y.ToStringInvariant()));
			Canvas.AppendLine("context.stroke();");

            if (p4.X > ActualWidth) ActualWidth = p4.X;
            if (p1.Y > ActualHeight) ActualHeight = p1.Y;
		}

		public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, Model.MusicalSymbol owner)
		{
			Canvas.AppendLine("context.beginPath();");
			Canvas.AppendLine(string.Format("context.moveTo({0}, {1});", startPoint.X.ToStringInvariant(), startPoint.Y.ToStringInvariant()));
			Canvas.AppendLine(string.Format("context.lineTo({0}, {1});", endPoint.X.ToStringInvariant(), endPoint.Y.ToStringInvariant()));
			Canvas.AppendLine("context.stroke();");

            if (startPoint.X > ActualWidth) ActualWidth = startPoint.X;
            if (endPoint.X > ActualWidth) ActualWidth = endPoint.X;
            if (startPoint.Y > ActualHeight) ActualHeight = startPoint.Y;
			if (endPoint.Y > ActualHeight) ActualHeight = endPoint.Y;
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, Model.MusicalSymbol owner)
		{
			if (!TypedSettings.Fonts.ContainsKey(fontStyle)) return;   //Nie ma takiego fontu zdefiniowanego. Nie rysuj.

			location = TranslateTextLocation(location, fontStyle);

			Canvas.AppendLine(string.Format("context.font = '{0}pt {1}';", TypedSettings.Fonts[fontStyle].Size.ToStringInvariant(), TypedSettings.Fonts[fontStyle].Name));
			Canvas.AppendLine(string.Format("context.fillText('{0}', {1}, {2});", text, location.X.ToStringInvariant(), location.Y.ToStringInvariant()));

            if (location.X > ActualWidth) ActualWidth = location.X;
            if (location.Y > ActualHeight) ActualHeight = location.Y;
		}

		public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Point location, Size size, Color color, MusicalSymbol owner)
		{
		}

		protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Point start, Point end)
		{
		}
	}
}