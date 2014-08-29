using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class ScoreRendererState
    {
        public Score CurrentScore { get; set; }
        public Staff CurrentStaff { get; set; }
        public Clef CurrentClef {get; set;}
        public Key CurrentKey { get; set; }
        public int CurrentMeasure { get; set; }
        public double LastMeasurePositionX { get; set; }
        public double CurrentMeasureWidth { get; set; }
        public int CurrentVoice { get; set; }

        public double currentClefPositionY { get; set;}

        public bool IsManualMode { get; set; }
        public bool IsPrintMode { get; set; }
        
        public double CursorPositionX { get; set; }
        public double LastCursorPositionX { get; set; } //for chords / dla akordów
        public double lastNoteEndXPosition { get; set; } //for many voices / dla wielu głosów
        public double firstNoteInMeasureXPosition { get; set; } //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public double lastNoteInMeasureEndXPosition { get; set; } //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie

        public double currentStemEndPositionY { get; set; }
        public int NumberOfNotesUnderTuplet { get; set; }
        public VerticalPlacement TupletPlacement { get; set; }
        public List<double> previousStemEndPositionsY { get; set; }
        public double currentStemPositionX { get; set; }
        public List<double> previousStemPositionsX { get; set; }
        public List<Point> beamStartPositionsY { get; set; }
        public List<Point> beamEndPositionsY { get; set; }
        public Point tieStartPoint { get; set; }
        public Point slurStartPoint { get; set; }
        
        public int[] alterationsWithinOneBar { get; set; }
        public bool firstNoteInIncipit { get; set; }
        
        public int[] LinePositions { get; private set; }

        public ScoreRendererState()
        {
            CurrentClef = new Clef(ClefType.CClef, 2);
            CurrentKey = new Key(0);
            CursorPositionX = 0;
            LastCursorPositionX = 0; //for chords / dla akordów
            lastNoteEndXPosition = 0; //for many voices / dla wielu głosów
            firstNoteInMeasureXPosition = 0; //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
            lastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
            currentStemEndPositionY = 0;
            NumberOfNotesUnderTuplet = 0;
            previousStemEndPositionsY = new List<double>();
            currentStemPositionX = 0;
            previousStemPositionsX = new List<double>();
            beamStartPositionsY = new List<Point>();
            beamEndPositionsY = new List<Point>();
            tieStartPoint = new Point();
            slurStartPoint = new Point();
            CurrentVoice = 1;
            LinePositions = new int[5];
            currentClefPositionY = 0;           
        }
    }
}
