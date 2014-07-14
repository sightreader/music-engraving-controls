using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Staff : MusicalSymbol
    {
        public List<MusicalSymbol> Elements { get; private set; }
        public Staff()
        {
            Elements = new List<MusicalSymbol>();
        }
    }
}
