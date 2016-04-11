using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public abstract class MusicalSymbolRenderStrategyBase
    {
        public abstract Type SymbolType { get; }

        public abstract void Render(MusicalSymbol element, ScoreRendererBase renderer);
    }
}
