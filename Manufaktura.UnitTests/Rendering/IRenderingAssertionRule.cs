using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.UnitTests.Rendering
{
    interface IRenderingAssertionRule
    {
        Dictionary<ScoreRenderingTestEntry, List<string>> Assert(IScoreRenderingTestResultsRepository currentResults, IScoreRenderingTestResultsRepository previousResults);
    }
}
