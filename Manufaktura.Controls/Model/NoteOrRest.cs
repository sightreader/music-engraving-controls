using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Base class that represents note or rest.
    /// </summary>
    public abstract class NoteOrRest : DurationElement, ICanBeElementOfTuplet, IHasCustomXPosition, IRenderedAsTextBlock
    {
        protected bool hasFermataSign = false;
        protected Point location = new Point();
        protected char musicalCharacter;
        private IMusicFont musicFont = new PolihymniaFont();

        /// <summary>
        /// Default X position of note or rest
        /// </summary>
		public double? DefaultXPosition { get; set; }

        /// <summary>
        /// Indicates if note has fermata sign
        /// </summary>
        public bool HasFermataSign { get { return hasFermataSign; } set { hasFermataSign = value; OnPropertyChanged(); } }

        public char MusicalCharacter => musicalCharacter;

        /// <summary>
        /// Music font used to draw the note
        /// </summary>
        public IMusicFont MusicFont { get { return musicFont; } set { musicFont = value; OnPropertyChanged(); } }

        /// <summary>
        /// Position of text block part of this NoteOrRest. Rests are rendered wholly as text blocks.
        /// Notes are rendered as text blocks (noteheads and flags) and lines (stems and beams).
        /// </summary>
		public Point TextBlockLocation { get { return location; } set { location = value; } }

        /// <summary>
        /// Only applicable if this NoteOrRest is part of a tuplet. If null, the number above tuplet is calculated as sum of (R_min / R_n)
        /// where R_min in the smallest rhythmic duration denominator and R_n is rhythmic duration denominator of n-th element.
        /// If not null, TupletWeightOverride will be used instead of (R_min / R_n).
        /// </summary>
		public double? TupletWeightOverride { get; set; }

        /// <summary>
        /// Tuplet sign placement (above or below).
        /// </summary>
		public VerticalPlacement? TupletPlacement { get; set; }

        /// <summary>
        /// Creates a Note or Rest from RhythmicUnit.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static NoteOrRest FromRhythmicUnit(RhythmicUnit unit)
        {
            return unit.IsRest ? (NoteOrRest)new Rest(unit.Duration) : new Note(unit.Duration);
        }
    }
}