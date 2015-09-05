using Manufaktura.Controls.Model;
using System;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Base class for rendering scores on specific canvas.
    /// </summary>
    /// <typeparam name="TCanvas">Canvas object</typeparam>
    public abstract class ScoreRenderer<TCanvas> : ScoreRendererBase
    {
        public TCanvas Canvas { get; internal set; }

        /// <summary>
        /// Initializes a new ScoreRendere with specific canvas object.
        /// </summary>
        /// <param name="canvas"></param>
        public ScoreRenderer(TCanvas canvas)
        {
            Canvas = canvas;
        }

        /// <summary>
        /// Renders score on canvas.
        /// </summary>
        /// <param name="score">Score</param>
        public override sealed void Render(Score score)
        {
            CurrentScore = score;
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
            if (Settings.IsPanoramaMode && scoreService.CurrentSystem != null && scoreService.CurrentSystem.Height == 0)
            {
                scoreService.CurrentSystem.Height = (scoreService.CurrentStaffHeight + Settings.LineSpacing) * scoreService.CurrentScore.Staves.Count;
            }

            foreach (var finishingTouch in FinishingTouches) finishingTouch.PerformOnScore(score, this);
        }
    }
}