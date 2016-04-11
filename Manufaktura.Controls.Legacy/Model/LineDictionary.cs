using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Dictionary that stores vertical location of lines in staves and systems.
    /// </summary>
    public class LineDictionary
    {
        private Dictionary<int, Dictionary<int, double[]>> innerDictionary = new Dictionary<int, Dictionary<int, double[]>>();

        /// <summary>
        /// Gets or sets line positions in specific system and staff
        /// </summary>
        /// <param name="system">System number</param>
        /// <param name="staff">Staff number</param>
        /// <returns>Array of vertical line positions</returns>
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

        /// <summary>
        /// Clears the dictionary.
        /// </summary>
        public void Clear()
        {
            innerDictionary.Clear();
        }
    }
}