using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// Indicates that class can be use to format a Score.
    /// </summary>
    public interface IScoreFormatter
    {
        /// <summary>
        /// Formats a Score.
        /// </summary>
        /// <param name="score">Score to format.</param>
        /// <returns>Formatted Score.</returns>
        Score Format(Score score);
    }
}