using System;
using System.Collections.Generic;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a pentatonic mode
    /// </summary>
    [Obsolete("Alpha version. Don't use it. :)")]
    public class PentatonicMode : Mode
    {
        /// <summary>
        /// Intervals of pentatonic mode
        /// </summary>
        public override IEnumerable<int> Intervals
        {
            get { return new[] { 3, 2, 2, 3 }; }
        }
    }
}