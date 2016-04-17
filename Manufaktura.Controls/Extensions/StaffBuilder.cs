using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Controls.Extensions
{
	public static class StaffBuilder
	{
		public static IEnumerable<Note> AddDots(this IEnumerable<Note> notes, params int[] dots)
		{
			if (dots.Count() != dots.Length) throw new Exception("Dots must have the same count as notes.");
			int i = 0;
			foreach (var n in notes)
			{
				n.NumberOfDots = dots[i];
				i++;
			}
			return notes;
		}

		public static IEnumerable<Note> AddRhythm(this IEnumerable<Pitch> pitches, params int[] durations)
		{
			if (pitches.Count() != durations.Length) throw new Exception("Durations must have the same count as pitches.");
			var units = new Queue<RhythmicUnit>(RhythmicUnit.Parse(durations));
			return pitches.Select(p => new Note(p, units.Dequeue().Duration)).ToArray();
		}

		public static IEnumerable<Note> ApplyStemDirection(this IEnumerable<Note> notes, VerticalDirection direction)
		{
			foreach (var n in notes)
			{
				n.StemDirection = direction;
				n.SubjectToNoteStemRule = false;
			}
			return notes;
		}

		public static IEnumerable<Pitch> FromPitches(params Pitch[] pitches)
		{
			return pitches;
		}

		public static IEnumerable<NoteOrRest> Rebeam(this IEnumerable<NoteOrRest> notes, RebeamMode mode = RebeamMode.Simple)
		{
			var strategies = typeof(IRebeamStrategy).GetTypeInfo().Assembly.DefinedTypes
				.Where(t => !t.IsAbstract && typeof(IRebeamStrategy).GetTypeInfo().IsAssignableFrom(t))
				.Select(t => Expression.Lambda(Expression.New(t.AsType())).Compile().DynamicInvoke())
				.Cast<IRebeamStrategy>()
				.ToArray();
			var matchingStrategy = strategies.FirstOrDefault(s => s.Mode == mode);
			if (matchingStrategy == null) throw new Exception($"Rebeam strategy not found for rebeam mode {mode}.");
			return matchingStrategy.Rebeam(notes);
		}
	}
}