using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin
{
	public class AbsoluteLayoutScoreRenderer : ScoreRenderer<AbsoluteLayout>
	{
		public Dictionary<VisualElement, MusicalSymbol> OwnershipDictionary { get; private set; }

		public AbsoluteLayoutScoreRenderer(AbsoluteLayout canvas) : base(canvas)
		{
			OwnershipDictionary = new Dictionary<VisualElement, MusicalSymbol>();
		}

		public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner)
		{
		}

		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Pen pen, MusicalSymbol owner)
		{
		}

		public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Pen pen, MusicalSymbol owner)
		{
			//BoxView
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
		{
			//Label
		}

		public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
		{
		}
	}
}