using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class Pitch : Step
    {
        private static Dictionary<string, int> pitches = new Dictionary<string, int>
        {
            {"C", 60}, {"D", 62}, {"E", 64}, {"F", 65}, {"G", 67}, {"A", 69}, {"B", 71}
        };

        public static Pitch G3 { get { return Pitch.FromStep(Step.G, 3); } }
        public static Pitch GSharp3 { get { return Pitch.FromStep(Step.GSharp, 3); } }
        public static Pitch A3 { get { return Pitch.FromStep(Step.A, 3); } }
        public static Pitch ASharp3 { get { return Pitch.FromStep(Step.ASharp, 3); } }
        public static Pitch B3 { get { return Pitch.FromStep(Step.B, 3); } }
        public static Pitch BSharp3 { get { return Pitch.FromStep(Step.BSharp, 3); } }
        public static Pitch C4 { get { return Pitch.FromStep(Step.C, 4); } }
        public static Pitch CSharp4 { get { return Pitch.FromStep(Step.CSharp, 4); } }
        public static Pitch D4 { get { return Pitch.FromStep(Step.D, 4); } }
        public static Pitch DSharp4 { get { return Pitch.FromStep(Step.DSharp, 4); } }
        public static Pitch E4 { get { return Pitch.FromStep(Step.E, 4); } }
        public static Pitch ESharp4 { get { return Pitch.FromStep(Step.ESharp, 4); } }
        public static Pitch F4 { get { return Pitch.FromStep(Step.F, 4); } }
        public static Pitch FSharp4 { get { return Pitch.FromStep(Step.FSharp, 4); } }
        public static Pitch G4 { get { return Pitch.FromStep(Step.G, 4); } }
        public static Pitch GSharp4 { get { return Pitch.FromStep(Step.GSharp, 4); } }
        public static Pitch A4 { get { return Pitch.FromStep(Step.A, 4); } }
        public static Pitch ASharp4 { get { return Pitch.FromStep(Step.ASharp, 4); } }
        public static Pitch B4 { get { return Pitch.FromStep(Step.B, 4); } }
        public static Pitch BSharp4 { get { return Pitch.FromStep(Step.BSharp, 4); } }
        public static Pitch C5 { get { return Pitch.FromStep(Step.C, 5); } }
        public static Pitch CSharp5 { get { return Pitch.FromStep(Step.CSharp, 5); } }
        public static Pitch D5 { get { return Pitch.FromStep(Step.D, 5); } }
        public static Pitch E5 { get { return Pitch.FromStep(Step.E, 5); } }
        public static Pitch F5 { get { return Pitch.FromStep(Step.F, 5); } }
        public static Pitch G5 { get { return Pitch.FromStep(Step.G, 5); } }
        public static Pitch A5 { get { return Pitch.FromStep(Step.A, 5); } }
        public static Pitch B5 { get { return Pitch.FromStep(Step.B, 5); } }
        public static Pitch C6 { get { return Pitch.FromStep(Step.C, 6); } }
        public static Pitch D6 { get { return Pitch.FromStep(Step.D, 6); } }
        public static Pitch E6 { get { return Pitch.FromStep(Step.E, 6); } }
        public static Pitch F6 { get { return Pitch.FromStep(Step.F, 6); } }
        public static Pitch G6 { get { return Pitch.FromStep(Step.G, 6); } }
        public static Pitch A6 { get { return Pitch.FromStep(Step.A, 6); } }
        public static Pitch B6 { get { return Pitch.FromStep(Step.B, 6); } }
        public static Pitch C7 { get { return Pitch.FromStep(Step.C, 7); } }

        public int MidiPitch { get; set; }
        public int Octave { get; set; }


        protected Pitch()
        {
        }


        public Step ToStep()
        {
            return Step.FromPitch(this);
        }

        public static Pitch operator +(Pitch pitch, Interval interval)
        {
            return pitch.Translate(interval, MidiPitchTranslationMode.Auto);
        }

        public static Pitch operator -(Pitch pitch, Interval interval)
        {
            return pitch.Translate(interval.MakeDescending(), MidiPitchTranslationMode.Auto);
        }

        public Pitch Translate(Interval interval, MidiPitchTranslationMode mode)
        {
            return Pitch.FromMidiPitch(MidiPitch + interval.Halftones, mode);
        }

        public static Pitch FromStep(Step step, int octaveNumber = 4)
        {
            return new Pitch { StepName = step.StepName, Alter = step.Alter, MidiPitch = pitches[step.StepName] + step.Alter + (octaveNumber - 4) * 12, Octave = octaveNumber };
        }

        public static Pitch FromMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            var pitch = new Pitch();
            pitch.ApplyMidiPitch(midiPitch, mode);
            return pitch;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", StepName, AlterToSigns(Alter), Octave);
        }

        public void ApplyMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            int midiPitchInLowestOctave = midiPitch;

            while (midiPitchInLowestOctave > 32)
            {
                midiPitchInLowestOctave -= 12;
            }

            switch (mode)
            {
                case MidiPitchTranslationMode.Auto:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "B"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "C"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "E"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "F"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "G"; Alter = 1; }
                    break;

                case MidiPitchTranslationMode.Sharps:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "A"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "C"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "D"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "F"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "G"; Alter = 1; }
                    break;

                case MidiPitchTranslationMode.Flats:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "B"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "D"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "E"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "G"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "A"; Alter = -1; }
                    break;

                default:
                    throw new NotImplementedException("Unsupported midi pitch translation mode.");
            }


            if (midiPitch < 24) Octave = 0;
            else if (midiPitch < 36) Octave = 1;
            else if (midiPitch < 48) Octave = 2;
            else if (midiPitch < 60) Octave = 3;
            else if (midiPitch < 72) Octave = 4;
            else if (midiPitch < 84) Octave = 5;
            else if (midiPitch < 96) Octave = 6;
            else if (midiPitch < 108) Octave = 7;
            else if (midiPitch < 120) Octave = 8;

            this.MidiPitch = midiPitch;
        }

        public static bool operator >(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch > p2.MidiPitch;
        }

        public static bool operator >=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch >= p2.MidiPitch;
        }

        public static bool operator <(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch < p2.MidiPitch;
        }

        public static bool operator <=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch <= p2.MidiPitch;
        }

        public static bool operator ==(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch == p2.MidiPitch;
        }

        public static bool operator !=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch != p2.MidiPitch;
        }

        public enum MidiPitchTranslationMode
        {
            Auto, Sharps, Flats
        }
    }
}
