using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public class PentatonicGamut : Gamut
    {
        public override IEnumerable<int> Intervals
        {
            get { return new[] { 2, 2, 1, 2, 2 }; }
        }
    }
}
