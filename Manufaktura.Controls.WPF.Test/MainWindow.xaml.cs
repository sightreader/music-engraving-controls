using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Music.MelodicTrails;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using Manufaktura.Music.RhythmicTrails;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Manufaktura.Controls.WPF.Test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			LoadTestModel();
			/*
			var scale = MajorScale.G;
			IMelodicTrail melodicTrail = new ConjunctMovementTrail(MovementType.Anabasis, Pitch.G3, Pitch.C6, 8, 12);
			IRhythmicTrail rhytmicTrail = new PolonaiseRhythmicTrail();
			var rhythmicUnits = rhytmicTrail.BuildRhythm(4).ToArray();
			var melody = melodicTrail.BuildMelody(scale, Pitch.G4).ToArray();
			var notes = new List<Note>();
			for (int i = 0; i < melody.Count(); i++)
			{
				notes.Add(Note.FromPitch(melody[i], rhythmicUnits[i].Duration));
			}

			var score = Score.CreateOneStaffScore(Clef.Treble, scale);
			score.FirstStaff.Elements.AddRange(notes);
			noteViewer1.ScoreSource = score;

			melodicTrail = new ConjunctMovementTrail(MovementType.Katabasis, Pitch.G3, Pitch.C6, 8, 12);
			notes = melodicTrail.BuildMelody(scale, Pitch.G4).Select(p => Note.FromPitch(p, RhythmicDuration.Whole)).ToList();
			score = Score.CreateOneStaffScore(Clef.Bass, scale);
			score.FirstStaff.Elements.AddRange(notes);
			noteViewer2.ScoreSource = score;

			melodicTrail = new ConjunctMovementTrail(MovementType.Metabasis, Pitch.G3, Pitch.C6, 8, 12);
			notes = melodicTrail.BuildMelody(scale, Pitch.G4).Select(p => Note.FromPitch(p, RhythmicDuration.Whole)).ToList();
			score = new Score();
			var staff = new Staff();
			staff.Elements.Add(Clef.Treble);
			staff.Elements.Add(Key.FromScale(scale));
			staff.Elements.AddRange(notes);
			score.Staves.Add(staff);
			noteViewer3.ScoreSource = score;
			*/
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "MusicXml (*.xml)|*.xml";
			if (dialog.ShowDialog().Value)
			{
				string xml = File.ReadAllText(dialog.FileName);
				noteViewer1.XmlSource = xml;
				MusicXmlParser parser = new MusicXmlParser();
				noteViewer2.ScoreSource = parser.Parse(XDocument.Parse(xml));
			}
		}

		private async void LoadTestModel()
		{
			//await Task.Factory.StartNew(() => Thread.Sleep(1000));
			var vm = new TestViewModel();

			DataContext = vm;
			vm.LoadTestData();
		}

		
		int systemSpacing = 0;
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			int delta = 0;
			systemSpacing += 2;
			foreach (var system in noteViewer1.InnerScore.Systems)
			{
				noteViewer1.MoveLayout(system, new Point(0, delta));
				delta += systemSpacing;
			}
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			var elements = noteViewer1.InnerScore.Staves.SelectMany(s => s.Elements).Where(x => x.Measure != null && x.Measure.System == noteViewer1.InnerScore.Systems[1]);
			foreach (var element in elements) element.CustomColor = Primitives.Color.Red;
		}
	}
}