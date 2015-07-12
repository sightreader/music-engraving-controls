using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    public class LineDictionary
    {
        private Dictionary<int, Dictionary<int, double[]>> innerDictionary = new Dictionary<int, Dictionary<int, double[]>>();

        public double[] this[int system, int staff]
        {
            get
            {
                if (!innerDictionary.ContainsKey(system)) innerDictionary.Add(system, new Dictionary<int, double[]>());
                if (!innerDictionary[system].ContainsKey(staff)) innerDictionary[system].Add(staff, new double[5]);
                return innerDictionary[system][staff];
            }
            set
            {
                if (!innerDictionary.ContainsKey(system)) innerDictionary.Add(system, new Dictionary<int, double[]>());
                if (!innerDictionary[system].ContainsKey(staff))
                {
                    innerDictionary[system].Add(staff, value);
                    return;
                }
                innerDictionary[system][staff] = value;
            }
        }

        public Dictionary<int, double[]> this[int system]
        {
            get
            {
                return innerDictionary[system];
            }
        }

        public void Clear()
        {
            innerDictionary.Clear();
        }
    }
}