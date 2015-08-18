using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    public class Rest : NoteOrRest
    {
        private bool fullMeasure;
        private int multiMeasure = 0;

        public bool FullMeasure
        {
            get { return fullMeasure; }
            set { fullMeasure = value; OnPropertyChanged(() => FullMeasure); }
        }

        public int MultiMeasure { get { return multiMeasure; } set { multiMeasure = value; OnPropertyChanged(() => MultiMeasure); } }

        /// <summary>
        /// Initializes a new Rest with specific duration
        /// </summary>
        /// <param name="restDuration">Duration</param>
        public Rest(RhythmicDuration restDuration)
        {
            type = MusicalSymbolType.Rest;
            Duration = restDuration;
            DetermineMusicalCharacter();
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