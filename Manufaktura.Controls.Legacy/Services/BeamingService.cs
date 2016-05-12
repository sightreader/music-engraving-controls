using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
	public class BeamingService : IBeamingService
	{
		public BeamingService()
		{
			PreviousStemEndPositionsY = new List<double>();
			PreviousStemPositionsX = new List<double>();
		}

		public double CurrentStemEndPositionY { get; set; }

		public double CurrentStemPositionX { get; set; }

		public List<double> PreviousStemEndPositionsY { get; set; }

		public List<double> PreviousStemPositionsX { get; set; }
	}
}