using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a printing suggestion.
    /// </summary>
    public class PrintSuggestion : MusicalSymbol
    {
        /// <summary>
        /// Indicates a page break
        /// </summary>
        public bool IsPageBreak { get; set; }

        /// <summary>
        /// Indicates a system break
        /// </summary>
        public bool IsSystemBreak { get; set; }

        /// <summary>
        /// Distance between systems
        /// </summary>
        public double? SystemDistance { get; set; }

        public PrintSuggestion Clone()
        {
            return new PrintSuggestion
            {
                CustomColor = CustomColor,
                IsPageBreak = IsPageBreak,
                IsSystemBreak = IsSystemBreak,
                IsVisible = IsVisible,
                SystemDistance = SystemDistance
            };
        }

        public override string ToString()
        {
            var suggestions = new List<string>();
            if (IsSystemBreak) suggestions.Add("system break");
            if (IsPageBreak) suggestions.Add("page break");
            if (SystemDistance.HasValue) suggestions.Add("system distance " + SystemDistance.Value);
            return string.Format("{0}{1}{2}", base.ToString(), suggestions.Any() ? " of " : "", string.Join(", ", suggestions));
        }
    }
}