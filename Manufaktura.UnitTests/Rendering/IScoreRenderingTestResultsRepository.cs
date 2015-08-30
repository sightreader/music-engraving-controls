using System.Collections.Generic;

namespace Manufaktura.UnitTests.Rendering
{
    public interface IScoreRenderingTestResultsRepository : IEnumerable<ScoreRenderingTestEntry>
    {
        string DataPath { get; }

        void Load(string fileName);

        void Persist(string fileName);

        void Put(ScoreRenderingTestEntry entry);
    }
}