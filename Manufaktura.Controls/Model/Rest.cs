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
        protected int currentTempo = 120;
        protected bool hasFermataSign = false;

        #endregion

        #region Properties

        public int MultiMeasure { get { return multiMeasure; } set { multiMeasure = value; } }
        public int CurrentTempo { get { return currentTempo; } set { currentTempo = value; } }
        public bool HasFermataSign { get { return hasFermataSign; } set { hasFermataSign = value; } }

        #endregion

        #region Constructor

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
            if (BaseDuration == RhythmicDuration.Whole) musicalCharacter = MusicalCharacters.WholeRest;
            else if (BaseDuration == RhythmicDuration.Half) musicalCharacter = MusicalCharacters.HalfRest;
            else if (BaseDuration == RhythmicDuration.Quarter) musicalCharacter = MusicalCharacters.QuarterRest;
            else if (BaseDuration == RhythmicDuration.Eighth) musicalCharacter = MusicalCharacters.EighthRest;
            else if (BaseDuration == RhythmicDuration.Sixteenth) musicalCharacter = MusicalCharacters.SixteenthRest;
            else if (BaseDuration == RhythmicDuration.D32nd) musicalCharacter = MusicalCharacters.D32thRest;
        }

        #endregion

    }
}
