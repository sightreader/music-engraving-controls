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
			Score = score;
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
				if (!Staves.Any()) return null;
				return Staves.ToDictionary(s => s.Staff.Score.Staves.IndexOf(s.Staff) + 1, s => s.LinePositions);
			}
		}

		public Score Score { get; internal set; }

		public List<StaffFragment> Staves { get; internal set; } = new List<StaffFragment>();

		/// <summary>
		/// Width of staff.
		/// </summary>
		public double Width { get; set; }

		public override string ToString()
		{
			return string.Format("Staff system {0}", Score.Systems.IndexOf(this) + 1);
		}

		internal void BuildStaffFragments(Dictionary<Staff, double[]> linePositions)
		{
			foreach (var kvp in linePositions)
			{
				var staffFragmentForThisStaff = Staves.FirstOrDefault(s => s.Staff == kvp.Key);
				if (staffFragmentForThisStaff == null)
				{
					staffFragmentForThisStaff = new StaffFragment(kvp.Key);
					Staves.Add(staffFragmentForThisStaff);
				}
				staffFragmentForThisStaff.LinePositions = kvp.Value;
			}
		}
	}
}