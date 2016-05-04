using CoreGraphics;
using Manufaktura.Controls.Xamarin.IoS.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BezierCurve), typeof(BezierCurveRenderer))]

namespace Manufaktura.Controls.Xamarin.IoS.Renderers
{
	public class BezierCurveRenderer : ViewRenderer<BezierCurve, BezierCurveRenderer>
	{
		public override void Draw(CGRect rect)
		{
			using (CGContext g = UIGraphics.GetCurrentContext())
			{
				
			}
		}
	}
}