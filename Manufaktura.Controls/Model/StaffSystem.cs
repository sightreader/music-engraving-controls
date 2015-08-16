using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Staff system information.
    /// </summary>
    public class StaffSystem
    {
        /// <summary>
        /// Height of staff.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Vertical line positions in the staff.
        /// </summary>
        public Dictionary<int, double[]> LinePositions { get; internal set; }

        /// <summary>
        /// Width of staff.
        /// </summary>
        public double Width { get; set; }

    }
}