using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using Manufaktura.Music.Model.MajorAndMinor;
using System.Collections.Generic;

namespace Manufaktura.VisualTests.Providers
{
    public class ApiTestScoreProvider : ITestScoreProvider
    {
        public IEnumerable<(string FileName, Score Score, ScoreRenderingModes Mode)> EnumerateScores()
        {
            yield return Keys();
        }

        private void CreateKey(Staff staff, int fifths)
        {
            var key = new Key(fifths);
            staff.Add(key);
            staff.Add(new Barline());
            if (fifths % 5 == 0) staff.Add(new PrintSuggestion { IsSystemBreak = true });
        }

        private (string FileName, Score Score, ScoreRenderingModes Mode) Keys()
        {
            var score = Score.CreateOneStaffScore(Clef.Treble, MajorScale.C);

            for (var i = 1; i < 15; i++)
                CreateKey(score.FirstStaff, i);

            score.FirstStaff.Add(new Barline());
            score.FirstStaff.Add(new PrintSuggestion { IsSystemBreak = true });

            for (var i = -1; i > -15; i--)
                CreateKey(score.FirstStaff, i);

            score.FirstStaff.Add(new Barline(BarlineStyle.LightHeavy));

            return ("[Api] Keys.png", score, ScoreRenderingModes.AllPages);
        }
    }
}