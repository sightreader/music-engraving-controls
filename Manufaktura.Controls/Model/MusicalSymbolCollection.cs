using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    public class MusicalSymbolCollection : IList<MusicalSymbol>, ICollection<MusicalSymbol>, IEnumerable<MusicalSymbol>
    {
        private List<MusicalSymbol> innerList = new List<MusicalSymbol>();
        private Staff staff;

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

        public MusicalSymbolCollection(Staff staff)
        {
            this.staff = staff;
        }

        public MusicalSymbol this[int index]
        {
            get
            {
                return innerList[index];
            }
            set
            {
                innerList[index] = value;
                staff.ApplyRules(value);
            }
        }

        public void Add(MusicalSymbol item)
        {
            innerList.Add(item);
            staff.ApplyRules(item);
        }

        public void AddRange(IEnumerable<MusicalSymbol> items)
        {
            innerList.AddRange(items);
            foreach (var item in items) staff.ApplyRules(item);
        }

        public void Clear()
        {
            innerList.Clear();
        }

        public bool Contains(MusicalSymbol item)
        {
            return innerList.Contains(item);
        }

        public bool Contains(object value)
        {
            return innerList.Contains(value);
        }

        public void CopyTo(MusicalSymbol[] array, int arrayIndex)
        {
            innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MusicalSymbol> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        public List<MusicalSymbol> GetRange(int index, int count)
        {
            return innerList.GetRange(index, count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        public int IndexOf(MusicalSymbol item)
        {
            return innerList.IndexOf(item);
        }

        public void Insert(int index, MusicalSymbol item)
        {
            innerList.Insert(index, item);
            staff.ApplyRules(item);
        }

        public bool Remove(MusicalSymbol item)
        {
            return innerList.Remove(item);
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }
    }
}