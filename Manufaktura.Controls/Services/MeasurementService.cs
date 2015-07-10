using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Services
{
    public class MeasurementService : IMeasurementService
    {
        public double LastMeasurePositionX { get; set; }

        public double LastNoteEndXPosition { get; set; }

        //for many voices / dla wielu głosów
        //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public double lastNoteInMeasureEndXPosition { get; set; }

        public double LastNotePositionX { get; set; } //for chords / dla akordów

        

        public List<double> previousStemEndPositionsY { get; set; }

        public List<double> previousStemPositionsX { get; set; }

        public Point SlurStartPoint { get; set; }

        public Point tieStartPoint { get; set; }

        //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        public Tuplet TupletState { get; set; }

        public MeasurementService()
        {
            LastNotePositionX = 0; //for chords / dla akordów
            LastNoteEndXPosition = 0; //for many voices / dla wielu głosów
            previousStemEndPositionsY = new List<double>();
            previousStemPositionsX = new List<double>();
            tieStartPoint = new Point();
            SlurStartPoint = new Point();
           
            lastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        }

    }
}
