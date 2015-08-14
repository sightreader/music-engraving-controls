using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public interface IScore2HtmlBuilder
    {
        IEnumerable<Score> Scores { get; }
        string CanvasPrefix { get; }
        HtmlScoreRendererSettings Settings { get; }

        /// <summary>
        /// Build html code for displaying Scores based on Settings.
        /// </summary>
        /// <returns>Html code to render scores on client side</returns>
        string Build();
    }
}
