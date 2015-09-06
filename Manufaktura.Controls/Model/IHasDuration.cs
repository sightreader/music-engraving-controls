using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Indicates that element has rhythmic duration.
    /// </summary>
    public interface IHasDuration
    {
        /// <summary>
        /// Represents duration without dots
        /// </summary>
        RhythmicDuration BaseDuration { get; }

        /// <summary>
        /// Number of dots
        /// </summary>
        int NumberOfDots { get; set; }

        /// <summary>
        /// Tuplet type
        /// </summary>
        TupletType Tuplet { get; set; }
    }
}