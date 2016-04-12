using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin
{
	public class AbsoluteLayoutScoreRenderer : ScoreRenderer<AbsoluteLayout>
	{
		public AbsoluteLayoutScoreRenderer(AbsoluteLayout canvas) : base(canvas)
		{
			OwnershipDictionary = new Dictionary<VisualElement, MusicalSymbol>();
		}

		public Dictionary<VisualElement, MusicalSymbol> OwnershipDictionary { get; private set; }

		public Color ConvertColor(Primitives.Color color)
		{
			return Color.FromRgba(color.R, color.G, color.B, color.A);
		}

		public Primitives.Color ConvertColor(Color color)
		{
			return new Primitives.Color((byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255), (byte)(color.A * 255));
		}

		public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
		{
		}

		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
		{
		}

		public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
		{
			if (!Settings.IsPanoramaMode)
			{
				startPoint = startPoint.Translate(CurrentScore.DefaultPageSettings);
				endPoint = endPoint.Translate(CurrentScore.DefaultPageSettings);
			}

			var line = new BoxView();
			line.AnchorX = startPoint.X;
			line.AnchorY = startPoint.Y;
			line.WidthRequest = endPoint.X - startPoint.X;
			line.HeightRequest = 1;
			line.Color = Color.Black;

			Canvas.Children.Add(line);

			OwnershipDictionary.Add(line, owner);
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
		{
			if (!Settings.IsPanoramaMode) location = location.Translate(CurrentScore.DefaultPageSettings);

			var label = new Label();
			label.AnchorX = location.X;
			label.AnchorY = location.Y;
			label.Text = text;
			label.FontFamily = Fonts.Get(fontStyle).FontFamily;
			label.FontAttributes = Fonts.Get(fontStyle).Attributes;
			label.FontSize = Fonts.Get(fontStyle).FontSize;
			label.TextColor = Color.Black;

			Canvas.Children.Add(label);

			OwnershipDictionary.Add(label, owner);
		}

		public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
		{
		}
	}
}