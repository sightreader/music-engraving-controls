using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using SkiaSharp;
using System;

namespace Manufaktura.Controls.Skia
{
    public class SKCanvasScoreRenderer : ScoreRenderer<SKCanvas>
    {
        public SKCanvasScoreRenderer(SKCanvas canvas) : base(canvas)
        {
            
        }

        public SKCanvasScoreRenderer(SKCanvas canvas, ScoreRendererSettings settings) : base(canvas, settings)
        {
        }

        public override bool CanDrawCharacterInBounds => throw new NotImplementedException();

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Point location, Size size, Color color, MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner)
        {
            throw new NotImplementedException();
        }

        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Point start, Point end)
        {
            throw new NotImplementedException();
        }
    }
}