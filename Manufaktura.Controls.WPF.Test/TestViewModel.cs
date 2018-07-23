using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.WPF.Test
{
    public class TestViewModel : ViewModel
    {
        private Score data;

        private ScorePlayer player;

        public RadarChartSample[] ChartSamples { get; } = new[] {
            new RadarChartSample("Performance", "Performance", 50) { ValidationMinValue = 40, ValidationMaxValue = 60 },
            new RadarChartSample("User experience", "User experience", 52) { ValidationMinValue = 20, ValidationMaxValue = 40 },
            new RadarChartSample("Responsiveness", "Responsiveness", 18) { ValidationMinValue = 20, ValidationMaxValue = 40 },
            new RadarChartSample("Cost", "Cost", 30) { ValidationMinValue = 30, ValidationMaxValue = 60 },
            new RadarChartSample("Awesomeness", "Awesomeness", 37) { ValidationMinValue = 20, ValidationMaxValue = 40 }
        };

        public Score Data
        {
            get { return data; }
            set { data = value; OnPropertyChanged(() => Data); }
        }

        public ScorePlayer Player { get { return player; } set { player = value; OnPropertyChanged(); } }

        public void LoadTestData(HookDirectionAlgorithm hookDirectionAlgorithm)
        {


            var mScore = Score.CreateOneStaffScore(Clef.Treble, Music.Model.MajorAndMinor.MajorScale.G);

            mScore.FirstStaff.AddTimeSignature(TimeSignatureType.Numbers, 4, 4);
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