namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Character mapping definition for music font.
    /// </summary>
    public interface IMusicFont
    {
        /// <summary>
        /// Black notehead character
        /// </summary>
        string BlackNoteHead { get; }


        /// <summary>
        /// C clef character
        /// </summary>
        string CClef { get; }

        /// <summary>
        /// Common time character
        /// </summary>
        string CommonTime { get; }

        /// <summary>
        /// Cut time character
        /// </summary>
        string CutTime { get; }

        /// <summary>
        /// 32-nd rest character
        /// </summary>
        string D32ndRest { get; }

        /// <summary>
        /// Dot character
        /// </summary>
        string Dot { get; }

        /// <summary>
        /// Double flat character
        /// </summary>
        string DoubleFlat { get; }

        /// <summary>
        /// Double sharp character
        /// </summary>
        string DoubleSharp { get; }

        /// <summary>
        /// Eighth note character
        /// </summary>
        string EighthNote { get; }
        string EighthRest { get; }
        string FClef { get; }
        string FermataDown { get; }
        string FermataUp { get; }
        string Flat { get; }
        string GClef { get; }
        string HalfNote { get; }
        string HalfRest { get; }
        string LeftBracket { get; }
        string LeftSquareBracket { get; }
        string Mordent { get; }
        string MordentShort { get; }
        string Natural { get; }
        string NoteFlag128th { get; }
        string NoteFlag128thRev { get; }
        string NoteFlag32nd { get; }
        string NoteFlag32ndRev { get; }
        string NoteFlag64th { get; }
        string NoteFlag64thRev { get; }
        string NoteFlagEighth { get; }
        string NoteFlagEighthRev { get; }
        string NoteFlagSixteenth { get; }
        string NoteFlagSixteenthRev { get; }
        string PercussionClef { get; }
        string QuarterNote { get; }

        string QuarterRest { get; }

        string RepeatBackward { get; }

        string RepeatForward { get; }

        string RightBracket { get; }

        string Sharp { get; }

        string SixteenthNote { get; }

        string SixteenthRest { get; }

        string Staff4Lines { get; }

        string Staff5Lines { get; }

        string Trill { get; }

        string WhiteNoteHead { get; }

        string WholeNote { get; }

        string WholeRest { get; }
    }
}