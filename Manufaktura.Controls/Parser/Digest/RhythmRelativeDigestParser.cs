using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
    public class RhythmRelativeDigestParser : ScoreParser<string>
    {
        public bool MarkRests { get; set; }
        public bool IncludeBarlines { get; set; }

        public RhythmRelativeDigestParser()
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
            if (score == null) throw new ArgumentNullException("Score cannot be null.");

            StringBuilder sb = new StringBuilder();
            IHasDuration previousElement = null;
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

                    if (previousElement != null)
                    {
                        sb.Append(previousElement.BaseDuration <= durationElement.BaseDuration ? "*" : "/");
                        var dur1 = (int)durationElement.BaseDuration.Denominator;
                        var dur2 = (int)previousElement.BaseDuration.Denominator;
                        sb.Append(dur2 > dur1 ? dur2 / dur1 : dur1 / dur2);
                    }
                    for (int i = 0; i < durationElement.NumberOfDots; i++) sb.Append(".");
                    if (element is Rest && MarkRests) sb.Append("r");
                    previousElement = durationElement;
                    sb.Append(" ");
                }
            }
            return sb.ToString().Trim();
        }
    }
}
