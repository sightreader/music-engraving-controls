using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class DirectionRenderStrategy : MusicalSymbolRenderStrategy<Direction>
    {
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
            renderer.DrawString(element.Text, FontStyles.DirectionFont, renderer.State.currentXPosition, dirPositionY);
        }
    }
}
