using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    /// <summary>
    /// Service that stores temporary information about beams
    /// </summary>
	public interface IBeamingService
	{
		double CurrentStemEndPositionY { get; set; }

		double CurrentStemPositionX { get; set; }
		List<double> PreviousStemEndPositionsY { get; set; }

		List<double> PreviousStemPositionsX { get; set; }
	}
}