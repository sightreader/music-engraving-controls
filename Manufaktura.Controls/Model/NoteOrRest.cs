using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Base class that represents note or rest.
	/// </summary>
	public abstract class NoteOrRest : MusicalSymbol, IHasDuration, ICanBeElementOfTuplet, IHasCustomXPosition, IRenderedAsTextBlock
	{
		protected bool hasFermataSign = false;
		protected Point location = new Point();
		protected string musicalCharacter;
		protected TupletType tuplet = TupletType.None;
		protected RhythmicDuration duration;
		private IMusicFont musicFont = new PolihymniaFont();

		protected NoteOrRest()
		{
			Voice = 1;
		}

		/// <summary>
		/// Duration without dots.
		/// </summary>
		public RhythmicDuration BaseDuration
		{
			get
			{
				return Duration.WithoutDots;
			}
		}

		public double? DefaultXPosition { get; set; }

		public virtual RhythmicDuration Duration { get { return duration; } set { duration = value; OnPropertyChanged(() => Duration); } }

		/// <summary>
		/// Indicates if note has fermata sign
		/// </summary>
		public bool HasFermataSign { get { return hasFermataSign; } set { hasFermataSign = value; OnPropertyChanged(() => HasFermataSign); } }

		public string MusicalCharacter
		{
			get { return musicalCharacter; }
		}

		/// <summary>
		/// Music font used to draw the note
		/// </summary>
		public IMusicFont MusicFont { get { return musicFont; } set { musicFont = value; OnPropertyChanged(() => MusicFont); } }

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

		public Point TextBlockLocation { get { return location; } set { location = value; } }

		public TupletType Tuplet { get { return tuplet; } set { tuplet = value; } }

		public double? TupletWeightOverride { get; set; }
		public VerticalPlacement? TupletPlacement { get; set; }

		/// <summary>
		/// Voice number.
		/// </summary>
		public int Voice { get; set; }

		/// <summary>
		/// Creates a Note or a Rest from RhythmicUnit.
		/// </summary>
		/// <param name="unit"></param>
		/// <returns></returns>
		public static NoteOrRest FromRhythmicUnit(RhythmicUnit unit)
		{
			return unit.IsRest ? (NoteOrRest)new Rest(unit.Duration) : new Note(unit.Duration);
		}
	}
}