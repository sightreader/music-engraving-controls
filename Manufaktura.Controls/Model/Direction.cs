using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents text directions.
    /// </summary>
    public class Direction : MusicalSymbol
    {
        #region Protected fields

        protected string text = "";
        protected DirectionPlacementType placement = DirectionPlacementType.Above;
        protected int defaultY = 0;   

        #endregion

        #region Properties

        /// <summary>
        /// Direction text.
        /// </summary>
        public string Text { get { return text; } set { text = value; OnPropertyChanged(() => Text); } }
        /// <summary>
        /// Direction placement.
        /// </summary>
        public DirectionPlacementType Placement { get { return placement; } set { placement = value; OnPropertyChanged(() => Placement); } }
        public int DefaultY { get { return defaultY; } set { defaultY = value; OnPropertyChanged(() => DefaultY); } }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of Direction.
        /// </summary>
        public Direction()
        {
            type = MusicalSymbolType.Direction;
        }

        #endregion
    }
}
