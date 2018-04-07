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

        /// <summary>
        /// Initializes a new instance of Barline with specific BarlineStyle
        /// </summary>
        public Barline(BarlineStyle style) : this()
        {
            Style = style;
        }

        /// <summary>
        /// Barline horizontal location
        /// </summary>
        public HorizontalPlacement Location { get; set; }

        public double RenderedXPositionForFirstStaffInMultiStaffPart { get; internal set; }
        /// <summary>
        /// Barline repeat sign
        /// </summary>
		public RepeatSignType RepeatSign { get { return repeatSign; } set { repeatSign = value; } }

        /// <summary>
        /// Barline style
        /// </summary>
		public BarlineStyle Style { get; set; } = BarlineStyle.Regular;
	}
}