using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public struct RhythmicUnit
    {
        public RhythmicDuration Duration { get; set; }
        public bool IsRest { get; set; }

        public RhythmicUnit(RhythmicDuration duration, bool isRest) : this()
        {
            Duration = duration;
            IsRest = isRest;
        }

        public static IEnumerable<RhythmicUnit> Parse(string s, string separator)
        {
            return RhythmicDuration.Parse(s, separator).Select(d => d.ToRhythmicUnit(false));
        }
    }
}
