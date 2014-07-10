using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class ScoreRendererState
    {
        public Clef CurrentClef {get; set;}

        public ScoreRendererState()
        {
            CurrentClef = new Clef(ClefType.CClef, 2);
        }
    }
}
