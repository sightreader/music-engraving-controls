using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Manufaktura.Controls.Model.Collections
{
	/// <summary>
	/// Collection that performs special actions on items on adding and removing.
	/// </summary>
	/// <typeparam name="TItem">Item type</typeparam>
	public abstract class ItemManagingCollection<TItem> : IList<TItem>, ICollection<TItem>, IEnumerable<TItem>, INotifyCollectionChanged
	{
		private List<TItem> innerList = new List<TItem>();

		public event NotifyCollectionChangedEventHandler CollectionChanged;

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

		public TItem this[int index]
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

		public void Add(TItem item)
		{
			innerList.Add(item);
			ManageItemOnAdd(item);
			UnbindEvents(item);
			BindEvents(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
		}

		public void AddRange(IEnumerable<TItem> items)
		{
			innerList.AddRange(items);
			foreach (var item in items)
			{
				ManageItemOnAdd(item);
				UnbindEvents(item);
				BindEvents(item);
			}
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, items.ToList()));
		}

		public void Clear()
		{
			foreach (var i in innerList) UnbindEvents(i);
			innerList.Clear();
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset, null));
		}

		public bool Contains(TItem item)
		{
			return innerList.Contains(item);
		}

		public bool Contains(object value)
		{
			return innerList.Contains((TItem)value);
		}

		public void CopyTo(TItem[] array, int arrayIndex)
		{
			innerList.CopyTo(array, arrayIndex);
		}

		public IEnumerator<TItem> GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public List<TItem> GetRange(int index, int count)
		{
			return innerList.GetRange(index, count);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public int IndexOf(TItem item)
		{
			return innerList.IndexOf(item);
		}

		public void Insert(int index, TItem item)
		{
			innerList.Insert(index, item);
			ManageItemOnAdd(item);
			UnbindEvents(item);
			BindEvents(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
		}

		public bool Remove(TItem item)
		{
			ManageItemOnRemove(item);
			var ret = innerList.Remove(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
			return ret;
		}

		public void RemoveAt(int index)
		{
			var item = innerList.ElementAt(index);
			ManageItemOnRemove(item);
			UnbindEvents(item);
			innerList.Remove(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
		}

		protected abstract void BindEvents(TItem item);

		protected abstract void ManageItemOnAdd(TItem item);

		protected abstract void ManageItemOnRemove(TItem item);

		protected abstract void UnbindEvents(TItem item);
	}
}