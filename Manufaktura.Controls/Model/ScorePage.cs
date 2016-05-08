using Manufaktura.Controls.Model.Collections;

namespace Manufaktura.Controls.Model
{
	public class ScorePage
	{
		internal ScorePage(Score score)
		{
			Score = score;
			Systems = new SystemCollection(this);
		}

		public double? DefaultStaffDistance { get; set; }
		public double? DefaultSystemDistance { get; set; }
		public double? Height { get; set; }
		public double? MarginBottom { get; set; }
		public double? MarginLeft { get; set; }
		public double? MarginRight { get; set; }
		public double? MarginTop { get; set; }
		public Score Score { get; set; }
		public SystemCollection Systems { get; private set; }

		public double? Width { get; set; }
	}
}