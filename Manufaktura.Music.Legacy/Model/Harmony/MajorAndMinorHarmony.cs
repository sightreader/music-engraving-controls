using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.Harmony
{
    public abstract class MajorAndMinorHarmony : IHarmony<MajorOrMinorScale>
    {
        public abstract DiatonicInterval GeneratorInterval { get; }

        public Chord CreateChord(Pitch basePitch, int inversion, int generatorIntervals, MajorOrMinorScale scale)
        {
            if (generatorIntervals < 1) throw new ArgumentException("Number of generatorIntervals must be greater than 0.");
            if (generatorIntervals < 0) throw new ArgumentException("Inversion must be a non-negative number.");
            if (inversion > generatorIntervals) throw new ArgumentException("Inversion must be less or equal to number of generatorIntervals.");

            var pitches = new List<Pitch>();
            var lastPitch = basePitch;
            pitches.Add(lastPitch);
            for (int i = 0; i < generatorIntervals; i++)
            {
                var translatedPitch = scale.TranslatePitch(lastPitch, GeneratorInterval);
                lastPitch = translatedPitch;
                pitches.Add(lastPitch);
            }

            return new Chord(pitches).Invert(inversion);
        }
    }
}
