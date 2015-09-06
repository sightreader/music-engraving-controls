namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents text directions.
    /// </summary>
    public class Direction : MusicalSymbol
    {
        #region Protected fields

        protected int defaultY = 0;
        protected DirectionPlacementType placement = DirectionPlacementType.Above;
        protected string text = "";

        #endregion Protected fields

        #region Properties

        public int DefaultY { get { return defaultY; } set { defaultY = value; OnPropertyChanged(() => DefaultY); } }

        /// <summary>
        /// Direction placement.
        /// </summary>
        public DirectionPlacementType Placement { get { return placement; } set { placement = value; OnPropertyChanged(() => Placement); } }

        /// <summary>
        /// Direction text.
        /// </summary>
        public string Text { get { return text; } set { text = value; OnPropertyChanged(() => Text); } }

        #endregion Properties

        public override MusicalSymbolType Type
        {
            get
            {
                return MusicalSymbolType.Direction;
            }
        }

        /// <summary>
        /// Initializes a new instance of Direction.
        /// </summary>
        public Direction()
        {
        }
    }
}