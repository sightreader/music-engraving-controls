using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class ScoreRendererState
    {
        public MusicFont CurrentFont { get; set; }
        public Score CurrentScore { get; set; }
        public Staff CurrentStaff { get; set; }
        public Clef CurrentClef {get; set;}
        public Key CurrentKey { get; set; }
        public TimeSignature CurrentTimeSignature { get; set; }
        public int CurrentMeasure { get; set; }
        public int CurrentSystem { get; set; }
        public double LastMeasurePositionX { get; set; }
        public double CurrentMeasureWidth { get; set; }
        public int CurrentVoice { get; set; }
        public double CurrentClefPositionY { get; set; }
        public double CurrentClefTextBlockPositionY { get; set;}

        public double CurrentSystemShiftY { get; set; }

        public bool IsManualMode { get; set; }
        public bool IsPrintMode { get; set; }
        
        public double CursorPositionX { get; set; }
        public double LastNotePositionX { get; set; } //for chords / dla akordów
        public double LastNoteEndXPosition { get; set; } //for many voices / dla wielu głosów
        public double firstNoteInMeasureXPosition { get; set; } //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public double lastNoteInMeasureEndXPosition { get; set; } //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie

        public double currentStemEndPositionY { get; set; }

        public Tuplet TupletState { get; set; }

        public List<double> previousStemEndPositionsY { get; set; }
        public double currentStemPositionX { get; set; }
        public List<double> previousStemPositionsX { get; set; }
        public List<Point> beamStartPositionsY { get; set; }
        public List<Point> beamEndPositionsY { get; set; }
        public Point tieStartPoint { get; set; }
        public Point SlurStartPoint { get; set; }
        
        public int[] alterationsWithinOneBar { get; set; }
        public bool firstNoteInIncipit { get; set; }
        
        public Dictionary<int, double[]> LinePositions { get; private set; }

        public ScoreRendererState()
        {
            CurrentFont = new PolihymniaFont();
            CurrentSystem = 1;
            CurrentClef = new Clef(ClefType.CClef, 2);
            CurrentKey = new Key(0);
            CursorPositionX = 0;
            LastNotePositionX = 0; //for chords / dla akordów
            LastNoteEndXPosition = 0; //for many voices / dla wielu głosów
            firstNoteInMeasureXPosition = 0; //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
            lastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
            currentStemEndPositionY = 0;
            previousStemEndPositionsY = new List<double>();
            currentStemPositionX = 0;
            previousStemPositionsX = new List<double>();
            beamStartPositionsY = new List<Point>();
            beamEndPositionsY = new List<Point>();
            tieStartPoint = new Point();
            SlurStartPoint = new Point();
            CurrentVoice = 1;
            LinePositions = new Dictionary<int, double[]>() { { 1, new double[5] } };
            CurrentClefTextBlockPositionY = 0;           
        }
    }
}
