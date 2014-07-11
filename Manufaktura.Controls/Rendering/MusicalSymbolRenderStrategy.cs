using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public abstract class MusicalSymbolRenderStrategy<TElement>
    {
        public Type SymbolType { get { return typeof(TElement); } }

        public abstract void Render(TElement element, ScoreRendererBase renderer);
    }
}
