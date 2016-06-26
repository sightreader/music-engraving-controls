using System;

namespace Manufaktura.Controls.Primitives
{
	public struct PolarPoint
	{
		public PolarPoint(double angle, double r) : this()
		{
			Angle = angle;
			R = r;
		}

		public double Angle { get; set; }
		public double R { get; set; }

		public Point ToCartesian()
		{
			return new Point(R * Math.Sin(Angle), R * Math.Cos(Angle));
		}
	}
}