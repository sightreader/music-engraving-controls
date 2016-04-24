using Manufaktura.Controls.Extensions;
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

		public Score Data
		{
			get { return data; }
			set { data = value; OnPropertyChanged(() => Data); }
		}

		public void LoadTestData()
		{
			var score = Score.CreateOneStaffScore(Clef.Alto, new MajorScale(Step.C, false));
			var firstStaff = score.FirstStaff;

			firstStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 4, 4));

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4, Pitch.G4, Pitch.C4, Pitch.E4, Pitch.G4)
				.AddRhythm(16, 32, 16, 32, 8, 8)
				.ApplyStemDirection(VerticalDirection.Up)
				.AddLyrics("Wlazł ko-tek na pło-tek"));

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

			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4)
				.AddRhythm(8, 32)
				.ApplyStemDirection(VerticalDirection.Up)
				.AddDots(2, 0));
			firstStaff.Elements.AddRange(StaffBuilder
				.FromPitches(Pitch.C4, Pitch.E4)
				.AddRhythm(8, 8)
				.ApplyStemDirection(VerticalDirection.Up));

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

			firstStaff.Elements.OfType<NoteOrRest>().Rebeam(Formatting.RebeamMode.ToLyrics);

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

			Data = score;
		}
	}
}