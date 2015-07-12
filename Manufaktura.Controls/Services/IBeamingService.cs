using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    public interface IBeamingService
    {
        List<Point> BeamEndPositionsY { get; set; }

        List<Point> BeamStartPositionsY { get; set; }

        double CurrentStemEndPositionY { get; set; }

        double CurrentStemPositionX { get; set; }

        List<double> PreviousStemEndPositionsY { get; set; }

        List<double> PreviousStemPositionsX { get; set; }
    }
}