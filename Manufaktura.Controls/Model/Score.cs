using Manufaktura.Controls.Model.Events;
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
		/// Initializes a new empty score.
		/// </summary>
		public Score()
		{
			Staves = new StaffCollection(this);
			Staves.StaffInvalidated += HandleStaves_StaffInvalidated;
			Staves.MeasureInvalidated += HandleStaves_MeasureInvalidated;
			Parts = new List<Part>();
			Systems = new List<StaffSystem>();
			Pages = new List<ScorePage>();
			Pages.Add(new ScorePage());
			DefaultPageSettings = new ScorePage();
		}

		public event EventHandler<InvalidateEventArgs<Measure>> MeasureInvalidated;

		public event EventHandler<InvalidateEventArgs<ScorePage>> PageInvalidated;

		public event EventHandler<InvalidateEventArgs<Staff>> StaffInvalidated;

		public ScorePage DefaultPageSettings { get; private set; }

		/// <summary>
		/// Provides fast access to a staff. You can also get staff by selecting it from Staves list.
		/// </summary>
		public Staff EighthStaff
		{
			get { return GetStaff(8); }
		}

		public ScoreEncoding Encoding { get; internal set; }

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

		public List<ScorePage> Pages { get; private set; }

		public List<PartGroup> PartGroups { get; private set; } = new List<PartGroup>();
		public List<Part> Parts { get; private set; }

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

		public StaffCollection Staves { get; private set; }

		public List<StaffSystem> Systems { get; private set; }

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

		/// <summary>
		/// Creates a new score with the same number of staves. Every element of every staff is the same object as in the source score.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Test. Do not use.")]
		public Score CreateEntangledScore()
		{
			var entangledScore = new Score();
			foreach (var system in Systems)
			{
				var entangledSystem = new StaffSystem(entangledScore);
				entangledScore.Systems.Add(entangledSystem);
			}
			foreach (var page in Pages)
			{
				var entangledPage = new ScorePage();
				entangledScore.Pages.Add(entangledPage);
			}
			foreach (var staff in Staves)
			{
				var entangledStaff = new Staff();
				foreach (var element in staff.Elements) entangledStaff.Elements.Add(element);
				entangledScore.Staves.Add(entangledStaff);
			}
			return entangledScore;
		}

		private Staff GetStaff(int staffNumber)
		{
			if (staffNumber < 1) throw new ArgumentException("Staff number must be greater than 0.", "staffNumber");
			if (Staves.Count < staffNumber) return null;
			return Staves[staffNumber - 1];
		}

		private void HandleStaves_MeasureInvalidated(object sender, InvalidateEventArgs<Measure> e)
		{
			MeasureInvalidated?.Invoke(sender, e);
		}

		private void HandleStaves_StaffInvalidated(object sender, InvalidateEventArgs<Staff> e)
		{
			StaffInvalidated?.Invoke(sender, e);
		}
	}
}