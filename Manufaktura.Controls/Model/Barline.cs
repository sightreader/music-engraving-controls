namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Represents a barline.
	/// </summary>
	public class Barline : MusicalSymbol
	{
		private RepeatSignType repeatSign;

		/// <summary>
		/// Initializes a new instance of Barline.
		/// </summary>
		public Barline()
		{
			Location = HorizontalPlacement.Right;
			repeatSign = RepeatSignType.None;
		}

		public Barline(BarlineStyle style) : this()
		{
			Style = style;
		}

		public HorizontalPlacement Location { get; set; }

		public RepeatSignType RepeatSign { get { return repeatSign; } set { repeatSign = value; } }

		public BarlineStyle Style { get; set; } = BarlineStyle.Regular;
	}
}