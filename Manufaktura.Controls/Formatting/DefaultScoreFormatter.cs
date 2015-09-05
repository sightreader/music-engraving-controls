using Manufaktura.Controls.Model;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Manufaktura.Controls.Formatting
{
    public class DefaultScoreFormatter : IScoreFormatter
    {
        public Score Format(Score score)
        {
            SetMeasureWidths(score);
            return score;
        }

        private IEnumerable<IEnumerable<Measure>> GetSystems(Score score)
        {
            var systems = new List<List<Measure>>();
            var measures = new List<Measure>();
            var currentSystem = new StaffSystem();
            foreach (var element in score.FirstStaff.Elements)
            {
                if (element is Barline) measures.Add(new Measure(score.FirstStaff, currentSystem));
                var suggestion = element as PrintSuggestion;
                if (suggestion != null && (suggestion.IsSystemBreak || suggestion.IsPageBreak))
                {
                    systems.Add(measures);
                    measures = new List<Measure>();
                    currentSystem = new StaffSystem();
                }
            }
            return systems;
        }

        private void SetMeasureWidths(Score score)
        {
            int index = 0;
            foreach (var system in GetSystems(score))
            {
                var averageMeasureWidth = score.DefaultPageSettings.Width / system.Count();
                foreach (var measure in system)
                {
                    foreach (var staff in score.Staves)
                    {
                        measure.Width = averageMeasureWidth;
                        if (staff.Measures.Count > index)
                            staff.Measures[index] = measure;
                        else
                            staff.Measures.Add(measure);
                    }
                    index++;
                }
            }
        }
    }
}