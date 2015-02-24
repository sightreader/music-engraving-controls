using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Helpers
{
    public class Pitch : Step
    {
        private static Dictionary<string, int> pitches = new Dictionary<string, int>
        {
            {"C", 60}, {"D", 62}, {"E", 64}, {"F", 65}, {"G", 67}, {"A", 69}, {"B", 71}
        };

        public int MidiPitch { get; set; }


        protected Pitch()
        {
        }

        public Note ToNote()
        {
            return Note.FromMidiPitch(MidiPitch);
        }

        public Step ToStep()
        {
            return Step.FromPitch(this);
        }

        public static Pitch FromNote(Note note)
        {
            return new Pitch { StepName = note.Step, Alter = note.Alter, MidiPitch = note.MidiPitch };
        }

        public static Pitch FromStep(Step step)
        {
            return new Pitch { StepName = step.StepName, Alter = step.Alter, MidiPitch = pitches[step.StepName] + step.Alter };
        }

        public static Pitch FromMidiPitch(int midiPitch)
        {
            return Pitch.FromNote(Note.FromMidiPitch(midiPitch));
        }


    }
}
