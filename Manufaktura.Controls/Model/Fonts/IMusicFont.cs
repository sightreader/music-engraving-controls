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
        char BlackNoteHead { get; }

        /// <summary>
        /// C clef character
        /// </summary>
        char CClef { get; }

        /// <summary>
        /// Common time character
        /// </summary>
        char CommonTime { get; }

        /// <summary>
        /// Cut time character
        /// </summary>
        char CutTime { get; }

        /// <summary>
        /// 32-nd rest character
        /// </summary>
        char D32ndRest { get; }

        /// <summary>
        /// Dot character
        /// </summary>
        char Dot { get; }

        /// <summary>
        /// Double flat character
        /// </summary>
        char DoubleFlat { get; }

        /// <summary>
        /// Double sharp character
        /// </summary>
        char DoubleSharp { get; }

        /// <summary>
        /// Eighth note character
        /// </summary>
        char EighthNote { get; }

        /// <summary>
        /// Eighth rest character
        /// </summary>
        char EighthRest { get; }

        char FClef { get; }
        char FermataDown { get; }
        char FermataUp { get; }
        char Flat { get; }
        char GClef { get; }
        char HalfNote { get; }
        char HalfRest { get; }
        char LeftBracket { get; }
        char LeftSquareBracket { get; }
        char Mordent { get; }
        char MordentShort { get; }
        char Natural { get; }
        char NoteFlag128th { get; }
        char NoteFlag128thRev { get; }
        char NoteFlag32nd { get; }
        char NoteFlag32ndRev { get; }
        char NoteFlag64th { get; }
        char NoteFlag64thRev { get; }
        char NoteFlagEighth { get; }
        char NoteFlagEighthRev { get; }
        char NoteFlagSixteenth { get; }
        char NoteFlagSixteenthRev { get; }
        char PercussionClef { get; }
        char QuarterNote { get; }

        char QuarterRest { get; }

        char RepeatBackward { get; }

        char RepeatForward { get; }

        char RightBracket { get; }

        char Sharp { get; }

        char SixteenthNote { get; }

        char SixteenthRest { get; }

        char Staff4Lines { get; }

        char Staff5Lines { get; }

        char Trill { get; }

        char WhiteNoteHead { get; }

        char WholeNote { get; }

        char WholeRest { get; }
    }
}