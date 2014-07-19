using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
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
                score = parser.Parse(scoreXml);
                noteViewer1.ScoreSource = score;
                noteViewer2.XmlSource = scoreXml;
            }
        }
    }
}
