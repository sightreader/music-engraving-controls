using Manufaktura.Controls.SMuFL;
using Manufaktura.Controls.WPF;
using System;
using System.Windows.Media;

namespace Manufaktura.VisualTests.Configurators
{
    public class BravuraFontConfigurator : IFontConfigurator
    {
        private static FontFamily BravuraFamily = new DummyControl().bravuraTextBlock.FontFamily;

        private static Lazy<SMuFLFontProfile> fontProfile = new Lazy<SMuFLFontProfile>(() => SMuFLMusicFont.CreateFromJsonResource<Tests>("Assets.bravura_metadata.json"));

        public void Configure(NoteViewer noteViewer)
        {
            noteViewer.SetFont(BravuraFamily, fontProfile.Value);
        }
    }
}