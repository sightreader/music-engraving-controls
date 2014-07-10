using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class ClefRenderStrategy : MusicalSymbolRenderStrategy<Clef>
    {

        public override void Render(Clef element, ScoreRendererBase renderer)
        {
            //Don't draw clef if it's current clef:
            if (element.ClefPitch == renderer.State.CurrentClef.ClefPitch && element.Line == renderer.State.CurrentClef.Line) return;


            currentClefPositionY = lines[4] - 24.4f - (((Clef)symbol).Line - 1) * lineSpacing;
            currentClef = (Clef)symbol;
            g.DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                currentXPosition, currentClefPositionY);
            currentXPosition += 20;
        }
    }
}
