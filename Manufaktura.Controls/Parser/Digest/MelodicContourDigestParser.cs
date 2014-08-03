using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
    class MelodicContourDigestParser : ScoreParser<int[]>
    {
        public override Model.Score Parse(int[] source)
        {
            throw new NotImplementedException();
        }

        public override int[] ParseBack(Model.Score score)
        {
            List<int> intervals = new List<int>();
            foreach (Staff staff in score.Staves)
            {
                Note lastNote = null;
                foreach (Note note in staff.Elements.OfType<Note>())
                {
                    if (lastNote != null)
                    {
                        intervals.Add(note.MidiPitch - lastNote.MidiPitch);
                    }
                    lastNote = note;
                }
            }
            return intervals.ToArray();
        }
    }
}
