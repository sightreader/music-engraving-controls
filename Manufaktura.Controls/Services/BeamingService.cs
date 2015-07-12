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

        public List<double> PreviousStemEndPositionsY { get; set; }

        public List<double> PreviousStemPositionsX { get; set; }

        public BeamingService()
        {
            PreviousStemEndPositionsY = new List<double>();
            PreviousStemPositionsX = new List<double>();
            BeamStartPositionsY = new List<Point>();
            BeamEndPositionsY = new List<Point>();
        }
    }
}