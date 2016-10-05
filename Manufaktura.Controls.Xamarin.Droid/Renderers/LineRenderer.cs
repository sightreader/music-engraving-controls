using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
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
			paint.SetStyle(Paint.Style.FillAndStroke);

			canvas.DrawLine(ConvertPixelsToDp((float)Element.TranslationX), ConvertPixelsToDp((float)Element.TranslationY), ConvertPixelsToDp((float)Element.EndX), ConvertPixelsToDp((float)Element.EndY), paint);
		}

		private float ConvertPixelsToDp(float pixelValue)
		{
			var dp = ((pixelValue) / Resources.DisplayMetrics.Density);
			return dp;
		}
	}
}