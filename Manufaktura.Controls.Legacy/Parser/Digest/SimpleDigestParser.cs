using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
	public class SimpleDigestParser : ScoreParser<string>
	{
		public override Model.Score Parse(string source)
		{
			var score = Score.CreateOneStaffScore(Clef.Treble, MajorScale.C);
			var splitted = source.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var element in splitted)
			{
				if (element.Contains("_"))
				{
					var pitchAndDuration = element.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
					var midiPitch = int.Parse(pitchAndDuration[1]);
					var denominator = int.Parse(pitchAndDuration[0].Replace(".", ""));
					var numberOfNotes = pitchAndDuration[0].ToCharArray().Where(c => c == '.').Count();
					var note = Note.FromMidiPitch(midiPitch, new RhythmicDuration(denominator, numberOfNotes));
					score.FirstStaff.Elements.Add(note);
				}
				else if (element == "|")
				{
					score.FirstStaff.Elements.Add(new Barline());
				}
				else
				{
					var denominator = int.Parse(element.Replace(".", ""));
					var numberOfNotes = element.ToCharArray().Where(c => c == '.').Count();
					var rest = new Rest(new RhythmicDuration(denominator, numberOfNotes));
					score.FirstStaff.Elements.Add(rest);
				}
			}
			return score;
		}

		public override string ParseBack(Score score)
		{
			var strings = new List<string>();
			foreach (var element in score.FirstStaff.Elements)
			{
				var noteOrRest = element as NoteOrRest;
				if (noteOrRest != null)
				{
					var sb = new StringBuilder();
					sb.Append(noteOrRest.Duration.Denominator);
					for (var i = 0; i < noteOrRest.Duration.Dots; i++) sb.Append(".");
					var note = element as Note;
					if (note != null)
					{
						sb.Append("_");
						sb.Append(note.MidiPitch);
					}
					strings.Add(sb.ToString());
				}
				
				var barline = element as Barline;
				if (barline != null) strings.Add("|");
			}
			return string.Join(" ", strings);
		}
	}
}