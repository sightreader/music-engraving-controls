using Manufaktura.Controls.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Score auxiliary information.
    /// </summary>
    public class ScoreInfo
    {
        /// <summary>
        /// All measures in the score (from every staff and system).
        /// </summary>
        public IEnumerable<Measure> AllMeasures { get; private set; }

        public IEnumerable<Part> AllParts { get; private set; }

        /// <summary>
        /// All systems in the score.
        /// </summary>
        public IEnumerable<StaffSystem> Systems { get; private set; }

        public ScoreInfo(IScoreService scoreService)
        {
            AllMeasures = new ReadOnlyCollection<Measure>(scoreService.CurrentScore.Staves.SelectMany(s => s.Measures).ToList());
            Systems = new ReadOnlyCollection<StaffSystem>(scoreService.Systems.ToList());
        }
    }
}