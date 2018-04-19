using Manufaktura.Controls.Model.Fonts;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a mordent ornament.
    /// </summary>
    public class Mordent : Ornament
    {
        /// <summary>
        /// Indicates if the mordent is inverted.
        /// </summary>
        public bool IsInverted { get; set; }

        public char GetCharacter(IMusicFont font)
        {
            return IsInverted ? font.MordentInverted : font.Mordent;
        }
    }
}