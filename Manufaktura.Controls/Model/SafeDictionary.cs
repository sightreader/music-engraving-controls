using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    public class LineDictionary
    {
        private Dictionary<int, Dictionary<int, double[]>> innerDictionary = new Dictionary<int, Dictionary<int, double[]>>();

        public LineDictionary()
        {
            innerDictionary.Add(1, new Dictionary<int, double[]> { { 1, new double[5] } });
        }
        public int Count
        {
            get { return innerDictionary.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public IDictionary<int, double[]> this[int key]
        {
            get
            {
                if (!innerDictionary.ContainsKey(key)) innerDictionary.Add(key, new Dictionary<int, double[]>());
                return innerDictionary[key];
            }
        }

        
    }
}