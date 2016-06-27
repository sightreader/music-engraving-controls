namespace Manufaktura.Controls.Model.Collections
{
	public class LyricsCollection : ItemManagingCollection<Lyrics>
	{
		private Note note;

		public LyricsCollection(Note note)
		{
			this.note = note;
		}

		protected override void BindEvents(Lyrics item)
		{
		}

		protected override void ManageItemOnAdd(Lyrics item)
		{
			item.Note = note;
		}

		protected override void ManageItemOnRemove(Lyrics item)
		{
			item.Note = null;
		}

		protected override void UnbindEvents(Lyrics item)
		{
		}
	}
}