using Manufaktura.UnitTests.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests.Rendering
{
    public class MissingElementsAssertionRule : IRenderingAssertionRule
    {
        public Dictionary<ScoreRenderingTestEntry, string> Assert(IScoreRenderingTestResultsRepository currentResults, IScoreRenderingTestResultsRepository previousResults)
        {
            throw new NotImplementedException();
        }
    }
}
