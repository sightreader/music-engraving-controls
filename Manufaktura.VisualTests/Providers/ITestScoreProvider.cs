using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;

namespace Manufaktura.VisualTests.Providers
{
    public interface ITestScoreProvider
    {
        IEnumerable<(string FileName, Score Score, ScoreRenderingModes Mode)> EnumerateScores();
    }
}