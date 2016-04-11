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
    /// Strategy for rendering a Direction.
    /// </summary>
    public class DirectionRenderStrategy : MusicalSymbolRenderStrategy<Direction>
    {
        private readonly IScoreService scoreService;
        public DirectionRenderStrategy(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }

        public override void Render(Direction element, ScoreRendererBase renderer)
        {
            //Performance directions / Wskazówki wykonawcze:
            double dirPositionY = 0;
            if (element.Placement == DirectionPlacementType.Custom)
                dirPositionY = element.DefaultY * -1.0f / 2.0f;
            else if (element.Placement == DirectionPlacementType.Above)
                dirPositionY = 0;
            else if (element.Placement == DirectionPlacementType.Below)
                dirPositionY = 50;
            renderer.DrawString(element.Text, MusicFontStyles.DirectionFont, scoreService.CursorPositionX, dirPositionY, element);
        }
    }
}
