using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Static methods for dragging strategies
	/// </summary>
	public static class DraggingStrategy
	{
		/// <summary>
		/// Assemblies that contain dragging strategy implementations
		/// </summary>
		public static ICollection<Assembly> AssembliesToSearchForStrategies = new List<Assembly> { typeof(IDraggingStrategy)
			.GetTypeInfo()
			.Assembly };

		private static Lazy<IEnumerable<IDraggingStrategy>> strategies = new Lazy<IEnumerable<IDraggingStrategy>>(() =>
			AssembliesToSearchForStrategies
			.SelectMany(a => a.DefinedTypes)
			.Where(t => !t.IsAbstract && typeof(IDraggingStrategy).GetTypeInfo().IsAssignableFrom(t))
			.Select(t => Expression.Lambda(Expression.New(t.AsType())).Compile().DynamicInvoke())
			.Cast<IDraggingStrategy>().ToList());

		/// <summary>
		/// Returns a proper dragging strategy for given element
		/// </summary>
		/// <param name="draggedElement">Dragged element</param>
		/// <returns>Proper dragging strategy</returns>
		public static IDraggingStrategy For(MusicalSymbol draggedElement)
		{
			return strategies.Value.FirstOrDefault(s => s.ElementType == draggedElement.GetType()) ??
				strategies.Value.FirstOrDefault(s => draggedElement.GetType().GetTypeInfo().IsSubclassOf(s.ElementType));
		}
	}

	/// <summary>
	/// Base class for implementing drawing strategies
	/// </summary>
	/// <typeparam name="TElement"></typeparam>
	public abstract class DraggingStrategy<TElement> : IDraggingStrategy
	{
		/// <summary>
		/// Type of MusicalSymbol which dragging behavior is managed by this class
		/// </summary>
		public Type ElementType => typeof(TElement);

		/// <summary>
		/// Manages dragging behavior
		/// </summary>
		/// <param name="renderer">Score renderer</param>
		/// <param name="draggedElement">Dragged element</param>
		/// <param name="draggingState">Dragging state</param>
		/// <param name="currentPosition">Current cursor position</param>
		public void Drag(ScoreRendererBase renderer, object draggedElement, DraggingState draggingState, Point currentPosition)
		{
			double horizontalDifference = Math.Abs(draggingState.MousePositionOnStartDragging.X - currentPosition.X);
			if (horizontalDifference > 30)
			{
				draggingState.StopDragging();
				return;
			}
			double delta = draggingState.MousePositionOnStartDragging.Y - currentPosition.Y;
			double smallDelta = draggingState.MousePreviousPosition.Y - currentPosition.Y;
			draggingState.MousePreviousPosition = currentPosition;

			DragInternal(renderer, (TElement)draggedElement, draggingState, delta, smallDelta);
		}

		/// <summary>
		/// Performs dragging operation
		/// </summary>
		/// <param name="renderer">Score renderer</param>
		/// <param name="draggedElement">Dragged element</param>
		/// <param name="draggingState">Dragging state</param>
		/// <param name="delta">Delta between start position and current position</param>
		/// <param name="smallDelta">Delta between previous position and current position</param>
		protected abstract void DragInternal(ScoreRendererBase renderer, TElement draggedElement, DraggingState draggingState, double delta, double smallDelta);
	}
}