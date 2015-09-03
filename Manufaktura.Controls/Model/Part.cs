using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    public class Part
    {
        public List<Staff> Staves { get; private set; }

        public Part(IEnumerable<Staff> staves)
        {
            Staves = new List<Staff>(staves);
        }

        public Part(Staff staff)
        {
            Staves = new List<Staff> { staff };
        }
    }
}