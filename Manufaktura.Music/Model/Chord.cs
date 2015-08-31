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

        public Chord Invert(int inversion)
        {
            if (inversion >= pitches.Count) throw new ArgumentException("Inversion must be less than number of pitches.");

            for (int i = 0; i < inversion; i++)
            {
                pitches[i] = pitches[i].OctaveUp();
            }
            pitches = pitches.OrderBy(p => p).ToList();
            return this;
        }
    }
}