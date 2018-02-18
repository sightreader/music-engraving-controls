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

        /// <summary>
        /// Rhythmic duration of 128th note or rest.
        /// </summary>
		public static RhythmicDuration D128th { get { return new RhythmicDuration(128); } }

        /// <summary>
        /// Rhythmic duration of 256th note or rest.
        /// </summary>
        public static RhythmicDuration D256th { get { return new RhythmicDuration(256); } }

        /// <summary>
        /// Rhythmic duration of 32nd note or rest.
        /// </summary>
        public static RhythmicDuration D32nd { get { return new RhythmicDuration(32); } }

        /// <summary>
        /// Rhythmic duration of 64th note or rest.
        /// </summary>
        public static RhythmicDuration D64th { get { return new RhythmicDuration(64); } }

        /// <summary>
        /// Rhythmic duration of eighth note or rest.
        /// </summary>
        public static RhythmicDuration Eighth { get { return new RhythmicDuration(8); } }

        /// <summary>
        /// Rhythmic duration of half note or rest.
        /// </summary>
        public static RhythmicDuration Half { get { return new RhythmicDuration(2); } }

        /// <summary>
        /// Rhythmic duration of quarter note or rest.
        /// </summary>
        public static RhythmicDuration Quarter { get { return new RhythmicDuration(4); } }

        /// <summary>
        /// Rhythmic duration of sixteenth note or rest.
        /// </summary>
        public static RhythmicDuration Sixteenth { get { return new RhythmicDuration(16); } }

        /// <summary>
        /// Rhythmic duration of whole note or rest.
        /// </summary>
        public static RhythmicDuration Whole { get { return new RhythmicDuration(1); } }

        /// <summary>
        /// Rhythmic duration denominator, i.e. 1 for whole, 2 for half, 8 for eighth, 16 for sixteenth, etc.
        /// </summary>
        public int Denominator { get; private set; }

        /// <summary>
        /// Number of dots
        /// </summary>
		public int Dots { get; set; }

        /// <summary>
        /// Returns a clone of this RhythmicDuration object but without dots
        /// </summary>
		public RhythmicDuration WithoutDots
		{
			get
			{
				return new RhythmicDuration(Denominator);
			}
		}

        /// <summary>
        /// Subtracts two rhythmic durations
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static Proportion operator -(RhythmicDuration d1, RhythmicDuration d2)
		{
			var sum = d1.ToProportion() - d2.ToProportion();
			return sum.Normalize();
		}

        /// <summary>
        /// Returns true if two RhythmicDurations are different
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static bool operator !=(RhythmicDuration d1, RhythmicDuration d2)
		{
			return d1.Denominator != d2.Denominator || d1.Dots != d2.Dots;
		}


        /// <summary>
        /// Adds two RhythmicDurations
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static Proportion operator +(RhythmicDuration d1, RhythmicDuration d2)
		{
			var sum = d1.ToProportion() + d2.ToProportion();
			return sum.Normalize();
		}

        /// <summary>
        /// Returns true if first RhythmicDuration is less than the second RhythmicDuration
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static bool operator <(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots > d2.Dots;
			return d1.Denominator > d2.Denominator;
		}

        /// <summary>
        /// Returns true if first RhythmicDuration is less than or equal to the second RhythmicDuration
        /// </summary>
        public static bool operator <=(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots >= d2.Dots;
			return d1.Denominator > d2.Denominator;
		}

        /// <summary>
        /// Returns true if first RhythmicDuration is equal to the second RhythmicDuration
        /// </summary>
        public static bool operator ==(RhythmicDuration d1, RhythmicDuration d2)
		{
			return d1.Denominator == d2.Denominator && d1.Dots == d2.Dots;
		}

        /// <summary>
        /// Returns true if first RhythmicDuration is greater than the second RhythmicDuration
        /// </summary>
        public static bool operator >(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots < d2.Dots;
			return d1.Denominator < d2.Denominator;
		}

        /// <summary>
        /// Returns true if first RhythmicDuration is greater than or equal to the second RhythmicDuration
        /// </summary>
        public static bool operator >=(RhythmicDuration d1, RhythmicDuration d2)
		{
			if (d1.Denominator == d2.Denominator) return d1.Dots <= d2.Dots;
			return d1.Denominator < d2.Denominator;
		}

        /// <summary>
        /// Parses RhythmicDuration from a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns a RhythmicDuration with a specific number of dots added
        /// </summary>
        /// <param name="dots"></param>
        /// <returns></returns>
		public RhythmicDuration AddDots(int dots)
		{
			return new RhythmicDuration(Denominator, dots);
		}

#if !CSHTML5

        /// <summary>
        /// Returns a fraction representing this RhythmicDuration as decimal value
        /// </summary>
        /// <returns></returns>
        public decimal ToDecimal()
		{
			return ToProportion().DecimalValue;
		}

#endif

        /// <summary>
        /// Returns a fraction representing this RhythmicDuration as double value
        /// </summary>
        public double ToDouble()
		{
			return ToProportion().DoubleValue;
		}

        /// <summary>
        /// Returns a proportion of this RhythmicDuration to the second RhythmicDuration. Dots are not taken into account.
        /// For example if this RhythmicDuration is half note duration and the second duration is quarter note duration, the proportion of 4:2 will be returned.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
		public Proportion ToFractionOf(RhythmicDuration duration)
		{
			return new Proportion(duration.Denominator, Denominator);
		}

        /// <summary>
        /// Converts this RhythmicDuration to fraction and returns it as Proportion structure. Dots are taken into account.
        /// </summary>
        /// <returns></returns>
		public Proportion ToProportion()
		{
			var prop = new Proportion(1, Denominator);
			for (int i=0; i< Dots; i++)
			{
				prop += new Proportion(1, Denominator * (int)Math.Pow(2, i + 1));
			}
			return prop;
		}

        /// <summary>
        /// Converts this RhythmicDuration to RhythmicUnit.
        /// </summary>
        /// <param name="isRest"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts this RhythmicDuration to TimeSpan for a specific Tempo. 
        /// I.e. returns the real duration of this RhythmicDuration in time units for a specific Tempo.
        /// </summary>
        /// <param name="tempo"></param>
        /// <returns></returns>
		public TimeSpan ToTimeSpan(Tempo tempo)
		{
			var proportion = ToFractionOf(tempo.BeatUnit);
			return TimeSpan.FromMilliseconds(tempo.BeatTimeSpan.TotalMilliseconds * proportion.DoubleValue);
		}
	}
}