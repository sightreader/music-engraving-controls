using Manufaktura.Controls.Model.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
	public class SystemCollection : IList<StaffSystem>, ICollection<StaffSystem>, IEnumerable<StaffSystem>
	{
		private List<StaffSystem> innerList = new List<StaffSystem>();
		private Score score;

		public SystemCollection(Score score)
		{
			this.score = score;
		}

		public event EventHandler<InvalidateEventArgs<Score>> ScoreInvalidated;

		/// <summary>
		/// Returns the number of elements in list.
		/// </summary>
		public int Count
		{
			get { return innerList.Count; }
		}

		public bool IsFixedSize
		{
			get { return false; }
		}

		public bool IsReadOnly
		{
			get { return false; }
		}

		public StaffSystem this[int index]
		{
			get
			{
				return innerList[index];
			}
			set
			{
				innerList[index] = value;
			}
		}

		public void Add(StaffSystem item)
		{
			innerList.Add(item);
			item.Score = score;
			BindEvents(item);
		}

		public void AddRange(IEnumerable<StaffSystem> items)
		{
			innerList.AddRange(items);
			foreach (var item in items)
			{
				item.Score = score;
				BindEvents(item);
			}
		}

		public void Clear()
		{
			foreach (var i in innerList) UnbindEvents(i);
			innerList.Clear();
		}

		public bool Contains(StaffSystem item)
		{
			return innerList.Contains(item);
		}

		public bool Contains(object value)
		{
			return innerList.Contains(value);
		}

		public void CopyTo(StaffSystem[] array, int arrayIndex)
		{
			innerList.CopyTo(array, arrayIndex);
		}

		public IEnumerator<StaffSystem> GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public List<StaffSystem> GetRange(int index, int count)
		{
			return innerList.GetRange(index, count);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		IEnumerator<StaffSystem> IEnumerable<StaffSystem>.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public int IndexOf(StaffSystem item)
		{
			return innerList.IndexOf(item);
		}

		public void Insert(int index, StaffSystem item)
		{
			innerList.Insert(index, item);
			BindEvents(item);
			item.Score = score;
		}

		public bool Remove(StaffSystem item)
		{
			item.Score = null;
			return innerList.Remove(item);
		}

		public void RemoveAt(int index)
		{
			var staff = innerList.ElementAt(index);
			staff.Score = null;
			UnbindEvents(staff);
			innerList.Remove(staff);
		}

		private void BindEvents(StaffSystem item)
		{
			UnbindEvents(item);
		}

		private void Item_ScoreInvalidated(object sender, Events.InvalidateEventArgs<Score> e)
		{
			ScoreInvalidated?.Invoke(sender, e);
		}

		private void UnbindEvents(StaffSystem item)
		{
		}
	}
}