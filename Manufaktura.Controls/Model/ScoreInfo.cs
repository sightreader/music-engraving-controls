using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class ScoreInfo
    {
        public IEnumerable<Measure> AllMeasures { get; private set; }
        public StaffSystem[] Systems { get; private set; }

        public ScoreInfo(IScoreService scoreService)
        {
            AllMeasures = scoreService.AllMeasures;
            Systems = scoreService.Systems;
        }
    }
}
