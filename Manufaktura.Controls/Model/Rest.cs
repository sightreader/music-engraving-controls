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