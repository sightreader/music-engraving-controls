using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    [Obsolete("It will be soon replaced by services")]
    public class ScoreRendererState
    {
        public List<Point> beamEndPositionsY { get; set; }

        public List<Point> beamStartPositionsY { get; set; }

        

        public double currentStemEndPositionY { get; set; }

        public double currentStemPositionX { get; set; }





        public double CursorPositionX { get; set; }

        public bool firstNoteInIncipit { get; set; }



        public bool IsManualMode { get; set; }

        public ScoreRendererState()
        {
            
            
            CursorPositionX = 0;
            currentStemEndPositionY = 0;
            
            currentStemPositionX = 0;

            beamStartPositionsY = new List<Point>();
            beamEndPositionsY = new List<Point>();
            
           
            
        }
    }
}