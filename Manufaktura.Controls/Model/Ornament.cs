using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public abstract class Ornament : IHasCustomXPosition, IHasCustomYPosition
    {
        public VerticalPlacement Placement { get; set; }
        public double? DefaultXPosition { get; set; }
        public double? DefaultYPosition { get; set; }
    }
}
