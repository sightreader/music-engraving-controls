using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Model.MVVM;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;

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
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)));
			firstStaff.Elements.Add(new Barline() { CustomColor = KolbergColors.OsterodeWheat });
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)) { CustomColor = Color.Red });
			firstStaff.Elements.Add(new Barline());
			firstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Half.AddDots(1)));
			firstStaff.Elements.Add(new Barline(BarlineStyle.LightHeavy));
			
			var secondStaff = new Staff();
			score.Staves.Add(secondStaff);
			secondStaff.Elements.Add(Clef.Bass);
			secondStaff.Elements.Add(new Key(0));
			secondStaff.Elements.Add(new TimeSignature(TimeSignatureType.Numbers, 3, 4));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
			secondStaff.Elements.Add(new Note(Pitch.C3, RhythmicDuration.Quarter));
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