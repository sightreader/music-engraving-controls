using Manufaktura.Controls.Model;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering.Strategies.Slurs
{
    public class BezierSlurRenderStrategy : SlurRenderStrategy
    {
        public BezierSlurRenderStrategy(IMeasurementService measurementService, IScoreService scoreService) : base(measurementService, scoreService)
        {
        }

        public override bool IsRelevant(Note element)
        {
            return element.Slur.IsDefinedAsBezierCurve;
        }

        protected override void ProcessSlurEnd(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement)
        {
            var absoluteControlPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(element.Slur.BezierStartOrEndPoint), notePositionY);
            var absoluteEndPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(element.Slur.BezierControlPoint), notePositionY);
            renderer.DrawBezier(measurementService.SlurStartPoint.X, measurementService.SlurStartPoint.Y,
                    measurementService.SlurBezierStartControlPoint.X, measurementService.SlurBezierStartControlPoint.Y,
                    absoluteControlPoint.X, absoluteControlPoint.Y,
                    absoluteEndPoint.X, absoluteEndPoint.Y, element);
        }

        protected override void ProcessSlurStart(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement)
        {
            measurementService.SlurStartPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(element.Slur.BezierControlPoint), notePositionY);
            measurementService.SlurBezierStartControlPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(element.Slur.BezierStartOrEndPoint), notePositionY);
        }
    }
}