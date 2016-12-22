using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.IO;

namespace Manufaktura.VisualTests.Renderers
{
    public abstract class VisualTestRenderer : IVisualTestRenderer
    {
        private string testPath;

        protected VisualTestRenderer(string testPath)
        {
            this.testPath = testPath;
        }

        public List<Exception> RenderExceptions { get; private set; } = new List<Exception>();

        public void GenerateImages()
        {
            var renderDate = DateTime.Now;
            var scorePath = Path.Combine(testPath, "Scores");
            var outputPath = Path.Combine(testPath, $"Test_{renderDate.ToString("yyyyMMddhhmmss")}");
            if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);

            foreach (var file in Directory.EnumerateFiles(scorePath))
            {
                try
                {
                    RenderImage(File.ReadAllText(file), Path.GetFileName(file), outputPath, ScoreRenderingModes.Panorama);
                    RenderImage(File.ReadAllText(file), Path.GetFileName(file), outputPath, ScoreRenderingModes.AllPages);
                }
                catch (Exception ex)
                {
                    RenderExceptions.Add(ex);
                }
            }
        }

        protected abstract void RenderImage(string musicXml, string fileName, string outputPath, ScoreRenderingModes mode);
    }
}