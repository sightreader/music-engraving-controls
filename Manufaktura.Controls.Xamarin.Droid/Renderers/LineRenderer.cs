using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.Text.BoringLayout;

[assembly: ExportRenderer(typeof(Line), typeof(LineRenderer))]

namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class LineRenderer : VisualElementRenderer<Line>
	{
		public LineRenderer()
		{
			SetWillNotDraw(false);
		}

		protected override void OnDraw(Canvas canvas)
		{
			var rect = new Rect();
			GetDrawingRect(rect);

			var paint = new Paint();
			paint.Color = Element.Color.ToAndroidColor();
			paint.StrokeWidth = (float)Element.Thickness;
			paint.SetStyle(Paint.Style.Stroke);

			canvas.DrawLine((float)Element.TranslationX, (float)Element.TranslationY, (float)Element.EndX, (float)Element.EndY, paint);
		}


		private float ConvertPixelsToDp(float pixelValue)
		{
			return pixelValue * 0.2f;
		}
	}
}