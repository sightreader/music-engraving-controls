using Manufaktura.Controls.Model.Exceptions;

namespace Manufaktura.Controls.Model.Collections
{
	/// <summary>
	/// Encapsulates a list of musical symbols. Applies custom rules upon adding new elements.
	/// </summary>
	public class MusicalSymbolCollection : ItemManagingCollection<MusicalSymbol>
	{
		private Staff staff;

		public MusicalSymbolCollection(Staff staff)
		{
			this.staff = staff;
		}

		protected override void BindEvents(MusicalSymbol item)
		{
		}

		protected override ScoreException CreateOutOfBoundsException(int index)
		{
			return new ScoreException(staff, $"Index {index} is out of bounds of staff elements collection.");
		}

		protected override void ManageItemOnAdd(MusicalSymbol item)
		{
			staff.ApplyRules(item);
			item.Staff = staff;
		}

		protected override void ManageItemOnRemove(MusicalSymbol item)
		{
			item.Staff = null;
		}

		protected override void UnbindEvents(MusicalSymbol item)
		{
		}
	}
}