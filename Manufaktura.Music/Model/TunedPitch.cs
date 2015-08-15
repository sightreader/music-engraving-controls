using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a pitch with a specific frequency (i.e. A4 at 440Hz)
    /// </summary>
    public class TunedPitch : Pitch
    {
        public double Frequency { get; protected set; }

        public TunedPitch(Pitch pitch, double freq) : base(pitch.StepName, pitch.Alter, pitch.Octave)
        {
            Frequency = freq;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1} Hz)", base.ToString(), Frequency);
        }
    }
}
