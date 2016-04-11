using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Base class for representing ornaments.
    /// </summary>
    public abstract class Ornament : IHasCustomXPosition, IHasCustomYPosition
    {
        /// <summary>
        /// Vertical placement of ornament.
        /// </summary>
        public VerticalPlacement Placement { get; set; }
        public double? DefaultXPosition { get; set; }
        public double? DefaultYPosition { get; set; }
    }
}
