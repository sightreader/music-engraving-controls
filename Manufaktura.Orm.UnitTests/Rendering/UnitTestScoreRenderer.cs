using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System;
using System.Linq;

namespace Manufaktura.Orm.UnitTests.Rendering
{
    public class UnitTestScoreRenderer : ScoreRenderer<IScoreRenderingTestResultsRepository>
    {
        public UnitTestScoreRenderer(IScoreRenderingTestResultsRepository canvas)
            : base(canvas)
        {
        }

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner)
        {
            var entry = new ScoreRenderingTestEntry();
            entry.Location = new Point(rect.X, rect.Y);
            entry.Size = new Point(rect.Width, rect.Height);
            entry.Type = owner.Type;
            Canvas.Put(entry);
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner)
        {
            var entry = new ScoreRenderingTestEntry();
            entry.Location = GetTopLeftPoint(p1, p2, p3, p4);
            entry.Type = owner.Type;
            Canvas.Put(entry);
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner)
        {
            var entry = new ScoreRenderingTestEntry();
            entry.Location = startPoint;
            entry.Size = new Point(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            entry.Type = owner.Type;
            Canvas.Put(entry);
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner)
        {
            var entry = new ScoreRenderingTestEntry();
            entry.Location = location;
            entry.Text = text;
            entry.Type = owner.Type;
            Canvas.Put(entry);
        }

        private Point GetTopLeftPoint(params Point[] points)
        {
            return new Point(points.Min(p => p.X), points.Min(p => p.Y));
        }
    }
}