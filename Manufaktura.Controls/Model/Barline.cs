using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Barline : MusicalSymbol
    {
        #region Private fields

        private RepeatSignType repeatSign;

        #endregion

        #region Properties

        public RepeatSignType RepeatSign { get { return repeatSign; } set { repeatSign = value; } }
        public HorizontalPlacement Location { get; set; }

        #endregion

        #region Constructor

        public Barline()
        {
            Location = HorizontalPlacement.Right;
            type = MusicalSymbolType.Barline;
            repeatSign = RepeatSignType.None;
        }

        #endregion
    }
}
