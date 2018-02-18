using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    /// <summary>
    /// Default implementation of IMeasurementService
    /// </summary>
    public class MeasurementService : IMeasurementService
    {
        public MeasurementService()
        {
            LastNotePositionX = 0; //for chords / dla akordów
            LastNoteEndXPosition = 0; //for many voices / dla wielu głosów

            TieStartPoint = new Point();
            LastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        }

        public double LastMeasurePositionX { get; set; }

        public double LastNoteEndXPosition { get; set; }

        //for many voices / dla wielu głosów
        //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public double LastNoteInMeasureEndXPosition { get; set; }

        public double LastNotePositionX { get; set; } //for chords / dla akordów

        public Dictionary<int, SlurInfo> Slurs { get; } = new Dictionary<int, SlurInfo>();

        public Point TieStartPoint { get; set; }

        //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        public Tuplet TupletState { get; set; }
    }
}