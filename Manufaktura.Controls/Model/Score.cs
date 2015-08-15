using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a score.
    /// </summary>
    public class Score
    {
        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff EighthStaff
        {
            get { return GetStaff(8); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff FifthStaff
        {
            get { return GetStaff(5); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff FirstStaff
        {
            get { return GetStaff(1); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff FourthStaff
        {
            get { return GetStaff(4); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff NinthStaff
        {
            get { return GetStaff(9); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff SecondStaff
        {
            get { return GetStaff(2); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff SeventhStaff
        {
            get { return GetStaff(7); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff SixthStaff
        {
            get { return GetStaff(6); }
        }

        public List<Staff> Staves { get; private set; }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff TenthStaff
        {
            get { return GetStaff(10); }
        }

        /// <summary>
        /// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
        /// </summary>
        public Staff ThirdStaff
        {
            get { return GetStaff(3); }
        }

        /// <summary>
        /// Initializes a new empty score.
        /// </summary>
        public Score()
        {
            Staves = new List<Staff>();
        }

        /// <summary>
        /// Creates a score with just one staff (other staves can be added later).
        /// </summary>
        /// <returns>A new score</returns>
        public static Score CreateOneStaffScore()
        {
            var score = new Score();
            score.Staves.Add(new Staff());
            return score;
        }

        /// <summary>
        /// Creates a score with just one staff (other staves can be added later).
        /// </summary>
        /// <returns>A new score</returns>
        public static Score CreateOneStaffScore(Clef clef, Step tonic, MajorAndMinorScaleFlags flags)
        {
            var score = CreateOneStaffScore();
            score.FirstStaff.Elements.Add(clef);
            score.FirstStaff.Elements.Add(Key.FromTonic(tonic, flags));
            return score;
        }

        /// <summary>
        /// Creates a score with just one staff (other staves can be added later) in specific clef and key signature determined by scale.
        /// </summary>
        /// <param name="clef">Clef</param>
        /// <param name="scale">Scale</param>
        /// <returns>A new score</returns>
        public static Score CreateOneStaffScore(Clef clef, MajorOrMinorScale scale)
        {
            var score = CreateOneStaffScore();
            score.FirstStaff.Elements.Add(clef);
            score.FirstStaff.Elements.Add(Key.FromScale(scale));
            return score;
        }

        /// <summary>
        /// Adds a new staff to the score.
        /// </summary>
        /// <param name="clef">Clef</param>
        /// <param name="timeSignature">Time signature</param>
        /// <param name="tonic">Tonic of key</param>
        /// <param name="flags">Scale flags</param>
        /// <returns>This score</returns>
        public Score AddStaff(Clef clef, TimeSignature timeSignature, Step tonic, MajorAndMinorScaleFlags flags)
        {
            var staff = new Staff();
            staff.Elements.Add(clef);
            staff.Elements.Add(Key.FromTonic(tonic, flags));
            Staves.Add(staff);
            return this;
        }

        private Staff GetStaff(int staffNumber)
        {
            if (staffNumber < 1) throw new ArgumentException("Staff number must be greater than 0.", "staffNumber");
            if (Staves.Count < staffNumber) throw new IndexOutOfRangeException(string.Format("There is no {0} staff in the score.", UsefulMath.NumberToOrdinal(staffNumber)));
            return Staves[staffNumber - 1];
        }
    }
}