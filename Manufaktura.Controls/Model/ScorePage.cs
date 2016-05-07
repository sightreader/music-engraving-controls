using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
	public class ScorePage
	{
		public ScorePage()
		{
			Systems = new List<StaffSystem>();
		}

		public double? DefaultStaffDistance { get; set; }
		public double? DefaultSystemDistance { get; set; }
		public double? Height { get; set; }

		public double? MarginBottom { get; set; }

		public double? MarginLeft { get; set; }

		public double? MarginRight { get; set; }

		public double? MarginTop { get; set; }

		public List<StaffSystem> Systems { get; private set; }

		public double? Width { get; set; }
	}
}