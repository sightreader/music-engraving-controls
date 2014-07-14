using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public abstract class MusicalSymbolRenderStrategy<TElement> : MusicalSymbolRenderStrategyBase where TElement : MusicalSymbol
    {
        public override Type SymbolType { get { return typeof(TElement); } }

        public abstract void Render(TElement element, ScoreRendererBase renderer);

        public override void Render(MusicalSymbol element, ScoreRendererBase renderer)
        {
            Render((TElement)element, renderer);
        }
    }
}
