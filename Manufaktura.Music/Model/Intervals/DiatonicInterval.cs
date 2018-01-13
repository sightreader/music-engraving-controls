using System;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents an interval in diatonic scale (with unspecified size such as major, minor or perfect).
    /// </summary>
    public class DiatonicInterval
    {
        /// <summary>
        /// Returns a fifth
        /// </summary>
        public static DiatonicInterval Fifth { get { return new DiatonicInterval(5); } }

        /// <summary>
        /// Returns a fourth
        /// </summary>
        public static DiatonicInterval Fourth { get { return new DiatonicInterval(4); } }

        /// <summary>
        /// Returns an octave
        /// </summary>
        public static DiatonicInterval Octave { get { return new DiatonicInterval(8); } }

        /// <summary>
        /// Returns a second
        /// </summary>
        public static DiatonicInterval Second { get { return new DiatonicInterval(2); } }

        /// <summary>
        /// Returns a seventh
        /// </summary>
        public static DiatonicInterval Seventh { get { return new DiatonicInterval(7); } }

        /// <summary>
        /// Returns a sixth
        /// </summary>
        public static DiatonicInterval Sixth { get { return new DiatonicInterval(6); } }

        /// <summary>
        /// Returns a third
        /// </summary>
        public static DiatonicInterval Third { get { return new DiatonicInterval(3); } }

        /// <summary>
        /// Returns a unison
        /// </summary>
        public static DiatonicInterval Unison { get { return new DiatonicInterval(1); } }

        /// <summary>
        /// Number of steps
        /// </summary>
        public int Steps { get; protected set; }

        /// <summary>
        /// Initializes a new DiatonicInterval instance with specific number of steps
        /// </summary>
        /// <param name="steps"></param>
        public DiatonicInterval(int steps)
        {
            Steps = steps;
        }

        /// <summary>
        /// Converts interval to ascending interval.
        /// </summary>
        /// <returns>Ascending interval.</returns>
        public DiatonicInterval MakeAscending()
        {
            return new DiatonicInterval(Math.Abs(Steps));
        }

        /// <summary>
        /// Converts interval to descending interval.
        /// </summary>
        /// <returns>Descending interval.</returns>
        public DiatonicInterval MakeDescending()
        {
            return new DiatonicInterval(Math.Abs(Steps) * -1);
        }

        /// <summary>
        /// Converts diatonic interval to interval.
        /// </summary>
        /// <param name="halftones">Number of halftones</param>
        /// <returns></returns>
        public Interval ToInterval(int halftones)
        {
            return new Interval(this.Steps, halftones);
        }
    }
}