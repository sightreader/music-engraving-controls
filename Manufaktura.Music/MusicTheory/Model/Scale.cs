using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public abstract class Scale
    {
        public Mode Mode { get; protected set; }
        public abstract int StartingMidiPitch { get; protected set; }

        protected Scale(Mode mode, int startingMidiPitch)
        {
            Mode = mode;
            StartingMidiPitch = startingMidiPitch;
        }

        public IEnumerable<Note> BuildSteps(int startingStep, int numberOfSteps)
        {
            return Mode.BuildSteps(StartingMidiPitch, startingStep, numberOfSteps);
        }
    }
}
