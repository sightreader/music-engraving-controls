using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Tuplet
    {
        public int NumberOfNotesUnderTuplet { get; set; }
        public VerticalPlacement TupletPlacement { get; set; }
        public bool AreSingleBeamsPresentUnderTuplet { get; set; }
    }
}
