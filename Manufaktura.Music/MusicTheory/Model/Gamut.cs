using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public abstract class Gamut
    {
        public abstract IEnumerable<int> Intervals { get; }
    }
}
