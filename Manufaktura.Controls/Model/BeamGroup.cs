using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
	public class BeamGroup : MusicalSymbol
	{
		public BeamGroup(Staff staff)
		{
			Staff = staff;
		}

		public double Angle => Point.BeamAngle(Start, End);
		public Point End { get; internal set; }
		public ICollection<NoteOrRest> Members { get; set; } = new List<NoteOrRest>();
		public Point Start { get; internal set; }

		public override string ToString()
		{
			return $"Beam group of {Members.Count} members with angle {Angle}.";
		}
	}
}