using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Services
{
    public interface IMeasurementService
    {
        double LastMeasurePositionX { get; set; }

        double LastNoteEndXPosition { get; set; }

        //for many voices / dla wielu głosów
        //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        double lastNoteInMeasureEndXPosition { get; set; }

        double LastNotePositionX { get; set; } //for chords / dla akordów


        List<double> previousStemEndPositionsY { get; set; }

        List<double> previousStemPositionsX { get; set; }

        Point SlurStartPoint { get; set; }

        Point tieStartPoint { get; set; }

        //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        Tuplet TupletState { get; set; }
    }
}
