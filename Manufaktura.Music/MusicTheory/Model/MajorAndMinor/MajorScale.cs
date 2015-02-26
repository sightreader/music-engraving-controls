using Manufaktura.Controls.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model.MajorAndMinor
{
    public class MajorScale : MajorOrMinorScale
    {
        public override int StartingMidiPitch
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public MajorScale(Step step, bool isFlat) : base(step, false, isFlat)
        {
            Mode = new MajorMode();
        }
    }
}
