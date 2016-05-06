using Manufaktura.Controls.Model.Events;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model.Collections
{
	public class SystemCollection : ItemManagingCollection<StaffSystem>
	{
		private List<StaffSystem> innerList = new List<StaffSystem>();
		private Score score;

		public SystemCollection(Score score)
		{
			this.score = score;
		}

		public event EventHandler<InvalidateEventArgs<Score>> ScoreInvalidated;

		protected override void BindEvents(StaffSystem item)
		{
		}

		protected override void ManageItemOnAdd(StaffSystem item)
		{
			item.Score = score;
		}

		protected override void ManageItemOnRemove(StaffSystem item)
		{
			item.Score = null;
		}

		protected override void UnbindEvents(StaffSystem item)
		{
		}

		private void Item_ScoreInvalidated(object sender, Events.InvalidateEventArgs<Score> e)
		{
			ScoreInvalidated?.Invoke(sender, e);
		}
	}
}