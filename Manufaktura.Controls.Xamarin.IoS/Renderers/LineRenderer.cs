using CoreGraphics;
using Manufaktura.Controls.Xamarin.IoS.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Line), typeof(LineRenderer))]

namespace Manufaktura.Controls.Xamarin.IoS.Renderers
{
	public class LineRenderer : ViewRenderer<Line, LineRenderer>
	{
		public override void Draw(CGRect rect)
		{
			using (CGContext g = UIGraphics.GetCurrentContext())
			{
				g.AddLines(new[] { new CGPoint(Element.TranslationX, Element.TranslationY), new CGPoint(Element.EndX, Element.EndY) });
			}
		}
	}
}