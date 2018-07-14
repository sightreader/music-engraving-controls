/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a rest.
    /// </summary>
    public class Rest : NoteOrRest, IHasCustomYPosition
    {
        private double? defaultYPosition;
        private bool fullMeasure;
        private int multiMeasure = 0;

        /// <summary>
        /// Initializes a new Rest with specific duration
        /// </summary>
        /// <param name="restDuration">Duration</param>
        public Rest(RhythmicDuration restDuration)
        {
            Duration = restDuration;
        }

        public double? DefaultYPosition
        {
            get { return defaultYPosition; }
            set { defaultYPosition = value; OnPropertyChanged(); }
        }

        public bool FullMeasure
        {
            get { return fullMeasure; }
            set { fullMeasure = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Indicates if this Rest is multimeasure.
        /// </summary>
        public int MultiMeasure { get { return multiMeasure; } set { multiMeasure = value; OnPropertyChanged(); } }

        public override char GetCharacter(IMusicFont font)
        {
            if (BaseDuration == RhythmicDuration.Whole) return font.RestWhole;
            else if (BaseDuration == RhythmicDuration.Half) return font.RestHalf;
            else if (BaseDuration == RhythmicDuration.Quarter) return font.RestQuarter;
            else if (BaseDuration == RhythmicDuration.Eighth) return font.RestEighth;
            else if (BaseDuration == RhythmicDuration.Sixteenth) return font.RestSixteenth;
            else if (BaseDuration == RhythmicDuration.D32nd) return font.Rest32nd;
            return '\0';
        }

        /// <summary>
        /// Returns a string representation of this symbol for debugging purposes
        /// </summary>
        /// <returns>String representation of this symbol for debugging purposes</returns>
        public override string ToString()
        {
            return string.Format("{0} {1}", base.ToString(), Duration.ToString());
        }
    }
}