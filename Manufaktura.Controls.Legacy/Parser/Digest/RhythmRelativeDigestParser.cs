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
                        int greaterDuration;
                        int lesserDuration;
                        string sign;
                        if (previousElement.BaseDuration <= durationElement.BaseDuration)
                        {
                            greaterDuration = (int)durationElement.BaseDuration.Denominator;
                            lesserDuration = (int)previousElement.BaseDuration.Denominator;
                            sign = "*";
                        }
                        else
                        {
                            lesserDuration = (int)durationElement.BaseDuration.Denominator;
                            greaterDuration = (int)previousElement.BaseDuration.Denominator;
                            sign = "/";
                        }
                        sb.Append(sign);
                        sb.Append(greaterDuration / lesserDuration);
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
