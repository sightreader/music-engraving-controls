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
            float timeSignaturePositionY = (lines[0] - 11);
            if (print) timeSignaturePositionY -= 0.6f;
            if (((TimeSignature)symbol).SignatureType == TimeSignatureType.Common)
                g.DrawString(MusicalCharacters.CommonTime, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                currentXPosition, timeSignaturePositionY);
            else if (((TimeSignature)symbol).SignatureType == TimeSignatureType.Cut)
                g.DrawString(MusicalCharacters.CutTime, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                currentXPosition, timeSignaturePositionY);
            else
            {
                g.DrawString(Convert.ToString(((TimeSignature)symbol).NumberOfBeats),
                    FontStyles.TimeSignatureFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, timeSignaturePositionY + 9);
                g.DrawString(Convert.ToString(((TimeSignature)symbol).TypeOfBeats),
                    FontStyles.TimeSignatureFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, timeSignaturePositionY + 21);
            }
            currentXPosition += 20;
        }
    }
}
