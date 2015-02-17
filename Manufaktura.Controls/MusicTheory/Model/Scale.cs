using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.MusicTheory.Model
{
    public abstract class Scale
    {
        public abstract Mode Mode { get; }
        public abstract int StartingPitch { get; protected set; }

        protected Scale(int startingPitch)
        {
            StartingPitch = startingPitch;
        }
    }
}
