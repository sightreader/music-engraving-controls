using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model.MajorAndMinor
{
    public abstract class MajorOrMinorScale : Scale
    {
        public Key Key { get; protected set; }
        public Step Tonic { get; protected set; }

        protected MajorOrMinorScale(int midiPitch, bool isMinor, bool isFlatScale)
            : base(GetMode(isMinor), midiPitch)
        {
            Key = Key.FromMidiPitch(midiPitch, isMinor, isFlatScale);
            Tonic = Pitch.FromMidiPitch(midiPitch);
        }

        protected MajorOrMinorScale(Step step, bool isMinor, bool isFlatScale)
            : base(GetMode(isMinor), Pitch.FromStep(step).MidiPitch)
        {
            Key = Key.FromTonic(step, isMinor, isFlatScale);
            Tonic = step;
        }

        public static Mode GetMode(bool isMinor)
        {
            return isMinor ? (Mode)new MinorMode() : new MajorMode();
        }
    }
}
