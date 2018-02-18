using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a mode (i.e. dorian, phrygian, pentatonic, 12-tone, etc.)
    /// </summary>
    public abstract class Mode
    {
        /// <summary>
        /// Intervals in this mode (by number of semitones)
        /// </summary>
        public abstract IEnumerable<int> Intervals { get; }

        /// <summary>
        /// Enumerates pitches in a scale created from this Mode.
        /// </summary>
        /// <param name="startingMidiPitch"></param>
        /// <param name="translationMode"></param>
        /// <param name="startingStep"></param>
        /// <param name="numberOfSteps"></param>
        /// <returns></returns>
        public IEnumerable<Pitch> BuildScale(int startingMidiPitch, Pitch.MidiPitchTranslationMode translationMode, int startingStep, int numberOfSteps)
        {
            if (startingStep < 1) throw new ArgumentException("Starting step must be greater than 0.", "startingStep");
            if (numberOfSteps < 1) throw new ArgumentException("Number of steps must be greater than 0.", "numberOfSteps");

            var pitches = new List<Pitch>();
            var midiPitch = startingMidiPitch;
            for (int step = startingStep; step < startingStep + numberOfSteps; step++)
            {
                pitches.Add(Pitch.FromMidiPitch(midiPitch, translationMode));
                midiPitch = midiPitch + GetIntervalAfterStep(step);
            }
            return pitches;
        }

        public int GetIntervalAfterStep(int step)
        {
            var intervalsList = Intervals.ToList();
            var index = NormalizeIndex(step - 1);
            return intervalsList[index];
        }

        public int GetIntervalBeforeStep(int step)
        {
            var intervalsList = Intervals.ToList();
            var index = NormalizeIndex(step - 2);
            return intervalsList[index];
        }

        private int NormalizeIndex(int stepIndex)
        {
            var intervalsList = Intervals.ToList();
            while (stepIndex < 0)
            {
                stepIndex += intervalsList.Count;
            }
            while (stepIndex >= intervalsList.Count)
            {
                stepIndex -= intervalsList.Count;
            }
            return stepIndex;
        }
        
    }
}
