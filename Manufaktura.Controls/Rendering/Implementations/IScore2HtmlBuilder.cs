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
        string Build();
    }
}
