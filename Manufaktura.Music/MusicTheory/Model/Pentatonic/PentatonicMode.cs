using Manufaktura.Music.MusicTheory.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public class PentatonicMode : Mode
    {
        private PentatonicScale scale = new PentatonicScale();
        public override Gamut Gamut
        {
            get { return scale; }
        }

        public override IEnumerable<MusicalRule> Rules
        {
            get { return new MusicalRule[] { }; }
        }
    }
}
