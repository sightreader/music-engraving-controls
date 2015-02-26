using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Helpers
{
    public static class CircleOfFifths
    {
        public static int CalculateFifths(int midiPitch, bool isMinorScale, bool isFlatScale)
        {
            var fifths = 0;
            var tonicMidiPitch = Pitch.C4.MidiPitch - (isMinorScale ? Interval.MinorThird : Interval.Unison);
            var currentPitch = tonicMidiPitch;
            while (currentPitch != midiPitch)
            {
                if (!isFlatScale)
                {
                    if (currentPitch - midiPitch > Interval.PerfectFifth)
                    {
                        currentPitch -= Interval.Octave;
                    }
                    else
                    {
                        currentPitch += Interval.PerfectFifth;
                        fifths++;
                    }
                }
                else
                {
                    if (currentPitch - midiPitch < Interval.PerfectFifth * -1)
                    {
                        currentPitch += Interval.Octave;
                    }
                    else
                    {
                        currentPitch -= Interval.PerfectFifth;
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
