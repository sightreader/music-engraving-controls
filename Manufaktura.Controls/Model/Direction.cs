using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Direction : MusicalSymbol
    {
        #region Protected fields

        protected string text = "";
        protected DirectionPlacementType placement = DirectionPlacementType.Above;
        protected int defaultY = 0;   

        #endregion

        #region Properties

        public string Text { get { return text; } set { text = value; } }
        public DirectionPlacementType Placement { get { return placement; } set { placement = value; } }
        public int DefaultY { get { return defaultY; } set { defaultY = value; } }

        #endregion

        #region Constructor

        public Direction()
        {
            type = MusicalSymbolType.Direction;
        }

        #endregion
    }
}
