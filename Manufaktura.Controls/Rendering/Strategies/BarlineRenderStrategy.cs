using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class BarlineRenderStrategy : MusicalSymbolRenderStrategy<Barline>
    {
        private readonly IMeasurementService measurementService;
        private readonly IAlterationService alterationService;
        private readonly IScoreService scoreService;
        public BarlineRenderStrategy(IMeasurementService measurementService, IAlterationService alterationService, IScoreService scoreService)
        {
            this.measurementService = measurementService;
            this.alterationService = alterationService;
            this.scoreService = scoreService;
        }

        public override void Render(Barline element, ScoreRendererBase renderer)
        {
            if (measurementService.lastNoteInMeasureEndXPosition > renderer.State.CursorPositionX)
            {
                renderer.State.CursorPositionX = measurementService.lastNoteInMeasureEndXPosition;
            }

            double? measureWidth = GetCursorPositionForCurrentBarline(renderer);
            if (!renderer.Settings.IgnoreCustomElementPositions && measureWidth.HasValue && element.Location == HorizontalPlacement.Right) renderer.State.CursorPositionX = measureWidth.Value;

            if (element.RepeatSign == RepeatSignType.None)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 16;
                if (element.Location == HorizontalPlacement.Right) measurementService.LastMeasurePositionX = renderer.State.CursorPositionX;
                renderer.DrawLine(new Point(renderer.State.CursorPositionX, scoreService.CurrentLinePositions[4]),
                                  new Point(renderer.State.CursorPositionX, scoreService.CurrentLinePositions[0]), element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 6;
            }
            else if (element.RepeatSign == RepeatSignType.Forward)
            {
                if (scoreService.CurrentStaff.Elements.IndexOf(element) > 0)
                {
                        renderer.State.CursorPositionX -= 8;   //TODO: Temporary workaround!!
                }
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 2;
                if (element.Location == HorizontalPlacement.Right) measurementService.LastMeasurePositionX = renderer.State.CursorPositionX;
                renderer.DrawString(renderer.Settings.CurrentFont.RepeatForward, MusicFontStyles.StaffFont, renderer.State.CursorPositionX,
                   scoreService.CurrentLinePositions[0] - 15.5f, element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 20;
            }
            else if (element.RepeatSign == RepeatSignType.Backward)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX -= 2;
                if (element.Location == HorizontalPlacement.Right) measurementService.LastMeasurePositionX = renderer.State.CursorPositionX;
                renderer.DrawString(renderer.Settings.CurrentFont.RepeatBackward, MusicFontStyles.StaffFont, renderer.State.CursorPositionX - 17.5,
                    scoreService.CurrentLinePositions[0] - 15, element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 6;
            }
            scoreService.CurrentMeasure.FirstNoteInMeasureXPosition = renderer.State.CursorPositionX;

            if (element.Location == HorizontalPlacement.Right)   //Start new measure only if it's right barline
            {
                alterationService.Reset();
                scoreService.BeginNewMeasure();
            }
        }

        public double? GetCursorPositionForCurrentBarline(ScoreRendererBase renderer)
        {
            Staff staff = scoreService.CurrentStaff;
            if (staff.MeasureWidths.Count < scoreService.CurrentMeasureNo) return null;
            double? width = staff.MeasureWidths[scoreService.CurrentMeasureNo - 1];
            if (!width.HasValue) return null;
            return measurementService.LastMeasurePositionX + width * renderer.Settings.CustomElementPositionRatio;
        }
    }
}
