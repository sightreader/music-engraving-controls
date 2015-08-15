using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser
{
    /// <summary>
    /// Base score parser class.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    public abstract class ScoreParser<TSource> : Parser<Score, TSource>
    {
    }
}
