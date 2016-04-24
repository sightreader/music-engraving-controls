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
			else return new SizeRequest(new Size(Math.Abs(Element.EndX - Element.TranslationX), Math.Abs(Element.EndY - Element.TranslationY)),
				new Size(Math.Abs(Element.EndX - Element.X), Math.Abs(Element.EndY - Element.Y)));
			//return base.GetDesiredSize(widthConstraint, heightConstraint);
		}

		protected override void OnDraw(Canvas canvas)
		{
			//canvas.m
			//base.OnDraw(canvas);
			var paint = new Paint();
			paint.Color = Element.Color.ToAndroidColor();
			paint.StrokeWidth = (float)Element.Thickness;
			paint.SetStyle(Paint.Style.FillAndStroke);
			System.Diagnostics.Debug.WriteLine($"Drawing line [{Element.TranslationX}, {Element.TranslationY}] to [{Element.EndX}, {Element.EndY}]");

			/*
			var path = new Path();
			path.MoveTo((float)Element.TranslationX, (float)Element.TranslationY);
			path.LineTo((float)Element.EndX, (float)Element.EndY);

			var shape = new ShapeDrawable(new PathShape(path, (float)Element.EndX - (float)Element.TranslationX, (float)Element.EndY - (float)Element.TranslationY));
			shape.Paint.Set(paint);

			shape.Draw(canvas);
			*/
			canvas.DrawLine((float)Element.TranslationX, (float)Element.TranslationY, (float)Element.EndX, (float)Element.EndY, paint);
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Line> e)
		{
			base.OnElementChanged(e);
		}
	}
}