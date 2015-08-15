namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Measure information.
    /// </summary>
    public class Measure
    {
        public Barline Barline { get; set; }

        public double BarlineLocationX { get; set; }

        public double FirstNoteInMeasureXPosition { get; set; }

        public Staff Staff { get; set; }

        public StaffSystem System { get; set; }

        /// <summary>
        /// Width of measure.
        /// </summary>
        public double Width { get; set; }

        //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public Measure(Staff staff, StaffSystem system)
        {
            Staff = staff;
            System = system;
        }
    }
}