using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    public class BeamingService : IBeamingService
    {
        public List<Point> BeamEndPositionsY { get; set; }

        public List<Point> BeamStartPositionsY { get; set; }

        public double CurrentStemEndPositionY { get; set; }

        public double CurrentStemPositionX { get; set; }

        public BeamingService()
        {
            BeamStartPositionsY = new List<Point>();
            BeamEndPositionsY = new List<Point>();
        }
    }
}