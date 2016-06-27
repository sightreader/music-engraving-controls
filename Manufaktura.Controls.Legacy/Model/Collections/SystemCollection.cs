using Manufaktura.Controls.Model.Events;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model.Collections
{
	public class SystemCollection : ItemManagingCollection<StaffSystem>
	{
		private List<StaffSystem> innerList = new List<StaffSystem>();
		private ScorePage page;
		private Score score;

		public SystemCollection(ScorePage page)
		{
			this.score = page.Score;
			this.page = page;
		}

		public event EventHandler<InvalidateEventArgs<Score>> ScoreInvalidated;

		protected override void BindEvents(StaffSystem item)
		{
		}

		protected override void ManageItemOnAdd(StaffSystem item)
		{
			item.Score = score;
			item.Page = page;
		}

		protected override void ManageItemOnRemove(StaffSystem item)
		{
			item.Score = null;
			item.Page = null;
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