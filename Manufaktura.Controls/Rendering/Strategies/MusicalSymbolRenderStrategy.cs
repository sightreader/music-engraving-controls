using Manufaktura.Controls.Model;
using System;

namespace Manufaktura.Controls.Rendering
{
	/// <summary>
	/// Strategy of drawing specific musical symbol.
	/// </summary>
	/// <typeparam name="TElement">Musical symbol type</typeparam>
	public abstract class MusicalSymbolRenderStrategy<TElement> : MusicalSymbolRenderStrategyBase where TElement : MusicalSymbol
	{
        /// <summary>
        /// Musica symbol whose rendering is supported by this strategy
        /// </summary>
		public override Type SymbolType { get { return typeof(TElement); } }

		/// <summary>
		/// Draw musical symbol
		/// </summary>
		/// <param name="element">Element to draw</param>
		/// <param name="renderer">Renderer</param>
		public abstract void Render(TElement element, ScoreRendererBase renderer);

		/// <summary>
		/// Draw musical symbol
		/// </summary>
		/// <param name="element">Element to draw</param>
		/// <param name="renderer">Renderer</param>
		public override void Render(MusicalSymbol element, ScoreRendererBase renderer)
		{
			Render((TElement)element, renderer);
		}
	}
}