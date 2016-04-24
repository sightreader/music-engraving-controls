using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Line), typeof(LineRenderer))]

namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class LineRenderer : ViewRenderer<Line, LineRenderer>
	{
		public LineRenderer()
		{
			SetWillNotDraw(false);
		}

		public override SizeRequest GetDesiredSize(int widthConstraint, int heightConstraint)
		{
			if (Element == null) return new SizeRequest(new Size(100, 100), new Size(100, 100));
			else return new SizeRequest(new Size(Math.Abs(Element.EndX - Element.X), Math.Abs(Element.EndY - Element.Y)),
				new Size(Math.Abs(Element.EndX - Element.X), Math.Abs(Element.EndY - Element.Y)));
			//return base.GetDesiredSize(widthConstraint, heightConstraint);
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);
			var paint = new Paint();
			paint.Color = Element.Color.ToAndroidColor();
			canvas.DrawLine((float)Element.X, (float)Element.Y, (float)Element.EndX, (float)Element.EndY, paint);
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Line> e)
		{
			base.OnElementChanged(e);
		}
	}
}