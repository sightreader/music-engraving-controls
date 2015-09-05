using System.Linq;

namespace Manufaktura.Controls.Model.Rules
{
    public class AutomaticAddMeasuresRule : StaffRule<MusicalSymbol>
    {
        public override void Apply(Staff staff, MusicalSymbol newElement)
        {
            var currentMeasure = staff.Measures.LastOrDefault();
            if (currentMeasure == null)
            {
                currentMeasure = new Measure(staff, null);
                staff.Measures.Add(currentMeasure);
                currentMeasure.Elements.Add(newElement);
                return;
            }
            var barline = newElement as Barline;
            if (barline != null)
            {
                currentMeasure.Elements.Add(barline);
                staff.Measures.Add(currentMeasure);
                return;
            }

            currentMeasure.Elements.Add(newElement);
        }

        public override bool Condition(Staff staff, MusicalSymbol newElement)
        {
            return staff.MeasureAddingRule == Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
        }
    }
}