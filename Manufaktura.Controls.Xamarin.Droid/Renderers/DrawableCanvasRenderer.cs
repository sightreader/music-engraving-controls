using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DrawableCanvas), typeof(DrawableCanvasRenderer))]

namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class DrawableCanvasRenderer : VisualElementRenderer<DrawableCanvas>
	{
		public DrawableCanvasRenderer()
		{
			SetWillNotDraw(false);
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);

			foreach (var child in Element.Children)
			{
				var line = child as Line;
				if (line != null)
				{
					var paint = new Paint();
					paint.Color = line.Color.ToAndroidColor();
					paint.StrokeWidth = (float)line.Thickness;
					paint.SetStyle(Paint.Style.Stroke);
					paint.AntiAlias = true;

					canvas.DrawLine((float)line.TranslationX, (float)line.TranslationY, (float)line.EndX, (float)line.EndY, paint);
					continue;
				}

				var text = child as Text;
				if (text != null)
				{
					Typeface font;

					if (text.FontFamily == "Polihymnia") font = Typeface.CreateFromAsset(Forms.Context.Assets, "Polihymnia.ttf");
					else if (text.FontAttributes.HasFlag(FontAttributes.Bold)) font = Typeface.DefaultBold;
					else font = Typeface.SansSerif;

					var paint = new Paint();
					paint.Color = text.TextColor.ToAndroid();
					paint.SetStyle(Paint.Style.FillAndStroke);
					paint.SetTypeface(font);
					paint.AntiAlias = true;
					paint.TextSize = (float)text.FontSize;

					if (text.FontFamily == "Polihymnia")
						canvas.DrawText(text.Text, (float)text.TranslationX + 3, (float)text.TranslationY + 24, paint);
					else
						canvas.DrawText(text.Text, (float)text.TranslationX + 3, (float)text.TranslationY + 13, paint);

					continue;
				}

				var arc = child as Arc;
				if (arc != null)
				{
					var paint = new Paint();
					paint.Color = arc.Color.ToAndroidColor();
					paint.SetStyle(Paint.Style.Stroke);
					paint.AntiAlias = true;
					paint.StrokeWidth = (float)arc.Thickness;
					canvas.DrawArc(new RectF((float)arc.X, (float)arc.Y, (float)arc.RX, (float)arc.RY), (float)arc.SweepAngle, (float)arc.SweepAngle, false, paint);
				}
			}
		}
	}
}