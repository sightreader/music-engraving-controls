using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Parser.Digest;
using Manufaktura.Controls.Parser.MusicXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Manufaktura.Controls.Silverlight.Test
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
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

                MusicXmlParser parser = new MusicXmlParser();
                score = parser.Parse(XDocument.Parse(scoreXml));
                noteViewer1.ScoreSource = score;

                MusicXmlNormalizer normalizer = new MusicXmlNormalizer() { NormalizeSpaceBeforeFirstNotesOfMeasures = true };
                noteViewer2.XmlTransformations = new[] { normalizer };
                noteViewer2.XmlSource = scoreXml;

                MelodicContourDigestParser digestParser = new MelodicContourDigestParser();
                int[] results = digestParser.ParseBack(score);
                MessageBox.Show(string.Join(", ", results));
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            XnaScorePlayer player = new XnaScorePlayer(noteViewer1.ScoreSource);
            player.ElementPlayed += player_ElementPlayed;
            player.Start();
        }

        void player_ElementPlayed(object sender, XnaScorePlayer.MusicalSymbolEventArgs e)
        {
            noteViewer1.Dispatcher.BeginInvoke(new Action(() => { noteViewer1.Select(e.Element); }));
        }

    }
}
