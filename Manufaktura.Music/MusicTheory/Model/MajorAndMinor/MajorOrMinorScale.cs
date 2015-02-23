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

        protected MajorOrMinorScale(int midiPitch, bool isMinor, bool isFlat) : base(midiPitch)
        {
            Key = Key.FromMidiPitch(midiPitch, isMinor, isFlat);
        }

        
    }
}
