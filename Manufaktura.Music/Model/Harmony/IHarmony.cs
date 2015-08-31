using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.Harmony
{
    public interface IHarmony<TScale> where TScale : Scale
    {
        Chord CreateChord(Pitch basePitch, int inversion, int generatorIntervals, TScale scale);
    }
}
