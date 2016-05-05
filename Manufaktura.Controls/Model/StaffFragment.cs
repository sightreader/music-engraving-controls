namespace Manufaktura.Controls.Model
{
	public class StaffFragment : MusicalSymbol
	{
		public StaffFragment(Staff staff)
		{
			Staff = staff;
		}

		public double[] LinePositions { get; set; }

		public override string ToString()
		{
			return $"Fragment of {Staff?.ToString()}.";
		}
	}
}