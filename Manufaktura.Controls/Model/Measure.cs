using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Measure information.
	/// </summary>
	public class Measure
	{
		/// <summary>
		/// Createa a new instance of Measure in specific staff in specific system.
		/// </summary>
		/// <param name="staff">Staff</param>
		/// <param name="system">System</param>
		public Measure(Staff staff, StaffSystem system)
		{
			Staff = staff;
			System = system;
			Elements = new List<MusicalSymbol>();
		}

		/// <summary>
		/// Barline object that represents the right barline
		/// </summary>
		public Barline Barline { get; set; }

		/// <summary>
		/// Location of right barline in measure
		/// </summary>
		public double BarlineLocationX { get; set; }

        /// <summary>
        /// Elements in measure
        /// </summary>
		public List<MusicalSymbol> Elements { get; private set; }

		/// <summary>
		/// Position of first note in measure
		/// </summary>
		public double FirstNoteInMeasureXPosition { get; set; }

        /// <summary>
        /// Measure number
        /// </summary>
		public int? Number { get; set; }

		/// <summary>
		/// Staff to which this measure belongs
		/// </summary>
		public Staff Staff { get; set; }

		/// <summary>
		/// Staff to which this measure belongs
		/// </summary>
		public StaffSystem System { get; set; }

		/// <summary>
		/// Width of measure.
		/// </summary>
		public double? Width { get; set; }

		public override string ToString()
		{
			return string.Format("Measure {0}", Number.HasValue ? Number.Value.ToString() : "(unnumbered)");
		}
	}
}