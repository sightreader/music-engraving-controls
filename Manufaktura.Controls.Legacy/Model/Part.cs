using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Represents a score part.
	/// </summary>
	public class Part
	{
		/// <summary>
		/// Initializes a new instance of multi-staff Part
		/// </summary>
		/// <param name="staves">Staves</param>
		public Part(IEnumerable<Staff> staves)
		{
			Staves = new List<Staff>(staves);
		}

		/// <summary>
		/// Initializes a new instance of one-staff Part
		/// </summary>
		/// <param name="staves">Staff</param>
		public Part(Staff staff)
		{
			Staves = new List<Staff> { staff };
		}

		public PartGroup Group { get; set; }

		/// <summary>
		/// Name of Part
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Part Id
		/// </summary>
		public string PartId { get; set; }

		/// <summary>
		/// Staves in Part
		/// </summary>
		public List<Staff> Staves { get; private set; }
	}
}