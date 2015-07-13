using Manufaktura.Controls.Music;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    public class Note : NoteOrRest, IHasPitch
    {
        #region Protected fields

        protected ArticulationType articulation = ArticulationType.None;
        protected VerticalPlacement articulationPlacement = VerticalPlacement.Below;
        protected List<NoteBeamType> beamList = new List<NoteBeamType>();
        protected int currentTempo = 120;
        protected bool customStemEndPosition = false;
        protected int dynamics = 80;
        protected bool hasFermataSign = false;
        protected bool hasNatural = false;
        protected bool isChordElement = false;
        protected bool isGraceNote = false;
        protected List<Lyrics> lyrics = new List<Lyrics>();
        protected string noteFlagCharacter = " ";
        protected string noteFlagCharacterRev = " ";
        protected Pitch pitch;
        protected Slur slur;
        protected double stemDefaultY;
        protected VerticalDirection stemDirection = VerticalDirection.Up;
        protected Point stemEndLocation = new Point();
        protected NoteTieType tieType = NoteTieType.None;
        protected int tremoloLevel = 0;
        protected NoteTrillMark trillMark = NoteTrillMark.None;
        //1 - eights (quavers), 2 - sixteenths (semiquavers), etc. / 1 - ósemki, 2 - szesnastki, itp.

        #endregion Protected fields

        #region Properties

        public double ActualStemLength { get { return Math.Abs(StemEndLocation.Y - TextBlockLocation.Y); } }
        public bool SubjectToNoteStemRule { get; private set; }

        public int Alter { get { return pitch.Alter; } }

        public ArticulationType Articulation { get { return articulation; } set { articulation = value; OnPropertyChanged(() => Articulation); } }

        public VerticalPlacement ArticulationPlacement
        {
            get { return articulationPlacement; }
            set { articulationPlacement = value; }
        }

        public List<NoteBeamType> BeamList { get { return beamList; } }

        public int Dynamics { get { return dynamics; } set { dynamics = value; } }

        public bool HasCustomStemEndPosition { get { return customStemEndPosition; } set { customStemEndPosition = value; } }

        public bool HasFermataSign { get { return hasFermataSign; } set { hasFermataSign = value; } }

        public bool HasNatural { get { return hasNatural; } set { hasNatural = value; } }

        public bool IsChordElement { get { return isChordElement; } set { isChordElement = value; OnPropertyChanged(() => IsChordElement); } }

        public bool IsCueNote { get; set; }

        public bool IsGraceNote { get { return isGraceNote; } set { isGraceNote = value; OnPropertyChanged(() => IsGraceNote); } }

        public List<Lyrics> Lyrics { get { return lyrics; } set { lyrics = value; OnPropertyChanged(() => Lyrics); } }

        public int MidiPitch { get { return pitch.MidiPitch; } }

        public string NoteFlagCharacter { get { return noteFlagCharacter; } }

        public string NoteFlagCharacterRev { get { return noteFlagCharacterRev; } }

        public int Octave { get { return pitch.Octave; } }

        public List<Ornament> Ornaments { get; private set; }

        public Pitch Pitch { get { return pitch; } set { pitch = value; OnPropertyChanged(() => Pitch); } }

        public Slur Slur { get { return slur; } set { slur = value; OnPropertyChanged(() => Slur); } }

        public double StemDefaultY { get { return stemDefaultY; } set { stemDefaultY = value; } }

        public VerticalDirection StemDirection { get { return stemDirection; } set { stemDirection = value; OnPropertyChanged(() => StemDirection); } }

        public Point StemEndLocation { get { return stemEndLocation; } set { stemEndLocation = value; OnPropertyChanged(() => StemEndLocation); } }

        public string Step { get { return pitch.StepName; } }

        public NoteTieType TieType { get { return tieType; } set { tieType = value; OnPropertyChanged(() => TieType); } }

        public int TremoloLevel { get { return tremoloLevel; } set { tremoloLevel = value; OnPropertyChanged(() => TremoloLevel); } }

        public NoteTrillMark TrillMark { get { return trillMark; } set { trillMark = value; OnPropertyChanged(() => TrillMark); } }

        #endregion Properties

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

        public Note(Pitch notePitch, RhythmicDuration noteDuration, VerticalDirection noteStemDirection)
            : this(notePitch, noteDuration, noteStemDirection, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        public Note(Pitch notePitch, RhythmicDuration noteDuration, bool determineStemDirectionOnAddingToStaff = true)
            : this(notePitch, noteDuration, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
            SubjectToNoteStemRule = determineStemDirectionOnAddingToStaff;
        }

        public Note(string noteStep, int noteAlter, int noteOctave, RhythmicDuration noteDuration,
            VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList) :
            this(new Pitch(noteStep, noteAlter, noteOctave), noteDuration, noteStemDirection, noteTieType, noteBeamList)
        {
        }

        public Note()
            : this("A", 0, 4, RhythmicDuration.Quarter, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        #endregion Constructor

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

        #endregion Private methods

        #region Public methods

        public void ApplyMidiPitch(int midiPitch)
        {
            pitch = Pitch.FromMidiPitch(midiPitch, Pitch.MidiPitchTranslationMode.Auto);
        }

        public double GetLineInSpecificClef(Clef clef)
        {
            var stepDistance = (double)Pitch.StepDistance(this, clef);
            return clef.Line + (stepDistance / 2);
        }

        #endregion Public methods

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

        #endregion Public static functions
    }
}