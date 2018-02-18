using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Rendering.Implementations
{
    /// <summary>
    /// Interface for implementing Score to HTML converters
    /// </summary>
    public interface IScore2HtmlBuilder
    {
        /// <summary>
        /// Scores to render
        /// </summary>
        IEnumerable<Score> Scores { get; }

        string CanvasPrefix { get; }

        /// <summary>
        /// Rendering settings
        /// </summary>
        HtmlScoreRendererSettings Settings { get; }

        /// <summary>
        /// Build html code for displaying Scores based on Settings.
        /// </summary>
        /// <returns>Html code to render scores on client side</returns>
        string Build();
    }
}