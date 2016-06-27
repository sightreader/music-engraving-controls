using Manufaktura.Controls.Model.Events;
using Manufaktura.Controls.Model.Exceptions;
using System;

namespace Manufaktura.Controls.Model.Collections
{
	public class StaffCollection : ItemManagingCollection<Staff>
	{
		private Score score;

		public StaffCollection(Score score)
		{
			this.score = score;
		}

		public event EventHandler<InvalidateEventArgs<Measure>> MeasureInvalidated;

		public event EventHandler<InvalidateEventArgs<Staff>> StaffInvalidated;

		protected override void BindEvents(Staff item)
		{
			item.StaffInvalidated += HandleItem_StaffInvalidated;
			item.MeasureInvalidated += HandleItem_MeasureInvalidated;
		}

		protected override ScoreException CreateOutOfBoundsException(int index)
		{
			return new ScoreException(score, $"Index {index} is out of bounds of score's staves collection.");
		}

		protected override void ManageItemOnAdd(Staff item)
		{
			item.Score = score;
		}

		protected override void ManageItemOnRemove(Staff item)
		{
			item.Score = null;
		}

		protected override void UnbindEvents(Staff item)
		{
			item.StaffInvalidated -= HandleItem_StaffInvalidated;
			item.MeasureInvalidated -= HandleItem_MeasureInvalidated;
		}

		private void HandleItem_MeasureInvalidated(object sender, InvalidateEventArgs<Measure> e)
		{
			MeasureInvalidated?.Invoke(sender, e);
		}

		private void HandleItem_StaffInvalidated(object sender, Events.InvalidateEventArgs<Staff> e)
		{
			StaffInvalidated?.Invoke(sender, e);
		}
	}
}