using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WPF
{
    public class WpfCanvasScoreRenderer : ScoreRenderer<Canvas>
    {
        private Dictionary<Primitives.Pen, Pen> _penCache = new Dictionary<Primitives.Pen, Pen>();
        private Line playbackCursor;
        private TranslateTransform playbackCursorTransform = new TranslateTransform();

        public WpfCanvasScoreRenderer(Canvas canvas) : base(canvas, new WpfScoreRendererSettings())
        {
            OwnershipDictionary = new Dictionary<FrameworkElement, MusicalSymbol>();
        }

        public WpfCanvasScoreRenderer(Canvas canvas, WpfScoreRendererSettings rendererSettings) : base(canvas, rendererSettings)
        {
            OwnershipDictionary = new Dictionary<FrameworkElement, MusicalSymbol>();
        }

        public Dictionary<FrameworkElement, MusicalSymbol> OwnershipDictionary { get; private set; }
        public WpfScoreRendererSettings TypedSettings => Settings as WpfScoreRendererSettings;
        public static Point ConvertPoint(Primitives.Point point)
        {
            return new Point(point.X, point.Y);
        }

        public static Primitives.Point ConvertPoint(Point point)
        {
            return new Primitives.Point(point.X, point.Y);
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
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama) rect = rect.Translate(CurrentScore.DefaultPageSettings);

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
            Canvas.Children.Add(path);

            OwnershipDictionary.Add(path, owner);
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
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
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
            {
                startPoint = startPoint.Translate(CurrentScore.DefaultPageSettings);
                endPoint = endPoint.Translate(CurrentScore.DefaultPageSettings);
            }

            var line = new Line();
            line.Stroke = new SolidColorBrush(ConvertColor(pen.Color));
            line.X1 = startPoint.X;
            line.X2 = endPoint.X;
            line.Y1 = startPoint.Y;
            line.Y2 = endPoint.Y;
            line.StrokeThickness = pen.Thickness;
            line.Visibility = BoolToVisibility(owner.IsVisible);
            Canvas.Children.Add(line);

            OwnershipDictionary.Add(line, owner);
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama) location = location.Translate(CurrentScore.DefaultPageSettings);

            TextBlock textBlock = new TextBlock();
            Typeface typeface = TypedSettings.GetFont(fontStyle);
            textBlock.FontSize = TypedSettings.GetFontSize(fontStyle);
            textBlock.FontFamily = typeface.FontFamily;
            textBlock.FontStretch = typeface.Stretch;
            textBlock.FontStyle = typeface.Style;
            textBlock.FontWeight = typeface.Weight;
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(ConvertColor(color));
            textBlock.Visibility = BoolToVisibility(owner.IsVisible);

            var baseline = typeface.FontFamily.Baseline * textBlock.FontSize;

            Canvas.SetLeft(textBlock, location.X);
            Canvas.SetTop(textBlock, location.Y - baseline);
            Canvas.Children.Add(textBlock);

            OwnershipDictionary.Add(textBlock, owner);
        }

        public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama) location = location.Translate(CurrentScore.DefaultPageSettings);

            TextBlock textBlock = new TextBlock();
            Typeface typeface = TypedSettings.GetFont(fontStyle);
            textBlock.FontSize = 200;
            textBlock.FontFamily = typeface.FontFamily;
            textBlock.FontStretch = typeface.Stretch;
            textBlock.FontStyle = typeface.Style;
            textBlock.FontWeight = typeface.Weight;
            textBlock.Text = text;
            textBlock.Margin = new Thickness(0, -25, 0, 0);
            textBlock.Foreground = new SolidColorBrush(ConvertColor(color));
            textBlock.Visibility = BoolToVisibility(owner.IsVisible);

            var viewBox = new Viewbox();
            viewBox.Child = textBlock;
            viewBox.Width = size.Width;
            viewBox.Height = size.Height;
            viewBox.Stretch = Stretch.Fill;
            viewBox.RenderTransform = new ScaleTransform(1, 1.9);
            System.Windows.Controls.Canvas.SetLeft(viewBox, location.X + 3d);
            System.Windows.Controls.Canvas.SetTop(viewBox, location.Y);
            Canvas.Children.Add(viewBox);

            OwnershipDictionary.Add(textBlock, owner);
        }

        public void MoveLayout(StaffSystem system, Point delta)
        {
            foreach (var staffFragment in system.Staves)
            {
                var systemElements = OwnershipDictionary.Where(d => d.Value == staffFragment).Select(d => d.Key).ToList();
                foreach (var frameworkElement in systemElements)
                {
                    Move(frameworkElement, delta);
                }
            }

            var alreadyMovedElements = new List<FrameworkElement>();
            foreach (var element in system.Score.Staves.SelectMany(s => s.Elements).Where(e => e.Measure != null && e.Measure.System == system).Distinct())
            {
                var frameworkElements = OwnershipDictionary.Where(d => d.Value == element).Select(d => d.Key).ToList();
                foreach (var frameworkElement in frameworkElements)
                {
                    if (alreadyMovedElements.Contains(frameworkElement)) continue;
                    Move(frameworkElement, delta);
                    alreadyMovedElements.Add(frameworkElement);
                }
            }
        }

        protected Visibility BoolToVisibility(bool isVisible)
        {
            return isVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        protected Pen ConvertPen(Primitives.Pen pen)
        {
            Pen wpfPen;
            if (_penCache.ContainsKey(pen)) wpfPen = _penCache[pen];
            else
            {
                wpfPen = new Pen(new SolidColorBrush(ConvertColor(pen.Color)), pen.Thickness);
                _penCache.Add(pen, wpfPen);
            }
            return wpfPen;
        }

        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Primitives.Point start, Primitives.Point end)
        {
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
            {
                start = start.Translate(CurrentScore.DefaultPageSettings);
                end = end.Translate(CurrentScore.DefaultPageSettings);
            }

            if (playbackCursor == null)
            {
                playbackCursor = new Line();
                playbackCursor.RenderTransform = playbackCursorTransform;

                playbackCursor.Stroke = new SolidColorBrush(Colors.Magenta);
                playbackCursor.X1 = 0;
                playbackCursor.X2 = 0;
                playbackCursor.Y1 = 0;
                playbackCursor.Y2 = end.Y - start.Y;
                playbackCursor.Visibility = BoolToVisibility(position.IsValid);
                playbackCursor.StrokeThickness = 1;
                Canvas.Children.Add(playbackCursor);
            }

            playbackCursorTransform.X = start.X;
            playbackCursorTransform.Y = start.Y;
        }

        private void Move(FrameworkElement element, Point delta)
        {
            var translation = new TranslateTransform();
            translation.X = delta.X;
            translation.Y = delta.Y;
            element.RenderTransform = translation;
        }
    }
}