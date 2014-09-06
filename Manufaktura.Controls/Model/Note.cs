using Manufaktura.Controls.Primitives;
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
        protected int voice = 1;
        protected int dynamics = 80;
        protected Point stemEndLocation = new Point();

        #endregion

        #region Properties

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
        public string Step { get { return step; } }
        public int Octave { get { return octave; } }
        public int Alter { get { return alter; } }
        public int MidiPitch { get { return midiPitch; } }
        public int Voice { get { return voice; } set { voice = value; } }
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
            DetermineMusicalCharacter();
        }

        public Note() : this("A", 0, 4, MusicalSymbolDuration.Quarter, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
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
            int midiPitchInLowestOctave = midiPitch;

            while (midiPitchInLowestOctave > 32) midiPitchInLowestOctave -= 12;
            if (midiPitchInLowestOctave == 21) { step = "A"; alter = 0; }
            else if (midiPitchInLowestOctave == 22) { step = "B"; alter = -1; }
            else if (midiPitchInLowestOctave == 23) { step = "B"; alter = 0; }
            else if (midiPitchInLowestOctave == 24) { step = "C"; alter = 0; }
            else if (midiPitchInLowestOctave == 25) { step = "C"; alter = 1; }
            else if (midiPitchInLowestOctave == 26) { step = "D"; alter = 0; }
            else if (midiPitchInLowestOctave == 27) { step = "E"; alter = -1; }
            else if (midiPitchInLowestOctave == 28) { step = "E"; alter = 0; }
            else if (midiPitchInLowestOctave == 29) { step = "F"; alter = 0; }
            else if (midiPitchInLowestOctave == 30) { step = "F"; alter = 1; }
            else if (midiPitchInLowestOctave == 31) { step = "G"; alter = 0; }
            else if (midiPitchInLowestOctave == 32) { step = "G"; alter = 1; }

            if (midiPitch < 24) octave = 0;
            else if (midiPitch < 36) octave = 1;
            else if (midiPitch < 48) octave = 2;
            else if (midiPitch < 60) octave = 3;
            else if (midiPitch < 72) octave = 4;
            else if (midiPitch < 84) octave = 5;
            else if (midiPitch < 96) octave = 6;
            else if (midiPitch < 108) octave = 7;
            else if (midiPitch < 120) octave = 8;

            this.midiPitch = midiPitch; 
        }

        #endregion

        #region Public static functions

        public static Note FromMidiPitch(int midiPitch)
        {
            Note note = new Note();
            note.ApplyMidiPitch(midiPitch);
            return note;
        }

        #endregion

    }
}
