using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Formatting
{
    public class DefaultScoreFormatter : IScoreFormatter
    {
        public Score Format(Score score)
        {
            SetMeasureWidths(score);
            SetElementPositions(score);
            return score;
        }

        private Dictionary<StaffSystem, IEnumerable<Measure>> GetSystems(Score score)
        {
            return score.FirstStaff.Measures.GroupBy(m => m.System).ToDictionary(g => g.Key, g => g.Select(m => m));
        }

        private void SetElementPositions(Score score)
        {
            foreach (var staff in score.Staves)
            {
                StaffSystem lastSystem = null;
                foreach (var measure in staff.Measures)
                {
                    var marginLeft = lastSystem == null || score.Systems.ToList().IndexOf(measure.System) != score.Systems.ToList().IndexOf(lastSystem) ? 85 : 14;    //First symbol in system should have bigger margin
                    foreach (var group in measure.Elements.GroupBy(e => e is NoteOrRest ? ((NoteOrRest)e).Voice : 1))
                    {
                        double x = marginLeft;
                        foreach (var element in group)
                        {
                            if (!measure.Width.HasValue) throw new Exception("Measure does not have width. Run SetMeasureWidths first.");

                            var durationElement = element as IHasDuration;
                            if (durationElement == null) continue;
                            var defaultXElement = element as IHasCustomXPosition;
                            if (defaultXElement == null) continue;

                            defaultXElement.DefaultXPosition = x;
                            var chordElement = element as ICanBeUpperMemberOfChord;
                            if (chordElement != null && chordElement.IsUpperMemberOfChord) continue;

                            var time = staff.Peek<TimeSignature>(element, Model.PeekStrategies.PeekType.PreviousElement);
                            var duration = durationElement.BaseDuration.AddDots(durationElement.NumberOfDots).ToDouble() * time.WholeNoteCapacity;    //TODO: Dots!
                            x += (measure.Width.Value - marginLeft) * duration;
                        }
                    }
                    lastSystem = measure.System;
                }
            }
        }

        private void SetMeasureWidths(Score score)
        {
            int index = 0;
            foreach (var measuresInSystem in GetSystems(score).Values)
            {
                var averageMeasureWidth = score.DefaultPageSettings.Width / measuresInSystem.Count();
                foreach (var measure in measuresInSystem)
                {
                    foreach (var staff in score.Staves)
                    {
                        Measure staffMeasure;
                        if (staff.Measures.Count > index)
                            staffMeasure = staff.Measures[index];
                        else
                        {
                            staffMeasure = new Measure(staff, measure.System);
                            staff.Measures.Add(staffMeasure);
                        }
                        staffMeasure.Width = averageMeasureWidth;
                    }
                    index++;
                }
            }
        }
    }
}