using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.RhythmicTrails
{
    public interface IRhythmicTrail
    {
        Proportion TimeSignature { get; }

        IEnumerable<RhythmicUnit> BuildRhythm(int measures);
    }
}
