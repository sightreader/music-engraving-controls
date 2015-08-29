using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System;

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
            throw new NotImplementedException();
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner)
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
    }
}