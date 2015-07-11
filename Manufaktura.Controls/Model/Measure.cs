using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Measure
    {
        public StaffSystem System { get; set; }
        public Staff Staff { get; set; }
        public double FirstNoteInMeasureXPosition { get; set; } //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public Measure(Staff staff, StaffSystem system)
        {
            Staff = staff;
            System = system;
        }
    }
}
