using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public interface IMelodicTrail
    {
        Pitch MaxPitch { get; set; }
        Pitch MinPitch { get; set; }
        IEnumerable<Pitch> BuildMelody(Scale scale, Pitch startingPitch);

    }
}
