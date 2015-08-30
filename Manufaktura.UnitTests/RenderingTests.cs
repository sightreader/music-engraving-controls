using Manufaktura.Controls.Parser;
using Manufaktura.Music.Model;
using Manufaktura.UnitTests.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manufaktura.UnitTests
{
    [TestClass]
    public class RenderingTests
    {
        const string inputPath = @"D:\Dokumenty\Manufaktura programów\Dane do bazy";
        const string outputPath = @"D:\Dokumenty\Manufaktura programów\UnitTests";
        const string inProgressPath = @"D:\Dokumenty\Manufaktura programów\UnitTests\InProgress";

        [TestMethod]
        public void TestRendering()
        {
            
            var currentResults = new ScoreRenderingTestResultsRepository(GetDirectoryPath(inProgressPath));
            var previousResults = GetPreviousResults(outputPath);
            var renderer = new UnitTestScoreRenderer(currentResults);
            foreach (var file in Directory.EnumerateFiles(inputPath, "*.xml", SearchOption.AllDirectories))
            {
                var xDocument = XDocument.Load(file);
                var parser = new MusicXmlParser();
                var score = parser.Parse(xDocument);
                renderer.Render(score);
                currentResults.Persist(Path.GetFileName(file));
                if (previousResults != null)
                {
                    previousResults.Load(Path.GetFileName(file));
                    PerformAssertions(currentResults, previousResults);
                }
            }
            File.Move(currentResults.DataPath, Path.GetDirectoryName(previousResults.DataPath));
        }

        private void PerformAssertions(IScoreRenderingTestResultsRepository currentResults, IScoreRenderingTestResultsRepository previousResults)
        {
            //TODO: Asercje
        }

        private IScoreRenderingTestResultsRepository GetPreviousResults(string resultsPath)
        {
            if (!Directory.Exists(resultsPath)) Directory.CreateDirectory(resultsPath);
            var directory = Directory.EnumerateDirectories(resultsPath, "*", SearchOption.TopDirectoryOnly)
                .OrderBy(d => GetDirectoryDate(Path.GetFileName(d))).LastOrDefault();
            if (string.IsNullOrWhiteSpace(directory)) return null;
            return new ScoreRenderingTestResultsRepository(directory);
        }

        private DateTime GetDirectoryDate(string directory)
        {
            if (directory.Length < 8) return DateTime.MinValue;
            return new DateTime(int.Parse(directory.Substring(0, 4)), int.Parse(directory.Substring(4, 2)), int.Parse(directory.Substring(6, 2)));
        }

        private string GetDirectoryPath(string folderPath)
        {
            var name = DateTime.Now.ToString("yyyy-MM-dd").Replace("-", string.Empty);
            while (Directory.Exists(name))
            {
                int? number = null;
                var splitName = name.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                if (splitName.Length > 1) number = UsefulMath.TryParseInt(splitName[1]);
                name = DateTime.Now.ToString("yyyy-MM-dd").Replace("-", string.Empty) + "_" + (number.HasValue ? number.Value + 1 : 2);
            }
            return Path.Combine(folderPath, name);
        }
    }
}
