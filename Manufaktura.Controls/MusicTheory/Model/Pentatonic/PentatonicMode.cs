using Manufaktura.Controls.MusicTheory.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.MusicTheory.Model
{
    public class PentatonicMode : Mode
    {
        private PentatonicScale scale = new PentatonicScale();
        public override RelativeScale Scale
        {
            get { return scale; }
        }

        public override IEnumerable<MusicalRule> Rules
        {
            get { return new MusicalRule[] { }; }
        }
    }
}
