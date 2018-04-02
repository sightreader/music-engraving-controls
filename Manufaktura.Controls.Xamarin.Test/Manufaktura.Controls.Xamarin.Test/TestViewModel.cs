using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Manufaktura.Controls.Xamarin.Test
{
	public class TestViewModel : ViewModel
	{
		private Score data;

		public Score Data
		{
			get { return data; }
			set { data = value; OnPropertyChanged(() => Data); }
		}

		private Score data2;

		public Score Data2
		{
			get { return data2; }
			set { data2 = value; OnPropertyChanged(() => Data2); }
		}

		public void LoadTestData()
		{
            string xml;
            var names = GetType().GetTypeInfo().Assembly.GetManifestResourceNames();
            using (var reader = new StreamReader(GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Manufaktura.Controls.Xamarin.Test.Assets.005 Bogurodzica [1].xml")))
            {
                xml = reader.ReadToEnd();
            }


            var rd = new RhythmicDuration(4, 0).ToProportion();
			rd = new RhythmicDuration(4, 1).ToProportion();
			rd = new RhythmicDuration(4, 2).ToProportion();
			rd = new RhythmicDuration(4, 3).ToProportion();

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
			firstStaff.Elements.OfType<NoteOrRest>().Rebeam(RebeamMode.ToBeats, HookDirectionAlgorithm.ProductionCandidate);

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

            Data2 = xml.ToScore();


		}

		Score CreateSecondScore()
		{
			var score = Score.CreateOneStaffScore(Clef.Treble, new MajorScale(Step.C, false));
			var firstStaff = score.FirstStaff;
			firstStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 3, 4));
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)) { TieType = NoteTieType.Start });
			firstStaff.Elements.Add(new Barline() { CustomColor = KolbergColors.OsterodeWheat });
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)) { CustomColor = Color.Red, TieType = NoteTieType.Stop });
			firstStaff.Elements.Add(new Barline());
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)));
			firstStaff.Elements.Add(new Barline(BarlineStyle.LightHeavy));

			var note = new Note(Pitch.A5, RhythmicDuration.Eighth, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Start });
			note.Lyrics.Clear();
			note.Lyrics.Add(new Lyrics() { Syllables = new List<Lyrics.Syllable>() { new Lyrics.Syllable(SyllableType.Begin, "xxx") } });
			score.FirstStaff.Elements.Add(note);
			score.FirstStaff.Elements.Add(new Note(Pitch.C5, RhythmicDuration.Sixteenth.AddDots(1), VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Continue, NoteBeamType.Start }));
			score.FirstStaff.Elements.Add(new Note(Pitch.D4, RhythmicDuration.D32nd, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.End, NoteBeamType.End, NoteBeamType.BackwardHook }));

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

			return score;
		}
	}
}