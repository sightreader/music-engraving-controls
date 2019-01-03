using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using Manufaktura.VisualTests.Providers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

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
                catch (ArgumentException aex) when (aex.InnerException is COMException)
                {
                    RenderExceptions.Add(aex);
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

            File.WriteAllText(Path.Combine(outputPath, "RenderExceptions.txt"), string.Join("\n\n\n\n", RenderExceptions.Select(re => re.ToString())));
        }

        protected Bitmap TintImage(string imagePath)
        {
            var img = Image.FromFile(imagePath);
            var bmp = new Bitmap(img.Width, img.Height, PixelFormat.Format16bppRgb555);
            var gfx = Graphics.FromImage(bmp);

            var ia = new ImageAttributes();
            ia.SetColorMatrix(new ColorMatrix(new float[][]
            {
              new float[] {1, 0, 0, 0, 0},
              new float[] {0, 1, 1, 0, 0},
              new float[] {0, 0, 1, 0, 0},
              new float[] {0, 0, 0, 1, 0},
              new float[] {1, 0, 0, 0, 1}
            }));
            gfx.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            return bmp;
        }

        protected abstract void RenderImage(Score score, string fileName, string outputPath, ScoreRenderingModes mode, string pathToCompare);
    }
}