using Manufaktura.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a beam group
    /// </summary>
    public class BeamGroup : MusicalSymbol
    {
        /// <summary>
        /// Initializes a new instance of BeamGroup for specific Staff
        /// </summary>
        /// <param name="staff"></param>
        public BeamGroup(Staff staff)
        {
            Staff = staff;
        }

        /// <summary>
        /// Beam angle
        /// </summary>
        public double Angle => Point.BeamAngle(Start, End);

        /// <summary>
        /// Beam group end point
        /// </summary>
        public Point End { get; internal set; }

        /// <summary>
        /// First measure containing this BeamGroup
        /// </summary>
        public override Measure Measure
        {
            get
            {
                return Members.FirstOrDefault(m => m.Measure != null)?.Measure;
            }

            internal set
            {
            }
        }

        /// <summary>
        /// Notes and rests under this Beam
        /// </summary>
        public ICollection<NoteOrRest> Members { get; private set; } = new List<NoteOrRest>();

        /// <summary>
        /// Beam group start position
        /// </summary>
        public Point Start { get; internal set; }

        /// <summary>
        /// Returns a string representation of this class for debugging purposes
        /// </summary>
        /// <returns>String representation of this class for debugging purposes</returns>
        public override string ToString()
        {
            return $"Beam group of {Members.Count} members with angle {Angle}.";
        }
    }
}