using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;

namespace Manufaktura.Controls.WinForms
{
    class GdiPlusScoreRenderer : ScoreRenderer<Graphics>
    {
        private Dictionary<MusicFontStyles, Font> _fonts = new Dictionary<MusicFontStyles, Font>()
            {
                {MusicFontStyles.MusicFont, new Font("Polihymnia", 20)},
                {MusicFontStyles.GraceNoteFont, new Font("Polihymnia", 18)},
                {MusicFontStyles.StaffFont, new Font("Polihymnia", 23)},
                {MusicFontStyles.LyricsFont, new Font("Times New Roman", 8)},
                {MusicFontStyles.LyricsFontBold, new Font("Times New Roman", 10, FontStyle.Bold)},
                {MusicFontStyles.MiscArticulationFont, new Font("Microsoft Sans Serif", 8, FontStyle.Bold)},
                {MusicFontStyles.DirectionFont, new Font("Microsoft Sans Serif", 9, FontStyle.Italic | FontStyle.Bold)},
                {MusicFontStyles.TrillFont, new Font("Times New Roman", 9, FontStyle.Italic | FontStyle.Bold)},
                {MusicFontStyles.TimeSignatureFont, new Font("Microsoft Sans Serif", 10, FontStyle.Bold)}
            };

        private Dictionary<Primitives.Pen, Pen> _penCache = new Dictionary<Primitives.Pen, Pen>();

        public GdiPlusScoreRenderer(Graphics canvas) : base(canvas)
        {
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

        private Color ConvertColor(Primitives.Color color) 
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
        {
            Canvas.DrawString(text, _fonts[fontStyle], new SolidBrush(ConvertColor(color)), new PointF((float)location.X, (float)location.Y));
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
        {
            
            Canvas.DrawLine(ConvertPen(pen), new Point((int)startPoint.X, (int)startPoint.Y), new Point((int)endPoint.X, (int)endPoint.Y));
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
        {
            Canvas.DrawArc(ConvertPen(pen), new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height), (float)startAngle, (float)sweepAngle);
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
        {
            Canvas.DrawBezier(ConvertPen(pen), new Point((int)p1.X, (int)p1.Y), new Point((int)p2.X, (int)p2.Y), new Point((int)p3.X, (int)p3.Y), new Point((int)p4.X, (int)p4.Y));
        }
    }
}
