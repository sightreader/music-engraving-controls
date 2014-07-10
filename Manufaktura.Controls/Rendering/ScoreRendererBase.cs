using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRendererBase
    {
        public ScoreRendererState State { get; private set; }
        protected ScoreRendererBase()
        {
            State = new ScoreRendererState();
        }

        public MusicalSymbolRenderStrategy<TElement> GetProperRenderStrategy<TElement>(TElement element)
        {
            //TODO: Patrzeć po typie elementu zawsze
            throw new NotImplementedException();
        }
    }
}
