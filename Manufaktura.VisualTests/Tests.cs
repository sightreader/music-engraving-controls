using Manufaktura.VisualTests.Renderers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

            new WpfTestRenderer(testPath).GenerateImages();
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