using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BezierCurve), typeof(BezierCurveRenderer))]

namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class BezierCurveRenderer : ViewRenderer<BezierCurve, BezierCurveRenderer>
	{
		public BezierCurveRenderer()
		{
			SetWillNotDraw(false);
		}

		public override SizeRequest GetDesiredSize(int widthConstraint, int heightConstraint)
		{
			return new SizeRequest(new Size(100, 100), new Size(100, 100));
			return base.GetDesiredSize(widthConstraint, heightConstraint);
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);
			var paint = new Paint();
			paint.Color = Element.Color.ToAndroidColor();
		}
	}
}