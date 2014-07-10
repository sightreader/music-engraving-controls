using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class TimeSignature : MusicalSymbol
    {
        #region Protected fields

        protected TimeSignatureType signatureType;
        protected uint numberOfBeats;
        protected uint typeOfBeats;

        #endregion

        #region Properties

        public TimeSignatureType SignatureType { get { return signatureType; } set { signatureType = value; } }
        public uint NumberOfBeats { get { return numberOfBeats; } set { numberOfBeats = value; } }
        public uint TypeOfBeats { get { return typeOfBeats; } set { typeOfBeats = value; } }

        #endregion

        #region Constructor

        public TimeSignature(TimeSignatureType sType, uint beats, uint beatType)
        {
            type = MusicalSymbolType.TimeSignature;
            numberOfBeats = beats;
            typeOfBeats = beatType;
            signatureType = sType;
        }

        #endregion
    }
}
