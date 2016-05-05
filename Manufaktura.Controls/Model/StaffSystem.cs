using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Staff system information.
	/// </summary>
	public class StaffSystem
	{
		public StaffSystem(Score score)
		{
			this.Score = score;
		}

		/// <summary>
		/// Height of staff.
		/// </summary>
		public double Height { get; set; }

		/// <summary>
		/// Vertical line positions in the staff.
		/// </summary>
		public Dictionary<int, double[]> LinePositions
		{
			get
			{
				var staffNumber = 1;
				if (!Staves.Any()) return null;
				return Staves.ToDictionary(s => staffNumber++, s => s.LinePositions);
			}
			set
			{
				while (Staves.Count < value.Count) Staves.Add(new StaffFragmentInSystem());
				foreach (var kvp in value)
				{
					Staves[kvp.Key - 1].LinePositions = kvp.Value;
				}
			}
		}

		public Score Score { get; internal set; }

		public List<StaffFragmentInSystem> Staves { get; internal set; } = new List<StaffFragmentInSystem>();

		/// <summary>
		/// Width of staff.
		/// </summary>
		public double Width { get; set; }

		public override string ToString()
		{
			return string.Format("Staff system {0}", Score.Systems.IndexOf(this) + 1);
		}
	}
}