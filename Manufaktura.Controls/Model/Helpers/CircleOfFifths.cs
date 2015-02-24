using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Helpers
{
    public static class CircleOfFifths
    {
        public static int CalculateFifths(int midiPitch, bool isFlatScale)
        {
            var fifths = 0;
            var midiPitchOfC = 60;
            var currentPitch = midiPitchOfC;
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

        public static int CalculateFifths(Step step, bool isFlatScale)
        {
            return CalculateFifths(step.ToPitch().MidiPitch, isFlatScale);
        }
    }
}
