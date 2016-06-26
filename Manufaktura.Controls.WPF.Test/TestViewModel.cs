using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Model.MVVM;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System.Linq;

namespace Manufaktura.Controls.WPF.Test
{
	public class TestViewModel : ViewModel
	{
		private Score data;

		private ScorePlayer player;

		public RadialChartSample[] ChartSamples { get; } = new[] {
			new RadialChartSample("A", "A", 5),
		new RadialChartSample("B", "B", 5.2),
		new RadialChartSample("C", "C", 1.8),
		new RadialChartSample("D", "D", 3),
		new RadialChartSample("E", "E", 3.7)
		};

		public Score Data
		{
			get { return data; }
			set { data = value; OnPropertyChanged(() => Data); }
		}
		public ScorePlayer Player { get { return player; } set { player = value; OnPropertyChanged(); } }

		public void LoadTestData(HookDirectionAlgorithm hookDirectionAlgorithm)
		{
			var score = Score.CreateOneStaffScore(Clef.Alto, new MajorScale(Step.C, false));
			var firstStaff = score.FirstStaff;

			firstStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 4, 4));

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.C4, Pitch.C4, Pitch.C4)
				.AddRhythm("16. 32 16 16")
				.ApplyStemDirection(VerticalDirection.Up)
				.Rebeam());

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4, Pitch.C4, Pitch.E4, Pitch.G4, Pitch.C4)
				.AddRhythm(16, 32, 16, 32, 8, 8, 16)
				.ApplyStemDirection(VerticalDirection.Up)
				.AddLyrics("Wlazł ko-tek na pło-tek"));
			firstStaff.Elements.Add(new MetronomeDirection(Tempo.Allegro, DirectionPlacementType.Above));

			firstStaff.Elements.Add(new Barline());

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4)
				.AddRhythm("8.. 32")
				.ApplyStemDirection(VerticalDirection.Up)
				.AddLyrics("i mru-"));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromRhythm(8, 8)
				.AddPitches(Pitch.C4, Pitch.E4)
				.ApplyStemDirection(VerticalDirection.Up));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4, Pitch.C4, Pitch.E4, Pitch.G4)
				.AddRhythm(32, 32, 32, 16, 16, 32)
				.ApplyStemDirection(VerticalDirection.Up));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4, Pitch.C4)
				.AddRhythm(8, 32, 16, 32)
				.ApplyStemDirection(VerticalDirection.Up));

			firstStaff.Elements.Add(new Barline());

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4)
				.AddRhythm(8, 32)
				.ApplyStemDirection(VerticalDirection.Up)
				.AddDots(2, 0));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4)
				.AddRhythm(8, 8)
				.ApplyStemDirection(VerticalDirection.Up));

			firstStaff.Elements.Add(new Barline());

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4, Pitch.C4, Pitch.E4)
				.AddRhythm(32, 32, 32, 32, 8)
				.ApplyStemDirection(VerticalDirection.Up));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4)
				.AddRhythm(8, 16, 16)
				.ApplyStemDirection(VerticalDirection.Up));

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4, Pitch.C4)
				.AddRhythm(8, 16, 32, 32)
				.ApplyStemDirection(VerticalDirection.Up));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4)
				.AddRhythm(8, 16)
				.ApplyStemDirection(VerticalDirection.Up)
				.AddDots(1, 0));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4)
				.AddRhythm(8, 32)
				.ApplyStemDirection(VerticalDirection.Up)
				.AddDots(2, 0));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4)
				.AddRhythm(32, 16, 8)
				.ApplyStemDirection(VerticalDirection.Up)
				.AddDots(0, 1, 0));

			firstStaff.Elements.OfType<Note>().FirstOrDefault(n => n.Pitch == Pitch.E4 && n.BaseDuration == RhythmicDuration.D32nd).DesiredHookDirection = DesiredHookDirections.ForwardHook;
			firstStaff.Elements.OfType<NoteOrRest>().Rebeam(RebeamMode.ToBeats, hookDirectionAlgorithm);

			/*
			firstStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 3, 4));
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)) { TieType = NoteTieType.Start });
			firstStaff.Elements.Add(new Barline() { CustomColor = KolbergColors.OsterodeWheat });
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)) { CustomColor = Color.Red, TieType = NoteTieType.Stop });
			firstStaff.Elements.Add(new Barline());
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)));
			firstStaff.Elements.Add(new Barline(BarlineStyle.LightHeavy));

			score.FirstStaff.Elements.Add(new Note(Pitch.C5, RhythmicDuration.Sixteenth, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Start, NoteBeamType.ForwardHook }));
			score.FirstStaff.Elements.Add(new Note(Pitch.F4, RhythmicDuration.Eighth, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Continue  }));
			score.FirstStaff.Elements.Add(new Note(Pitch.D4, RhythmicDuration.Sixteenth, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.End, NoteBeamType.BackwardHook }));
			score.FirstStaff.Elements.Add(new MetronomeDirection(new Tempo(RhythmicDuration.Eighth, 120), DirectionPlacementType.Above));

			var secondStaff = new Staff();
			score.Staves.Add(secondStaff);
			secondStaff.Elements.Add(Clef.Bass);
			secondStaff.Elements.Add(new Key(0));
			secondStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 3, 4));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Eighth) { Tuplet = TupletType.Start, TupletWeightOverride = 1 });
			secondStaff.Elements.Add(new Note(Pitch.D3, RhythmicDuration.Sixteenth) { TupletWeightOverride = 0.5 });
			secondStaff.Elements.Add(new Note(Pitch.F3, RhythmicDuration.Sixteenth) {  TupletWeightOverride = 0.5});
			secondStaff.Elements.Add(new Note(Pitch.E3, RhythmicDuration.Eighth) { Tuplet = TupletType.Stop, TupletWeightOverride = 1 } );
			secondStaff.Elements.Add(new Barline());
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Barline());
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Half.AddDots(1)));
			secondStaff.Elements.Add(new Barline(BarlineStyle.LightHeavy));
			*/

			var secondStaff = new Staff();
			score.Staves.Add(secondStaff);
			secondStaff.Elements.Add(Clef.Bass);
			secondStaff.Elements.Add(new Key(0));
			secondStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 3, 4));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Eighth) { Tuplet = TupletType.Start });
			secondStaff.Elements.Add(new Note(Pitch.D3, RhythmicDuration.Eighth));
			secondStaff.Elements.Add(new Note(Pitch.E3, RhythmicDuration.Eighth) { Tuplet = TupletType.Stop });
			secondStaff.Elements.Add(new Barline());
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Barline());
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Half.AddDots(1)));
			secondStaff.Elements.Add(new Barline(BarlineStyle.LightHeavy));

			var nn = secondStaff.Elements.OfType<Note>().Last();
			var timeSignature = secondStaff.Peek<TimeSignature>(nn, Model.PeekStrategies.PeekType.PreviousElement);

			Data = score;
		}
	}
}