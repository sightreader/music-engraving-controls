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
			return strategies.Value.FirstOrDefault(s => s.ElementType == draggedElement.GetType());
		}
	}

	public abstract class DraggingStrategy<TElement> : IDraggingStrategy
	{
		public Type ElementType => typeof(TElement);

		public void Drag<TPoint>(object draggedElement, DraggingState<TPoint> draggingState, int midiPitchOnStartDragging, Point startPosition, Point currentPosition) where TPoint : struct
		{
			double horizontalDifference = Math.Abs(startPosition.X - currentPosition.X);
			if (horizontalDifference > 30)
			{
				draggingState.StopDragging();
				return;
			}
			double delta = startPosition.Y - currentPosition.Y;

			DragInternal((TElement)draggedElement, midiPitchOnStartDragging, delta);
		}

		protected abstract void DragInternal(TElement draggedElement, int midiPitchOnStartDragging, double delta);
	}
}