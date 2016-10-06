using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Text), typeof(TextRenderer))]

namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class TextRenderer : VisualElementRenderer<Text>
	{
		public TextRenderer()
		{
			SetWillNotDraw(false);
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);

			Typeface font = (Element.FontFamily == "Polihymnia") ? Typeface.CreateFromAsset(Forms.Context.Assets, "Polihymnia.ttf") : Typeface.SansSerif;

			var paint = new Paint();
			paint.Color = Android.Graphics.Color.Black;
			paint.SetStyle(Paint.Style.FillAndStroke);
			paint.SetTypeface(font);
			paint.TextSize = (float)Element.FontSize;
			
			canvas.DrawText(Element.Text, (float)Element.TranslationX, (float)Element.TranslationY, paint);
		}


	}
}