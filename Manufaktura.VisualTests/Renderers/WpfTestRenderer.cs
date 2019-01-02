using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.WPF;
using Manufaktura.VisualTests.Configurators;
using Manufaktura.VisualTests.Providers;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Manufaktura.VisualTests.Renderers
{
    public class WpfTestRenderer : VisualTestRenderer
    {
        private NoteViewer noteViewer = new NoteViewer();
        private readonly IFontConfigurator fontConfigurator;

        public WpfTestRenderer(ITestScoreProvider scoreProvider, IFontConfigurator fontConfigurator) : base(scoreProvider)
        {
            this.fontConfigurator = fontConfigurator;
        }

        protected override void RenderImage(Score score, string imageFileName, string outputPath, ScoreRenderingModes mode, string pathToCompare)
        {
            noteViewer = new NoteViewer();
            noteViewer.RenderingMode = mode;
            noteViewer.IsOccupyingSpace = true;
            fontConfigurator.Configure(noteViewer);
            noteViewer.ScoreSource = score;

            //Ustalamy orientacyjne wymiary i mierzymy kontrolkę, żeby uaktualniło się ActualWidth:
            noteViewer.Measure(new Size(double.MaxValue, double.MaxValue));
            noteViewer.Arrange(new Rect(0, 0, double.MaxValue, double.MaxValue));

            int outputDpi = 200;
            double newWidthX = (outputDpi * noteViewer.DesiredSize.Width) / 96;
            double newHeightY = (outputDpi * noteViewer.DesiredSize.Height) / 96;
            RenderTargetBitmap bmp = new RenderTargetBitmap((int)newWidthX, (int)newHeightY, outputDpi, outputDpi, PixelFormats.Default);
            noteViewer.InvalidateVisual();

            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                drawingContext.DrawRectangle(Brushes.White, null, new Rect(0, 0, newWidthX, newHeightY));
                if (!string.IsNullOrWhiteSpace(pathToCompare))
                {
                    var oldVersion = Path.Combine(pathToCompare, imageFileName);
                    var tintedPath = Path.Combine(outputPath, Path.GetFileName(oldVersion).Replace(".png", "_TINT.png"));
                    try
                    {
                        using (var tintedVersion = TintImage(oldVersion))
                        {
                            tintedVersion.Save(tintedPath);
                        }

                        using (var stream = File.OpenRead(tintedPath))
                        {
                            var resizedTintedImage = new BitmapImage();
                            resizedTintedImage.BeginInit();
                            resizedTintedImage.CacheOption = BitmapCacheOption.OnLoad;
                            resizedTintedImage.StreamSource = stream;
                            resizedTintedImage.EndInit();
                            drawingContext.DrawImage(resizedTintedImage, new Rect(0, 0, resizedTintedImage.Width / (outputDpi / resizedTintedImage.DpiX), resizedTintedImage.Height / (outputDpi / resizedTintedImage.DpiY)));
                            stream.Close();
                        }
                    }
                    finally
                    {
                        if (File.Exists(tintedPath)) File.Delete(tintedPath);
                    }
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
    }
}