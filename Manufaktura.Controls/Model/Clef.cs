using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Represents a clef.
	/// </summary>
	public class Clef : MusicalSymbol, IHasPitch, IRenderedAsTextBlock
	{
		private int line;
		private string musicalCharacter;
		private IMusicFont musicFont = new PolihymniaFont();
		private int octaveChange;
		private ClefType typeOfClef;

		/// <summary>
		/// Initializes a new instance of Clef.
		/// </summary>
		/// <param name="clefType">Type of clef (C, F, G)</param>
		/// <param name="whichLine">Line</param>
		public Clef(ClefType clefType, int whichLine, int octaveShift = 0)
		{
			typeOfClef = clefType;
			line = whichLine;
			if (typeOfClef == ClefType.GClef)
			{
				musicalCharacter = MusicFont.GClef;
				Pitch = Pitch.FromStep(Step.G, 4 + octaveShift);
			}
			else if (typeOfClef == ClefType.FClef)
			{
				musicalCharacter = MusicFont.FClef;
				Pitch = Pitch.FromStep(Step.F, 3 + octaveShift);
			}
			else if (typeOfClef == ClefType.CClef)
			{
				musicalCharacter = MusicFont.CClef;
				Pitch = Pitch.FromStep(Step.C, 4 + octaveShift);
			}
            else if (typeOfClef == ClefType.Percussion)
            {
                musicalCharacter = MusicFont.PercussionClef;
                Pitch = Pitch.FromStep(Step.G, 4 + octaveShift);
            }
        }

		/// <summary>
		/// Returns a new instance of alto clef.
		/// </summary>
		public static Clef Alto
		{
			get { return new Clef(ClefType.CClef, 3); }
		}

		/// <summary>
		/// Returns a new instance of baritone "C" clef.
		/// </summary>
		public static Clef BaritoneC
		{
			get { return new Clef(ClefType.CClef, 5); }
		}

		/// <summary>
		/// Returns a new instance of baritone "F" clef.
		/// </summary>
		public static Clef BaritoneF
		{
			get { return new Clef(ClefType.FClef, 3); }
		}

		/// <summary>
		/// Returns a new instance of bass clef.
		/// </summary>
		public static Clef Bass
		{
			get { return new Clef(ClefType.FClef, 4); }
		}

		/// <summary>
		/// Returns a new instance of french violin clef.
		/// </summary>
		public static Clef FrenchViolin
		{
			get { return new Clef(ClefType.GClef, 1); }
		}

		/// <summary>
		/// Returns a new instance of mezzosoprano clef.
		/// </summary>
		public static Clef Mezzosoprano
		{
			get { return new Clef(ClefType.CClef, 2); }
		}

		/// <summary>
		/// Returns a new instance of soprano clef.
		/// </summary>
		public static Clef Soprano
		{
			get { return new Clef(ClefType.CClef, 1); }
		}

		/// <summary>
		/// Returns a new instance of subbass clef.
		/// </summary>
		public static Clef Subbass
		{
			get { return new Clef(ClefType.FClef, 5); }
		}

		/// <summary>
		/// Returns a new instance of tenor clef.
		/// </summary>
		public static Clef Tenor
		{
			get { return new Clef(ClefType.CClef, 4, -1); }
		}

		/// <summary>
		/// Returns a new instance of treble clef.
		/// </summary>
		public static Clef Treble
		{
			get { return new Clef(ClefType.GClef, 2); }
		}

		/// <summary>
		/// Clef line
		/// </summary>
		public int Line { get { return line; } }

		public string MusicalCharacter
		{
			get { return musicalCharacter; }
		}

		public IMusicFont MusicFont { get { return musicFont; } set { musicFont = value; OnPropertyChanged(() => MusicFont); } }

		public int OctaveChange
		{
			get
			{
				return octaveChange;
			}

			set
			{
				if (value > 0) for (var i = 0; i < value; i++) Pitch = Pitch.OctaveUp();
				if (value < 0) for (var i = 0; i > value; i--) Pitch = Pitch.OctaveDown();
				octaveChange = value; OnPropertyChanged(() => OctaveChange);
			}
		}

		/// <summary>
		/// Pitch of clef.
		/// </summary>
		/// <remarks>
		/// Note that only some pitches (steps C, F, G) are valid for clefs.
		/// </remarks>
		public Pitch Pitch { get; private set; }

		public Point TextBlockLocation
		{
			get;
			set;
		}

		/// <summary>
		/// Type of clef (C-clef, G-clef or F-clef)
		/// </summary>
		public ClefType TypeOfClef { get { return typeOfClef; } }

		/// <summary>
		/// This methods selects a appropriate clef for a note to make the note comfortably visible in the staff.
		/// </summary>
		/// <param name="n">Note</param>
		/// <returns>Appropriate clef</returns>
		public static Clef SuggestClefForANote(Note n)
		{
			if (n.MidiPitch < 55) return new Clef(ClefType.FClef, 4);
			else return new Clef(ClefType.GClef, 2);
		}

		/// <summary>
		/// This methods selects a appropriate clef for a note to make the note comfortably visible in the staff.
		/// </summary>
		/// <param name="n">Note</param>
		/// <param name="currentClef">Current clef</param>
		/// <returns>Appropriate clef</returns>
		public static Clef SuggestClefForANote(Note n, Clef currentClef)
		{
			if (currentClef.TypeOfClef == ClefType.GClef)
			{
				if ((currentClef.Line == 1) && (n.MidiPitch < 59)) return new Clef(ClefType.FClef, 4);
				else if ((currentClef.Line == 2) && (n.MidiPitch < 55)) return new Clef(ClefType.FClef, 4);
				else if ((currentClef.Line == 3) && (n.MidiPitch < 52)) return new Clef(ClefType.FClef, 4);
				else if ((currentClef.Line == 4) && (n.MidiPitch < 48)) return new Clef(ClefType.FClef, 4);
				else if ((currentClef.Line == 5) && (n.MidiPitch < 45)) return new Clef(ClefType.FClef, 4);
				else return currentClef;
			}
			else if (currentClef.TypeOfClef == ClefType.FClef)
			{
				if ((currentClef.Line == 1) && (n.MidiPitch > 74)) return new Clef(ClefType.GClef, 2);
				else if ((currentClef.Line == 2) && (n.MidiPitch > 71)) return new Clef(ClefType.GClef, 2);
				else if ((currentClef.Line == 3) && (n.MidiPitch > 67)) return new Clef(ClefType.GClef, 2);
				else if ((currentClef.Line == 4) && (n.MidiPitch > 64)) return new Clef(ClefType.GClef, 2);
				else if ((currentClef.Line == 5) && (n.MidiPitch > 60)) return new Clef(ClefType.GClef, 2);
				else return currentClef;
			}
			else return new Clef(ClefType.GClef, 2);
		}

        /// <summary>
        /// Returns a string representation of this symbol for debugging purposes
        /// </summary>
        /// <returns>String representation of this symbol for debugging purposes</returns>
        public override string ToString()
		{
			return string.Format("{0} {1} on line {2}", base.ToString(), TypeOfClef.ToString(), Line);
		}
	}
}