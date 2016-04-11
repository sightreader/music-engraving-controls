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

        public Score Score { get; internal set; }

        /// <summary>
        /// Width of staff.
        /// </summary>
        public double Width { get; set; }

        public StaffSystem(Score score)
        {
            this.Score = score;
        }

        public override string ToString()
        {
            return string.Format("Staff system {0}", Score.Systems.IndexOf(this) + 1);
        }
    }
}