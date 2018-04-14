using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Manufaktura.Controls.WinForms
{
    public class GdiPlusScoreRenderer : ScoreRenderer<Graphics>
    {
        private Dictionary<MusicFontStyles, Font> _fonts = new Dictionary<MusicFontStyles, Font>()
            {
                {MusicFontStyles.MusicFont, new Font("Polihymnia", 27.5f, GraphicsUnit.Pixel)},
                {MusicFontStyles.GraceNoteFont, new Font("Polihymnia", 20, GraphicsUnit.Pixel)},
                {MusicFontStyles.StaffFont, new Font("Polihymnia", 30.5f, GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFont, new Font("Times New Roman", 11, GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFontBold, new Font("Times New Roman", 11, FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.MiscArticulationFont, new Font("Microsoft Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.DirectionFont, new Font("Microsoft Sans Serif", 11, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.TrillFont, new Font("Times New Roman", 14, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.TimeSignatureFont, new Font("Microsoft Sans Serif", 14.5f, FontStyle.Bold, GraphicsUnit.Pixel)}
            };

        private Dictionary<Primitives.Pen, Pen> _penCache = new Dictionary<Primitives.Pen, Pen>();

        public GdiPlusScoreRenderer(Graphics canvas)
            : base(canvas)
        {
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
            {
                rect = rect.Translate(CurrentScore.DefaultPageSettings);
            }

            Canvas.DrawArc(ConvertPen(pen), new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height), (float)startAngle, (float)sweepAngle);
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

            Canvas.DrawBezier(ConvertPen(pen), new Point((int)p1.X, (int)p1.Y), new Point((int)p2.X, (int)p2.Y), new Point((int)p3.X, (int)p3.Y), new Point((int)p4.X, (int)p4.Y));
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
            {
                startPoint = startPoint.Translate(CurrentScore.DefaultPageSettings);
                endPoint = endPoint.Translate(CurrentScore.DefaultPageSettings);
            }

            Canvas.DrawLine(ConvertPen(pen), new Point((int)startPoint.X, (int)startPoint.Y), new Point((int)endPoint.X, (int)endPoint.Y));
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
            {
                location = location.Translate(CurrentScore.DefaultPageSettings);
            }

            var font = _fonts[fontStyle];
            var baselineDesignUnits = font.FontFamily.GetCellAscent(font.Style);
            var baselinePixels = (baselineDesignUnits * font.Size) / font.FontFamily.GetEmHeight(font.Style);
            Canvas.DrawString(text, font, new SolidBrush(ConvertColor(color)), new PointF((float)location.X - 4, (float)location.Y - baselinePixels));
        }

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
                location = location.Translate(CurrentScore.DefaultPageSettings);

            var font = _fonts[fontStyle];
            var path = new GraphicsPath();
            path.AddString(character.ToString(), font.FontFamily, (int)font.Style, Canvas.DpiY * font.Size / 72, new Point(0, 0), new StringFormat()); 
            var matrix = new Matrix();
            var matrix2 = new Matrix();
            var pathBounds = path.GetBounds();
            var scaleX = (float)size.Width / pathBounds.Width;
            var scaleY = (float)size.Height / pathBounds.Height;
            matrix2.Translate((float)location.X - (float)LinespacesToPixels(2.5), (float)location.Y - (float)LinespacesToPixels(2.5));  //TODO: Sprawdzić czemu się źle przesuwa i usunąć linespacestopixels
            matrix.Scale(scaleX, scaleY);
            path.Transform(matrix);
            path.Transform(matrix2);
            Canvas.DrawPath(new Pen(ConvertColor(color)), path);
            Canvas.FillPath(new SolidBrush(ConvertColor(color)), path);
        }

        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Primitives.Point start, Primitives.Point end)
        {
        }

        private Color ConvertColor(Primitives.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private Pen ConvertPen(Primitives.Pen pen)
        {
            Pen gdiPen;
            if (_penCache.ContainsKey(pen)) gdiPen = _penCache[pen];
            else
            {
                gdiPen = new Pen(new SolidBrush(ConvertColor(pen.Color)), (float)pen.Thickness);
                _penCache.Add(pen, gdiPen);
            }
            return gdiPen;
        }
    }
}