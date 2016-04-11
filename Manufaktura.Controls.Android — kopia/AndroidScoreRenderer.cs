using Android.Graphics;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Android
{
    public class AndroidScoreRenderer : ScoreRenderer<Canvas>, IDisposable
    {
        private Dictionary<MusicFontStyles, Typeface> typefaces = new Dictionary<MusicFontStyles, Typeface>();

        private static Dictionary<MusicFontStyles, float> fontSizes = new Dictionary<MusicFontStyles, float>()
        {
                {MusicFontStyles.MusicFont, 27.5f},
                {MusicFontStyles.GraceNoteFont, 20},
                {MusicFontStyles.StaffFont, 30},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.LyricsFontBold, 0.8f},
                {MusicFontStyles.MiscArticulationFont, 14},
                {MusicFontStyles.DirectionFont, 11},
                {MusicFontStyles.TrillFont, 14},
                {MusicFontStyles.TimeSignatureFont, 14.5f}
        };

        public AndroidScoreRenderer(Canvas canvas) : base(canvas)
        {
            typefaces.Add(MusicFontStyles.MusicFont, Typeface.Create("Polihymnia", TypefaceStyle.Normal));
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
            using (var paint = GetPaint(pen))
            {
                Canvas.DrawLine((float)startPoint.X, (float)startPoint.Y, (float)endPoint.X, (float)endPoint.Y, paint);
            }
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, Model.MusicalSymbol owner)
        {
            using (var paint = GetPaint(color, fontStyle))
            {
                Canvas.DrawText(text, (float)location.X, (float)location.Y, paint);
            }
        }

        private Paint GetPaint(Primitives.Pen pen)
        {
            var paint = new Paint(PaintFlags.AntiAlias);
            paint.Color = new global::Android.Graphics.Color(pen.Color.R, pen.Color.G, pen.Color.B, pen.Color.A);
            return paint;
        }

        private Paint GetPaint(Primitives.Color color, MusicFontStyles fontStyle)
        {
            var paint = new Paint(PaintFlags.AntiAlias);
            paint.Color = new global::Android.Graphics.Color(color.R, color.G, color.B, color.A);
            paint.SetTypeface(typefaces[fontStyle]);
            paint.TextSize = fontSizes[fontStyle];
            return paint;
        }

        public void Dispose()
        {
            foreach (var typeface in typefaces.Values) typeface.Dispose();
        }

        public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Primitives.Point location, Size size, Primitives.Color color, Model.MusicalSymbol owner)
        {
        }
    }
}