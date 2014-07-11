using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class ScoreRendererState
    {
        public Clef CurrentClef {get; set;}
        public double currentClefPositionY = 0;

        public Key currentKey { get; set; }
        public double currentXPosition { get; set; }
        public int lastXPosition { get; set; } //for chords / dla akordów
        public int lastNoteEndXPosition { get; set; } //for many voices / dla wielu głosów
        public int firstNoteInMeasureXPosition { get; set; } //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public int lastNoteInMeasureEndXPosition { get; set; } //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        public int paddingTop { get; private set; }
        public int lineSpacing { get; private set; }
        public float currentStemEndPositionY { get; set; }
        public int numberOfNotesUnderTuplet { get; set; }
        public List<float> previousStemEndPositionsY { get; set; }
        public float currentStemPositionX { get; set; }
        public List<float> previousStemPositionsX { get; set; }
        public List<Point> beamStartPositionsY { get; set; }
        public List<Point> beamEndPositionsY { get; set; }
        public Point tieStartPoint { get; set; }
        public Point slurStartPoint { get; set; }
        public int currentVoice { get; set; }
        public int[] alterationsWithinOneBar { get; set; }
        public bool firstNoteInIncipit { get; set; }
        public int currentMeasure { get; set; }

        public int[] lines { get; private set; }

        public ScoreRendererState()
        {
            CurrentClef = new Clef(ClefType.CClef, 2);
            currentKey = new Key(0);
            currentXPosition = 0;
            lastXPosition = 0; //for chords / dla akordów
            lastNoteEndXPosition = 0; //for many voices / dla wielu głosów
            firstNoteInMeasureXPosition = 0; //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
            lastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
            paddingTop = 20;
            lineSpacing = 6;
            currentStemEndPositionY = 0;
            numberOfNotesUnderTuplet = 0;
            previousStemEndPositionsY = new List<float>();
            currentStemPositionX = 0;
            previousStemPositionsX = new List<float>();
            beamStartPositionsY = new List<Point>();
            beamEndPositionsY = new List<Point>();
            tieStartPoint = new Point();
            slurStartPoint = new Point();
            currentVoice = 1;
            lines = new int[5];
            
        }
    }
}
