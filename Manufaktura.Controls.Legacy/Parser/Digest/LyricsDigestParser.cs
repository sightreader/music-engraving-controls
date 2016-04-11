using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
    public class LyricsDigestParser : ScoreParser<string>
    {
        public override Model.Score Parse(string source)
        {
            throw new NotImplementedException();
        }

        public override string ParseBack(Score score)
        {
            List<StringBuilder> verses = new List<StringBuilder>();
            foreach (Staff staff in score.Staves)
            {
                foreach (Note note in staff.Elements.OfType<Note>())
                {
                    for (int i = 0; i < note.Lyrics.Count; i++)
                    {
                        if (verses.Count < i + 1) verses.Add(new StringBuilder());
                        Lyrics currentLyrics = note.Lyrics[i];
                        verses[i].Append(currentLyrics.Text);
                        if (currentLyrics.Type == SyllableType.End || currentLyrics.Type == SyllableType.Single) verses[i].Append(" ");
                    }
                }
            }
            return string.Join(" ", verses).Trim();
        }
    }
}
