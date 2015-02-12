using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.Digest;
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Controls.UniversalApps;
using Manufaktura.Controls.UniversalApps.Audio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Manufaktura.Controls.WindowsRuntime.Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadFilesAsync();
        }

        private async Task LoadFilesAsync()
        {
            FileOpenPicker dialog = new FileOpenPicker();
            Score score = null;
            string scoreXml;

            var result = await dialog.PickSingleFileAsync();

            using (System.IO.Stream fileStream = (await result.OpenAsync(Windows.Storage.FileAccessMode.Read)).AsStreamForRead())
            {

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    scoreXml = reader.ReadToEnd();
                }


                score = scoreXml.ToScore();
                noteViewer1.ScoreSource = score;
                noteViewer3.ScoreSource = score;

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

        MediaElementScorePlayer player;
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            player = new MediaElementScorePlayer(noteViewer1.ScoreSource);
            //player.ElementPlayed += player_ElementPlayed;
            player.Dispatcher = noteViewer1.Dispatcher;
            var binding = new Binding { Path = new PropertyPath("ThreadSafeCurrentElement") };
            binding.Source = player;
            noteViewer1.SetBinding(NoteViewer.SelectedElementProperty, binding);
            player.Start();

        }

        void player_ElementPlayed(object sender, MediaElementScorePlayer.MusicalSymbolEventArgs e)
        {
            noteViewer1.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, new DispatchedHandler(() => { noteViewer1.Select(e.Element); }));
        }
    }
}
