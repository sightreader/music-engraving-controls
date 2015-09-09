using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Services
{
    public class BeamingService : IBeamingService
    {
        public List<Point> BeamEndPositionsY { get; set; }

        public List<Point> BeamStartPositionsY { get; set; }

        public double CurrentStemEndPositionY { get; set; }

        public double CurrentStemPositionX { get; set; }

        public List<double> PreviousStemEndPositionsY { get; set; }

        public List<double> PreviousStemPositionsX { get; set; }

        public BeamingService()
        {
            PreviousStemEndPositionsY = new List<double>();
            PreviousStemPositionsX = new List<double>();
            BeamStartPositionsY = new List<Point>();
            BeamEndPositionsY = new List<Point>();
        }

        public IEnumerable<Note> GetAllNotesUnderOneBeam(Note examinedNote)
        {
            if (examinedNote.BeamList.All(b => b == NoteBeamType.Single)) return null;
            var staff = examinedNote.Staff;
            if (staff == null) return new List<Note> { examinedNote };
            var results = new List<Note>();
            for (int i = staff.Elements.IndexOf(examinedNote) - 1; i > 0; i--)
            {
                var note = staff.Elements[i] as Note;
                if (note == null) continue;
                if (note.BeamList.All(b => b == NoteBeamType.Single)) break;
                results.Add(note);
            }
            for (int i = staff.Elements.IndexOf(examinedNote) + 1; i < staff.Elements.Count; i++)
            {
                var note = staff.Elements[i] as Note;
                if (note == null) continue;
                if (note.BeamList.All(b => b == NoteBeamType.Single)) break;
                results.Add(note);
            }
            return results;
        }
    }
}