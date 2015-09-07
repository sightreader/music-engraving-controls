using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Barline.
    /// </summary>
    public class BarlineRenderStrategy : MusicalSymbolRenderStrategy<Barline>
    {
        private readonly IAlterationService alterationService;
        private readonly IMeasurementService measurementService;
        private readonly IScoreService scoreService;

        public BarlineRenderStrategy(IMeasurementService measurementService, IAlterationService alterationService, IScoreService scoreService)
        {
            this.measurementService = measurementService;
            this.alterationService = alterationService;
            this.scoreService = scoreService;
        }

        public double? GetCursorPositionForCurrentBarline(ScoreRendererBase renderer)
        {
            Staff staff = scoreService.CurrentStaff;
            if (staff.Measures.Count < scoreService.CurrentMeasureNo) return null;
            double? width = staff.Measures[scoreService.CurrentMeasureNo - 1].Width;
            if (!width.HasValue) return null;
            return measurementService.LastMeasurePositionX + width * renderer.Settings.CustomElementPositionRatio;
        }

        public override void Render(Barline element, ScoreRendererBase renderer)
        {
            if (measurementService.LastNoteInMeasureEndXPosition > scoreService.CursorPositionX)
            {
                scoreService.CursorPositionX = measurementService.LastNoteInMeasureEndXPosition;
            }

            double? measureWidth = GetCursorPositionForCurrentBarline(renderer);
            if (!renderer.Settings.IgnoreCustomElementPositions && measureWidth.HasValue && element.Location == HorizontalPlacement.Right) scoreService.CursorPositionX = measureWidth.Value;
            else if (element.RepeatSign == RepeatSignType.None)
            {
                //If measure width is not set, get barline location from the first staff:
                if (scoreService.CurrentStaff != scoreService.CurrentScore.FirstStaff)
                {
                    var correspondingMeasure = scoreService.GetCorrespondingMeasure(scoreService.CurrentMeasure, scoreService.CurrentScore.FirstStaff);
                    if (correspondingMeasure != null) scoreService.CursorPositionX = correspondingMeasure.BarlineLocationX - 16;
                }
            }

            if (element.RepeatSign == RepeatSignType.None)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 16;
                if (element.Location == HorizontalPlacement.Right) measurementService.LastMeasurePositionX = scoreService.CursorPositionX;
                renderer.DrawLine(new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4]),
                                  new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]), element);
                scoreService.CurrentMeasure.BarlineLocationX = scoreService.CursorPositionX;
                scoreService.CurrentMeasure.Barline = element;
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 6;
            }
            else if (element.RepeatSign == RepeatSignType.Forward)
            {
                if (scoreService.CurrentStaff.Elements.IndexOf(element) > 0)
                {
                    scoreService.CursorPositionX -= 8;   //TODO: Temporary workaround!!
                }
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 2;
                if (element.Location == HorizontalPlacement.Right) measurementService.LastMeasurePositionX = scoreService.CursorPositionX;
                renderer.DrawString(renderer.Settings.CurrentFont.RepeatForward, MusicFontStyles.StaffFont, scoreService.CursorPositionX,
                   scoreService.CurrentLinePositions[0] - 15.5f, element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 20;
            }
            else if (element.RepeatSign == RepeatSignType.Backward)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX -= 2;
                if (element.Location == HorizontalPlacement.Right) measurementService.LastMeasurePositionX = scoreService.CursorPositionX;
                renderer.DrawString(renderer.Settings.CurrentFont.RepeatBackward, MusicFontStyles.StaffFont, scoreService.CursorPositionX - 17.5,
                    scoreService.CurrentLinePositions[0] - 15, element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 6;
            }

            if (element.Location == HorizontalPlacement.Right)   //Start new measure only if it's right barline
            {
                alterationService.Reset();
                scoreService.BeginNewMeasure();
            }
        }
    }
}