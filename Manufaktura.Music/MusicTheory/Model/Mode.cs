using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Helpers;
using Manufaktura.Music.MusicTheory.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model
{
    public abstract class Mode
    {
        public abstract IEnumerable<int> Intervals { get; }
        public abstract IEnumerable<MusicalRule> Rules { get; }

        public IEnumerable<Pitch> BuildScale(int startingMidiPitch, int startingStep, int numberOfSteps)
        {
            if (startingStep < 1) throw new ArgumentException("Starting step must be greater than 0.", "startingStep");
            if (numberOfSteps < 1) throw new ArgumentException("Number of steps must be greater than 0.", "numberOfSteps");

            var pitches = new List<Pitch>();
            var midiPitch = startingMidiPitch;
            for (int step = startingStep; step < startingStep + numberOfSteps; step++)
            {
                pitches.Add(Pitch.FromMidiPitch(midiPitch));
                midiPitch = midiPitch + GetIntervalAfterStep(step);
            }
            return pitches;
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
