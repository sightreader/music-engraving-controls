using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Represents a rest.
	/// </summary>
	public class Rest : NoteOrRest, IHasCustomYPosition
	{
		private double? defaultYPosition;
		private bool fullMeasure;
		private int multiMeasure = 0;

		/// <summary>
		/// Initializes a new Rest with specific duration
		/// </summary>
		/// <param name="restDuration">Duration</param>
		public Rest(RhythmicDuration restDuration)
		{
			Duration = restDuration;
			DetermineMusicalCharacter();
		}

		public double? DefaultYPosition
		{
			get { return defaultYPosition; }
			set { defaultYPosition = value; OnPropertyChanged(() => DefaultYPosition); }
		}

		public bool FullMeasure
		{
			get { return fullMeasure; }
			set { fullMeasure = value; OnPropertyChanged(() => FullMeasure); }
		}

		/// <summary>
		/// Indicates if this Rest is multimeasure.
		/// </summary>
		public int MultiMeasure { get { return multiMeasure; } set { multiMeasure = value; OnPropertyChanged(() => MultiMeasure); } }

		public override string ToString()
		{
			return string.Format("{0} {1}", base.ToString(), Duration.ToString());
		}

		private void DetermineMusicalCharacter()
		{
			if (BaseDuration == RhythmicDuration.Whole) musicalCharacter = MusicFont.WholeRest;
			else if (BaseDuration == RhythmicDuration.Half) musicalCharacter = MusicFont.HalfRest;
			else if (BaseDuration == RhythmicDuration.Quarter) musicalCharacter = MusicFont.QuarterRest;
			else if (BaseDuration == RhythmicDuration.Eighth) musicalCharacter = MusicFont.EighthRest;
			else if (BaseDuration == RhythmicDuration.Sixteenth) musicalCharacter = MusicFont.SixteenthRest;
			else if (BaseDuration == RhythmicDuration.D32nd) musicalCharacter = MusicFont.D32ndRest;
		}
	}
}