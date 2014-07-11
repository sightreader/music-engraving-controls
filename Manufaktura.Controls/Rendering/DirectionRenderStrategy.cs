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
            Direction dir = ((Direction)symbol);
            float dirPositionY = 0;
            if (dir.Placement == DirectionPlacementType.Custom)
                dirPositionY = dir.DefaultY * -1.0f / 2.0f;
            else if (dir.Placement == DirectionPlacementType.Above)
                dirPositionY = 0;
            else if (dir.Placement == DirectionPlacementType.Below)
                dirPositionY = 50;
            DrawString(dir.Text, FontStyles.DirectionFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, dirPositionY);
        }
    }
}
