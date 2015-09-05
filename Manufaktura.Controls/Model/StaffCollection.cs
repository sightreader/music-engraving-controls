using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    public class StaffCollection : IList<Staff>, ICollection<Staff>, IEnumerable<Staff>
    {
        private List<Staff> innerList = new List<Staff>();
        private Score score;

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

        public StaffCollection(Score score)
        {
            this.score = score;
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
        }

        public void AddRange(IEnumerable<Staff> items)
        {
            innerList.AddRange(items);
            foreach (var item in items) item.Score = score;
        }

        public void Clear()
        {
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
            innerList.Remove(staff);
        }
    }
}