using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Desktop.Audio;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Music.Model;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace Manufaktura.Controls.WPF.Test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private int systemSpacing = 0;

		public MainWindow()
		{
			InitializeComponent();
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
			((TestViewModel)DataContext).Player.Play();
		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{
			((TestViewModel)DataContext).Player.Pause();
		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{
			((TestViewModel)DataContext).Player.Stop();
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
			vm.Data.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Eighth));
			vm.Data.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Eighth));
			vm.Data.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Eighth));
			vm.Data.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Eighth));
			vm.Data.FirstStaff.Elements.Add(new Barline());
			var score = vm.Data;
			vm.Data = null;
			vm.Data = score;
		}
	}
}