using Manufaktura.Controls.Primitives;
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

        public Staff FirstStaff
        {
            get { return GetStaff(1); }
        }

        public Staff SecondStaff
        {
            get { return GetStaff(2); }
        }

        public Staff ThirdStaff
        {
            get { return GetStaff(3); }
        }

        public Staff FourthStaff
        {
            get { return GetStaff(4); }
        }

        protected Staff GetStaff(int staffNumber)
        {
            if (staffNumber < 1) throw new ArgumentException("Staff number must be greater than 0.", "staffNumber");
            if (Staves.Count < staffNumber) throw new IndexOutOfRangeException(string.Format("There is no {0} staff in the score.", UsefulMath.NumberToOrdinal(staffNumber)));
            return Staves[staffNumber - 1];
        }

        public static Score CreateOneStaffScore()
        {
            var score = new Score();
            score.Staves.Add(new Staff());
            return score;
        }
    }
}
