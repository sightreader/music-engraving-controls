using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public static class CircleOfFifths
    {
        public static int CalculateFifths(int midiPitch, bool isMinorScale, bool isFlatScale)
        {
            var fifths = 0;
            var neutralScaleTonicMidiPitch = isMinorScale ? Pitch.A3.MidiPitch : Pitch.C4.MidiPitch;
            var currentPitch = neutralScaleTonicMidiPitch;
            while (currentPitch != midiPitch)
            {
                if (!isFlatScale)
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

        public static int CalculateFifths(Step step, bool isMinorScale, bool isFlatScale)
        {
            return CalculateFifths(step.ToPitch(4).MidiPitch, isMinorScale, isFlatScale);
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
                if (step == "C") return alterTable[1];
                else if (step == "D") return alterTable[3];
                else if (step == "E") return alterTable[5];
                else if (step == "F") return alterTable[0];
                else if (step == "G") return alterTable[2];
                else if (step == "A") return alterTable[4];
                else if (step == "B") return alterTable[6];
            }
            else if (fifths < 0)
            {
                if (step == "C") return alterTable[5] * -1;
                else if (step == "D") return alterTable[3] * -1;
                else if (step == "E") return alterTable[1] * -1;
                else if (step == "F") return alterTable[6] * -1;
                else if (step == "G") return alterTable[4] * -1;
                else if (step == "A") return alterTable[2] * -1;
                else if (step == "B") return alterTable[0] * -1;
            }

            return 0;
        }
    }
}
