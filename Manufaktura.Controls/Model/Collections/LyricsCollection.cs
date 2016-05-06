using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model.Collections
{
	public class LyricsCollection : IList<Lyrics>, ICollection<Lyrics>, IEnumerable<Lyrics>
	{
		private List<Lyrics> innerList = new List<Lyrics>();
		private Note note;

		public LyricsCollection(Note note)
		{
			this.note = note;
		}

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

		public Lyrics this[int index]
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

		public void Add(Lyrics item)
		{
			innerList.Add(item);
			item.Note = note;
		}

		public void AddRange(IEnumerable<Lyrics> items)
		{
			innerList.AddRange(items);
			foreach (var item in items)
			{
				item.Note = note;
			}
		}

		public void Clear()
		{
			innerList.Clear();
		}

		public bool Contains(Lyrics item)
		{
			return innerList.Contains(item);
		}

		public bool Contains(object value)
		{
			return innerList.Contains(value);
		}

		public void CopyTo(Lyrics[] array, int arrayIndex)
		{
			innerList.CopyTo(array, arrayIndex);
		}

		public IEnumerator<Lyrics> GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public List<Lyrics> GetRange(int index, int count)
		{
			return innerList.GetRange(index, count);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		IEnumerator<Lyrics> IEnumerable<Lyrics>.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public int IndexOf(Lyrics item)
		{
			return innerList.IndexOf(item);
		}

		public void Insert(int index, Lyrics item)
		{
			innerList.Insert(index, item);
			item.Note = note;
		}

		public bool Remove(Lyrics item)
		{
			item.Note = null;
			return innerList.Remove(item);
		}

		public void RemoveAt(int index)
		{
			var Lyrics = innerList.ElementAt(index);
			Lyrics.Note = null;
			innerList.Remove(Lyrics);
		}
	}
}