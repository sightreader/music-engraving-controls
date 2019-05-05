using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System.Windows.Input;

namespace Manufaktura.Controls.Avalonia.Test.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private Score data;
        private PredefinedMusicFonts musicFont;

        public MainWindowViewModel()
        {
            LoadTestData(HookDirectionAlgorithm.ProductionCandidate);
        }

        public Score Data
        {
            get { return data; }
            set { data = value; OnPropertyChanged(); }
        }

        public string Greeting => "Welcome to Avalonia!";

        public PredefinedMusicFonts MusicFont { get => musicFont; set { musicFont = value; OnPropertyChanged(); } }

        public ICommand SetPolihymniaFont => new ActionCommand(() => MusicFont = PredefinedMusicFonts.Polihymnia);
        public ICommand SetBravuraFont => new ActionCommand(() => MusicFont = PredefinedMusicFonts.Bravura);

        public ICommand SetGootvilleFont => new ActionCommand(() => MusicFont = PredefinedMusicFonts.Gootville);

        public void LoadTestData(HookDirectionAlgorithm hookDirectionAlgorithm)
        {
            var mScore = Score.CreateOneStaffScore(Clef.Treble, Music.Model.MajorAndMinor.MajorScale.G);

            mScore.FirstStaff.AddTimeSignature(TimeSignatureType.Numbers, 4, 4);

            mScore.FirstStaff.Add(new Rest(24));
            mScore.FirstStaff.AddBarline(BarlineStyle.Regular);

            mScore.FirstStaff.Add(new Rest(9));
            mScore.FirstStaff.AddBarline(BarlineStyle.Regular);

            mScore.FirstStaff.AddNote(Pitch.G4, RhythmicDuration.Half);
            mScore.FirstStaff.Add(new Rest(RhythmicDuration.Quarter));
            mScore.FirstStaff.AddNote(Pitch.FromMidiPitch(60, Pitch.MidiPitchTranslationMode.Auto), RhythmicDuration.Half);
            mScore.FirstStaff.AddBarline(BarlineStyle.Regular);
            mScore.FirstStaff.AddNote(Pitch.G4, RhythmicDuration.Quarter);

            mScore.FirstStaff.AddNote(Pitch.FromMidiPitch(61, Pitch.MidiPitchTranslationMode.Auto), RhythmicDuration.Quarter);
            mScore.FirstStaff.AddRange(new Note[] {
                    Note.FromMidiPitch(63, RhythmicDuration.Quarter),
                    Note.FromMidiPitch(67, RhythmicDuration.Quarter)
            }.MakeChord());
            mScore.FirstStaff.AddBarline(BarlineStyle.Regular);
            mScore.FirstStaff.AddRange(StaffBuilder.FromPitches(
                Pitch.C4,
                Pitch.E4,
                Pitch.G4,
                Pitch.A4,
                Pitch.C4,
                Pitch.E4,
                Pitch.G4,
                Pitch.A4).AddUniformRhythm(RhythmicDuration.Sixteenth).ApplyStemDirection(VerticalDirection.Up).Rebeam());

            Note n1 = new Note();
            n1.ApplyMidiPitch(63);
            n1.Duration = RhythmicDuration.Quarter;
            n1.Tuplet = TupletType.Start;
            n1.TupletWeightOverride = 1;
            mScore.FirstStaff.Add(n1);

            n1 = new Note();
            n1.ApplyMidiPitch(66);

            n1.Duration = RhythmicDuration.Quarter;
            n1.TupletWeightOverride = 1;

            mScore.FirstStaff.Add(n1);

            n1 = new Note();
            n1.ApplyMidiPitch(66);
            n1.Duration = RhythmicDuration.Quarter;
            n1.TupletWeightOverride = 1;

            n1.Tuplet = TupletType.Stop;
            mScore.FirstStaff.Add(n1);

            mScore.FirstStaff.AddBarline(BarlineStyle.Regular);
            PrintSuggestion ps = new PrintSuggestion
            {
                IsSystemBreak = true
            };

            mScore.FirstStaff.Add(ps);

            mScore.FirstStaff.AddRange(StaffBuilder.FromPitches(Pitch.G4, Pitch.B4, Pitch.D5, Pitch.C4, Pitch.E4, Pitch.G4, Pitch.D4, Pitch.DSharp4, Pitch.A4)
                .AddRhythm("8 8 8 8 4 4 4 4 4"));
            mScore.FirstStaff.AddBarline(BarlineStyle.Regular);

            mScore.FirstStaff.AddRange(StaffBuilder.FromPitches(Pitch.G4, Pitch.B4, Pitch.D5, Pitch.C4, Pitch.E4, Pitch.G4, Pitch.D4, Pitch.DSharp4, Pitch.A4)
                .AddRhythm("8 8 8 8 4 4 4 4 4"));

            mScore.FirstStaff.Elements.Add(new Barline());

            mScore.FirstStaff.Add(new PrintSuggestion() { IsSystemBreak = true });

            mScore.FirstStaff.AddBarline(BarlineStyle.LightHeavy);

            mScore.FirstStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 3, 4));
            mScore.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)) { TieType = NoteTieType.Start });

            mScore.FirstStaff.Elements.Add(new Barline());
            mScore.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)) { TieType = NoteTieType.Stop });
            mScore.FirstStaff.Elements.Add(new Barline());
            mScore.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)));
            mScore.FirstStaff.Elements.Add(new Barline(BarlineStyle.LightHeavy));

            Data = mScore;
        }
    }
}