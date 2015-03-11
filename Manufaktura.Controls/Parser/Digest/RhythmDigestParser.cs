using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
    public class RhythmDigestParser : ScoreParser<string>
    {
        public bool MarkRests { get; set; }
        public bool IncludeBarlines { get; set; }

        public RhythmDigestParser()
        {
            MarkRests = true;
            IncludeBarlines = true;
        }

        public override Model.Score Parse(string source)
        {
            throw new NotImplementedException();
        }

        public override string ParseBack(Model.Score score)
        {
            if (score == null) throw new ArgumentNullException("Score");

            StringBuilder sb = new StringBuilder();
            foreach (Staff staff in score.Staves)
            {
                foreach (var element in staff.Elements.Where(el => el is IHasDuration || el is Barline))
                {
                    if (element is Barline && IncludeBarlines)
                    {
                        sb.Append("| ");
                        continue;
                    }
                    IHasDuration durationElement = element as IHasDuration;
                    if (durationElement == null) continue;
                    sb.Append((int)durationElement.BaseDuration.Denominator);
                    for (int i = 0; i < durationElement.NumberOfDots; i++) sb.Append(".");
                    if (element is Rest && MarkRests) sb.Append("r");
                    sb.Append(" ");
                }
            }
            return sb.ToString().Trim();
        }
    }
}
