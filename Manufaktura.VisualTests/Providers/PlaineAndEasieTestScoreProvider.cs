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

        private Dictionary<string, string> GetPlaineAndEasieData()
        {
            return new Dictionary<string, string>
            {
                { "[RISM] Proper stem length.png", "'4..F6G2G/4..A6B2Bqq3BCr/4CxCD8-6-'A/''2C'8B-4-/;G-2;bB;c" },
                { "[RISM] Clef change under beam.png", "8-{,G'D,B}{'6C %G-2CEDE}{,A'DCD}/8-{DGE};F-4;xF;c" },
                { "[RISM] 64th beams.png", "''2.D+/D+/D+/(D){5DEDxCDExFG}{AGFEGFED};G-2;bBE;3/4" },
                { "[RISM] Key signature placement in some C keys.png", ",8G/{'6CD8E}{ED}{FE}{,GF}/;C-4;bBEA;c"},
                { "[RISM] Note position at start of measure.png", "'4E6{FEDC}4G+{6GFED}/{E3DC''8C}-;C-1;;c" },
                { "[RISM] Rest position at start of measure.png", "'2AA/B''C/DD/C-/6-{C'B''C}{D'BAG};C-1;xFC;c"},
                { "[RISM] Centering of time signature.png", "6-{''C'BAGF}{EAGFED}8{CEG};C-1;;12/8" },
                { "[RISM] Plaine and Easie time signature 0.png", "'4DDFGAG''CD(C)// @c4C2D'4A/GnB2A/;G-2;bB;0" }
            };
        }
    }
}