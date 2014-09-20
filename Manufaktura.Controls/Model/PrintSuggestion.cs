using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class PrintSuggestion : MusicalSymbol
    {
        public bool IsSystemBreak { get; set; }
        public bool IsPageBreak { get; set; }
        public double SystemDistance { get; set; }

    }
}
