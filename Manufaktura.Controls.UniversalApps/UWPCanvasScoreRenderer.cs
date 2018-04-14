using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;

using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Manufaktura.Controls.UniversalApps
{
    public class UWPCanvasScoreRenderer : ScoreRenderer<Canvas>
    {
        private Line playbackCursor;

        private TranslateTransform playbackCursorTransform = new TranslateTransform();

        public UWPCanvasScoreRenderer(Canvas canvas) : base(canvas, new UWPScoreRendererSettings())
        {
            OwnershipDictionary = new Dictionary<FrameworkElement, MusicalSymbol>();
        }

        public UWPCanvasScoreRenderer(Canvas canvas, UWPScoreRendererSettings rendererSettings) : base(canvas, rendererSettings)
        {
            OwnershipDictionary = new Dictionary<FrameworkElement, MusicalSymbol>();
        }

        public UWPScoreRendererSettings TypedSettings => Settings as UWPScoreRendererSettings;

        public Dictionary<FrameworkElement, MusicalSymbol> OwnershipDictionary { get; private set; }

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
            rect = rect.Translate(CurrentScore.DefaultPageSettings);

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
            Windows.UI.Xaml.Controls.Canvas.SetZIndex(path, (int)pen.ZIndex);
            Canvas.Children.Add(path);

            OwnershipDictionary.Add(path, owner);
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
        {
            p1 = p1.Translate(CurrentScore.DefaultPageSettings);
            p2 = p2.Translate(CurrentScore.DefaultPageSettings);
            p3 = p3.Translate(CurrentScore.DefaultPageSettings);
            p4 = p4.Translate(CurrentScore.DefaultPageSettings);

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
            Windows.UI.Xaml.Controls.Canvas.SetZIndex(path, (int)pen.ZIndex);
            Canvas.Children.Add(path);

            OwnershipDictionary.Add(path, owner);
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
        {
            startPoint = startPoint.Translate(CurrentScore.DefaultPageSettings);
            endPoint = endPoint.Translate(CurrentScore.DefaultPageSettings);

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
            location = location.Translate(CurrentScore.DefaultPageSettings);

            TextBlock textBlock = new TextBlock();
            textBlock.FontSize = TypedSettings.GetFontSize(fontStyle);
            textBlock.FontFamily = TypedSettings.GetFont(fontStyle);
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(ConvertColor(color));
            textBlock.UseLayoutRounding = true;
            textBlock.Visibility = BoolToVisibility(owner.IsVisible);

            var compatibleFont = TypedSettings.GetCompatibleFont(fontStyle);
            var baselineDesignUnits = compatibleFont.FontFamily.GetCellAscent(compatibleFont.Style);
            var baselinePixels = (baselineDesignUnits * compatibleFont.Size) / compatibleFont.FontFamily.GetEmHeight(compatibleFont.Style);

            Canvas.SetLeft(textBlock, location.X);
            Canvas.SetTop(textBlock, location.Y - baselinePixels);
            Canvas.Children.Add(textBlock);

            OwnershipDictionary.Add(textBlock, owner);
        }

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
        {
            return;

            //TODO: W UWP Nie ma klasy Typeface ani TryGetGlyphTypeface (one chyba korzystają z Win32 Api). Być może trzeba będzie użyć DirectX (SharpDX).
            //Albo użyć .NET Core Compatibility pack: https://blogs.msdn.microsoft.com/dotnet/2017/11/16/announcing-the-windows-compatibility-pack-for-net-core/

            /*
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama) location = location.Translate(CurrentScore.DefaultPageSettings);

            Typeface typeface = TypedSettings.GetFont(fontStyle);

            GlyphTypeface glyphTypeface;
            if (!typeface.TryGetGlyphTypeface(out glyphTypeface)) return;

            var glyphMap = glyphTypeface.CharacterToGlyphMap;
            var outline = glyphTypeface.GetGlyphOutline(glyphMap[character], 1000, 100);
            var path = new Path();
            path.Data = outline;

            path.Stroke = new SolidColorBrush(ConvertColor(color));
            path.Fill = new SolidColorBrush(ConvertColor(color));
            path.Visibility = BoolToVisibility(owner.IsVisible);
            path.Stretch = Stretch.Fill;

            var viewBox = new Viewbox();
            viewBox.Child = path;
            viewBox.Width = size.Width;
            viewBox.Height = size.Height;
            viewBox.Stretch = Stretch.Fill;
            Canvas.SetLeft(viewBox, location.X);
            Canvas.SetTop(viewBox, location.Y);
            Canvas.Children.Add(viewBox);

            OwnershipDictionary.Add(path, owner);*/
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

        private Visibility BoolToVisibility(bool isVisible)
        {
            return isVisible ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}