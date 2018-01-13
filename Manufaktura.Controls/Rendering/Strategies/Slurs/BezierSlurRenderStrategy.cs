using Manufaktura.Controls.Model;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering.Strategies.Slurs
{
    /// <summary>
    /// Strategy for rendering slurs as Bezier curvers whose parameters are explicitly defined in MusicXml.
    /// </summary>
    public class BezierSlurRenderStrategy : SlurRenderStrategy
    {
        /// <summary>
        /// Initializes a new instance of SlurRenderStrategy with specific services.
        /// </summary>
        /// <param name="measurementService">Measurement service</param>
        /// <param name="scoreService">Score service</param>
        public BezierSlurRenderStrategy(IMeasurementService measurementService, IScoreService scoreService) : base(measurementService, scoreService)
        {
        }

        /// <summary>
        /// Returns true if this strategy type is relevant for drawing a specific slur
        /// </summary>
        /// <param name="element">Element with a slur</param>
        /// <param name="slur">Slur</param>
        /// <returns>True if this strategy is relevant for rendering a specific slur</returns>
        public override bool IsRelevant(Note element, Slur slur)
        {
            return slur.IsDefinedAsBezierCurve;
        }

        /// <summary>
        /// Draws of performs additional logic at slur end
        /// </summary>
        /// <param name="renderer">Score renderer</param>
        /// <param name="slur">Slur</param>
        /// <param name="element">Element with a slur</param>
        /// <param name="notePositionY">Y position of element with a slur</param>
        /// <param name="slurStartInfo">Information about slur start point</param>
        /// <param name="slurPlacement">Information about slur placement</param>
        protected override void ProcessSlurEnd(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement)
        {
            var absoluteControlPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierStartOrEndPoint), notePositionY);
            var absoluteEndPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierControlPoint), notePositionY);
            renderer.DrawBezier(slurStartInfo.StartPoint.X, slurStartInfo.StartPoint.Y,
                    slurStartInfo.BezierStartControlPoint.X, slurStartInfo.BezierStartControlPoint.Y,
                    absoluteControlPoint.X, absoluteControlPoint.Y,
                    absoluteEndPoint.X, absoluteEndPoint.Y, element);
        }

        /// <summary>
        /// Draws or performs additional logic at slur start
        /// </summary>
        /// <param name="renderer">Score renderer</param>
        /// <param name="slur">Slur</param>
        /// <param name="element">Element with a slur</param>
        /// <param name="notePositionY"></param>
        /// <param name="slurStartInfo">Information about slur start point</param>
        /// <param name="slurPlacement">Information about slur placement</param>
        protected override void ProcessSlurStart(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement)
        {
            slurStartInfo.StartPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierControlPoint), notePositionY);
            slurStartInfo.BezierStartControlPoint = RelativeToAbsolute(renderer, renderer.TenthsToPixels(slur.BezierStartOrEndPoint), notePositionY);
        }
    }
}