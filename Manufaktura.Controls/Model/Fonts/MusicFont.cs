using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Character mapping definition for music font.
    /// </summary>
    public abstract class MusicFont
    {
        public string Staff5Lines { get; protected set; }
        public string Staff4Lines { get; protected set; }
        public string GClef { get; protected set; }
        public string FClef { get; protected set; }
        public string CClef { get; protected set; }
        public string Sharp { get; protected set; }
        public string Flat { get; protected set; }
        public string Natural { get; protected set; }
        public string DoubleSharp { get; protected set; }
        public string DoubleFlat { get; protected set; }
        public string WholeNote { get; protected set; }
        public string HalfNote { get; protected set; }
        public string QuarterNote { get; protected set; }
        public string EighthNote { get; protected set; }
        public string SixteenthNote { get; protected set; }
        public string WholeRest { get; protected set; }
        public string HalfRest { get; protected set; }
        public string QuarterRest { get; protected set; }
        public string EighthRest { get; protected set; }
        public string SixteenthRest { get; protected set; }
        public string D32ndRest { get; protected set; }
        public string WhiteNoteHead { get; protected set; }
        public string BlackNoteHead { get; protected set; }
        public string NoteFlagEighth { get; protected set; }
        public string NoteFlagSixteenth { get; protected set; }
        public string NoteFlag32nd { get; protected set; }
        public string NoteFlag64th { get; protected set; }
        public string NoteFlag128th { get; protected set; }
        public string NoteFlagEighthRev { get; protected set; }
        public string NoteFlagSixteenthRev { get; protected set; }
        public string NoteFlag32ndRev { get; protected set; }
        public string NoteFlag64thRev { get; protected set; }
        public string NoteFlag128thRev { get; protected set; }
        public string Dot { get; protected set; }
        public string CommonTime { get; protected set; }
        public string CutTime { get; protected set; }
        public string RepeatForward { get; protected set; }
        public string RepeatBackward { get; protected set; }
        public string Trill { get; protected set; }
        public string Mordent { get; protected set; }
        public string MordentShort { get; protected set; }
        public string FermataUp { get; protected set; }
        public string FermataDown { get; protected set; }
    }
}
