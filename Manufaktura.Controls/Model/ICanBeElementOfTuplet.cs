using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Indicates that class represents element of tuplet
    /// </summary>
    interface ICanBeElementOfTuplet
    {
        TupletType Tuplet { get; set; }

        /// <summary>
        /// Vertical placement of tuplet sign.
        /// </summary>
        VerticalPlacement? TupletPlacement { get; set; }
    }
}
