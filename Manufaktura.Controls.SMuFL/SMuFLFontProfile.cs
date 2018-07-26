using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;

namespace Manufaktura.Controls.SMuFL
{
    public class SMuFLFontProfile : FontProfile
    {
        private readonly IMusicFont musicFont = new SMuFLMusicFont();

        private ISMuFLFontMetadata metadata;
        internal SMuFLFontProfile(ISMuFLFontMetadata metadata)
        {
            this.metadata = metadata;
        }

        public override IMusicFont MusicFont => musicFont;
        public override ISMuFLFontMetadata SMuFLMetadata => metadata;
    }
}