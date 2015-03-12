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

        protected MajorOrMinorScale(int midiPitch, MajorAndMinorScaleFlags flags)
            : base(GetMode(flags.IsMinor), midiPitch, flags.IsFlat ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Tonic = Pitch.FromMidiPitch(midiPitch, MidiPitchTranslationMode);
            Fifths = CircleOfFifths.CalculateFifths(Tonic, flags);
        }

        protected MajorOrMinorScale(Step step, MajorAndMinorScaleFlags flags)
            : base(GetMode(flags.IsMinor), Pitch.FromStep(step).MidiPitch, flags.IsFlat ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Fifths = CircleOfFifths.CalculateFifths(step, flags);
            if (CircleOfFifths.GetAlterOfStepFromNumberOfFifths(step, Fifths) != step.Alter)
            {
                throw new MalformedScaleException(string.Format("There is no {0} {1} scale beginning on step {2}.",
                    flags.IsMinor ? "minor" : "major", flags.IsFlat ? "flat" : (Math.Abs(Fifths) > 0 ? "sharp" : "natural"), step));
            }

            Tonic = step;
        }

        public static Mode GetMode(bool isMinor)
        {
            return isMinor ? (Mode)new MinorMode() : new MajorMode();
        }
    }
}
