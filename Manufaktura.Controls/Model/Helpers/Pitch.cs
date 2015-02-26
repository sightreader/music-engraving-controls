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

        public static Pitch C4 { get { return Pitch.FromStep(Step.C, 4); } }
        public static Pitch D4 { get { return Pitch.FromStep(Step.D, 4); } }
        public static Pitch E4 { get { return Pitch.FromStep(Step.E, 4); } }
        public static Pitch F4 { get { return Pitch.FromStep(Step.F, 4); } }
        public static Pitch G4 { get { return Pitch.FromStep(Step.G, 4); } }
        public static Pitch A4 { get { return Pitch.FromStep(Step.A, 4); } }
        public static Pitch B4 { get { return Pitch.FromStep(Step.B, 4); } }

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

        public static Pitch FromStep(Step step, int octaveNumber = 4)
        {
            return new Pitch { StepName = step.StepName, Alter = step.Alter, MidiPitch = pitches[step.StepName] + step.Alter + (octaveNumber - 4) * 12 };
        }

        public static Pitch FromMidiPitch(int midiPitch)
        {
            return Pitch.FromNote(Note.FromMidiPitch(midiPitch));
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", StepName, AlterToSigns(Alter) );
        }

        private static string AlterToSigns(int alter)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Math.Abs(alter); i++)
            {
                sb.Append(alter < 0 ? "b" : "#");
            }
            return sb.ToString();
        }
    }
}
