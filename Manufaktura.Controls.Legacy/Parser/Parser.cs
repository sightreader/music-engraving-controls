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
        /// <summary>
        /// Parse TSource object and convert it into TSink.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public abstract TSink Parse(TSource source);

        /// <summary>
        /// Convert TSink object back into TSource.
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public abstract TSource ParseBack(TSink score);
    }
}
