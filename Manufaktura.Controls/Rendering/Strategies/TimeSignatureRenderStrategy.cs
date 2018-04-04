using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a TimeSignature.
    /// </summary>
    public class TimeSignatureRenderStrategy : MusicalSymbolRenderStrategy<TimeSignature>
    {
        private readonly IScoreService scoreService;

        /// <summary>
        /// Initializes a new instance of TimeSignatureRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public TimeSignatureRenderStrategy(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }

        /// <summary>
        /// Renders time signature symbol with specific score renderer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="renderer"></param>
        public override void Render(TimeSignature element, ScoreRendererBase renderer)
        {
            double timeSignaturePositionY = (scoreService.CurrentLinePositions[0] + 3);
            if (element.SignatureType == TimeSignatureType.Common)
                renderer.DrawCharacter(renderer.Settings.CurrentFont.CommonTime, MusicFontStyles.MusicFont, 
                scoreService.CursorPositionX, timeSignaturePositionY + 15, element);
            else if (element.SignatureType == TimeSignatureType.Cut)
                renderer.DrawCharacter(renderer.Settings.CurrentFont.CutTime, MusicFontStyles.MusicFont, 
                scoreService.CursorPositionX, timeSignaturePositionY + 15, element);
            else
            {
                renderer.DrawString(Convert.ToString(element.NumberOfBeats),
                    MusicFontStyles.TimeSignatureFont, scoreService.CursorPositionX, timeSignaturePositionY + 9, element);
                renderer.DrawString(Convert.ToString(element.TypeOfBeats),
                    MusicFontStyles.TimeSignatureFont, scoreService.CursorPositionX, timeSignaturePositionY + 21, element);
            }
            scoreService.CursorPositionX += 20;
        }
    }
}
