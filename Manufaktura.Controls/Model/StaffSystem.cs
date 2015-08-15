using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Staff system information.
    /// </summary>
    public class StaffSystem
    {
        public double Height { get; set; }

        public Dictionary<int, double[]> LinePositions { get; internal set; }

        public double Width { get; set; }

    }
}