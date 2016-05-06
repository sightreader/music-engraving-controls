namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents text directions.
    /// </summary>
    public class Direction : MusicalSymbol, IHasCustomYPosition
    {
        protected double? defaultY = 0;
        protected DirectionPlacementType placement = DirectionPlacementType.Above;
        protected string text = "";

        public double? DefaultYPosition { get { return defaultY; } set { defaultY = value; OnPropertyChanged(); } }

        /// <summary>
        /// Direction placement.
        /// </summary>
        public DirectionPlacementType Placement { get { return placement; } set { placement = value; OnPropertyChanged(() => Placement); } }

        /// <summary>
        /// Direction text.
        /// </summary>
        public string Text { get { return text; } set { text = value; OnPropertyChanged(() => Text); } }

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