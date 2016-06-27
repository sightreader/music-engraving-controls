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

		public static IEnumerable<NoteOrRest> AddLyrics(this IEnumerable<NoteOrRest> notes, string text)
		{
			var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var noteQueue = new Queue<NoteOrRest>(notes);
			var syllableQueue = new Queue<Lyrics.Syllable>();
			foreach (var word in words)
			{
				var syllables = word.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (var syllable in syllables)
				{
					var syllableType = SyllableType.Middle;
					if (syllables.Length == 1) syllableType = SyllableType.Single;
					else if (syllable == syllables.Last()) syllableType = SyllableType.End;
					else if (syllable == syllables.First()) syllableType = SyllableType.Begin;

					syllableQueue.Enqueue(new Lyrics.Syllable { Text = syllable, Type = syllableType });
				}
			}

			while (noteQueue.Count > 0 && syllableQueue.Count > 0)
			{
				var note = noteQueue.Dequeue() as Note;
				if (note == null) continue;
				var syllable = syllableQueue.Dequeue();

				note.Lyrics.Clear();
				note.Lyrics.Add(new Lyrics(syllable.Type, syllable.Text));
			}

			return notes;
		}

		public static IEnumerable<Note> AddPitches(this IEnumerable<RhythmicDuration> durations, params Pitch[] pitches)
		{
			if (pitches.Length != durations.Count()) throw new Exception("Durations must have the same count as pitches.");
			var i = 0;
			return durations.Select(d => new Note(pitches[i++], d)).ToArray();
		}

		public static IEnumerable<Note> AddRhythm(this IEnumerable<Pitch> pitches, params int[] durations)
		{
			if (pitches.Count() != durations.Length) throw new Exception("Durations must have the same count as pitches.");
			var units = new Queue<RhythmicUnit>(RhythmicUnit.Parse(durations));
			return pitches.Select(p => new Note(p, units.Dequeue().Duration)).ToArray();
		}

		public static IEnumerable<Note> AddRhythm(this IEnumerable<Pitch> pitches, string durations)
		{
			var units = new Queue<RhythmicUnit>(RhythmicUnit.Parse(durations, " "));
			if (pitches.Count() != units.Count) throw new Exception("Durations must have the same count as pitches.");
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

		public static IEnumerable<RhythmicDuration> FromRhythm(params RhythmicDuration[] durations)
		{
			return durations;
		}

		public static IEnumerable<RhythmicDuration> FromRhythm(params int[] durations)
		{
			return RhythmicDuration.Parse(durations);
		}

		public static IEnumerable<RhythmicDuration> FromRhythm(string durations)
		{
			return RhythmicDuration.Parse(durations, " ");
		}

		public static IEnumerable<NoteOrRest> Rebeam(this IEnumerable<NoteOrRest> notes, RebeamMode mode = RebeamMode.Simple, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate)
		{
			var strategies = typeof(IRebeamStrategy).GetTypeInfo().Assembly.DefinedTypes
				.Where(t => !t.IsAbstract && typeof(IRebeamStrategy).GetTypeInfo().IsAssignableFrom(t))
				.Select(t => Expression.Lambda(Expression.New(t.AsType())).Compile().DynamicInvoke())
				.Cast<IRebeamStrategy>()
				.ToArray();
			var matchingStrategy = strategies.FirstOrDefault(s => s.Mode == mode);
			if (matchingStrategy == null) throw new Exception($"Rebeam strategy not found for rebeam mode {mode}.");
            foreach (var n in notes.OfType<Note>()) n.ModeUsedForRebeaming = mode; 
			return matchingStrategy.Rebeam(notes, hookDirectionAlgorithm);
		}

		public static IEnumerable<NoteOrRest>[] SplitByBeats(this IEnumerable<NoteOrRest> notes, TimeSignature timeSignature)
		{
			var groups = new List<List<NoteOrRest>>();
			var queue = new Queue<NoteOrRest>(notes);

			while (queue.Count > 0)
			{
				var sum = 0d;
				var currentGroup = new List<NoteOrRest>();
				while (sum == 0 || sum - Math.Floor(sum) != 0)
				{
					if (queue.Count == 0) break;
					var currentNote = queue.Dequeue();
					currentGroup.Add(currentNote);
					sum += ((1d + Enumerable.Range(1, currentNote.NumberOfDots).Sum(r => Math.Pow(0.5d, r))) / currentNote.BaseDuration.Denominator) * timeSignature.TypeOfBeats;
				}
				groups.Add(currentGroup);
			}
			return groups.ToArray();
		}

		public static IEnumerable<NoteOrRest>[] SplitByLyrics(this IEnumerable<NoteOrRest> notes)
		{
			var groups = new List<List<NoteOrRest>>();
			var queue = new Queue<NoteOrRest>(notes);

			var currentGroup = new List<NoteOrRest>();
			while (queue.Count > 0)
			{
				var currentNote = queue.Dequeue() as Note;
				currentGroup.Add(currentNote);
				if (currentNote == null) continue;

				if (currentNote.Lyrics.Any(l => l.Syllables.Any(s => s.Type == SyllableType.End || s.Type == SyllableType.Single)))
				{
					groups.Add(currentGroup);
					currentGroup = new List<NoteOrRest>();
				}
			}
			return groups.ToArray();
		}
	}
}