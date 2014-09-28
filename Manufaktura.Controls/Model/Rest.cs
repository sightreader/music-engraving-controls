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

        public Rest(MusicalSymbolDuration restDuration)
        {
            type = MusicalSymbolType.Rest;
            duration = restDuration;
            DetermineMusicalCharacter();
        }

        #endregion

        #region Private methods

        private void DetermineMusicalCharacter()
        {
            if (duration == MusicalSymbolDuration.Whole) musicalCharacter = MusicalCharacters.WholeRest;
            else if (duration == MusicalSymbolDuration.Half) musicalCharacter = MusicalCharacters.HalfRest;
            else if (duration == MusicalSymbolDuration.Quarter) musicalCharacter = MusicalCharacters.QuarterRest;
            else if (duration == MusicalSymbolDuration.Eighth) musicalCharacter = MusicalCharacters.EighthRest;
            else if (duration == MusicalSymbolDuration.Sixteenth) musicalCharacter = MusicalCharacters.SixteenthRest;
            else if (duration == MusicalSymbolDuration.d32nd) musicalCharacter = MusicalCharacters.D32thRest;
        }

        #endregion

    }
}
