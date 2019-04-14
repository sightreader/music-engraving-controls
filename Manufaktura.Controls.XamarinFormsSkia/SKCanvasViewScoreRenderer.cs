using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.Skia;
using SkiaSharp.Views.Forms;
using System;

namespace Manufaktura.Controls.XamarinFormsSkia
{
    [Obsolete("Probably we need only SKCanvasScoreRenderer")]
    public class SKCanvasViewScoreRenderer : ScoreRenderer<SKPaintSurfaceEventArgs>
    {
        private readonly SKCanvasScoreRenderer innerRenderer;

        public SKCanvasViewScoreRenderer(SKPaintSurfaceEventArgs canvas) : base(canvas)
        {
            innerRenderer = new SKCanvasScoreRenderer(canvas.Surface.Canvas, new SKScoreRendererSettings());
        }

        public SKCanvasViewScoreRenderer(SKPaintSurfaceEventArgs canvas, SKScoreRendererSettings settings) : base(canvas, settings)
        {
            innerRenderer = new SKCanvasScoreRenderer(canvas.Surface.Canvas, settings);
        }

        public override bool CanDrawCharacterInBounds => innerRenderer.CanDrawCharacterInBounds;

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner) => innerRenderer.DrawArc(rect, startAngle, sweepAngle, pen, owner);

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner) => innerRenderer.DrawBezier(p1, p2, p3, p4, pen, owner);

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Point location, Size size, Color color, MusicalSymbol owner)
            => innerRenderer.DrawCharacterInBounds(character, fontStyle, location, size, color, owner);

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner) => innerRenderer.DrawLine(startPoint, endPoint, pen, owner);

        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner)
            => innerRenderer.DrawString(text, fontStyle, location, color, owner);

        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Point start, Point end)
            => innerRenderer.DrawPlaybackCursor(position);
    }
}