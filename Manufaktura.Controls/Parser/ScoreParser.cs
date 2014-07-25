using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser
{
    public abstract class ScoreParser<TSource>
    {
        public abstract Score Parse(TSource source);

        public abstract TSource ParseBack (Score score);
    }
}
