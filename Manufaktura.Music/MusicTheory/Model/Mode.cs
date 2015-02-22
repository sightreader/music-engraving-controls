using Manufaktura.Music.MusicTheory.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public abstract class Mode
    {
        public abstract Gamut Gamut { get; }
        public abstract IEnumerable<MusicalRule> Rules { get; }
    }
}
