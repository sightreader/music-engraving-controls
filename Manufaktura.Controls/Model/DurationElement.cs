using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    public abstract class DurationElement : MusicalSymbol, IHasDuration
    {
        protected RhythmicDuration duration;
        private TupletType tuplet = TupletType.None;
        protected DurationElement()
        {
            Voice = 1;
        }

        /// <summary>
        /// Duration without dots.
        /// </summary>
        public RhythmicDuration BaseDuration => Duration.WithoutDots;

        /// <summary>
        /// RhythmicDuraton of this PlaybackSuggestion
        /// </summary>
        public virtual RhythmicDuration Duration { get { return duration; } set { duration = value; } } 
        /// <summary>
        /// Returns number of dots associated with this DurationElement.
        /// </summary>
        public int NumberOfDots
        {
            get
            {
                return Duration.Dots;
            }
            set
            {
                Duration = new RhythmicDuration(BaseDuration.Denominator, value);
            }
        }

        /// <summary>
        /// Tuplet information
        /// </summary>
        public TupletType Tuplet { get { return tuplet; } set { tuplet = value; OnPropertyChanged(); } }
        /// <summary>
        /// Voice number.
        /// </summary>
        public int Voice { get; set; }
    }
}