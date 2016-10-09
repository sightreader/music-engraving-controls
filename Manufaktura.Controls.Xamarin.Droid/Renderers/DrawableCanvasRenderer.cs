using Android.Graphics;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using System.ComponentModel;
using System.Linq;
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

		public override SizeRequest GetDesiredSize(int widthConstraint, int heightConstraint)
		{
			if (!Element.Children.OfType<ManufakturaShape>().Any()) return new SizeRequest(new Size(0, 0));

			var bottomMostShape = Element.Children.OfType<ManufakturaShape>().OrderByDescending(s => s.TranslationY).First();
			var rightMostShape = Element.Children.OfType<ManufakturaShape>().OrderByDescending(s => s.TranslationX).First();

			return new SizeRequest(new Size(rightMostShape.TranslationX + 10, bottomMostShape.TranslationY + 10));
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);

			foreach (var child in Element.Children)
			{
				var line = child as Line;
				if (line != null)
				{
					canvas.DrawLine((float)line.TranslationX, (float)line.TranslationY, (float)line.EndX, (float)line.EndY, GetPaint(line));
					continue;
				}

				var text = child as Text;
				if (text != null)
				{
					Typeface font;

					if (text.FontStyle == MusicFontStyles.MusicFont || text.FontStyle == MusicFontStyles.GraceNoteFont || text.FontStyle == MusicFontStyles.StaffFont) font = Typeface.CreateFromAsset(Forms.Context.Assets, "Polihymnia.ttf");
					else if (text.FontAttributes.HasFlag(FontAttributes.Bold)) font = Typeface.DefaultBold;
					else font = Typeface.SansSerif;

					var paint = new Paint();
					paint.Color = text.TextColor.ToAndroid();
					paint.SetStyle(Paint.Style.FillAndStroke);
					paint.SetTypeface(font);
					paint.AntiAlias = true;
					paint.TextSize = (float)text.FontSize;

					if (text.FontStyle == MusicFontStyles.MusicFont || text.FontStyle == MusicFontStyles.StaffFont)
						canvas.DrawText(text.Text, (float)text.TranslationX + 3, (float)text.TranslationY + 24, paint);
					else if (text.FontStyle == MusicFontStyles.GraceNoteFont)
						canvas.DrawText(text.Text, (float)text.TranslationX + 3, (float)text.TranslationY + 18, paint);
					else
						canvas.DrawText(text.Text, (float)text.TranslationX + 3, (float)text.TranslationY + 13, paint);

					continue;
				}

				var arc = child as Arc;
				if (arc != null)
				{
					canvas.DrawArc(new RectF((float)arc.TranslationX, (float)arc.TranslationY - 10, (float)arc.RX + (float)arc.TranslationX, (float)arc.RY + (float)arc.TranslationY - 10),
						(float)arc.StartAngle, (float)arc.SweepAngle * -1, false, GetPaint(arc));

					continue;
				}

				var bezier = child as BezierCurve;
				if (bezier != null)
				{
					var path = new Path();
					path.MoveTo((float)bezier.TranslationX, (float)bezier.TranslationY);

					path.CubicTo((float)bezier.X2, (float)bezier.Y2, (float)bezier.X3, (float)bezier.Y3, (float)bezier.X4, (float)bezier.Y4);
					canvas.DrawPath(path, GetPaint(bezier));
					continue;
				}
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == nameof(NoteViewer.ScoreSource) || e.PropertyName == nameof(NoteViewer.XmlSource)) Invalidate();
		}
		private static Paint GetPaint(ManufakturaShape shape)
		{
			var paint = new Paint();
			paint.Color = shape.Color.ToAndroidColor();
			paint.SetStyle(Paint.Style.Stroke);
			paint.AntiAlias = true;
			paint.StrokeWidth = (float)shape.Thickness;
			return paint;
		}
	}
}