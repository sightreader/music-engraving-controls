using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Rules
{
    public class ManualAddMeasuresRule : StaffRule<MusicalSymbol>
    {
        public override void Apply(Staff staff, MusicalSymbol newElement)
        {
            var currentMeasure = staff.Measures.LastOrDefault();
            if (currentMeasure != null)
            {
                currentMeasure.Elements.Add(newElement);
            }
        }

        public override bool Condition(Staff staff, MusicalSymbol newElement)
        {
            return staff.MeasureAddingRule == Staff.MeasureAddingRuleEnum.AddMeasuresManually;
        }
    }
}
