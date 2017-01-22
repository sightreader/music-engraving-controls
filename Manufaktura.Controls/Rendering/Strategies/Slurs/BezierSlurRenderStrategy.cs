using Manufaktura.Controls.Model;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering.Strategies.Slurs
{
    public class BezierSlurRenderStrategy : SlurRenderStrategy
    {
        public BezierSlurRenderStrategy(IMeasurementService measurementService, IScoreService scoreService) : base(measurementService, scoreService)
        {
        }

        public override bool IsRelevant(Note element, Slur slur)
        {
            return slur.IsDefinedAsBezierCurve;
        }

        protected override void ProcessSlurEnd(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement)
        {
            var absoluteControlPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierStartOrEndPoint), notePositionY);
            var absoluteEndPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierControlPoint), notePositionY);
            renderer.DrawBezier(slurStartInfo.StartPoint.X, slurStartInfo.StartPoint.Y,
                    slurStartInfo.BezierStartControlPoint.X, slurStartInfo.BezierStartControlPoint.Y,
                    absoluteControlPoint.X, absoluteControlPoint.Y,
                    absoluteEndPoint.X, absoluteEndPoint.Y, element);
        }

        protected override void ProcessSlurStart(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement)
        {
            slurStartInfo.StartPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierControlPoint), notePositionY);
            slurStartInfo.BezierStartControlPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierStartOrEndPoint), notePositionY);
        }
    }
}