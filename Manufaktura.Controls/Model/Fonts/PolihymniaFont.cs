using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Character mapping for font Polihymnia
    /// </summary>
    public class PolihymniaFont : MusicFont
    {
        public PolihymniaFont() 
        {
            Staff5Lines = "=";
            Staff4Lines = "_";
            GClef = "G";
            FClef = "?";
            CClef = "K";
            Sharp = "X";
            Flat = "b";
            Natural = "k";
            DoubleSharp = "x";
            DoubleFlat = "B";
            WholeNote = "w";
            HalfNote = "h";
            QuarterNote = "q";
            EighthNote = "e";
            SixteenthNote = "s";
            WholeRest = "W";
            HalfRest = "H";
            QuarterRest = "Q";
            EighthRest = "E";
            SixteenthRest = "S";
            D32ndRest = "T";
            WhiteNoteHead = "9";
            BlackNoteHead = "0";
            NoteFlagEighth = "1";
            NoteFlagSixteenth = "2";
            NoteFlag32nd = "3";
            NoteFlag64th = "4";
            NoteFlag128th = "5";
            NoteFlagEighthRev = "!";
            NoteFlagSixteenthRev = "@";
            NoteFlag32ndRev = "#";
            NoteFlag64thRev = "$";
            NoteFlag128thRev = "%";
            Dot = ".";
            CommonTime = "c";
            CutTime = "C";
            RepeatForward = @"\";
            RepeatBackward = @"l";
            Trill = "r";
            Mordent = "m";
            MordentShort = "n";
            FermataUp = "Y";
            FermataDown = "Z";
        }
    }
}
