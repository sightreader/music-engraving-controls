using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class BoundInterval : Interval
    {
        public Pitch StartingPitch { get; protected set; }

        public Pitch EndingPitch { get; protected set; }

        public BoundInterval(Pitch pitch1, Pitch pitch2) : base(Pitch.StepDistance(pitch1, pitch2) + 1, pitch2.MidiPitch - pitch1.MidiPitch)
        {
            StartingPitch = pitch1;
            EndingPitch = pitch2;
        }

        public BoundInterval(Pitch pitch1, Interval interval, Pitch.MidiPitchTranslationMode translationMode)
            : base(interval.Steps, interval.Halftones)
        {
            StartingPitch = pitch1;
            EndingPitch = pitch1.Translate(interval, translationMode);
        }

        public override string ToString()
        {
            return string.Format("{0}-{1} {2}", StartingPitch, EndingPitch, base.ToString());
        }
    }
}
