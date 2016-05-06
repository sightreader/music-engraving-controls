﻿using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System.Diagnostics;

namespace Manufaktura.Controls.Interactivity
{
	public class DirectionDraggingStrategy : DraggingStrategy<Direction>
	{
		protected override void DragInternal(ScoreRendererBase renderer, Direction draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			draggedElement.SuppressEvents = true;
			draggedElement.Placement = DirectionPlacementType.Custom;
			draggedElement.SuppressEvents = false;
			draggedElement.DefaultYPosition -= renderer.PixelsToTenths(smallDelta);
		}
	}
}