using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public interface IMelodicTrail
    {
        IEnumerable<Pitch> BuildMelody(Pitch startingPitch, Mode mode);
    }
}
