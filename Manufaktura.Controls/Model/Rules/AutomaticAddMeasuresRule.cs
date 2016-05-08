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
				currentMeasure = new Measure(staff, GetSystem(staff)) { Number = staff.Measures.Count + 1 };
				staff.Measures.Add(currentMeasure);
			}

			var barline = newElement as Barline;
			if (barline != null)
			{
				currentMeasure.Elements.Add(barline);
				barline.Measure = currentMeasure;
				staff.Measures.Add(new Measure(staff, GetSystem(staff)) { Number = staff.Measures.Count + 1 });
				return;
			}

            currentMeasure.Elements.Add(newElement);
			newElement.Measure = currentMeasure;
        }

		private static StaffSystem GetSystem (Staff staff)
		{
			StaffSystem system = null;
			if (staff.Score != null)
			{
				system = staff.Score.Systems.LastOrDefault();
				if (system == null)
				{
					system = new StaffSystem(staff.Score);
					staff.Score.Pages.Last().Systems.Add(system);
				}
			}
			return system;
		}

        public override bool Condition(Staff staff, MusicalSymbol newElement)
        {
            return staff.MeasureAddingRule == Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
        }
    }
}