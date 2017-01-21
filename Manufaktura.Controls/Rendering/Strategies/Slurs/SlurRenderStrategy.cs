using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering.Strategies.Slurs
{
    public abstract class SlurRenderStrategy
    {
        protected IMeasurementService measurementService;
        protected IScoreService scoreService;

        protected SlurRenderStrategy(IMeasurementService measurementService, IScoreService scoreService)
        {
            this.measurementService = measurementService;
            this.scoreService = scoreService;
        }

        public void Draw(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            VerticalPlacement slurPlacement;
            if (element.Slur.Placement.HasValue) slurPlacement = element.Slur.Placement.Value;
            else slurPlacement = element.StemDirection == VerticalDirection.Up ? VerticalPlacement.Below : VerticalPlacement.Above;

            if (element.Slur.Type == NoteSlurType.Start) ProcessSlurStart(renderer, element, notePositionY, slurPlacement);
            if (element.Slur.Type == NoteSlurType.Stop) ProcessSlurEnd(renderer, element, notePositionY, slurPlacement);
        }

        public abstract bool IsRelevant(Note element);

        protected abstract void ProcessSlurEnd(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement);

        protected abstract void ProcessSlurStart(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement);
        protected Point RelativeToAbsolute(ScoreRendererBase renderer, Point relative, double notePositionY)
        {
            return new Point(relative.X * renderer.Settings.CustomElementPositionRatio + 7, relative.Y) + new Point(measurementService.LastNotePositionX, scoreService.CurrentLinePositions[0]);
        }
    }
}