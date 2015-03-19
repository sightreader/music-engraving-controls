using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class TunedPitch : Pitch
    {
        public double Frequency { get; protected set; }

        public TunedPitch(Pitch pitch, double freq) : base(pitch.StepName, pitch.Alter, pitch.Octave)
        {
            Frequency = freq;
        }
    }
}
