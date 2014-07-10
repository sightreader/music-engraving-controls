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
        float currentClefPositionY = 0;

        Key currentKey { get; set; }
        int currentXPosition { get; set; }
        int lastXPosition { get; set; } //for chords / dla akordów
        int lastNoteEndXPosition { get; set; } //for many voices / dla wielu głosów
        int firstNoteInMeasureXPosition { get; set; } //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        int lastNoteInMeasureEndXPosition { get; set; } //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        int paddingTop { get; private set; }
        int lineSpacing { get; private set; }
        float currentStemEndPositionY { get; set; }
        int numberOfNotesUnderTuplet { get; set; }
        List<float> previousStemEndPositionsY { get; set; }
        float currentStemPositionX { get; set; }
        List<float> previousStemPositionsX { get; set; }
        List<Point> beamStartPositionsY { get; set; }
        List<Point> beamEndPositionsY { get; set; }
        Point tieStartPoint { get; set; }
        Point slurStartPoint { get; set; }
        int currentVoice { get; set; }

        int[] lines {get; private set;}

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
