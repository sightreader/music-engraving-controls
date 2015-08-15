using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Character mapping for font Polihymnia
    /// </summary>
    public class PolihymniaFont : IMusicFont
    {
        /// <summary>
        /// Creates a new instance of PolihymniaFont
        /// </summary>
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

        public string BlackNoteHead
        {
            get; private set;
        }

        public string CClef
        {
            get; private set;
        }

        public string CommonTime
        {
            get; private set;
        }

        public string CutTime
        {
            get; private set;
        }

        public string D32ndRest
        {
            get; private set;
        }

        public string Dot
        {
            get; private set;
        }

        public string DoubleFlat
        {
            get; private set;
        }

        public string DoubleSharp
        {
            get; private set;
        }

        public string EighthNote
        {
            get; private set;
        }

        public string EighthRest
        {
            get; private set;
        }

        public string FClef
        {
            get; private set;
        }

        public string FermataDown
        {
            get; private set;
        }

        public string FermataUp
        {
            get; private set;
        }

        public string Flat
        {
            get; private set;
        }

        public string GClef
        {
            get; private set;
        }

        public string HalfNote
        {
            get; private set;
        }

        public string HalfRest
        {
            get; private set;
        }

        public string Mordent
        {
            get; private set;
        }

        public string MordentShort
        {
            get; private set;
        }

        public string Natural
        {
            get; private set;
        }

        public string NoteFlag128th
        {
            get; private set;
        }

        public string NoteFlag128thRev
        {
            get; private set;
        }

        public string NoteFlag32nd
        {
            get; private set;
        }

        public string NoteFlag32ndRev
        {
            get; private set;
        }

        public string NoteFlag64th
        {
            get; private set;
        }

        public string NoteFlag64thRev
        {
            get; private set;
        }

        public string NoteFlagEighth
        {
            get; private set;
        }

        public string NoteFlagEighthRev
        {
            get; private set;
        }

        public string NoteFlagSixteenth
        {
            get; private set;
        }

        public string NoteFlagSixteenthRev
        {
            get; private set;
        }

        public string QuarterNote
        {
            get; private set;
        }

        public string QuarterRest
        {
            get; private set;
        }

        public string RepeatBackward
        {
            get; private set;
        }

        public string RepeatForward
        {
            get; private set;
        }

        public string Sharp
        {
            get; private set;
        }

        public string SixteenthNote
        {
            get; private set;
        }

        public string SixteenthRest
        {
            get; private set;
        }

        public string Staff4Lines
        {
            get; private set;
        }

        public string Staff5Lines
        {
            get; private set;
        }

        public string Trill
        {
            get; private set;
        }

        public string WhiteNoteHead
        {
            get; private set;
        }

        public string WholeNote
        {
            get; private set;
        }

        public string WholeRest
        {
            get; private set;
        }
    }
}
