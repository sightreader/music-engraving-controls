using Manufaktura.VisualTests.Renderers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Manufaktura.VisualTests
{
    [TestClass]
    public class Tests
    {
        private const string testPath = @"D:\Dokumenty\Manufaktura programów\VisualTests";

        private DateTime lastAcceptedTestDateTime;
        private List<DateTime> testHistory = new List<DateTime>();

        [TestMethod]
        public void PerformVisualTests()
        {
            AcceptTo(DateTime.MinValue);

            var tests = CreatePathDictionary();
            var lastNotAcceptedTest = tests.Any(d => d.Key > lastAcceptedTestDateTime) ? tests.FirstOrDefault(d => d.Key > lastAcceptedTestDateTime).Value : null;

            new WpfTestRenderer(testPath).GenerateImages();
            if (!string.IsNullOrWhiteSpace(lastNotAcceptedTest))
            {
                //TODO: Porównanie
            }
        }

        private Dictionary<DateTime, string> CreatePathDictionary ()
        {
            var dict = new Dictionary<DateTime, string>();
            foreach (var directory in Directory.EnumerateDirectories(testPath, "Test*"))
            {
                var unparsedDate = Path.GetFileName(directory).Replace("Test_", "");
                DateTime dt;
                if (DateTime.TryParseExact(unparsedDate, "yyyyMMddhhmmss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dt))
                    dict.Add(dt, directory);
            }
            return dict.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
        }

        private string GetLastUnacceptedTestPath()
        {
            return "";
        }

        private void AcceptTo(DateTime testTime)
        {
            lastAcceptedTestDateTime = testTime;
            testHistory.Add(testTime);
        }
    }
}