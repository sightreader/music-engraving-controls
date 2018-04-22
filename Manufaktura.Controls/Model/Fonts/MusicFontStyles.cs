namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Music font styles.
    /// </summary>
    public enum MusicFontStyles
    {
        /// <summary>
        /// Font for drawing most score elements like noteheads, rests, clefs, etc.
        /// </summary>
        MusicFont,

        /// <summary>
        /// Font for drawing grace an cue notes
        /// </summary>
        GraceNoteFont,

        /// <summary>
        /// Font for drawing lyrics
        /// </summary>
        LyricsFont,

        /// <summary>
        /// Fonts for drawing symbols that are precisely 4 linespaces high. Used only in renderers that don't support DrawCharacterInBounds
        /// </summary>
        StaffFont,

        /// <summary>
        /// Font for drawing directions
        /// </summary>
        DirectionFont,

        /// <summary>
        /// Font for drawing time signature, only in Polihymnia font. In SMuFL fonts MusicFont is used.
        /// </summary>
        TimeSignatureFont
    }
}