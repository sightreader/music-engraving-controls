using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Parser.Digest;
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Controls.Parser.MusicXml.Strategies;
using Manufaktura.Controls.UniversalApps.Media.Midi;
using Manufaktura.Music.Model;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Manufaktura.Controls.UWP.Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int systemSpacing = 0;

        public MainPage()
        {
            InitializeComponent();
            LoadTestModel(HookDirectionAlgorithm.ProductionCandidate);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await LoadFilesAsync();
        }

        private async Task LoadFilesAsync()
        {
            FileOpenPicker dialog = new FileOpenPicker();
            dialog.ViewMode = PickerViewMode.Thumbnail;
            dialog.FileTypeFilter.Add(".xml");
            Score score = null;
            string scoreXml;

            var result = await dialog.PickSingleFileAsync();

            using (Stream fileStream = (await result.OpenAsync(Windows.Storage.FileAccessMode.Read)).AsStreamForRead())
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    scoreXml = reader.ReadToEnd();
                }

                score = scoreXml.ToScore();
                noteViewer1.ScoreSource = score;
                var player = new MidiTaskScorePlayer(score, noteViewer1.Dispatcher);
                var devices = await player.GetDeviceNamesAsync();
                await player.InitializeAsync(devices[0]);
                var vm = new TestViewModel() { Player = player  };
                DataContext = vm;
                //noteViewer3.ScoreSource = score;

                MusicXmlNormalizer normalizer = new MusicXmlNormalizer() { NormalizeSpaceBeforeFirstNotesOfMeasures = true };
                noteViewer2.XmlTransformations = new[] { normalizer };
                noteViewer2.XmlSource = scoreXml;

                MelodicContourDigestParser digestParser = new MelodicContourDigestParser();
                int[] results = digestParser.ParseBack(score);

                LyricsDigestParser lyricsParser = new LyricsDigestParser();
                string lyrics = lyricsParser.ParseBack(score);
                //MessageBox.Show(string.Join(", ", results));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            noteViewer1.CurrentPage++;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var elements = noteViewer1.InnerScore.Staves.SelectMany(s => s.Elements).Where(x => x.Measure != null && x.Measure.System == noteViewer1.InnerScore.Systems[1]);
            foreach (var element in elements) element.CustomColor = Primitives.Color.Red;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            noteViewer1.RenderingMode = Rendering.ScoreRenderingModes.Panorama;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            noteViewer1.RenderingMode = Rendering.ScoreRenderingModes.SinglePage;
            noteViewer1.CurrentPage = 1;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            noteViewer1.RenderingMode = Rendering.ScoreRenderingModes.AllPages;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ((TestViewModel)DataContext).Player?.Play();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ((TestViewModel)DataContext).Player.Pause();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ((TestViewModel)DataContext).Player.PlayElement(Note.FromPitch(Pitch.C5));
            //((TestViewModel)DataContext).Player.Stop();
        }

        private async void LoadTestModel(HookDirectionAlgorithm hookDirectionAlgorithm)
        {
            //await Task.Factory.StartNew(() => Thread.Sleep(1000));
            var vm = new TestViewModel();

            DataContext = vm;
            vm.LoadTestData(hookDirectionAlgorithm);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var vm = (TestViewModel)DataContext;

            var supported = MusicXmlWritingStrategyBase.SupportedElements;
            var unsupported = MusicXmlWritingStrategyBase.UnsupportedElements;
            var createdDocument = new MusicXmlParser().ParseBack(vm.Data);
        }

        private void Breakpoint_Click(object sender, RoutedEventArgs e)
        {
            if (noteViewerTest.SelectedElement == null) return;
            var vm = (TestViewModel)DataContext;
            DataContext = null;
            noteViewerTest.SelectedElement.IsBreakpointSet = true;
            DataContext = vm;


        }
    }
}