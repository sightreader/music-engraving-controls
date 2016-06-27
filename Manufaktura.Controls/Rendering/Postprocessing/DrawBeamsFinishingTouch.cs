using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Exceptions;
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
	public class DrawBeamsFinishingTouch : IFinishingTouch
	{
		public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
		{
			var beamGroupsForThisMeasure = measure.Staff.BeamGroups.Where(bg => bg.Members.Any(m => m.Measure == measure));
			foreach (var beamGroup in beamGroupsForThisMeasure)
			{
				beamGroup.Start = beamGroup.Members.OfType<Note>().First().StemEndLocation;
				beamGroup.End = beamGroup.Members.OfType<Note>().Last().StemEndLocation;
			}
			PerformOnBeamGroups(beamGroupsForThisMeasure, renderer);
		}

		public void PerformOnScore(Score score, ScoreRendererBase renderer)
		{
		}

		public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
		{
			DiscoverBeamGroups(staff, renderer);
			PerformOnBeamGroups(staff.BeamGroups, renderer);
		}

		private void DiscoverBeamGroups(Staff staff, ScoreRendererBase renderer)
		{
			staff.BeamGroups.Clear();
			BeamGroup beamGroup = null;
			foreach (var nr in staff.Elements.OfType<NoteOrRest>())
			{
				var note = nr as Note;
				if (note != null && note.BeamList.Any())
				{
					if (note.BeamList.First() == NoteBeamType.Start)
					{
						beamGroup = new BeamGroup(staff);
						beamGroup.Start = note.StemEndLocation;
						staff.BeamGroups.Add(beamGroup);
					}
					if (beamGroup != null) beamGroup.Members.Add(nr);
					if (note.BeamList.First() == NoteBeamType.End)
					{
						if (beamGroup == null) renderer.Exceptions.Add(new ScoreException(note, $"Encountered beam group end without corresponding beam group start."));
						else
						{
							beamGroup.End = note.StemEndLocation;
							beamGroup = null;
						}
					}
				}
			}
		}

		private void PerformOnBeamGroups(IEnumerable<BeamGroup> beamGroups, ScoreRendererBase renderer)
		{
			foreach (var beamGroup in beamGroups)
			{
				Note previousNote = null;
				foreach (var member in beamGroup.Members)
				{
					var currentNote = member as Note;
					if (currentNote == null) continue;

					var beamNumber = 1;
					foreach (var beamType in currentNote.BeamList)
					{
						var beamOffset = 28 + 4 * (beamNumber - 1) * (currentNote.StemDirection == VerticalDirection.Up ? 1 : -1);
						var stemEnd = beamGroup.Start.TranslateHorizontallyAndMaintainAngle(beamGroup.Angle, currentNote.StemEndLocation.X - beamGroup.Start.X);
						currentNote.StemStartLocation = stemEnd;
						if (beamType == NoteBeamType.ForwardHook || beamType == NoteBeamType.BackwardHook)
						{
							var hookLength = beamType == NoteBeamType.ForwardHook ? 6 : -6;
							var hookEnd = stemEnd.TranslateByAngleOld(beamGroup.Angle, hookLength);
							renderer.DrawLine(stemEnd.Translate(0, beamOffset), hookEnd.Translate(0, beamOffset), new Pen { Thickness = 2, Color = currentNote.CoalesceColor(renderer) }, beamGroup);
						}
						else if (previousNote != null && beamType != NoteBeamType.Single && previousNote.BeamList.Count >= beamNumber)
						{
							var stemEnd1 = beamGroup.Start.TranslateHorizontallyAndMaintainAngle(beamGroup.Angle, previousNote.StemEndLocation.X - beamGroup.Start.X);
							renderer.DrawLine(stemEnd1.Translate(0, beamOffset), stemEnd.Translate(0, beamOffset), new Pen { Thickness = 2, Color = currentNote.CoalesceColor(renderer) }, beamGroup);
						}
						beamNumber++;
					}

					previousNote = currentNote;
				}
			}
		}
	}
}