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
            var tonicMidiPitch = Pitch.C4.MidiPitch - (isMinorScale ? Interval.MinorThird.Halftones : Interval.PerfectUnison.Halftones);
            var currentPitch = tonicMidiPitch;
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
            return fifths;
        }

        public static int CalculateFifths(Step step, bool isMinorScale, bool isFlatScale)
        {
            return CalculateFifths(step.ToPitch(4).MidiPitch, isMinorScale, isFlatScale);
        }
    }
}
