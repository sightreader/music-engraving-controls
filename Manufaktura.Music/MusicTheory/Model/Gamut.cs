using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public abstract class Gamut
    {
        public abstract IEnumerable<int> Intervals { get; }

        public IEnumerable<Note> BuildSteps(int startingMidiPitch, int startingStep, int numberOfSteps)
        {
            if (startingStep < 1) throw new ArgumentException("Starting step must be greater than 0.", "startingStep");
            if (numberOfSteps < 1) throw new ArgumentException("Number of steps must be greater than 0.", "numberOfSteps");

            var notes = new List<Note>();
            var midiPitch = startingMidiPitch;
            for (int step = startingStep; step < startingStep + numberOfSteps; step++)
            {
                notes.Add(Note.FromMidiPitch(midiPitch));
                midiPitch = midiPitch + GetIntervalAfterStep(step);
            }
            return notes;
        }

        public int GetIntervalAfterStep(int step)
        {
            if (step < 1) throw new ArgumentException("Step must be greater than 0.", "step");
            var index = step - 1;
            var intervalsList = Intervals.ToList();
            while (index >= intervalsList.Count)
            {
                index -= intervalsList.Count;
            }
            return intervalsList[index];
        }
    }
}
