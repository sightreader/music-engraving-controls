using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Rest : NoteOrRest
    {
        #region Protected fields

        protected int multiMeasure = 0;

        #endregion

        #region Properties

        public int MultiMeasure { get { return multiMeasure; } set { multiMeasure = value; OnPropertyChanged(() => MultiMeasure); } }

        #endregion

        #region Constructor

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

        #endregion

        #region Private methods

        private void DetermineMusicalCharacter()
        {
            if (BaseDuration == RhythmicDuration.Whole) musicalCharacter = MusicFont.WholeRest;
            else if (BaseDuration == RhythmicDuration.Half) musicalCharacter = MusicFont.HalfRest;
            else if (BaseDuration == RhythmicDuration.Quarter) musicalCharacter = MusicFont.QuarterRest;
            else if (BaseDuration == RhythmicDuration.Eighth) musicalCharacter = MusicFont.EighthRest;
            else if (BaseDuration == RhythmicDuration.Sixteenth) musicalCharacter = MusicFont.SixteenthRest;
            else if (BaseDuration == RhythmicDuration.D32nd) musicalCharacter = MusicFont.D32ndRest;
        }

        #endregion

    }
}
