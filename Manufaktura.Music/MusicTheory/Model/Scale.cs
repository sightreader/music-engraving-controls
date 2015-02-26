using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public abstract class Scale
    {
        public Mode Mode { get; protected set; }
        public int StartingMidiPitch { get; protected set; }

        protected Scale(Mode mode, int startingMidiPitch)
        {
            Mode = mode;
            StartingMidiPitch = startingMidiPitch;
        }

        public IEnumerable<Pitch> BuildScale(int startingStep, int numberOfSteps)
        {
            return Mode.BuildScale(StartingMidiPitch, startingStep, numberOfSteps);
        }
    }
}
