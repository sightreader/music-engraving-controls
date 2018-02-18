using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Structure that represents a RhythicDuration with additional flag that tells if this is a duration of note or a rest.
    /// </summary>
    public struct RhythmicUnit
    {
        public RhythmicUnit(RhythmicDuration duration, bool isRest) : this()
        {
            Duration = duration;
            IsRest = isRest;
        }

        /// <summary>
        /// RhythmicDuration of this RhythmicUnit
        /// </summary>
        public RhythmicDuration Duration { get; set; }

        /// <summary>
        /// True if this RhythmicUnit represents a duration of a Rest.
        /// </summary>
        public bool IsRest { get; set; }

        public static IEnumerable<RhythmicUnit> Parse(string s, string separator)
        {
            return RhythmicDuration.Parse(s, separator).Select(d => d.ToRhythmicUnit(false));
        }

        public static IEnumerable<RhythmicUnit> Parse(params int[] durations)
        {
            return RhythmicDuration.Parse(durations).Select(d => new RhythmicUnit(d, false)).ToArray();
        }
    }
}