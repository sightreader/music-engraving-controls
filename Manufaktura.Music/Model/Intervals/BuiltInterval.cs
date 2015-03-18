using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class BuiltInterval : Interval
    {
        public Pitch StartingPitch { get; protected set; }

        public Pitch EndingPitch { get; protected set; }

        public BuiltInterval(Pitch pitch1, Pitch pitch2) : base(pitch2.ToStep().ToStepNumber() - pitch1.ToStep().ToStepNumber() + 1,
            pitch2.MidiPitch - pitch1.MidiPitch)
        {
            StartingPitch = pitch1;
            EndingPitch = pitch2;
        }

        public BuiltInterval(Pitch pitch1, Interval interval, Pitch.MidiPitchTranslationMode translationMode)
            : base(interval.Steps, interval.Halftones)
        {
            StartingPitch = pitch1;
            EndingPitch = pitch1.Translate(interval, translationMode);
        }
    }
}
