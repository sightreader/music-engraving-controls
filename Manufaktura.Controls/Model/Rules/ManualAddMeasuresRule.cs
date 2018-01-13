using System.Linq;

namespace Manufaktura.Controls.Model.Rules
{
    /// <summary>
    /// This rule only adds measure to the staff if it doesn't contain any measures. Programmer has to add measures manually.
    /// This rule is applied if MeasureAddingRule property on Staff is set to Staff.MeasureAddingRuleEnum.AddMeasuresManually.
    /// </summary>
    public class ManualAddMeasuresRule : StaffRule<MusicalSymbol>
    {
        public override void Apply(Staff staff, MusicalSymbol newElement)
        {
            var currentMeasure = staff.Measures.LastOrDefault();
            if (currentMeasure != null)
            {
                currentMeasure.Elements.Add(newElement);
                newElement.Measure = currentMeasure;
            }
        }

        public override bool Condition(Staff staff, MusicalSymbol newElement)
        {
            return staff.MeasureAddingRule == Staff.MeasureAddingRuleEnum.AddMeasuresManually;
        }
    }
}