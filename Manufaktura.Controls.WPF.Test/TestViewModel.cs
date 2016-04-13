using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Model.MVVM;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System.Collections.Generic;

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
			note.Lyrics.Add(new Lyrics(SyllableType.Begin, "Xxx"));
			//note.Lyrics = new List<Lyrics>();
			//note.Lyrics.Add(new Lyrics() { Syllables = new List<Lyrics.Syllable>() { new Lyrics.Syllable (SyllableType.Begin, "xxx") }  });
			score.FirstStaff.Elements.Add(note);
			score.FirstStaff.Elements.Add(new Note(Pitch.C5, RhythmicDuration.Sixteenth.AddDots(1), VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Continue, NoteBeamType.Start }));
			score.FirstStaff.Elements.Add(new Note(Pitch.D4, RhythmicDuration.D32nd, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.End, NoteBeamType.End, NoteBeamType.BackwardHook }));
			score.FirstStaff.Elements.Add(new MetronomeDirection(new Tempo(RhythmicDuration.Eighth, 120), DirectionPlacementType.Above));

			var secondStaff = new Staff();
			score.Staves.Add(secondStaff);
			secondStaff.Elements.Add(Clef.Bass);
			secondStaff.Elements.Add(new Key(0));
			secondStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 3, 4));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Eighth) { Tuplet = TupletType.Start });
			secondStaff.Elements.Add(new Note(Pitch.D3, RhythmicDuration.Eighth));
			secondStaff.Elements.Add(new Note(Pitch.E3, RhythmicDuration.Eighth) { Tuplet = TupletType.Stop } );
			secondStaff.Elements.Add(new Barline());
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Barline());
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Half.AddDots(1)));
			secondStaff.Elements.Add(new Barline(BarlineStyle.LightHeavy));

			Data = score;
		}
	}
}