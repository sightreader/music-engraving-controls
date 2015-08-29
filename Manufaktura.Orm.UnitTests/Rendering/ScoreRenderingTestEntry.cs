using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests.Rendering
{
    public class ScoreRenderingTestEntry
    {
        public Point Location { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int StaffNo { get; set; }
        public int StaffIndex { get; set; }
        public MusicalSymbolType Type { get; set; }
    }
}
