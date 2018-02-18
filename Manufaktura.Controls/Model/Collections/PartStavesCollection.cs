using Manufaktura.Controls.Model.Exceptions;

namespace Manufaktura.Controls.Model.Collections
{
    /// <summary>
    /// Collection of staves in a Part
    /// </summary>
	public class PartStavesCollection : ItemManagingCollection<Staff>
	{
		private readonly Part part;

		public PartStavesCollection(Part part)
		{
			this.part = part;
		}

		protected override void BindEvents(Staff item)
		{
		}

		protected override ScoreException CreateOutOfBoundsException(int index)
		{
			return new ScoreException(part, $"Index {index} is out of bounds of part's staves collection.");
		}

		protected override void ManageItemOnAdd(Staff item)
		{
			item.Part = part;
		}

		protected override void ManageItemOnRemove(Staff item)
		{
			item.Part = null;
		}

		protected override void UnbindEvents(Staff item)
		{
		}
	}
}