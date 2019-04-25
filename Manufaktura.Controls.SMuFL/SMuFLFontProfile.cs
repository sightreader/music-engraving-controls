using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Polenter.Serialization;
using System.IO;

namespace Manufaktura.Controls.SMuFL
{
    public class SMuFLFontProfile : FontProfile
    {
        private readonly IMusicFont musicFont;

        private ISMuFLFontMetadata metadata;

        internal SMuFLFontProfile(ISMuFLFontMetadata metadata, ISMuFLGlyphs glyphsInstance)
        {
            this.metadata = metadata;
            musicFont = new SMuFLMusicFont(glyphsInstance);
        }

        public override IMusicFont MusicFont => musicFont;
        public override ISMuFLFontMetadata SMuFLMetadata => metadata;

        public void SerializeMetadataAsBinary(Stream outputStream)
        {
            var settings = new SharpSerializerBinarySettings(BinarySerializationMode.SizeOptimized);
            var serializer = new SharpSerializer(settings);
            serializer.Serialize(SMuFLMetadata, outputStream);
        }
    }
}