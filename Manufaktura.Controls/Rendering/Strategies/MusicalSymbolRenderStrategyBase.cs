using Manufaktura.Controls.Model;
using System;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Base class for implementing render strategies
    /// </summary>
    public abstract class MusicalSymbolRenderStrategyBase
    {
        /// <summary>
        /// Type of musical symbol whose rendering is supported by this strategy
        /// </summary>
        public abstract Type SymbolType { get; }

        /// <summary>
        /// Renders musical symbol with specific score renderer
        /// </summary>
        /// <param name="element">Musical symbol to render</param>
        /// <param name="renderer">Score renderer</param>
        public abstract void Render(MusicalSymbol element, ScoreRendererBase renderer);
    }
}