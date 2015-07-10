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

        public double CurrentClefTextBlockPositionY { get; set; }

        public MusicFont CurrentFont { get; set; }

        public Key CurrentKey { get; set; }

        public int CurrentLine
        {
            get
            {
                return CurrentScore.Staves.IndexOf(CurrentStaff) + 1;
            }
        }

        public int CurrentMeasure { get; set; }

        public double CurrentMeasureWidth { get; set; }

        public Score CurrentScore { get; set; }

        public Staff CurrentStaff { get; set; }

        public double CurrentStaffHeight
        {
            get
            {
                return LinePositions[CurrentSystem][CurrentLine].Max() - LinePositions[CurrentSystem][CurrentLine].Min();
            }
        }

        public LineDictionary LinePositions { get; private set; }

        public double currentStemEndPositionY { get; set; }

        public double currentStemPositionX { get; set; }

        public int CurrentSystem { get; set; }

        public double CurrentSystemShiftY { get; set; }

        public TimeSignature CurrentTimeSignature { get; set; }

        public int CurrentVoice { get; set; }

        public double CursorPositionX { get; set; }

        public bool firstNoteInIncipit { get; set; }

        public double firstNoteInMeasureXPosition { get; set; }

        public bool IsManualMode { get; set; }

        public ScoreRendererState()
        {
            CurrentFont = new PolihymniaFont();
            CurrentSystem = 1;
            CurrentClef = new Clef(ClefType.CClef, 2);
            CurrentKey = new Key(0);
            CursorPositionX = 0;
            firstNoteInMeasureXPosition = 0; //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
            currentStemEndPositionY = 0;
            
            currentStemPositionX = 0;
            LinePositions = new LineDictionary();

            beamStartPositionsY = new List<Point>();
            beamEndPositionsY = new List<Point>();
            
            CurrentVoice = 1;
            
            CurrentClefTextBlockPositionY = 0;
        }
    }
}