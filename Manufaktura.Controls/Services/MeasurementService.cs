using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Services
{
    public class MeasurementService : IMeasurementService
    {
        public MeasurementService()
        {
            LastNotePositionX = 0; //for chords / dla akordów
            LastNoteEndXPosition = 0; //for many voices / dla wielu głosów

            TieStartPoint = new Point();
            SlurStartPoint = new Point();

            LastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        }

        public double LastMeasurePositionX { get; set; }

        public double LastNoteEndXPosition { get; set; }

        //for many voices / dla wielu głosów
        //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public double LastNoteInMeasureEndXPosition { get; set; }

        public double LastNotePositionX { get; set; } //for chords / dla akordów

        public Point SlurStartPoint { get; set; }

        public VerticalDirection SlurStartPointStemDirection { get; set; }
        public Point TieStartPoint { get; set; }

        //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        public Tuplet TupletState { get; set; }
    }
}