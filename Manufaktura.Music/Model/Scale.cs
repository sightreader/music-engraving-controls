using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public abstract class Scale
    {
        public Mode Mode { get; protected set; }
        public int StartingMidiPitch { get; protected set; }
        public Pitch.MidiPitchTranslationMode MidiPitchTranslationMode { get; protected set; }

        protected Scale(Mode mode, int startingMidiPitch,  Pitch.MidiPitchTranslationMode translationMode)
        {
            Mode = mode;
            StartingMidiPitch = startingMidiPitch;
            MidiPitchTranslationMode = translationMode;
        }

        public IEnumerable<Pitch> BuildScale(int startingStep, int numberOfSteps)
        {
            return Mode.BuildScale(StartingMidiPitch, MidiPitchTranslationMode, startingStep, numberOfSteps);
        }
    }
}
