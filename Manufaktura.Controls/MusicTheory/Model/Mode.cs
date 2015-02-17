using Manufaktura.Controls.MusicTheory.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.MusicTheory.Model
{
    public abstract class Mode
    {
        public abstract RelativeScale Scale { get; }
        public abstract IEnumerable<MusicalRule> Rules { get; }
    }
}
