using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.IO;

namespace Manufaktura.VisualTests.Providers
{
    public class FileTestScoreProvider : ITestScoreProvider
    {
        private string testPath;

        public FileTestScoreProvider(string testPath)
        {
            this.testPath = testPath;
        }

        public IEnumerable<(string FileName, Score Score, ScoreRenderingModes Mode)> EnumerateScores()
        {
            var scorePath = Path.Combine(testPath, "Scores");
            foreach (var file in Directory.EnumerateFiles(scorePath))
            {
                yield return (Path.GetFileName(file).Replace(".xml", $"_Panorama.png"), File.ReadAllText(file).ToScore(), ScoreRenderingModes.Panorama);
                yield return (Path.GetFileName(file).Replace(".xml", $"_AllPages.png"), File.ReadAllText(file).ToScore(), ScoreRenderingModes.AllPages);
            }
        }
    }
}