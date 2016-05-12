using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.Digest;
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Controls.UniversalApps.Audio;
using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
				var vm = new TestViewModel() { Player = new TestTaskScorePlayer(score, noteViewer1.Dispatcher) };
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

		private void Play_Click(object sender, RoutedEventArgs e)
		{
			((TestViewModel)DataContext).Player.Play();
		}
	}
}