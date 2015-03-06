using Manufaktura.Music.Model;
using Manufaktura.Music.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public abstract class Mode
    {
        public abstract IEnumerable<int> Intervals { get; }
        public abstract IEnumerable<MusicalRule> Rules { get; }

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
            if (step < 1) throw new ArgumentException("Step must be greater than 0.", "step");
            var index = step - 1;
            var intervalsList = Intervals.ToList();
            while (index >= intervalsList.Count)
            {
                index -= intervalsList.Count;
            }
            return intervalsList[index];
        }



        public Pitch TranslatePitch(IEnumerable<Pitch> scale, Pitch pitch, IntervalBase interval)
        {
            var concreteInterval = interval as Interval;
            throw new NotImplementedException();
        }
        
    }
}
