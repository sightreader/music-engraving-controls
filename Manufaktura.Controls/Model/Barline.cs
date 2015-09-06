namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a barline.
    /// </summary>
    public class Barline : MusicalSymbol
    {
        private RepeatSignType repeatSign;

        public HorizontalPlacement Location { get; set; }

        public RepeatSignType RepeatSign { get { return repeatSign; } set { repeatSign = value; } }

        public override MusicalSymbolType Type
        {
            get
            {
                return MusicalSymbolType.Barline;
            }
        }

        /// <summary>
        /// Initializes a new instance of Barline.
        /// </summary>
        public Barline()
        {
            Location = HorizontalPlacement.Right;
            repeatSign = RepeatSignType.None;
        }
    }
}