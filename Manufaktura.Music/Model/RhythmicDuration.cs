using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
	/// <summary>
	/// Represents a rhythmic duration.
	/// </summary>
	public struct RhythmicDuration
	{
		public RhythmicDuration(int denominator, int dots)
			: this()
		{
			Denominator = denominator;
			Dots = dots;
		}

		public RhythmicDuration(int denominator)
			: this(denominator, 0)
		{
		}

		public static RhythmicDuration D128th { get { return new RhythmicDuration(128); } }

		public static RhythmicDuration D256th { get { return new RhythmicDuration(256); } }

		public static RhythmicDuration D32nd { get { return new RhythmicDuration(32); } }

		public static RhythmicDuration D64th { get { return new RhythmicDuration(64); } }

		public static RhythmicDuration Eighth { get { return new RhythmicDuration(8); } }

		public static RhythmicDuration Half { get { return new RhythmicDuration(2); } }

		public static RhythmicDuration Quarter { get { return new RhythmicDuration(4); } }

		public static RhythmicDuration Sixteenth { get { return new RhythmicDuration(16); } }

		public static RhythmicDuration Whole { get { return new RhythmicDuration(1); } }

		public int Denominator { get; private set; }

		public int Dots { get; set; }

		public RhythmicDuration WithoutDots
		{
			get
			{
				return new RhythmicDuration(Denominator);
			}
		}

		public static RhythmicDuration operator -(RhythmicDuration d1, RhythmicDuration d2)
		{
			var sum = d1.ToProportion() - d2.ToProportion();
			sum = sum.Normalize();
			return new RhythmicDuration(sum.Denominator);
		}

		public static bool operator !=(RhythmicDuration d1, RhythmicDuration d2)
		{
			return d1.Denominator != d2.Denominator || d1.Dots != d2.Dots;
		}

		public static RhythmicDuration operator +(RhythmicDuration d1, RhythmicDuration d2)
		{
			var sum = d1.ToProportion() + d2.ToProportion();
			sum = sum.Normalize();
			return new RhythmicDuration(sum.Denominator);
		}

		public static bool operator <(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots > d2.Dots;
			return d1.Denominator > d2.Denominator;
		}

		public static bool operator <=(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots >= d2.Dots;
			return d1.Denominator > d2.Denominator;
		}

		public static bool operator ==(RhythmicDuration d1, RhythmicDuration d2)
		{
			return d1.Denominator == d2.Denominator && d1.Dots == d2.Dots;
		}

		public static bool operator >(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots < d2.Dots;
			return d1.Denominator < d2.Denominator;
		}

		public static bool operator >=(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots <= d2.Dots;
			return d1.Denominator < d2.Denominator;
		}

		public static RhythmicDuration Parse(string s)
		{
			var numberOfDots = s.ToCharArray().Count(c => c == '.');
			int denominator;
			if (!int.TryParse(s.Replace(".", ""), out denominator)) throw new Exception("Could not parse string. Unrecognized duration.");
			return new RhythmicDuration(denominator, numberOfDots);
		}

		public static IEnumerable<RhythmicDuration> Parse(string s, string separator)
		{
			var result = new List<RhythmicDuration>();
			foreach (var substring in s.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
			{
				result.Add(Parse(substring));
			}
			return result;
		}

		public static IEnumerable<RhythmicDuration> Parse(params int[] durations)
		{
			return durations.Select(i => new RhythmicDuration(i)).ToArray();
		}

		public static bool TryParse(string s, out RhythmicDuration duration)
		{
			int val;
			if (!int.TryParse(s, out val))
			{
				duration = default(RhythmicDuration);
				return false;
			}
			duration = new RhythmicDuration(val);
			return true;
		}

		public RhythmicDuration AddDots(int dots)
		{
			return new RhythmicDuration(Denominator, dots);
		}

		public decimal ToDecimal()
		{
			return ToProportion().DecimalValue;
		}

		public double ToDouble()
		{
			return ToProportion().DoubleValue;
		}

		public Proportion ToFractionOf(RhythmicDuration duration)
		{
			return new Proportion(duration.Denominator, Denominator);
		}

		public Proportion ToProportion()
		{
			return new Proportion(1, Denominator) + (Dots > 0 ? new Proportion(1, Denominator * (int)Math.Pow(2, Dots)) : new Proportion(0, 1));
		}

		public RhythmicUnit ToRhythmicUnit(bool isRest)
		{
			return new RhythmicUnit(this, isRest);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			for (var i = 0; i < Dots; i++) sb.Append(".");
			return string.Format("{0}{1}", Denominator, sb);
		}

		public TimeSpan ToTimeSpan(Tempo tempo)
		{
			var proportion = ToFractionOf(tempo.BeatUnit);
			return TimeSpan.FromMilliseconds(tempo.BeatTimeSpan.TotalMilliseconds * proportion.DoubleValue);
		}
	}
}