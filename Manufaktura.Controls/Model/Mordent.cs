using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a mordent ornament.
    /// </summary>
    public class Mordent : Ornament
    {
        /// <summary>
        /// Indicates if the mordent is inverted.
        /// </summary>
        public bool IsInverted { get; set; }
    }
}
