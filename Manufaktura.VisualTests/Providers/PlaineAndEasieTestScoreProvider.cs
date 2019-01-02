using Manufaktura.Controls.LibraryStandards.PlaineAndEasie;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.VisualTests.Providers
{
    public class PlaineAndEasieTestScoreProvider : ITestScoreProvider
    {
        public IEnumerable<Tuple<string, Score, ScoreRenderingModes>> EnumerateScores()
        {
            foreach (var data in GetPlaineAndEasieData())
            {
                var splitData = data.Value.Split(';');
                var parser = new PlaineAndEasie2ScoreParser();
                var score = parser.Parse(splitData.ElementAtOrDefault(1), splitData.ElementAtOrDefault(2), splitData.ElementAtOrDefault(3), splitData.ElementAtOrDefault(0));
                yield return new Tuple<string, Score, ScoreRenderingModes>(data.Key, score, ScoreRenderingModes.Panorama);
            }
        }


        private Dictionary<string, string> GetPlaineAndEasieData ()
        {
            return new Dictionary<string, string>
            {
                { "[RISM] Too long stems.png", "'4..F6G2G/4..A6B2Bqq3BCr/4CxCD8-6-'A/''2C'8B-4-/;G-2;bB;c" },
                { "[RISM] Clef change under beam.png", "8-{,G'D,B}{'6C %G-2CEDE}{,A'DCD}/8-{DGE};F-4;xF;c" }
            };
        }
    }
}