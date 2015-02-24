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
            : base(midiPitch)
        {
            //TODO: Uwzględniać tonacje mollowe, bo przecież kwinty liczymy od durowych!
            Key = Key.FromMidiPitch(midiPitch, isFlatScale);
            Tonic = Pitch.FromMidiPitch(midiPitch);
        }

        protected MajorOrMinorScale(Step step, bool isMinor, bool isFlatScale)
            : base(Pitch.FromStep(step).MidiPitch)
        {
            //TODO: Uwzględniać tonacje mollowe, bo przecież kwinty liczymy od durowych!
            Key = Key.FromTonic(step, isFlatScale);
            Tonic = step;
        }
    }
}
