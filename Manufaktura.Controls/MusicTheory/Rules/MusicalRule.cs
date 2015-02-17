using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.MusicTheory.Rules
{
    public abstract class MusicalRule
    {
        public abstract IEnumerable<MusicalError> Validate(Score score);
    }
}
