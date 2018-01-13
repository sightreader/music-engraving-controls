﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a Scale with a specific Mode which is built from starting pitch and contains a list of Steps.
    /// </summary>
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

        /// <summary>
        /// Returns a step of this Scale with specific step number
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        public Step GetStepByNumber(int step)
        {
            while (step > FullScale.Count) step -= FullScale.Count;
            return FullScale[step - 1];
        }

        /// <summary>
        /// Returns true if specific step of this scale translated by a specific interval is still a member of this scale.
        /// Example: Second step of C Major scale (D) translated by a major third (F#) is not a member of C Major scale.
        /// </summary>
        /// <param name="pitch"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public bool IsIntervalDiatonic(Pitch pitch, Interval interval)
        {
            if (!FullScale.Contains(pitch.ToStep()))
                throw new ArgumentException(string.Format("Starting pitch {0} does not belong to scale.", pitch), "pitch");
            var newStep = pitch.Translate(interval, MidiPitchTranslationMode).ToStep();
            return FullScale.Contains(newStep);
        }

        /// <summary>
        /// Translates pitch by a specific interval
        /// </summary>
        /// <param name="pitch"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public Pitch TranslatePitch(Pitch pitch, Interval interval)
        {
            return Pitch.FromMidiPitch(pitch.MidiPitch + interval.Halftones, MidiPitchTranslationMode);
        }

        /// <summary>
        /// Translates pitch by a specific diatonic interval.
        /// </summary>
        /// <param name="pitch"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public Pitch TranslatePitch(Pitch pitch, DiatonicInterval interval)
        {
            var stepNumber = StepToStepNumber(pitch.ToStep());
            var halfTones = 0;
            if (interval.Steps == 0) throw new ArithmeticException("There is no interval with 0 steps.");
            if (interval.Steps > 0)
            {
                for (var i = 0; i < interval.Steps - 1; i++)
                {
                    halfTones += Mode.GetIntervalAfterStep(stepNumber + i);
                }
            }
            else if (interval.Steps < 0)
            {
                for (var i = 0; i > interval.Steps + 1; i--)
                {
                    halfTones -= Mode.GetIntervalBeforeStep(stepNumber + i);
                }
            }
            return Pitch.FromMidiPitch(pitch.MidiPitch + halfTones, MidiPitchTranslationMode);
        }
    }
}