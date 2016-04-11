namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Describes a tuplet.
    /// </summary>
    public class Tuplet
    {
        /// <summary>
        /// Inicates if single beams are present under tuplet.
        /// </summary>
        public bool AreSingleBeamsPresentUnderTuplet { get; set; }

        /// <summary>
        /// Number of notes which create a tuplet.
        /// </summary>
        public int NumberOfNotesUnderTuplet { get; set; }

        /// <summary>
        /// Vertical placement of a tuplet.
        /// </summary>
        public VerticalPlacement TupletPlacement { get; set; }
    }
}