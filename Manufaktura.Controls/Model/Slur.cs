using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Slur
    {
        public int Number { get; set; }
        public NoteSlurType Type { get; set; }
        public VerticalPlacement? Placement { get; set; }

        public Slur()
        {
            Type = NoteSlurType.None;
        }

        public Slur(NoteSlurType type)
        {
            Type = type;
        }
    }
}
