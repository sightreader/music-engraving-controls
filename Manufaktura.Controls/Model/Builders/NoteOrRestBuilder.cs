using Manufaktura.Controls.Parser.MusicXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Builders
{
    public class NoteOrRestBuilder
    {
        public MusicXmlParserState State { get; protected set; }

        public int Octave { get; set; }
        public int Alter { get; set; }
        public string Step { get; set; }
        public bool IsRest { get; set; }
        public int NumberOfDots { get; set; }
        public MusicalSymbolDuration Duration { get; set; }
        public VerticalDirection StemDirection { get; set; }
        public NoteTieType TieType { get; set; }
        public TupletType Tuplet { get; set; }
        public VerticalPlacement? TupletPlacement { get; set; }
        public List<NoteBeamType> BeamList { get; set; }
        public List<Lyrics> Lyrics { get; set; }
        public VerticalPlacement ArticulationPlacement { get; set; }
        public ArticulationType Articulation { get; set; }
        public bool HasNatural { get; set; }
        public bool IsGraceNote { get; set; }
        public bool IsCueNote { get; set; }
        public bool IsChordElement { get; set; }
        public bool HasFermataSign { get; set; }
        public float StemDefaultY { get; set; }
        public double DefaultX { get; set; }
        public bool CustomStemEndPosition { get; set; }
        public int TremoloLevel { get; set; }
        public Slur Slur { get; set; }
        public NoteTrillMark TrillMark { get; set; }
        public Mordent Mordent { get; set; }
        public int Voice { get; set; }
        public bool IsVisible { get; set; }

        public NoteOrRestBuilder(MusicXmlParserState state)
        {
            State = state;

            Octave = 0;
            Alter = 0;
            Step = "C";
            IsRest = false;
            NumberOfDots = 0;
            Duration = MusicalSymbolDuration.Whole;
            StemDirection = VerticalDirection.Up;
            TieType = NoteTieType.None;
            Tuplet = TupletType.None;
            TupletPlacement = null;
            BeamList = new List<NoteBeamType>();
            Lyrics = new List<Lyrics>();
            ArticulationPlacement = VerticalPlacement.Below;
            Articulation = ArticulationType.None;
            HasNatural = false;
            IsGraceNote = false;
            IsCueNote = false;
            IsChordElement = false;
            HasFermataSign = false;
            StemDefaultY = 28;
            DefaultX = 0;
            CustomStemEndPosition = false;
            TremoloLevel = 0;
            Slur = null;
            TrillMark = NoteTrillMark.None;
            Mordent = null;
            Voice = 1;
            IsVisible = true;
        }

        public NoteOrRest Build()
        {
            if (!IsRest)
            {
                Note nt = new Note(Step, Alter, Octave, Duration, StemDirection, TieType, BeamList);
                nt.NumberOfDots = NumberOfDots;
                nt.Tuplet = Tuplet;
                nt.TupletPlacement = TupletPlacement;
                nt.Lyrics = Lyrics;
                nt.Articulation = Articulation;
                nt.ArticulationPlacement = ArticulationPlacement;
                nt.HasNatural = HasNatural;
                nt.IsGraceNote = IsGraceNote;
                nt.IsCueNote = IsCueNote;
                nt.IsChordElement = IsChordElement;
                nt.StemDefaultY = StemDefaultY;
                nt.DefaultXPosition = DefaultX;
                nt.CustomStemEndPosition = CustomStemEndPosition;
                nt.CurrentTempo = State.CurrentTempo;
                nt.TrillMark = TrillMark;
                nt.Slur = Slur;
                nt.HasFermataSign = HasFermataSign;
                nt.TremoloLevel = TremoloLevel;
                nt.Voice = Voice;
                nt.Dynamics = State.CurrentDynamics;
                nt.IsVisible = IsVisible;
                if (Mordent != null) nt.Ornaments.Add(Mordent);
                return nt;
            }
            else
            {
                Rest rt = new Rest(Duration);
                rt.NumberOfDots = NumberOfDots;
                rt.Tuplet = Tuplet;
                rt.TupletPlacement = TupletPlacement;
                rt.MultiMeasure = State.SkipMeasures + 1;
                rt.CurrentTempo = State.CurrentTempo;
                rt.HasFermataSign = HasFermataSign;
                rt.Voice = Voice;
                rt.DefaultXPosition = DefaultX;
                rt.IsVisible = IsVisible;
                return rt;
            }
        }
    }
}
