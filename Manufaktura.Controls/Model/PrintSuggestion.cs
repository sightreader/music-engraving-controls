using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a printing suggestion.
    /// </summary>
    public class PrintSuggestion : MusicalSymbol
    {
        /// <summary>
        /// Indicates a system break
        /// </summary>
        public bool IsSystemBreak { get; set; }

        /// <summary>
        /// Indicates a page break
        /// </summary>
        public bool IsPageBreak { get; set; }

        /// <summary>
        /// Distance between systems
        /// </summary>
        public double SystemDistance { get; set; }

    }
}
