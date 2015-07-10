using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
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
            renderer.State.CurrentTimeSignature = element;

            double timeSignaturePositionY = (renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] - 11);
            if (element.SignatureType == TimeSignatureType.Common)
                renderer.DrawString(renderer.State.CurrentFont.CommonTime, MusicFontStyles.MusicFont, 
                renderer.State.CursorPositionX, timeSignaturePositionY, element);
            else if (element.SignatureType == TimeSignatureType.Cut)
                renderer.DrawString(renderer.State.CurrentFont.CutTime, MusicFontStyles.MusicFont, 
                renderer.State.CursorPositionX, timeSignaturePositionY, element);
            else
            {
                renderer.DrawString(Convert.ToString(element.NumberOfBeats),
                    MusicFontStyles.TimeSignatureFont, renderer.State.CursorPositionX, timeSignaturePositionY + 9, element);
                renderer.DrawString(Convert.ToString(element.TypeOfBeats),
                    MusicFontStyles.TimeSignatureFont, renderer.State.CursorPositionX, timeSignaturePositionY + 21, element);
            }
            renderer.State.CursorPositionX += 20;
        }
    }
}
