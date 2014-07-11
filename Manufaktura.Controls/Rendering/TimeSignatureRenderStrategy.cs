using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class TimeSignatureRenderStrategy : MusicalSymbolRenderStrategy<TimeSignature>
    {
        public override void Render(TimeSignature element, ScoreRendererBase renderer)
        {
            double timeSignaturePositionY = (renderer.State.lines[0] - 11);
            if (renderer.State.print) timeSignaturePositionY -= 0.6f;
            if (element.SignatureType == TimeSignatureType.Common)
                renderer.DrawString(MusicalCharacters.CommonTime, FontStyles.MusicFont, 
                renderer.State.currentXPosition, timeSignaturePositionY);
            else if (element.SignatureType == TimeSignatureType.Cut)
                renderer.DrawString(MusicalCharacters.CutTime, FontStyles.MusicFont, 
                renderer.State.currentXPosition, timeSignaturePositionY);
            else
            {
                renderer.DrawString(Convert.ToString(element.NumberOfBeats),
                    FontStyles.TimeSignatureFont, renderer.State.currentXPosition, timeSignaturePositionY + 9);
                renderer.DrawString(Convert.ToString(element.TypeOfBeats),
                    FontStyles.TimeSignatureFont, renderer.State.currentXPosition, timeSignaturePositionY + 21);
            }
            renderer.State.currentXPosition += 20;
        }
    }
}
