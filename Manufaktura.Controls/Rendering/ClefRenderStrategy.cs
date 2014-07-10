using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class ClefRenderStrategy : MusicalSymbolRenderStrategy<Clef>
    {

        public override void Render(Clef element, ScoreRendererBase renderer)
        {
            //Don't draw clef if it's current clef:
            if (element.ClefPitch == renderer.State.CurrentClef.ClefPitch && element.Line == renderer.State.CurrentClef.Line) return;


            renderer.State.currentClefPositionY = renderer.State.lines[4] - 24.4f - (element.Line - 1) * renderer.State.lineSpacing;
            renderer.State.CurrentClef = element;
            g.DrawString(element.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                renderer.State.currentXPosition, renderer.State.currentClefPositionY);
            renderer.State.currentXPosition += 20;
        }
    }
}
