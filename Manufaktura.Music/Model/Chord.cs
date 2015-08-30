using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Music.Model
{
    public struct Chord
    {
        private List<Pitch> pitches;

        public IEnumerable<Pitch> Pitches
        {
            get { return pitches; }
        }

        public Chord(IEnumerable<Pitch> pitches)
        {
            this.pitches = new List<Pitch>(pitches.OrderBy(p => p));
        }

        public static Chord CreateChord(Pitch basePitch, int inversion, int thirds, MajorOrMinorScale scale)
        {
            if (thirds < 1) throw new ArgumentException("Number of thirds must be greater than 0.");
            if (thirds < 0) throw new ArgumentException("Inversion must be a non-negative number.");
            if (inversion > thirds) throw new ArgumentException("Inversion must be less or equal to number of thirds.");

            var pitches = new List<Pitch>();
            var lastPitch = basePitch;
            pitches.Add(lastPitch);
            for (int i = 0; i < thirds; i++)
            {
                var translatedPitch = scale.TranslatePitch(lastPitch, DiatonicInterval.Third);
                lastPitch = translatedPitch;
                pitches.Add(lastPitch);
            }

            for (int i = 0; i < inversion; i++)
            {
                pitches[i] = pitches[i].OctaveUp();
            }

            return new Chord(pitches);
        }

        public static Chord CreateChord(Pitch basePitch, int inversion, MajorOrMinorScale scale)
        {
            return CreateChord(basePitch, inversion, 2, scale);
        }

        public static Chord Create7thChord(Pitch basePitch, int inversion, MajorOrMinorScale scale)
        {
            var chord = CreateChord(basePitch, inversion, 3, scale);
            var pitches = chord.Pitches.ToList();
            pitches[3 - inversion] = pitches[3 - inversion].Flatten();
            return new Chord(pitches);
        }
    }
}