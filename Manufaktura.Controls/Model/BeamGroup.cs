using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
	public class BeamGroup
	{
		public BeamGroup()
		{
		}

		public BeamGroup(Point start, Point end, double angle)
		{
		}

		public double Angle => Point.BeamAngle(Start, End);
		public Point End { get; set; }
		public ICollection<NoteOrRest> Members { get; set; } = new List<NoteOrRest>();
		public Point Start { get; set; }
	}
}