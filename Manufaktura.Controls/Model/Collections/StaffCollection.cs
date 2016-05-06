using Manufaktura.Controls.Model.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
	public class StaffCollection : IList<Staff>, ICollection<Staff>, IEnumerable<Staff>
	{
		private List<Staff> innerList = new List<Staff>();
		private Score score;

		public StaffCollection(Score score)
		{
			this.score = score;
		}

		public event EventHandler<InvalidateEventArgs<Measure>> MeasureInvalidated;

		public event EventHandler<InvalidateEventArgs<Staff>> StaffInvalidated;

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

		public Staff this[int index]
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

		public void Add(Staff item)
		{
			innerList.Add(item);
			item.Score = score;
			BindEvents(item);
		}

		public void AddRange(IEnumerable<Staff> items)
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

		public bool Contains(Staff item)
		{
			return innerList.Contains(item);
		}

		public bool Contains(object value)
		{
			return innerList.Contains(value);
		}

		public void CopyTo(Staff[] array, int arrayIndex)
		{
			innerList.CopyTo(array, arrayIndex);
		}

		public IEnumerator<Staff> GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public List<Staff> GetRange(int index, int count)
		{
			return innerList.GetRange(index, count);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		IEnumerator<Staff> IEnumerable<Staff>.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public int IndexOf(Staff item)
		{
			return innerList.IndexOf(item);
		}

		public void Insert(int index, Staff item)
		{
			innerList.Insert(index, item);
			BindEvents(item);
			item.Score = score;
		}

		public bool Remove(Staff item)
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

		private void BindEvents(Staff item)
		{
			UnbindEvents(item);
			item.StaffInvalidated += HandleItem_StaffInvalidated;
			item.MeasureInvalidated += HandleItem_MeasureInvalidated;
		}

		private void HandleItem_MeasureInvalidated(object sender, InvalidateEventArgs<Measure> e)
		{
			MeasureInvalidated?.Invoke(sender, e);
		}

		private void HandleItem_StaffInvalidated(object sender, Events.InvalidateEventArgs<Staff> e)
		{
			StaffInvalidated?.Invoke(sender, e);
		}

		private void UnbindEvents(Staff item)
		{
			item.StaffInvalidated -= HandleItem_StaffInvalidated;
			item.MeasureInvalidated -= HandleItem_MeasureInvalidated;
		}
	}
}