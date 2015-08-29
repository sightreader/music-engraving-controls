using System.Collections.Generic;

namespace Manufaktura.Orm.UnitTests.Rendering
{
    public interface IScoreRenderingTestResultsRepository : IEnumerable<ScoreRenderingTestEntry>
    {
        void Persist(string fileName);
        void Load(string fileName);

        void Put(ScoreRenderingTestEntry entry);
    }
}