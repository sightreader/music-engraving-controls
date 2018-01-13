using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;

namespace Manufaktura.Music.Model.Harmony
{
    /// <summary>
    /// Class for generating chords in major-minor system
    /// </summary>
    public abstract class MajorAndMinorHarmony : IHarmony<MajorOrMinorScale>
    {
        /// <summary>
        /// Generator interval (for example third, fourth) used to generate chord members
        /// </summary>
        public abstract DiatonicInterval GeneratorInterval { get; }

        /// <summary>
        /// Creates chord in major-minor system
        /// </summary>
        /// <param name="basePitch">Base pitch, for example C in C Major</param>
        /// <param name="inversion">Inversion of a chord</param>
        /// <param name="generatorIntervals">Number of chord members, for example 4 in C7 Major, 5 in C9 Major, etc.</param>
        /// <param name="scale">Scale for which a chord will be created</param>
        /// <returns>Chord</returns>
        public Chord CreateChord(Pitch basePitch, int inversion, int generatorIntervals, MajorOrMinorScale scale)
        {
            if (generatorIntervals < 1) throw new ArgumentException("Number of generatorIntervals must be greater than 0.");
            if (inversion < 0) throw new ArgumentException("Inversion must be a non-negative number.");
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