using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public static class CircleOfFifths
    {
        public static int CalculateFifths(int midiPitch, MajorAndMinorScaleFlags flags)
        {
            var fifths = 0;
            var neutralScaleTonicMidiPitch = flags.IsMinor ? Pitch.A3.MidiPitch : Pitch.C4.MidiPitch;
            var currentPitch = neutralScaleTonicMidiPitch;
            while (currentPitch != midiPitch)
            {
                if (!flags.IsFlat)
                {
                    if (currentPitch - midiPitch > Interval.PerfectFifth.Halftones)
                    {
                        currentPitch -= Interval.PerfectOctave.Halftones;
                    }
                    else
                    {
                        currentPitch += Interval.PerfectFifth.Halftones;
                        fifths++;
                    }
                }
                else
                {
                    if (currentPitch - midiPitch < Interval.PerfectFifth.MakeDescending().Halftones)
                    {
                        currentPitch += Interval.PerfectOctave.Halftones;
                    }
                    else
                    {
                        currentPitch -= Interval.PerfectFifth.Halftones;
                        fifths--;
                    }
                }
            }
            return fifths % 12;
        }

        public static int CalculateFifths(Step step, MajorAndMinorScaleFlags flags)
        {
            return CalculateFifths(step.ToPitch(4).MidiPitch, flags);
        }

        public static int GetAlterOfStepFromNumberOfFifths(Step step, int fifths)
        {
            int[] alterTable = new int[7];
            int numberOfStepsToAlter = Math.Abs(fifths);
            for (int i = 0; i < numberOfStepsToAlter; i++)
            {
                alterTable[i] += 1;
                if (i == 6)
                {
                    i = -1;
                    numberOfStepsToAlter -= 6;
                }

            }
            if (fifths > 0)
            {
                if (step.StepName == "C") return alterTable[1];
                else if (step.StepName == "D") return alterTable[3];
                else if (step.StepName == "E") return alterTable[5];
                else if (step.StepName == "F") return alterTable[0];
                else if (step.StepName == "G") return alterTable[2];
                else if (step.StepName == "A") return alterTable[4];
                else if (step.StepName == "B") return alterTable[6];
            }
            else if (fifths < 0)
            {
                if (step.StepName == "C") return alterTable[5] * -1;
                else if (step.StepName == "D") return alterTable[3] * -1;
                else if (step.StepName == "E") return alterTable[1] * -1;
                else if (step.StepName == "F") return alterTable[6] * -1;
                else if (step.StepName == "G") return alterTable[4] * -1;
                else if (step.StepName == "A") return alterTable[2] * -1;
                else if (step.StepName == "B") return alterTable[0] * -1;
            }

            return 0;
        }
    }
}
