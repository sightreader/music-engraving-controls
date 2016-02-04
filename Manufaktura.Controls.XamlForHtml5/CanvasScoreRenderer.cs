using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using Windows.UI.Xaml.Controls;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI;
using Windows.Foundation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Manufaktura.Controls.XamlForHtml5
{
	public class CanvasScoreRenderer : ScoreRenderer<Canvas>
	{
		public Dictionary<FrameworkElement, MusicalSymbol> OwnershipDictionary { get; private set; }

		public CanvasScoreRenderer(Canvas canvas)
			: base(canvas)
		{
			OwnershipDictionary = new Dictionary<FrameworkElement, MusicalSymbol>();
		}

		public Color ConvertColor(Primitives.Color color)
		{
			return Color.FromArgb(color.A, color.R, color.G, color.B);
		}

		public Primitives.Color ConvertColor(Color color)
		{
			return new Primitives.Color(color.R, color.G, color.B, color.A);
		}

		public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
		{
			if (!Settings.IsPanoramaMode) rect = rect.Translate(CurrentScore.DefaultPageSettings);

			if (rect.Width < 0 || rect.Height < 0) return;  //TODO: Sprawdzić czemu tak się dzieje, poprawić
			PathGeometry pathGeom = new PathGeometry();
			PathFigure pf = new PathFigure();
			pf.StartPoint = new Point(rect.X, rect.Y);
			ArcSegment arcSeg = new ArcSegment();
			arcSeg.Point = new Point(rect.X + rect.Width, rect.Y);
			arcSeg.RotationAngle = startAngle;
			arcSeg.Size = new Size(rect.Width, rect.Height);
			arcSeg.SweepDirection = sweepAngle < 180 ? SweepDirection.Counterclockwise : SweepDirection.Clockwise;
			arcSeg.IsLargeArc = sweepAngle > 180;
			pf.Segments.Add(arcSeg);
			pathGeom.Figures.Add(pf);

			Path path = new Path();
			path.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
			path.StrokeThickness = pen.Thickness;
			path.Data = pathGeom;
			path.Visibility = BoolToVisibility(owner.IsVisible);
			Canvas.SetZIndex(path, (int)pen.ZIndex);
			Canvas.Children.Add(path);

			OwnershipDictionary.Add(path, owner);
		}

		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
		{
			if (!Settings.IsPanoramaMode)
			{
				p1 = p1.Translate(CurrentScore.DefaultPageSettings);
				p2 = p2.Translate(CurrentScore.DefaultPageSettings);
				p3 = p3.Translate(CurrentScore.DefaultPageSettings);
				p4 = p4.Translate(CurrentScore.DefaultPageSettings);
			}

			PathGeometry pathGeom = new PathGeometry();
			PathFigure pf = new PathFigure();
			pf.StartPoint = new Point(p1.X, p1.Y);
			BezierSegment bezierSegment = new BezierSegment();
			bezierSegment.Point1 = ConvertPoint(p2);
			bezierSegment.Point2 = ConvertPoint(p3);
			bezierSegment.Point3 = ConvertPoint(p4);
			pf.Segments.Add(bezierSegment);
			pathGeom.Figures.Add(pf);

			Path path = new Path();
			path.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
			path.StrokeThickness = pen.Thickness;
			path.Data = pathGeom;
			path.Visibility = BoolToVisibility(owner.IsVisible);
			Canvas.Children.Add(path);

			OwnershipDictionary.Add(path, owner);
		}

		public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
		{
			if (!Settings.IsPanoramaMode)
			{
				startPoint = startPoint.Translate(CurrentScore.DefaultPageSettings);
				endPoint = endPoint.Translate(CurrentScore.DefaultPageSettings);
			}

			var line = new Line();
			line.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
			line.UseLayoutRounding = true;
			line.X1 = startPoint.X;
			line.X2 = endPoint.X;
			line.Y1 = startPoint.Y;
			line.Y2 = endPoint.Y;
			Canvas.SetZIndex(line, (int)pen.ZIndex);
			line.StrokeThickness = pen.Thickness;
			line.Visibility = BoolToVisibility(owner.IsVisible);

			Canvas.Children.Add(line);

			OwnershipDictionary.Add(line, owner);
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
		{
			if (!Settings.IsPanoramaMode) location = location.Translate(CurrentScore.DefaultPageSettings);

			TextBlock textBlock = new TextBlock();
			textBlock.FontSize = Fonts.GetSize(fontStyle);
			textBlock.FontFamily = Fonts.Get(fontStyle);
			textBlock.Text = text;
			textBlock.Foreground = new SolidColorBrush(ConvertColor(color));
			textBlock.Visibility = BoolToVisibility(owner.IsVisible);
			Canvas.SetLeft(textBlock, location.X + 3d);
			Canvas.SetTop(textBlock, location.Y);
			Canvas.Children.Add(textBlock);

			OwnershipDictionary.Add(textBlock, owner);
		}

		public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
		{
			if (!Settings.IsPanoramaMode) location = location.Translate(CurrentScore.DefaultPageSettings);

			TextBlock textBlock = new TextBlock();
			textBlock.FontFamily = Fonts.Get(fontStyle);
			textBlock.FontSize = 200;
			textBlock.Text = text;
			textBlock.Margin = new Thickness(0, -25, 0, 0);
			textBlock.Foreground = new SolidColorBrush(ConvertColor(color));
			textBlock.Visibility = BoolToVisibility(owner.IsVisible);

			/*var viewBox = new Viewbox();
			viewBox.Child = textBlock;
			viewBox.Width = size.Width;
			viewBox.Height = size.Height;
			viewBox.Stretch = Stretch.Fill;
			viewBox.RenderTransform = new ScaleTransform { ScaleX = 1, ScaleY = 1.9 };
			Canvas.SetLeft(viewBox, location.X + 3d);
			Canvas.SetTop(viewBox, location.Y);
			Canvas.Children.Add(viewBox);

			OwnershipDictionary.Add(textBlock, owner);*/
		}

		private Visibility BoolToVisibility(bool isVisible)
		{
			return isVisible ? Visibility.Visible : Visibility.Collapsed;
		}

		private Point ConvertPoint(Primitives.Point point)
		{
			return new Point(point.X, point.Y);
		}
	}
}
