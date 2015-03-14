using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Note : NoteOrRest, IHasPitch
    {
        #region Protected fields

        protected Pitch pitch;
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
        public Slur Slur { get { return slur; } set { slur = value; OnPropertyChanged(() => Slur); } }
        public NoteTrillMark TrillMark { get { return trillMark; } set { trillMark = value; OnPropertyChanged(() => TrillMark); } }

        public double StemDefaultY { get { return stemDefaultY; } set { stemDefaultY = value; } }

        public List<Lyrics> Lyrics { get { return lyrics; } set { lyrics = value; OnPropertyChanged(() => Lyrics); } }
        public ArticulationType Articulation { get { return articulation; } set { articulation = value; OnPropertyChanged(() => Articulation); } }
        public VerticalPlacement ArticulationPlacement
        {
            get { return articulationPlacement; }
            set { articulationPlacement = value; }
        }
        public bool HasNatural { get { return hasNatural; } set { hasNatural = value; } }
        public bool IsGraceNote { get { return isGraceNote; } set { isGraceNote = value; OnPropertyChanged(() => IsGraceNote); } }
        public bool IsCueNote { get; set; }
        public bool IsChordElement { get { return isChordElement; } set { isChordElement = value; OnPropertyChanged(() => IsChordElement); } }
        public int TremoloLevel { get { return tremoloLevel; } set { tremoloLevel = value; OnPropertyChanged(() => TremoloLevel); } }
        public string NoteFlagCharacter { get { return noteFlagCharacter; } }
        public string NoteFlagCharacterRev { get { return noteFlagCharacterRev; } }

        public Point StemEndLocation { get { return stemEndLocation; } set { stemEndLocation = value; OnPropertyChanged(() => StemEndLocation); } }
        public double ActualStemLength { get { return Math.Abs(StemEndLocation.Y - TextBlockLocation.Y); } }

        public VerticalDirection StemDirection { get { return stemDirection; } set { stemDirection = value; OnPropertyChanged(() => StemDirection); } }
        public NoteTieType TieType { get { return tieType; } set { tieType = value; OnPropertyChanged(() => TieType); } }
        public List<NoteBeamType> BeamList { get { return beamList; } }
        public string Step { get { return pitch.StepName; } }
        public int Octave { get { return pitch.Octave; } }
        public int Alter { get { return pitch.Alter; } }
        public int MidiPitch { get { return pitch.MidiPitch; } }
        public Pitch Pitch { get { return pitch; } set { pitch = value; OnPropertyChanged(() => Pitch); } }
        public int Dynamics { get { return dynamics; } set { dynamics = value; } }


        #endregion

        #region Constructor

        public Note(Pitch notePitch, RhythmicDuration noteDuration, VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList)
        {
            type = MusicalSymbolType.Note;
            Duration = noteDuration;
            pitch = notePitch;
            stemDirection = noteStemDirection;
            beamList = noteBeamList;
            tieType = noteTieType;
            Lyrics = new List<Lyrics>();
            Ornaments = new List<Ornament>();
            DetermineMusicalCharacter();
        }

        public Note(RhythmicDuration noteDuration)
            : this("A", 0, 4, noteDuration, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {

        }

        public Note(string noteStep, int noteAlter, int noteOctave, RhythmicDuration noteDuration,
            VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList) :
            this(new Music.Model.Pitch(noteStep, noteAlter, noteOctave), noteDuration, noteStemDirection, noteTieType, noteBeamList)
        {

        }

        public Note()
            : this("A", 0, 4, RhythmicDuration.Quarter, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {

        }

        #endregion

        #region Private methods

        private void DetermineMusicalCharacter()
        {
            if (BaseDuration == RhythmicDuration.Whole) musicalCharacter = MusicFont.WholeNote;
            else if (BaseDuration == RhythmicDuration.Half) musicalCharacter = MusicFont.WhiteNoteHead;
            else if (BaseDuration == RhythmicDuration.Quarter) musicalCharacter = MusicFont.BlackNoteHead;
            else if (BaseDuration == RhythmicDuration.Eighth) musicalCharacter = MusicFont.BlackNoteHead;
            else if (BaseDuration == RhythmicDuration.Sixteenth) musicalCharacter = MusicFont.BlackNoteHead;
            else if (BaseDuration == RhythmicDuration.D32nd) musicalCharacter = MusicFont.BlackNoteHead;
            else if (BaseDuration == RhythmicDuration.D64th) musicalCharacter = MusicFont.BlackNoteHead;
            else if (BaseDuration == RhythmicDuration.D128th) musicalCharacter = MusicFont.BlackNoteHead;
            else musicalCharacter = MusicFont.BlackNoteHead;

            if (BaseDuration == RhythmicDuration.Eighth)
            {
                noteFlagCharacter = MusicFont.NoteFlagEighth;
                noteFlagCharacterRev = MusicFont.NoteFlagEighthRev;
            }
            else if (BaseDuration == RhythmicDuration.Sixteenth)
            {
                noteFlagCharacter = MusicFont.NoteFlagSixteenth;
                noteFlagCharacterRev = MusicFont.NoteFlagSixteenthRev;
            }
            else if (BaseDuration == RhythmicDuration.D32nd)
            {
                noteFlagCharacter = MusicFont.NoteFlag32nd;
                noteFlagCharacterRev = MusicFont.NoteFlag32ndRev;
            }
            else if (BaseDuration == RhythmicDuration.D64th)
            {
                noteFlagCharacter = MusicFont.NoteFlag64th;
                noteFlagCharacterRev = MusicFont.NoteFlag64thRev;
            }
            else if (BaseDuration == RhythmicDuration.D128th)
            {
                noteFlagCharacter = MusicFont.NoteFlag128th;
                noteFlagCharacterRev = MusicFont.NoteFlag128thRev;
            }
        }

        #endregion

        #region Public methods

        public int StepToStepNumber()
        {
            if (Step == "C") return 0;
            else if (Step == "D") return 1;
            else if (Step == "E") return 2;
            else if (Step == "F") return 3;
            else if (Step == "G") return 4;
            else if (Step == "A") return 5;
            else if (Step == "B") return 6;
            else return 0;
        }

        public void ApplyMidiPitch(int midiPitch)
        {
            pitch = Pitch.FromMidiPitch(midiPitch, Pitch.MidiPitchTranslationMode.Auto);
        }

        #endregion

        #region Public static functions

        public static Note FromMidiPitch(int midiPitch, RhythmicDuration duration)
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

        public static Note FromPitch(Pitch pitch, RhythmicDuration duration)
        {
            Note note = new Note(duration);
            note.Pitch = pitch;
            return note;
        }

        public static Note FromPitch(Pitch pitch)
        {
            Note note = new Note();
            note.Pitch = pitch;
            return note;
        }

        #endregion

    }
}
