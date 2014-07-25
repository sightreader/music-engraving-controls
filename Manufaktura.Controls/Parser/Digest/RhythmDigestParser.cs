using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
    public class RhythmDigestParser : ScoreParser<string>
    {
        public override Model.Score Parse(string source)
        {
            throw new NotImplementedException();
        }

        public override string ParseBack(Model.Score score)
        {
            if (score == null) throw new ArgumentNullException("Score cannot be null.");

            StringBuilder sb = new StringBuilder();
            foreach (Staff staff in score.Staves)
            {
                foreach (IHasDuration element in staff.Elements.OfType<IHasDuration>())
                {
                    sb.Append((int)element.Duration);
                    if (element is Rest) sb.Append("r");
                    sb.Append(" ");
                }
            }
            return sb.ToString().Trim();
        }
    }
}
