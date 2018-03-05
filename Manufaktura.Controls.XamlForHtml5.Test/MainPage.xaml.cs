using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System.Linq;
using Windows.UI.Xaml.Controls;

namespace Manufaktura.Controls.XamlForHtml5.Test
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var score = Score.CreateOneStaffScore(Clef.Treble, MajorScale.C);
            score.FirstStaff.Elements.AddRange(StaffBuilder
                .FromPitches(Pitch.ChromaticRange(Pitch.C4, Pitch.C5, Pitch.MidiPitchTranslationMode.Auto).ToArray())
                .AddRhythm(Enumerable.Repeat(4, 12).ToArray()));

            foreach (var element in score.FirstStaff.Elements)
            {
            }
            viewer.ScoreSource = score;
        }
    }
}