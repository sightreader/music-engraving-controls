using Manufaktura.Controls.Music;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Music.Model
{
    public struct Chord
    {
        private List<Pitch> pitches;

        public Pitch Base
        {
            get { return pitches.First(); }
        }

        public Step Name
        {
            get;
            private set;
        }

        public IEnumerable<Pitch> Pitches
        {
            get { return pitches; }
        }

        public Pitch Position
        {
            get { return pitches.Last(); }
        }

        public Chord(IEnumerable<Pitch> pitches)
            : this()
        {
            this.pitches = new List<Pitch>(pitches.OrderBy(p => p));
            this.Name = this.pitches.First();
        }

        public Chord(IEnumerable<IHasPitch> pitchedElements)
            : this(pitchedElements.Select(p => p.Pitch))
        {
        }

        public Chord ApplyAlteration(int pitchIndex, int alter)
        {
            pitches[pitchIndex] = pitches[pitchIndex].Flatten();
            return this;
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