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
        public List<Step> FullScale { get; protected set; }

        protected Scale(Mode mode, int startingMidiPitch, Pitch.MidiPitchTranslationMode translationMode)
        {
            Mode = mode;
            StartingMidiPitch = startingMidiPitch;
            MidiPitchTranslationMode = translationMode;
            FullScale = BuildScale(1, Mode.Intervals.Count()).Select(p => p.ToStep()).ToList();
        }

        public IEnumerable<Pitch> BuildScale(int startingStep, int numberOfSteps)
        {
            return Mode.BuildScale(StartingMidiPitch, MidiPitchTranslationMode, startingStep, numberOfSteps);
        }

        public int StepToStepNumber(Step step)
        {
            if (!FullScale.Contains(step))
                throw new ArgumentException(string.Format("Step {0} does not belong to scale.", step), "step");
            return FullScale.IndexOf(step) + 1;
        }

        public Step GetStepByNumber(int step)
        {
            while (step > FullScale.Count) step -= FullScale.Count;
            return FullScale[step - 1];
        }

        public bool IsIntervalDiatonic(Pitch pitch, Interval interval)
        {
            if (!FullScale.Contains(pitch.ToStep()))
                throw new ArgumentException(string.Format("Starting pitch {0} does not belong to scale.", pitch), "pitch");
            var newStep = pitch.Translate(interval, MidiPitchTranslationMode).ToStep();
            return FullScale.Contains(newStep);
        }

        public Pitch TranslatePitch(Pitch pitch, Interval interval)
        {
            return Pitch.FromMidiPitch(pitch.MidiPitch + interval.Halftones, MidiPitchTranslationMode);
        }

        public Pitch TranslatePitch(Pitch pitch, IntervalBase interval)
        {
            var stepNumber = StepToStepNumber(pitch.ToStep());
            var halfTones = 0;
            for (var i = 0; i < interval.Steps - 1; i++)
            {
                halfTones += Mode.GetIntervalAfterStep(stepNumber + i);
            }
            return Pitch.FromMidiPitch(pitch.MidiPitch + halfTones, MidiPitchTranslationMode);
        }
    }
}
