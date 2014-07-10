using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Score
    {
        public List<Staff> Staves { get; private set; }
        public Score()
        {
            Staves = new List<Staff>();
        }
    }
}
