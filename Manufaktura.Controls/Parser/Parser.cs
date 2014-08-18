using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser
{
    public abstract class Parser <TSink, TSource>
    {
        public abstract TSink Parse(TSource source);

        public abstract TSource ParseBack(TSink score);
    }
}
