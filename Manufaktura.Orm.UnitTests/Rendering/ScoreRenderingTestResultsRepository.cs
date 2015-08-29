using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Manufaktura.Orm.UnitTests.Rendering
{
    public class ScoreRenderingTestResultsRepository : IScoreRenderingTestResultsRepository
    {
        private string dataPath = string.Empty;

        private List<ScoreRenderingTestEntry> elements = new List<ScoreRenderingTestEntry>();

        public ScoreRenderingTestResultsRepository(string folderPath)
        {
            dataPath = folderPath;
        }

        public IEnumerator<ScoreRenderingTestEntry> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        public void Persist(string fileName)
        {
            if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);
        }

        public void Put(ScoreRenderingTestEntry entry)
        {
            elements.Add(entry);
        }


        public void Load(string fileName)
        {
            
        }
    }
}