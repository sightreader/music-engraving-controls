using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents text directions.
    /// </summary>
    public class Direction : MusicalSymbol, IHasCustomYPosition
    {
        private double? defaultY = 0;
        private DirectionPlacementType placement = DirectionPlacementType.Above;
        private string text = "";

        /// <summary>
        /// Initializes a new instance of Direction.
        /// </summary>
        public Direction()
        {
        }

        /// <summary>
        /// Default Y position
        /// </summary>
		public double? DefaultYPosition { get { return defaultY; } set { defaultY = value; OnPropertyChanged(); } }

        /// <summary>
        /// Direction placement.
        /// </summary>
        public DirectionPlacementType Placement { get { return placement; } set { placement = value; OnPropertyChanged(); } }

        /// <summary>
        /// Direction text.
        /// </summary>
        public string Text { get { return text; } set { text = value; OnPropertyChanged(); } }

        public DirectionPlaybackEffect PlaybackEffect { get; set; }
    }

    public struct DirectionPlaybackEffect
    {
        public string DalSegno { get; set; }
        public bool IsFine { get; set; }

        public Tempo? Tempo { get; set; }
    }
}