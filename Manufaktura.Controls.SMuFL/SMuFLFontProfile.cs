using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Polenter.Serialization;
using System.IO;

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

        public void SerializeMetadataAsBinary(Stream outputStream)
        {
            var settings = new SharpSerializerBinarySettings(BinarySerializationMode.SizeOptimized);
            var serializer = new SharpSerializer(settings);
            serializer.Serialize(SMuFLMetadata, outputStream);
        }
    }
}