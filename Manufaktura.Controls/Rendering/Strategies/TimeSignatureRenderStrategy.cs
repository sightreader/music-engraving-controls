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
            double timeSignaturePositionY = (renderer.State.LinePositions[renderer.State.CurrentSystem][0] - 11);
            if (renderer.State.IsPrintMode) timeSignaturePositionY -= 0.6f;
            if (element.SignatureType == TimeSignatureType.Common)
                renderer.DrawString(MusicalCharacters.CommonTime, FontStyles.MusicFont, 
                renderer.State.CursorPositionX, timeSignaturePositionY, element);
            else if (element.SignatureType == TimeSignatureType.Cut)
                renderer.DrawString(MusicalCharacters.CutTime, FontStyles.MusicFont, 
                renderer.State.CursorPositionX, timeSignaturePositionY, element);
            else
            {
                renderer.DrawString(Convert.ToString(element.NumberOfBeats),
                    FontStyles.TimeSignatureFont, renderer.State.CursorPositionX, timeSignaturePositionY + 9, element);
                renderer.DrawString(Convert.ToString(element.TypeOfBeats),
                    FontStyles.TimeSignatureFont, renderer.State.CursorPositionX, timeSignaturePositionY + 21, element);
            }
            renderer.State.CursorPositionX += 20;
        }
    }
}
