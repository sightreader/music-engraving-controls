namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Character mapping definition for music font.
    /// </summary>
    public interface IMusicFont
    {
        /// <summary>
        /// Dot character
        /// </summary>
        char AugmentationDot { get; }

        char BraceLeft { get; }

        char BraceRight { get; }

        /// <summary>
        /// C clef character
        /// </summary>
        char CClef { get; }

        char CClef8va { get; }
        char CClef8vb { get; }
        char CClef15ma { get; }
        char CClef15mb { get; }

        /// <summary>
        /// Common time character
        /// </summary>
        char CommonTime { get; }

        /// <summary>
        /// Cut time character
        /// </summary>
        char CutTime { get; }

        /// <summary>
        /// Double flat character
        /// </summary>
        char DoubleFlat { get; }

        /// <summary>
        /// Double sharp character
        /// </summary>
        char DoubleSharp { get; }

        char FClef { get; }
        char FClef8va { get; }
        char FClef8vb { get; }
        char FClef15ma { get; }
        char FClef15mb { get; }

        char FermataDown { get; }

        char FermataUp { get; }

        char Flat { get; }

        char GClef { get; }
        char GClef8va { get; }
        char GClef8vb { get; }
        char GClef15ma { get; }
        char GClef15mb { get; }

        char Mordent { get; }

        char MordentShort { get; }

        char Natural { get; }

        /// <summary>
        /// Eighth note character
        /// </summary>
        char NoteEighth { get; }

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

        char NoteHalf { get; }

        /// <summary>
        /// Black notehead character
        /// </summary>
        char NoteheadBlack { get; }

        char NoteheadHalf { get; }
        char NoteheadBlackCue { get; }
        char NoteheadHalfCue { get; }
        char NoteheadBlackLarge { get; }
        char NoteheadHalfLarge { get; }

        char NoteQuarter { get; }

        char NoteSixteenth { get; }
        char NoteDoubleWhole { get; }
        char NoteDoubleWholeCue { get; }
        char NoteDoubleWholeLarge { get; }
        char NoteWhole { get; }
        char NoteWholeCue { get; }
        char NoteWholeLarge { get; }

        char PercussionClef { get; }

        char RepeatBackward { get; }

        char RepeatForward { get; }

        /// <summary>
        /// 32-nd rest character
        /// </summary>
        char Rest32nd { get; }

        /// <summary>
        /// Eighth rest character
        /// </summary>
        char RestEighth { get; }

        char RestHalf { get; }
        char RestQuarter { get; }
        char RestSixteenth { get; }
        char RestWhole { get; }
        char Sharp { get; }
        char SquareBracketLeft { get; }
        char Staff4Lines { get; }

        char Staff5Lines { get; }

        char Trill { get; }
    }
}