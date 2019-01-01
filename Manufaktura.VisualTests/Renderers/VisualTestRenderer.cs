using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using Manufaktura.VisualTests.Providers;
using System;
using System.Collections.Generic;
using System.IO;

namespace Manufaktura.VisualTests.Renderers
{
    public abstract class VisualTestRenderer : IVisualTestRenderer
    {
        private readonly ITestScoreProvider scoreProvider;

        protected VisualTestRenderer(ITestScoreProvider scoreProvider)
        {
            this.scoreProvider = scoreProvider;
        }

        public List<Exception> RenderExceptions { get; private set; } = new List<Exception>();

        public void GenerateImages(string pathToCompare, string outputPath)
        {
            if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);

            foreach (var scoreInfo in scoreProvider.EnumerateScores())
            {
                try
                {
                    RenderImage(scoreInfo.Item2, scoreInfo.Item1, outputPath, scoreInfo.Item3, pathToCompare);
                }
                catch (OutOfMemoryException omex)
                {
                    RenderExceptions.Add(omex);
                }
                catch (FileNotFoundException fex)
                {
                    RenderExceptions.Add(fex);
                }
                catch (Exception ex)
                {
                    RenderExceptions.Add(ex);
                    throw;
                }
            }

            foreach (var file in Directory.EnumerateFiles(outputPath, "*TINT*"))
            {
                try
                {
                    File.Delete(file);
                }
                catch { }
            }
        }

        protected abstract void RenderImage(Score score, string fileName, string outputPath, ScoreRenderingModes mode, string pathToCompare);
    }
}