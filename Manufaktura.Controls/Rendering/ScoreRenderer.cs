using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Base class for rendering scores on specific canvas.
    /// </summary>
    /// <typeparam name="TCanvas">Canvas object</typeparam>
    public abstract class ScoreRenderer<TCanvas> : ScoreRendererBase
    {
        public TCanvas Canvas { get; internal set; }

        public List<Exception> Exceptions { get; protected set; }

        public ScoreRenderer(TCanvas canvas)
        {
            Canvas = canvas;
            Exceptions = new List<Exception>();
        }

        /// <summary>
        /// Render score on canvas.
        /// </summary>
        /// <param name="score">Score</param>
        public void Render(Score score)
        {
            scoreService.BeginNewScore(score);
            foreach (Staff staff in score.Staves)
            {
                try
                {
                    RenderStaff(staff);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }

            //Set height of current system in Panorama mode. This is used for determining the size of the control:
            if (Settings.IsPanoramaMode && scoreService.CurrentSystem.Height == 0)
            {
                scoreService.CurrentSystem.Height = (scoreService.CurrentStaffHeight + Settings.LineSpacing) * scoreService.CurrentScore.Staves.Count;
            }

            foreach (var finishingTouch in FinishingTouches) finishingTouch.PerformOnScore(score, this);
        }

        private void DetermineClef(Staff staff)
        {
            var clef = staff.Elements.FirstOrDefault(MusicalSymbolType.Clef) as Clef;
            if (clef == null) return;

            scoreService.CurrentClef = clef;
            var clefPositionY = scoreService.CurrentLinePositions[4] - ((clef.Line - 1) * Settings.LineSpacing);
            clef.TextBlockLocation = new Point(scoreService.CursorPositionX, clefPositionY - Settings.TextBlockHeight);
            DrawString(clef.MusicalCharacter, MusicFontStyles.MusicFont, clef.TextBlockLocation.X, clef.TextBlockLocation.Y, clef);
            scoreService.CursorPositionX += 20;
        }

        private void RenderStaff(Staff staff)
        {
            BreakToNextStaff();
            if (!Settings.IgnoreCustomElementPositions && Settings.IsPanoramaMode)
            {
                double newPageWidth = staff.MeasureWidths.Where(w => w.HasValue).Sum(w => w.Value * Settings.CustomElementPositionRatio);
                if (newPageWidth > Settings.PageWidth) Settings.PageWidth = newPageWidth;
            }

            DetermineClef(staff);
            alterationService.Reset();

            foreach (MusicalSymbol symbol in staff.Elements)
            {
                try
                {
                    var renderStrategy = GetProperRenderStrategy(symbol);
                    if (renderStrategy != null) renderStrategy.Render(symbol, this);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }

            scoreService.CurrentSystem.Width = scoreService.CursorPositionX;
            foreach (var finishingTouch in FinishingTouches) finishingTouch.PerformOnStaff(staff, this);
        }
    }
}