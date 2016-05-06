using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Controls.Interactivity
{
	public static class DraggingStrategy
	{
		private static Lazy<IEnumerable<IDraggingStrategy>> strategies = new Lazy<IEnumerable<IDraggingStrategy>>(() =>
			typeof(IDraggingStrategy)
			.GetTypeInfo()
			.Assembly
			.DefinedTypes
			.Where(t => !t.IsAbstract && typeof(IDraggingStrategy).GetTypeInfo().IsAssignableFrom(t))
			.Select(t => Expression.Lambda(Expression.New(t.AsType())).Compile().DynamicInvoke())
			.Cast<IDraggingStrategy>().ToList());

		public static IDraggingStrategy For(MusicalSymbol draggedElement)
		{
			return strategies.Value.FirstOrDefault(s => s.ElementType == draggedElement.GetType()) ??
				strategies.Value.FirstOrDefault(s => draggedElement.GetType().GetTypeInfo().IsSubclassOf(s.ElementType));
		}
	}

	public abstract class DraggingStrategy<TElement> : IDraggingStrategy
	{
		public Type ElementType => typeof(TElement);

		public void Drag(object draggedElement, DraggingState draggingState, Point currentPosition)
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

			DragInternal((TElement)draggedElement, draggingState, delta, smallDelta);
		}

		/// <summary>
		/// Performs dragging operation
		/// </summary>
		/// <param name="draggedElement">Dragged element</param>
		/// <param name="draggingState">Dragging state</param>
		/// <param name="delta">Delta between start position and current position</param>
		/// <param name="smallDelta">Delta between previous position and current position</param>
		protected abstract void DragInternal(TElement draggedElement, DraggingState draggingState, double delta, double smallDelta);
	}
}