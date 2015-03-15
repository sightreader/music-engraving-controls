using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class PentatonicMode : Mode
    {
        public override IEnumerable<int> Intervals
        {
            get { return new[] { 2, 2, 1, 2, 2 }; } //TODO: Lol, to jest średniowieczny heksachord, a nie pentatonika :P
        }

    }
}
