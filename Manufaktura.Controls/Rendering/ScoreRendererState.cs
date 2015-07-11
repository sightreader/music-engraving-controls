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

        public Clef CurrentClef { get; set; }

        public double CurrentClefPositionY { get; set; }

        public MusicFont CurrentFont { get; set; }

        public Key CurrentKey { get; set; }



        public double CurrentMeasureWidth { get; set; }





        public double currentStemEndPositionY { get; set; }

        public double currentStemPositionX { get; set; }



        public int CurrentVoice { get; set; }

        public double CursorPositionX { get; set; }

        public bool firstNoteInIncipit { get; set; }



        public bool IsManualMode { get; set; }

        public ScoreRendererState()
        {
            CurrentFont = new PolihymniaFont();
            CurrentClef = new Clef(ClefType.CClef, 2);
            CurrentKey = new Key(0);
            CursorPositionX = 0;
            currentStemEndPositionY = 0;
            
            currentStemPositionX = 0;

            beamStartPositionsY = new List<Point>();
            beamEndPositionsY = new List<Point>();
            
            CurrentVoice = 1;
            
        }
    }
}