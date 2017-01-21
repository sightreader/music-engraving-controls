using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Services
{
    public interface IMeasurementService
    {
        double LastMeasurePositionX { get; set; }

        double LastNoteEndXPosition { get; set; }

        //for many voices / dla wielu głosów
        //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        double LastNoteInMeasureEndXPosition { get; set; }

        double LastNotePositionX { get; set; } //for chords / dla akordów

        Point SlurBezierStartControlPoint { get; set; }
        VerticalPlacement SlurStartPlacement { get; set; }
        Point SlurStartPoint { get; set; }
        VerticalDirection SlurStartPointStemDirection { get; set; }
        Point TieStartPoint { get; set; }

        //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        Tuplet TupletState { get; set; }
    }
}