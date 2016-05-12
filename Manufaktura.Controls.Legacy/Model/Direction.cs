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

		/// <summary>
		/// Initializes a new instance of Direction.
		/// </summary>
		public Direction()
		{
		}

		public double? DefaultYPosition { get { return defaultY; } set { defaultY = value; OnPropertyChanged(() => DefaultYPosition); } }

		/// <summary>
		/// Direction placement.
		/// </summary>
		public DirectionPlacementType Placement { get { return placement; } set { placement = value; OnPropertyChanged(() => Placement); } }

		/// <summary>
		/// Direction text.
		/// </summary>
		public string Text { get { return text; } set { text = value; OnPropertyChanged(() => Text); } }
	}
}