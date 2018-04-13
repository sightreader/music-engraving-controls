using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Linq;

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

        /// <summary>
        /// Initializes a new instance of BarlineRenderStrategy
        /// </summary>
        /// <param name="measurementService"></param>
        /// <param name="alterationService"></param>
        /// <param name="scoreService"></param>
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
			var partGroup = element.Staff?.Part?.Group;
			var doNotDraw = partGroup != null && partGroup.GroupBarline == GroupBarlineType.Mensurstrich;

			var lightPen = new Pen(element.CoalesceColor(renderer), 1);
			var thickPen = new Pen(element.CoalesceColor(renderer), 3);
            var barlinePen = renderer.CreatePenFromDefaults(element, "thinBarlineThickness", s => s.DefaultBarlineThickness);

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
				if (!doNotDraw)
				{
                    if (element.Style == BarlineStyle.LightHeavy)
                    {
                        renderer.DrawLine(new Point(scoreService.CursorPositionX - 6, scoreService.CurrentLinePositions[4]),
                                          new Point(scoreService.CursorPositionX - 6, scoreService.CurrentLinePositions[0]), lightPen, element);
                        renderer.DrawLine(new Point(scoreService.CursorPositionX - 1.5, scoreService.CurrentLinePositions[4]),
                                          new Point(scoreService.CursorPositionX - 1.5, scoreService.CurrentLinePositions[0]), thickPen, element);
                    }
                    else if (element.Style == BarlineStyle.Dashed)
                    {
                        var barlineHeight = Math.Abs(scoreService.CurrentLinePositions[4] - scoreService.CurrentLinePositions[0]);
                        var currentPositionY = scoreService.CurrentLinePositions[0];
                        var numberOfSegments = 6;
                        var dy = barlineHeight / numberOfSegments;
                        for (int i=0; i< numberOfSegments; i++)
                        {
                            if (i % 2 == 0)
                            {
                                renderer.DrawLine(new Point(scoreService.CursorPositionX, currentPositionY),
                                              new Point(scoreService.CursorPositionX, currentPositionY + dy), barlinePen, element);
                            }
                            currentPositionY += dy;
                        }
                    }
                    else if (element.Style != BarlineStyle.None)
                    {
                        renderer.DrawLine(new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4]),
                                          new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]), lightPen, element);
                    }
				}
				scoreService.CurrentMeasure.BarlineLocationX = scoreService.CursorPositionX;
				scoreService.CurrentMeasure.Barline = element;
				if (!IsLastBarline(element) && (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue))
                    scoreService.CursorPositionX += 6;
			}
			else if (element.RepeatSign == RepeatSignType.Forward)
			{
				if (scoreService.CurrentStaff.Elements.IndexOf(element) > 0)
				{
					scoreService.CursorPositionX -= 8;   //TODO: Temporary workaround!!
				}
				if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue)
                    scoreService.CursorPositionX -= 2;
				if (element.Location == HorizontalPlacement.Right)
                    measurementService.LastMeasurePositionX = scoreService.CursorPositionX;

                if (scoreService.CurrentStaffNo > 1 && element.RenderedXPositionForFirstStaffInMultiStaffPart > 0)
                    scoreService.CursorPositionX = element.RenderedXPositionForFirstStaffInMultiStaffPart;

                renderer.DrawCharacter(renderer.Settings.CurrentFont.RepeatForward, MusicFontStyles.StaffFont, scoreService.CursorPositionX + 4,
				   scoreService.CurrentLinePositions[2], element);

                if (scoreService.CurrentStaffNo == 1) element.RenderedXPositionForFirstStaffInMultiStaffPart = scoreService.CursorPositionX;

                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 20;
			}
			else if (element.RepeatSign == RepeatSignType.Backward)
			{
				if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue)
                    scoreService.CursorPositionX += 2;
				if (element.Location == HorizontalPlacement.Right)
                    measurementService.LastMeasurePositionX = scoreService.CursorPositionX;

                if (scoreService.CurrentStaffNo > 1 && element.RenderedXPositionForFirstStaffInMultiStaffPart > 0)
                    scoreService.CursorPositionX = element.RenderedXPositionForFirstStaffInMultiStaffPart;

                renderer.DrawCharacter(renderer.Settings.CurrentFont.RepeatBackward, MusicFontStyles.StaffFont, scoreService.CursorPositionX - 14.5,
					scoreService.CurrentLinePositions[2], element);

                if (scoreService.CurrentStaffNo == 1) element.RenderedXPositionForFirstStaffInMultiStaffPart = scoreService.CursorPositionX;

                scoreService.CurrentMeasure.BarlineLocationX = scoreService.CursorPositionX;
                scoreService.CurrentMeasure.Barline = element;
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 6;
			}

			if (element.Location == HorizontalPlacement.Right)   //Start new measure only if it's right barline
			{
				alterationService.Reset();
				scoreService.BeginNewMeasure();
			}
		}

		private bool IsLastBarline(Barline element)
		{
			return element == scoreService.CurrentStaff.Elements.LastOrDefault();
		}
	}
}