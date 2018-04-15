using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

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

        Dictionary<int, SlurInfo> Slurs { get; }

        Point TieStartPoint { get; set; }
        StaffSystem TieStartSystem { get; set; }

        //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        Tuplet TupletState { get; set; }
    }

    public class SlurInfo
    {
        public Point BezierStartControlPoint { get; set; }
        public VerticalPlacement StartPlacement { get; set; }
        public Point StartPoint { get; set; }
        public VerticalDirection StartPointStemDirection { get; set; }
    }
}