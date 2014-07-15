using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Manufaktura.Controls.WinForms
{
    class GdiPlusScoreRenderer : ScoreRenderer<Graphics>
    {
        private Dictionary<Model.FontStyles, Font> _fonts = new Dictionary<Model.FontStyles, Font>()
            {
                {Model.FontStyles.MusicFont, new Font("Polihymnia", 20)},
                {Model.FontStyles.GraceNoteFont, new Font("Polihymnia", 18)},
                {Model.FontStyles.StaffFont, new Font("Polihymnia", 23)},
                {Model.FontStyles.LyricsFont, new Font("Times New Roman", 8)},
                {Model.FontStyles.LyricsFontBold, new Font("Times New Roman", 10, FontStyle.Bold)},
                {Model.FontStyles.MiscArticulationFont, new Font("Microsoft Sans Serif", 8, FontStyle.Bold)},
                {Model.FontStyles.DirectionFont, new Font("Microsoft Sans Serif", 9, FontStyle.Italic | FontStyle.Bold)},
                {Model.FontStyles.TrillFont, new Font("Times New Roman", 9, FontStyle.Italic | FontStyle.Bold)},
                {Model.FontStyles.TimeSignatureFont, new Font("Microsoft Sans Serif", 10, FontStyle.Bold)}
            };

        private Dictionary<double, Pen> _penCache = new Dictionary<double, Pen>();

        public GdiPlusScoreRenderer(Graphics canvas)
            : base(canvas)
        {
        }

        public override void DrawString(string text, Model.FontStyles fontStyle, Primitives.Point location)
        {
            Canvas.DrawString(text, _fonts[fontStyle], Brushes.Black, new PointF((float)location.X, (float)location.Y));
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, double thickness)
        {
            Pen pen;
            if (_penCache.ContainsKey(thickness)) pen = _penCache[thickness];
            else
            {
                pen = new Pen(Brushes.Black, (float)thickness);
                _penCache.Add(thickness, pen);
            }
            Canvas.DrawLine(pen, new Point((int)startPoint.X, (int)startPoint.Y), new Point((int)endPoint.X, (int)endPoint.Y));
        }

        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, double thickness)
        {
            Pen pen;
            if (_penCache.ContainsKey(thickness)) pen = _penCache[thickness];
            else
            {
                pen = new Pen(Brushes.Black, (float)thickness);
                _penCache.Add(thickness, pen);
            }
            Canvas.DrawArc(pen, new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height), (float)startAngle, (float)sweepAngle);
        }

        public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, double thickness)
        {
            Pen pen;
            if (_penCache.ContainsKey(thickness)) pen = _penCache[thickness];
            else
            {
                pen = new Pen(Brushes.Black, (float)thickness);
                _penCache.Add(thickness, pen);
            }
            Canvas.DrawBezier(pen, new Point((int)p1.X, (int)p1.Y), new Point((int)p2.X, (int)p2.Y), new Point((int)p3.X, (int)p3.Y), new Point((int)p4.X, (int)p4.Y));
        }
    }
}
