using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
	public interface IBeamingService
	{
		List<Point> BeamEndPositionsY { get; set; }

		List<Point> BeamStartPositionsY { get; set; }

		double CurrentBeamAngle { get; set; }
		double CurrentStemEndPositionY { get; set; }

		double CurrentStemPositionX { get; set; }
		ICollection<Hook> HooksToDraw { get; }
		List<double> PreviousStemEndPositionsY { get; set; }

		List<double> PreviousStemPositionsX { get; set; }

		Dictionary<int, double> SomeMoreComplexBeamsToDraw { get; }

		IEnumerable<Note> GetAllNotesUnderOneBeam(Note examinedNote);
	}
}