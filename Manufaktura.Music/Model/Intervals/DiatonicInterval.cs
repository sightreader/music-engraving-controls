using System;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents an interval in diatonic scale (with unspecified size such as major, minor or perfect).
    /// </summary>
    public class DiatonicInterval
    {
        public static DiatonicInterval Fifth { get { return new DiatonicInterval(5); } }

        public static DiatonicInterval Fourth { get { return new DiatonicInterval(4); } }

        public static DiatonicInterval Octave { get { return new DiatonicInterval(8); } }

        public static DiatonicInterval Second { get { return new DiatonicInterval(2); } }

        public static DiatonicInterval Seventh { get { return new DiatonicInterval(7); } }

        public static DiatonicInterval Sixth { get { return new DiatonicInterval(6); } }

        public static DiatonicInterval Third { get { return new DiatonicInterval(3); } }

        public static DiatonicInterval Unison { get { return new DiatonicInterval(1); } }

        /// <summary>
        /// Number of steps
        /// </summary>
        public int Steps { get; protected set; }

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