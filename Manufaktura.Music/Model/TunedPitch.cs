using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a pitch with a specific frequency (i.e. A4 at 440Hz, A4 at 415Hz, etc.)
    /// </summary>
    public class TunedPitch : Pitch
    {
        /// <summary>
        /// Frequency [Hz]
        /// </summary>
        public double Frequency { get; protected set; }

        /// <summary>
        /// Initializes a new instance of TunedPitch with specific pitch and frequency.
        /// </summary>
        /// <param name="pitch">Pitch</param>
        /// <param name="freq">Frequency [Hz]</param>
        public TunedPitch(Pitch pitch, double freq) : base(pitch.StepName, pitch.Alter, pitch.Octave)
        {
            Frequency = freq;
        }

        /// <summary>
        /// Returns a string value of this object (mainly for debug purposes)
        /// </summary>
        /// <returns>String value of this object (mainly for debug purposes)</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1} Hz)", base.ToString(), Frequency);
        }
    }
}
