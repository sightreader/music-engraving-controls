using Manufaktura.Controls.Music;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a note.
    /// </summary>
    public class Note : NoteOrRest, IHasPitch, ICanBeUpperMemberOfChord
    {
        private ArticulationType articulation = ArticulationType.None;
        private VerticalPlacement articulationPlacement = VerticalPlacement.Below;
        private List<NoteBeamType> beamList = new List<NoteBeamType>();
        private bool customStemEndPosition = false;
        private bool hasNatural = false;
        private bool isChordElement = false;
        private bool isGraceNote = false;
        private List<Lyrics> lyrics = new List<Lyrics>();
        private string noteFlagCharacter = " ";
        private string noteFlagCharacterRev = " ";
        private Pitch pitch;
        private Slur slur;
        private double stemDefaultY;
        private VerticalDirection stemDirection = VerticalDirection.Up;
        private Point stemEndLocation = new Point();
        private NoteTieType tieType = NoteTieType.None;
        private int tremoloLevel = 0;
        private NoteTrillMark trillMark = NoteTrillMark.None;
        //1 - eights (quavers), 2 - sixteenths (semiquavers), etc. / 1 - ósemki, 2 - szesnastki, itp.

        public double ActualStemLength { get { return Math.Abs(StemEndLocation.Y - TextBlockLocation.Y); } }

        public int Alter { get { return pitch.Alter; } }

        public ArticulationType Articulation { get { return articulation; } set { articulation = value; OnPropertyChanged(() => Articulation); } }

        public VerticalPlacement ArticulationPlacement
        {
            get { return articulationPlacement; }
            set { articulationPlacement = value; }
        }

        public List<NoteBeamType> BeamList { get { return beamList; } }

        public bool HasCustomStemEndPosition { get { return customStemEndPosition; } set { customStemEndPosition = value; } }

        /// <summary>
        /// Indicates that the note has a natural sign.
        /// </summary>
        public bool HasNatural { get { return hasNatural; } set { hasNatural = value; OnPropertyChanged(() => HasNatural); } }

        /// <summary>
        /// Indicates that the note belongs to a chord.
        /// </summary>
        public bool IsUpperMemberOfChord { get { return isChordElement; } set { isChordElement = value; OnPropertyChanged(() => IsUpperMemberOfChord); } }

        /// <summary>
        /// Indicates that the note is cue note.
        /// </summary>
        public bool IsCueNote { get; set; }

        /// <summary>
        /// Indicates that the note is grace note.
        /// </summary>
        public bool IsGraceNote { get { return isGraceNote; } set { isGraceNote = value; OnPropertyChanged(() => IsGraceNote); } }

        public List<Lyrics> Lyrics { get { return lyrics; } set { lyrics = value; OnPropertyChanged(() => Lyrics); } }

        public int MidiPitch { get { return pitch.MidiPitch; } }

        public string NoteFlagCharacter { get { return noteFlagCharacter; } }

        public string NoteFlagCharacterRev { get { return noteFlagCharacterRev; } }

        /// <summary>
        /// Gets octave number of the note's pitch.
        /// </summary>
        public int Octave { get { return pitch.Octave; } }

        /// <summary>
        /// List of ornaments applied on the note.
        /// </summary>
        public List<Ornament> Ornaments { get; private set; }

        /// <summary>
        /// Pitch of note.
        /// </summary>
        public Pitch Pitch { get { return pitch; } set { pitch = value; OnPropertyChanged(() => Pitch); } }

        public Slur Slur { get { return slur; } set { slur = value; OnPropertyChanged(() => Slur); } }

        public double StemDefaultY { get { return stemDefaultY; } set { stemDefaultY = value; } }

        public VerticalDirection StemDirection { get { return stemDirection; } set { stemDirection = value; OnPropertyChanged(() => StemDirection); } }

        public Point StemEndLocation { get { return stemEndLocation; } set { stemEndLocation = value; OnPropertyChanged(() => StemEndLocation); } }

        /// <summary>
        /// Step of note.
        /// </summary>
        public string Step { get { return pitch.StepName; } }

        public bool SubjectToNoteStemRule { get; private set; }

        public NoteTieType TieType { get { return tieType; } set { tieType = value; OnPropertyChanged(() => TieType); } }

        public int TremoloLevel { get { return tremoloLevel; } set { tremoloLevel = value; OnPropertyChanged(() => TremoloLevel); } }

        public NoteTrillMark TrillMark { get { return trillMark; } set { trillMark = value; OnPropertyChanged(() => TrillMark); } }

        public override MusicalSymbolType Type
        {
            get
            {
                return MusicalSymbolType.Note;
            }
        }

        /// <summary>
        /// Creates a new instance of a Note.
        /// </summary>
        /// <param name="notePitch">Pitch</param>
        /// <param name="noteDuration">Duration</param>
        /// <param name="noteStemDirection">Stem direction</param>
        /// <param name="noteTieType">Tie type</param>
        /// <param name="noteBeamList">Beam list</param>
        public Note(Pitch notePitch, RhythmicDuration noteDuration, VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList)
        {
            Duration = noteDuration;
            pitch = notePitch;
            stemDirection = noteStemDirection;
            beamList = noteBeamList;
            tieType = noteTieType;
            Lyrics = new List<Lyrics>();
            Ornaments = new List<Ornament>();
            DetermineMusicalCharacter();
        }

        /// <summary>
        /// Create a new A4 note with a specific duration.
        /// </summary>
        /// <param name="noteDuration">Duration</param>
        public Note(RhythmicDuration noteDuration)
            : this("A", 0, 4, noteDuration, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        /// <summary>
        /// Creates a new note with specific pitch, duration and stem direction.
        /// </summary>
        /// <param name="notePitch">Pitch</param>
        /// <param name="noteDuration">Duration</param>
        /// <param name="noteStemDirection">Stem direction</param>
        public Note(Pitch notePitch, RhythmicDuration noteDuration, VerticalDirection noteStemDirection)
            : this(notePitch, noteDuration, noteStemDirection, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        /// <summary>
        /// Creates a new note with specific pitch and duration. Stem direction can be automatically determined upon adding the note to a staff.
        /// </summary>
        /// <param name="notePitch">Pitch</param>
        /// <param name="noteDuration">Duration</param>
        /// <param name="determineStemDirectionOnAddingToStaff">If true, stem direction will be automatically determined when note is added to a staff.</param>
        public Note(Pitch notePitch, RhythmicDuration noteDuration, bool determineStemDirectionOnAddingToStaff = true)
            : this(notePitch, noteDuration, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
            SubjectToNoteStemRule = determineStemDirectionOnAddingToStaff;
        }

        /// <summary>
        /// Creates a new A4 quarter note.
        /// </summary>
        public Note()
            : this("A", 0, 4, RhythmicDuration.Quarter, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        internal Note(string noteStep, int noteAlter, int noteOctave, RhythmicDuration noteDuration,
            VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList) :
            this(new Pitch(noteStep, noteAlter, noteOctave), noteDuration, noteStemDirection, noteTieType, noteBeamList)
        {
        }

        /// <summary>
        /// Creates a new instance of Note from given midi pitch and duration.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        /// <param name="duration">Duration</param>
        /// <returns></returns>
        public static Note FromMidiPitch(int midiPitch, RhythmicDuration duration)
        {
            Note note = new Note(duration);
            note.ApplyMidiPitch(midiPitch);
            return note;
        }

        /// <summary>
        /// Creates a new instance of Note from given midi pitch.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        public static Note FromMidiPitch(int midiPitch)
        {
            Note note = new Note();
            note.ApplyMidiPitch(midiPitch);
            return note;
        }

        /// <summary>
        /// Creates a new instance of Note from given pitch and duration.
        /// </summary>
        /// <param name="midiPitch">Pitch</param>
        /// <param name="duration">Duration</param>
        public static Note FromPitch(Pitch pitch, RhythmicDuration duration)
        {
            Note note = new Note(duration);
            note.Pitch = pitch;
            return note;
        }

        /// <summary>
        /// Creates a new instance of Note from given pitch.
        /// </summary>
        /// <param name="pitch">Pitch</param>
        public static Note FromPitch(Pitch pitch)
        {
            Note note = new Note();
            note.Pitch = pitch;
            return note;
        }

        /// <summary>
        /// Changes pitch of the note to the specific midi pitch.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        public void ApplyMidiPitch(int midiPitch)
        {
            pitch = Pitch.FromMidiPitch(midiPitch, Pitch.MidiPitchTranslationMode.Auto);
        }

        public double GetLineInSpecificClef(Clef clef)
        {
            var stepDistance = (double)Pitch.StepDistance(this, clef);
            return clef.Line + (stepDistance / 2);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), Pitch.ToString(), Duration.ToString());
        }

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
    }
}