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

        public void GenerateImages(string pathToCompare)
        {
            var renderDate = DateTime.Now;
            var scorePath = Path.Combine(testPath, "Scores");
            var outputPath = Path.Combine(testPath, $"Test_{renderDate.ToString("yyyyMMddHHmmss")}");
            if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);

            foreach (var file in Directory.EnumerateFiles(scorePath))
            {
                try
                {
                    RenderImage(File.ReadAllText(file), Path.GetFileName(file), outputPath, ScoreRenderingModes.Panorama, pathToCompare);
                    RenderImage(File.ReadAllText(file), Path.GetFileName(file), outputPath, ScoreRenderingModes.AllPages, pathToCompare);
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

        protected abstract void RenderImage(string musicXml, string fileName, string outputPath, ScoreRenderingModes mode, string pathToCompare);
    }
}