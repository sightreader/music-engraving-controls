using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class ClefRenderStrategy : MusicalSymbolRenderStrategy<Clef>
    {
        private readonly IScoreService scoreService;
        public ClefRenderStrategy(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }
        public bool WasSystemChanged { get; set; }

        public override void Render(Clef element, ScoreRendererBase renderer)
        {
            //Don't draw clef if it's current clef:
            if (!WasSystemChanged && element.Pitch == renderer.State.CurrentClef.Pitch && element.Line == renderer.State.CurrentClef.Line) return;

            renderer.State.CurrentClefTextBlockPositionY = scoreService.CurrentLinePositions[4] - 24.4f - (element.Line - 1) * renderer.Settings.LineSpacing;
            renderer.State.CurrentClef = element;
            renderer.DrawString(element.MusicalCharacter, MusicFontStyles.MusicFont, renderer.State.CursorPositionX, renderer.State.CurrentClefTextBlockPositionY, element);
            renderer.State.CursorPositionX += 20;
        }
    }
}
