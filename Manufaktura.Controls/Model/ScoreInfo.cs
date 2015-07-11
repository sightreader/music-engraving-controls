using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class ScoreInfo
    {
        public IEnumerable<Measure> AllMeasures { get; private set; }
        public IEnumerable<StaffSystem> Systems { get; private set; }

        public ScoreInfo(IScoreService scoreService)
        {
            AllMeasures = new ReadOnlyCollection<Measure>(scoreService.AllMeasures.ToList());
            Systems = new ReadOnlyCollection<StaffSystem>(scoreService.Systems.ToList());
        }
    }
}
