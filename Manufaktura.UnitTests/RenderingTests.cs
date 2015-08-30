using Manufaktura.Controls.IoC;
using Manufaktura.Controls.Parser;
using Manufaktura.Music.Model;
using Manufaktura.UnitTests.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.UnitTests
{
    [TestClass]
    public class RenderingTests
    {
        private const string inProgressPath = @"D:\Dokumenty\Manufaktura programów\UnitTests\InProgress";
        private const string inputPath = @"D:\Dokumenty\Manufaktura programów\UnitTests\Data";
        private const string outputPath = @"D:\Dokumenty\Manufaktura programów\UnitTests";

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
                Assert.IsTrue(!renderer.Exceptions.Any(), "Exceptions occured while rendering.");

                currentResults.Persist(Path.GetFileName(file));
                if (previousResults != null)
                {
                    previousResults.Load(Path.GetFileName(file));
                    PerformAssertions(currentResults, previousResults);
                }
            }
            var successPath = Path.Combine(outputPath, Path.GetFileName(currentResults.DataPath));
            Directory.Move(currentResults.DataPath, successPath);
        }

        private DateTime? GetDirectoryDate(string directory)
        {
            if (directory.Length < 14) return null;
            var year = UsefulMath.TryParseInt(directory.Substring(0, 4));
            if (!year.HasValue) return null;
            var month = UsefulMath.TryParseInt(directory.Substring(4, 2));
            if (!month.HasValue) return null;
            var day = UsefulMath.TryParseInt(directory.Substring(6, 2));
            if (!day.HasValue) return null;
            var hour = UsefulMath.TryParseInt(directory.Substring(8, 2));
            if (!hour.HasValue) return null;
            var minute = UsefulMath.TryParseInt(directory.Substring(10, 2));
            if (!minute.HasValue) return null;
            var second = UsefulMath.TryParseInt(directory.Substring(12, 2));
            if (!second.HasValue) return null;
            return new DateTime(year.Value, month.Value, day.Value).AddHours(hour.Value).AddMinutes(minute.Value).AddSeconds(second.Value);
        }

        private string GetDirectoryPath(string folderPath)
        {
            var name = DateTime.Now.ToString("yyyyMMddHHmmss");
            //while (Directory.Exists(name))
            //{
            //    int? number = null;
            //    var splitName = name.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            //    if (splitName.Length > 1) number = UsefulMath.TryParseInt(splitName[1]);
            //    name = DateTime.Now.ToString("yyyyMMddHHmmSS") + "_" + (number.HasValue ? number.Value + 1 : 2);
            //}
            return Path.Combine(folderPath, name);
        }

        private IScoreRenderingTestResultsRepository GetPreviousResults(string resultsPath)
        {
            if (!Directory.Exists(resultsPath)) Directory.CreateDirectory(resultsPath);
            var directory = Directory.EnumerateDirectories(resultsPath, "*", SearchOption.TopDirectoryOnly)
                .Where(d => GetDirectoryDate(Path.GetFileName(d)) != null)
                .OrderBy(d => GetDirectoryDate(Path.GetFileName(d))).LastOrDefault();
            if (string.IsNullOrWhiteSpace(directory)) return null;
            return new ScoreRenderingTestResultsRepository(directory);
        }

        private void PerformAssertions(IScoreRenderingTestResultsRepository currentResults, IScoreRenderingTestResultsRepository previousResults)
        {
            var rules = new ManufakturaResolver().ResolveAll<IRenderingAssertionRule>();
            foreach (var rule in rules)
            {
                var results = rule.Assert(currentResults, previousResults);
            }
        }
    }
}