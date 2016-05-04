using CoreGraphics;
using Manufaktura.Controls.Xamarin.IoS.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Arc), typeof(ArcRenderer))]

namespace Manufaktura.Controls.Xamarin.IoS.Renderers
{
	public class ArcRenderer : ViewRenderer<Arc, ArcRenderer>
	{
		public override void Draw(CGRect rect)
		{
			using (CGContext g = UIGraphics.GetCurrentContext())
			{
				g.AddArc((nfloat)Element.X, (nfloat)Element.Y, (nfloat)Element.RX, 0, (nfloat)Element.SweepAngle, true);
			}
		}
	}
}