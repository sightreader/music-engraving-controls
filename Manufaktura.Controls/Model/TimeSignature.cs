using Manufaktura.Music.Model;
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
        protected Proportion numberValue;

        #endregion

        #region Properties

        public TimeSignatureType SignatureType { get { return signatureType; } set { signatureType = value; } }
        public int NumberOfBeats { get { return numberValue.Numerator; } }
        public int TypeOfBeats { get { return numberValue.Denominator; } }
        public Proportion NumberValue { get { return numberValue; } set { numberValue = value; OnPropertyChanged(() => NumberValue); } }

        #endregion

        #region Constructor

        public TimeSignature(TimeSignatureType sType, int beats, int beatType)
        {
            type = MusicalSymbolType.TimeSignature;
            numberValue = new Proportion(beats, beatType);
            signatureType = sType;
        }

        #endregion

        public static TimeSignature CommonTime
        {
            get
            {
                return new TimeSignature(TimeSignatureType.Common, 4, 4);
            }
        }

        public static TimeSignature CutTime
        {
            get
            {
                return new TimeSignature(TimeSignatureType.Cut, 2, 2);
            }
        }
    }
}
