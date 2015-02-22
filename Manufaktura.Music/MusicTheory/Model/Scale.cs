using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public abstract class Scale
    {
        public abstract Mode Mode { get; }
        public abstract int StartingMidiPitch { get; protected set; }

        protected Scale(int startingMidiPitch)
        {
            StartingMidiPitch = startingMidiPitch;
        }

        public IEnumerable<Note> BuildSteps(int startingStep, int numberOfSteps)
        {
            return Mode.Gamut.BuildSteps(StartingMidiPitch, startingStep, numberOfSteps);
        }
    }
}
