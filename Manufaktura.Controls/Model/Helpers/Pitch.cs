using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Helpers
{
    public class Pitch : Step
    {
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

        public static Pitch FromMidiPitch(int midiPitch)
        {
            return Pitch.FromNote(Note.FromMidiPitch(midiPitch));
        }

        
    }
}
