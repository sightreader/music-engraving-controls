using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.WPF;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Manufaktura.VisualTests.Renderers
{
    public class WpfTestRenderer : VisualTestRenderer
    {
        public WpfTestRenderer(string testPath) : base(testPath)
        {
        }

        protected override void RenderImage(string musicXml, string fileName, string outputPath, ScoreRenderingModes mode)
        {
            var noteViewer = new NoteViewer();
            noteViewer.RenderingMode = mode;
            noteViewer.IsOccupyingSpace = true;
            noteViewer.XmlSource = musicXml;

            //Ustalamy orientacyjne wymiary i mierzymy kontrolkę, żeby uaktualniło się ActualWidth:
            noteViewer.Measure(new Size(double.MaxValue, double.MaxValue));
            noteViewer.Arrange(new Rect(0, 0, double.MaxValue, double.MaxValue));

            int outputDpi = 96;
            double newWidthX = (outputDpi * noteViewer.DesiredSize.Width) / 96;
            double newHeightY = (outputDpi * noteViewer.DesiredSize.Height) / 96;
            RenderTargetBitmap bmp = new RenderTargetBitmap((int)newWidthX, (int)newHeightY, outputDpi, outputDpi, PixelFormats.Default);
            noteViewer.InvalidateVisual();

            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                drawingContext.DrawRectangle(Brushes.White, null, new Rect(0, 0, newWidthX, newHeightY));
            }
            bmp.Render(drawingVisual);
            bmp.Render(noteViewer);

            //Konwertujemy na obrazek i zapisujemy do pola ImageData:
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            var newFileName = fileName.Replace(".xml", $"_{mode}.png");
            var filePath = Path.Combine(outputPath, newFileName);
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                encoder.Save(fs);
                fs.Flush();
                fs.Close();
            }
        }


    }
}