using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser
{
    /// <summary>
    /// Base class to implement parser.
    /// </summary>
    /// <typeparam name="TSink"></typeparam>
    /// <typeparam name="TSource"></typeparam>
    public abstract class Parser <TSink, TSource>
    {
        public abstract TSink Parse(TSource source);

        public abstract TSource ParseBack(TSink score);
    }
}
