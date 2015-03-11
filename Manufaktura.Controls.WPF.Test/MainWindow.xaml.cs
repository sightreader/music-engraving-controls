using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Music.MelodicTrails;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

            var scale = MajorScale.G;
            IMelodicTrail melodicTrail = new ConjunctMovementTrail(MovementType.Anabasis, Pitch.G3, Pitch.C6, 8, 12);
            var notes = melodicTrail.BuildMelody(scale, Pitch.G4).Select(p => Note.FromPitch(p, RhythmicDuration.Whole));
            var score = Score.CreateOneStaffScore(Clef.Treble, scale);
            score.FirstStaff.Elements.AddRange(notes);
            noteViewer1.ScoreSource = score;

            melodicTrail = new ConjunctMovementTrail(MovementType.Katabasis, Pitch.G3, Pitch.C6, 8, 12);
            notes = melodicTrail.BuildMelody(scale, Pitch.G4).Select(p => Note.FromPitch(p, RhythmicDuration.Whole));
            score = Score.CreateOneStaffScore(Clef.Bass, scale);
            score.FirstStaff.Elements.AddRange(notes);
            noteViewer2.ScoreSource = score;

            melodicTrail = new ConjunctMovementTrail(MovementType.Metabasis, Pitch.G3, Pitch.C6, 8, 12);
            notes = melodicTrail.BuildMelody(scale, Pitch.G4).Select(p => Note.FromPitch(p, RhythmicDuration.Whole));
            score = new Score();
            var staff = new Staff();
            staff.Elements.Add(Clef.Treble);
            staff.Elements.Add(Controls.Model.Key.FromScale(scale));
            staff.Elements.AddRange(notes);
            score.Staves.Add(staff);
            noteViewer3.ScoreSource = score;
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
    }
}
