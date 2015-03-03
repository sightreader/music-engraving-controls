using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.MajorAndMinor
{
    public abstract class MajorOrMinorScale : Scale
    {
        public int Fifths { get; protected set; }
        public Step Tonic { get; protected set; }

        protected MajorOrMinorScale(int midiPitch, bool isMinorScale, bool isFlatScale)
            : base(GetMode(isMinorScale), midiPitch, isFlatScale ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Tonic = Pitch.FromMidiPitch(midiPitch, MidiPitchTranslationMode);
            Fifths = CircleOfFifths.CalculateFifths(Tonic, isMinorScale, isFlatScale);
        }

        protected MajorOrMinorScale(Step step, bool isMinorScale, bool isFlatScale) 
            : base(GetMode(isMinorScale), Pitch.FromStep(step).MidiPitch, isFlatScale ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Fifths = CircleOfFifths.CalculateFifths(step, isMinorScale, isFlatScale);
            Tonic = step;
        }

        public static Mode GetMode(bool isMinor)
        {
            return isMinor ? (Mode)new MinorMode() : new MajorMode();
        }
    }
}
