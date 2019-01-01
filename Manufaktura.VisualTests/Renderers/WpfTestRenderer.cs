using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.WPF;
using Manufaktura.VisualTests.Providers;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Manufaktura.VisualTests.Renderers
{
    public class WpfTestRenderer : VisualTestRenderer
    {
        public WpfTestRenderer(ITestScoreProvider scoreProvider) : base(scoreProvider)
        {
        }

        protected override void RenderImage(Score score, string imageFileName, string outputPath, ScoreRenderingModes mode, string pathToCompare)
        {
            var noteViewer = new NoteViewer();
            noteViewer.RenderingMode = mode;
            noteViewer.IsOccupyingSpace = true;
            noteViewer.ScoreSource = score;

            //Ustalamy orientacyjne wymiary i mierzymy kontrolkę, żeby uaktualniło się ActualWidth:
            noteViewer.Measure(new System.Windows.Size(double.MaxValue, double.MaxValue));
            noteViewer.Arrange(new Rect(0, 0, double.MaxValue, double.MaxValue));

            int outputDpi = 200;
            double newWidthX = (outputDpi * noteViewer.DesiredSize.Width) / 96;
            double newHeightY = (outputDpi * noteViewer.DesiredSize.Height) / 96;
            RenderTargetBitmap bmp = new RenderTargetBitmap((int)newWidthX, (int)newHeightY, outputDpi, outputDpi, PixelFormats.Default);
            noteViewer.InvalidateVisual();

            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                drawingContext.DrawRectangle(System.Windows.Media.Brushes.White, null, new Rect(0, 0, newWidthX, newHeightY));
                if (!string.IsNullOrWhiteSpace(pathToCompare))
                {
                    var oldVersion = Path.Combine(pathToCompare, imageFileName);
                    var tintedVersion = TintImage(oldVersion);
                    var tintedPath = Path.Combine(outputPath, Path.GetFileName(oldVersion).Replace(".png", "_TINT.png"));
                    tintedVersion.Save(tintedPath);
                    tintedVersion.Dispose();

                    BitmapImage resizedTintedImage = new BitmapImage();
                    resizedTintedImage.BeginInit();
                    resizedTintedImage.UriSource = new Uri(tintedPath);
                    resizedTintedImage.EndInit();
                    drawingContext.DrawImage(resizedTintedImage, new Rect(0, 0, resizedTintedImage.Width / (outputDpi / resizedTintedImage.DpiX), resizedTintedImage.Height / (outputDpi / resizedTintedImage.DpiY)));
                }
            }
            bmp.Render(drawingVisual);
            bmp.Render(noteViewer);

            //Konwertujemy na obrazek i zapisujemy do pola ImageData:
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));

            var filePath = Path.Combine(outputPath, imageFileName);
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                encoder.Save(fs);
                fs.Flush();
                fs.Close();
            }
        }

        private Bitmap TintImage(string imagePath)
        {
            var cm = new ColorMatrix(new float[][]
            {
              new float[] {1, 0, 0, 0, 0},
              new float[] {0, 1, 1, 0, 0},
              new float[] {0, 0, 1, 0, 0},
              new float[] {0, 0, 0, 1, 0},
              new float[] {1, 0, 0, 0, 1}
            });

            var img = System.Drawing.Image.FromFile(imagePath);
            var ia = new ImageAttributes();
            ia.SetColorMatrix(cm);

            var bmp = new Bitmap(img.Width, img.Height);
            var gfx = Graphics.FromImage(bmp);
            var rect = new Rectangle(0, 0, img.Width, img.Height);

            gfx.DrawImage(img, rect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            return bmp;
        }
    }
}