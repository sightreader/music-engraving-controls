using Manufaktura.Controls.Desktop.Audio;
using Manufaktura.Controls.Desktop.Audio.Midi;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Parser.MusicXml.Strategies;
using Manufaktura.Music.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Xml.Linq;

namespace Manufaktura.Controls.WPF.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int systemSpacing = 0;
        private static FontFamily BravuraFamily = new FontFamily(new Uri("pack://application:,,,/Manufaktura.Controls.WPF.Test;component/Assets;component/"), "./#Bravura");
        private static FontFamily GootvilleFamily = new FontFamily(new Uri("pack://application:,,,/Manufaktura.Controls.WPF.Test;component/Assets;component/"), "./#Gootville");
        private static FontFamily JazzyFamily = new FontFamily(new Uri("pack://application:,,,/Manufaktura.Controls.WPF.Test;component/Assets;component/"), "./#Jazzy");

        public MainWindow()
        {
            InitializeComponent();
            var family = dummyTextBlock.FontFamily;

            var assembly = typeof(MainWindow).Assembly;
            var resourceName = $"{typeof(MainWindow).Namespace}.Assets.bravura_metadata.json";
            //var resourceName = $"{typeof(MainWindow).Namespace}.Assets.gootville_metadata.json";
            //var resourceName = $"{typeof(MainWindow).Namespace}.Assets.jazzy_metadata.json";
            //noteViewerTest.LoadFont(family);
            //noteViewer1.LoadFont(family);
            //noteViewer2.LoadFont(family);
            //noteViewer3.LoadFont(family);

            var useSMuFL = true;
            
            if (useSMuFL) {
                using (var stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    var metadataJson = JsonConvert.DeserializeObject<SMuFLFontMetadata>(result);
                    noteViewerTest.LoadFont(family, 25, 16, metadataJson);
                    noteViewer1.LoadFont(family, 25, 16, metadataJson);
                    noteViewer2.LoadFont(family, 25, 16, metadataJson);
                    noteViewer3.LoadFont(family, 25, 16, metadataJson);

                    //var s = new WpfScoreRendererSettings();
                    //s.CurrentSMuFLMetadata = metadataJson;
                    //var ba = ((MemoryStream)s.GetSMuFLMetadataBinaryStream()).ToArray();
                }
            }

            LoadTestModel(HookDirectionAlgorithm.ProductionCandidate);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MusicXml (*.xml)|*.xml";
            if (dialog.ShowDialog().Value)
            {
                string xml = File.ReadAllText(dialog.FileName);
                noteViewer1.XmlSource = xml;
                var testViewModel = DataContext as TestViewModel;
                if (testViewModel.Player != null) ((IDisposable)testViewModel.Player).Dispose();

                testViewModel.Player = new MidiTaskScorePlayer(noteViewer1.InnerScore);
                ((MidiTaskScorePlayer)testViewModel.Player).SetInstrument(GeneralMidiInstrument.AcousticGrandPiano);
                var devices = MidiTaskScorePlayer.AvailableDevices;
                MusicXmlParser parser = new MusicXmlParser();
                noteViewer2.ScoreSource = parser.Parse(XDocument.Parse(xml));
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

            if (vm.Player != null) ((IDisposable)vm.Player).Dispose();

            vm.Player = new MidiTaskScorePlayer(vm.Data);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var vm = (TestViewModel)DataContext;

            var supported = MusicXmlWritingStrategyBase.SupportedElements;
            var unsupported = MusicXmlWritingStrategyBase.UnsupportedElements;
            var createdDocument = new MusicXmlParser().ParseBack(noteViewer1.InnerScore);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "MusicXml (*.xml)|*.xml";
            if (dialog.ShowDialog().Value)
            {
                createdDocument.Save(dialog.FileName, SaveOptions.None);
            }
        }

        private void Breakpoint_Click(object sender, RoutedEventArgs e)
        {
            if (noteViewer1.SelectedElement == null) return;
            noteViewer1.SelectedElement.IsBreakpointSet = true;
        }

        private void IdentifyClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(noteViewer1.SelectedElement?.ToString());
        }
    }
}