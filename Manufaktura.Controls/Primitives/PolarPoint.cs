using System;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Point in polar coordinates
    /// </summary>
	public struct PolarPoint
	{
        /// <summary>
        /// Initializes a new instance of PolarPoint structure
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="r"></param>
		public PolarPoint(double angle, double r) : this()
		{
			Angle = angle;
			R = r;
		}

        /// <summary>
        /// Angle
        /// </summary>
		public double Angle { get; set; }

        /// <summary>
        /// Radius
        /// </summary>
		public double R { get; set; }

        /// <summary>
        /// Converts PolarPoint to carthesian coordinates
        /// </summary>
        /// <returns></returns>
		public Point ToCartesian()
		{
			return new Point(R * Math.Sin(Angle), R * Math.Cos(Angle));
		}
	}
}