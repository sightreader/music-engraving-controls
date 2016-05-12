using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.Digest;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Manufaktura.Controls.Silverlight.Test
{
	public partial class MainPage : UserControl
	{
		private XnaScorePlayer player;

		public MainPage()
		{
			InitializeComponent();

			var score = Score.CreateOneStaffScore(Clef.Treble, new MajorScale(Step.C, false));
			score.FirstStaff.Elements.Add(new Note(Pitch.C4, RhythmicDuration.Quarter));
			score.FirstStaff.Elements.Add(new Note(Pitch.E4, RhythmicDuration.Quarter) { IsUpperMemberOfChord = true });
			score.FirstStaff.Elements.Add(new Note(Pitch.G4, RhythmicDuration.Quarter) { IsUpperMemberOfChord = true });
			score.FirstStaff.Elements.Add(new Note(Pitch.D4, RhythmicDuration.Quarter) { Voice = 2 });
			score.FirstStaff.Elements.Add(new Note(Pitch.E4, RhythmicDuration.Quarter));
			score.FirstStaff.Elements.Add(new Note(Pitch.F4, RhythmicDuration.Quarter));
			score.FirstStaff.Elements.Add(new Note(Pitch.G4, RhythmicDuration.Quarter));
			score.FirstStaff.Elements.Add(new Note(Pitch.A4, RhythmicDuration.Quarter));
			score.FirstStaff.Elements.Add(new Note(Pitch.B4, RhythmicDuration.Quarter));
			score.FirstStaff.Elements.Add(new Note(Pitch.C5, RhythmicDuration.Quarter));
			noteViewer1.ScoreSource = score;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "MusicXml (*.xml)|*.xml";
			Score score = null;
			string scoreXml;
			if (dialog.ShowDialog().Value)
			{
				System.IO.Stream fileStream = dialog.File.OpenRead();

				using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
				{
					scoreXml = reader.ReadToEnd();
				}
				fileStream.Close();

				score = scoreXml.ToScore();
				noteViewer1.ScoreSource = score;
				noteViewer3.ScoreSource = scoreXml.ToScore();

				//MusicXmlNormalizer normalizer = new MusicXmlNormalizer() { NormalizeSpaceBeforeFirstNotesOfMeasures = true };
				//noteViewer2.XmlTransformations = new[] { normalizer };
				//noteViewer2.XmlSource = scoreXml;

				MelodicContourDigestParser digestParser = new MelodicContourDigestParser();
				int[] results = digestParser.ParseBack(score);

				LyricsDigestParser lyricsParser = new LyricsDigestParser();
				string lyrics = lyricsParser.ParseBack(score);
				//MessageBox.Show(string.Join(", ", results));
			}
		}

		private void Play_Click(object sender, RoutedEventArgs e)
		{
			player = new XnaScorePlayer(noteViewer1.ScoreSource);
			//player.ElementPlayed += player_ElementPlayed;
			player.Dispatcher = noteViewer1.Dispatcher;
			var binding = new Binding("ThreadSafeCurrentElement");
			binding.Source = player;
			noteViewer1.SetBinding(NoteViewer.SelectedElementProperty, binding);
			player.Play();
		}

		private void player_ElementPlayed(object sender, XnaScorePlayer.MusicalSymbolEventArgs e)
		{
			noteViewer1.Dispatcher.BeginInvoke(new Action(() => { noteViewer1.Select(e.Element); }));
		}
	}
}