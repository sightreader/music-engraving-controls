using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Note : NoteOrRest
    {
        #region Protected fields

        protected int midiPitch;
        protected string step;
        protected int octave;
        protected int alter;
        protected double stemDefaultY;
        protected bool customStemEndPosition = false;
        protected string noteFlagCharacter = " ";
        protected string noteFlagCharacterRev = " ";
        protected VerticalDirection stemDirection = VerticalDirection.Up;
        protected NoteTieType tieType = NoteTieType.None;
        protected List<NoteBeamType> beamList = new List<NoteBeamType>();

        protected List<Lyrics> lyrics = new List<Lyrics>();
        protected ArticulationType articulation = ArticulationType.None;
        protected VerticalPlacement articulationPlacement = VerticalPlacement.Below;
        protected bool hasNatural = false;
        protected bool isGraceNote = false;
        protected bool isChordElement = false;
        protected int currentTempo = 120;
        protected NoteTrillMark trillMark = NoteTrillMark.None;
        protected Slur slur;
        protected bool hasFermataSign = false;
        protected int tremoloLevel = 0; //1 - eights (quavers), 2 - sixteenths (semiquavers), etc. / 1 - ósemki, 2 - szesnastki, itp.
        protected int dynamics = 80;
        protected Point stemEndLocation = new Point();

        #endregion

        #region Properties

        public List<Ornament> Ornaments { get; private set; }
        public bool CustomStemEndPosition { get { return customStemEndPosition; } set { customStemEndPosition = value; } }
        public bool HasFermataSign { get { return hasFermataSign; } set { hasFermataSign = value; } }
        public Slur Slur { get { return slur; } set { slur = value; } }
        public NoteTrillMark TrillMark { get { return trillMark; } set { trillMark = value; } }
        public int CurrentTempo { get { return currentTempo; } set { currentTempo = value; } }
        public double StemDefaultY { get { return stemDefaultY; } set { stemDefaultY = value; } }

        public List<Lyrics> Lyrics { get { return lyrics; } set { lyrics = value; } }
        public ArticulationType Articulation { get { return articulation; } set { articulation = value; } }
        public VerticalPlacement ArticulationPlacement
        {
            get { return articulationPlacement; }
            set { articulationPlacement = value; }
        }
        public bool HasNatural { get { return hasNatural; } set { hasNatural = value; } }
        public bool IsGraceNote { get { return isGraceNote; } set { isGraceNote = value; } }
        public bool IsCueNote { get; set; }
        public bool IsChordElement { get { return isChordElement; } set { isChordElement = value; } }
        public int TremoloLevel { get { return tremoloLevel; } set { tremoloLevel = value; } }
        public string NoteFlagCharacter { get { return noteFlagCharacter; } }
        public string NoteFlagCharacterRev { get { return noteFlagCharacterRev; } }

        public Point StemEndLocation { get { return stemEndLocation; } set { stemEndLocation = value; } }
        public double ActualStemLength { get { return Math.Abs(StemEndLocation.Y - TextBlockLocation.Y); } }

        public VerticalDirection StemDirection { get { return stemDirection; } set { stemDirection = value; } }
        public NoteTieType TieType { get { return tieType; } set { tieType = value; } }
        public List<NoteBeamType> BeamList { get { return beamList; } }
        public string Step { get { return step; } protected set { step = value; } }
        public int Octave { get { return octave; } protected set { octave = value; } }
        public int Alter { get { return alter; } protected set { alter = value; } }
        public int MidiPitch { get { return midiPitch; } protected set { midiPitch = value; } }
        public int Dynamics { get { return dynamics; } set { dynamics = value; } }


        #endregion

        #region Constructor

        public Note(string noteStep, int noteAlter, int noteOctave, MusicalSymbolDuration noteDuration,
            VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList)
        {
            type = MusicalSymbolType.Note;
            duration = noteDuration;
            step = noteStep;
            octave = noteOctave;
            alter = noteAlter;
            stemDirection = noteStemDirection;
            beamList = noteBeamList;
            tieType = noteTieType;
            midiPitch = MusicalSymbol.ToMidiPitch(step, alter, octave);
            Lyrics = new List<Lyrics>();
            Ornaments = new List<Ornament>();
            DetermineMusicalCharacter();
        }

        public Note(MusicalSymbolDuration noteDuration)
            : this("A", 0, 4, noteDuration, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {

        }

        public Note()
            : this("A", 0, 4, MusicalSymbolDuration.Quarter, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {

        }

        #endregion

        #region Private methods

        private void DetermineMusicalCharacter()
        {
            if (duration == MusicalSymbolDuration.Whole) musicalCharacter = MusicalCharacters.WholeNote;
            else if (duration == MusicalSymbolDuration.Half) musicalCharacter = MusicalCharacters.WhiteNoteHead;
            else if (duration == MusicalSymbolDuration.Quarter) musicalCharacter = MusicalCharacters.BlackNoteHead;
            else if (duration == MusicalSymbolDuration.Eighth) musicalCharacter = MusicalCharacters.BlackNoteHead;
            else if (duration == MusicalSymbolDuration.Sixteenth) musicalCharacter = MusicalCharacters.BlackNoteHead;
            else if (duration == MusicalSymbolDuration.d32nd) musicalCharacter = MusicalCharacters.BlackNoteHead;
            else if (duration == MusicalSymbolDuration.d64th) musicalCharacter = MusicalCharacters.BlackNoteHead;
            else if (duration == MusicalSymbolDuration.d128th) musicalCharacter = MusicalCharacters.BlackNoteHead;
            else if (duration == MusicalSymbolDuration.Unknown) musicalCharacter = MusicalCharacters.BlackNoteHead;

            if (duration == MusicalSymbolDuration.Eighth)
            {
                noteFlagCharacter = MusicalCharacters.NoteFlagEighth;
                noteFlagCharacterRev = MusicalCharacters.NoteFlagEighthRev;
            }
            else if (duration == MusicalSymbolDuration.Sixteenth)
            {
                noteFlagCharacter = MusicalCharacters.NoteFlagSixteenth;
                noteFlagCharacterRev = MusicalCharacters.NoteFlagSixteenthRev;
            }
            else if (duration == MusicalSymbolDuration.d32nd)
            {
                noteFlagCharacter = MusicalCharacters.NoteFlag32nd;
                noteFlagCharacterRev = MusicalCharacters.NoteFlag32ndRev;
            }
            else if (duration == MusicalSymbolDuration.d64th)
            {
                noteFlagCharacter = MusicalCharacters.NoteFlag64th;
                noteFlagCharacterRev = MusicalCharacters.NoteFlag64thRev;
            }
            else if (duration == MusicalSymbolDuration.d128th)
            {
                noteFlagCharacter = MusicalCharacters.NoteFlag128th;
                noteFlagCharacterRev = MusicalCharacters.NoteFlag128thRev;
            }
        }

        #endregion

        #region Public methods

        public int StepToStepNumber()
        {
            if (step == "C") return 0;
            else if (step == "D") return 1;
            else if (step == "E") return 2;
            else if (step == "F") return 3;
            else if (step == "G") return 4;
            else if (step == "A") return 5;
            else if (step == "B") return 6;
            else return 0;
        }

        public void ApplyMidiPitch(int midiPitch)
        {
            var pitch = Pitch.FromMidiPitch(midiPitch, Pitch.MidiPitchTranslationMode.Auto);
            Alter = pitch.Alter;
            Octave = pitch.Octave;
            Step = pitch.StepName;
            MidiPitch = midiPitch;
        }

        #endregion

        #region Public static functions

        public static Note FromMidiPitch(int midiPitch, MusicalSymbolDuration duration)
        {
            Note note = new Note(duration);
            note.ApplyMidiPitch(midiPitch);
            return note;
        }

        public static Note FromMidiPitch(int midiPitch)
        {
            Note note = new Note();
            note.ApplyMidiPitch(midiPitch);
            return note;
        }

        public static Note FromPitch(Pitch pitch, MusicalSymbolDuration duration)
        {
            Note note = new Note(duration);
            note.Alter = pitch.Alter;
            note.Octave = pitch.Octave;
            note.Step = pitch.StepName;
            note.MidiPitch = pitch.MidiPitch;
            return note;
        }

        public static Note FromPitch(Pitch pitch)
        {
            Note note = new Note();
            note.Alter = pitch.Alter;
            note.Octave = pitch.Octave;
            note.Step = pitch.StepName;
            note.MidiPitch = pitch.MidiPitch;
            return note;
        }

        #endregion

    }
}
