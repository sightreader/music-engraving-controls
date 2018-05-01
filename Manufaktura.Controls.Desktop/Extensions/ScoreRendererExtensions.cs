using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.IO;

namespace Manufaktura.Controls.Desktop.Extensions
{
    public static class ScoreRendererExtensions
    {
        public static byte[] GetSMuFLMetadataAsBinary(this ScoreRendererSettings settings)
        {
            if (settings.CurrentSMuFLMetadata == null) return null;

            var ms = new MemoryStream();
            using (var writer = new BsonDataWriter(ms))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(writer, settings.CurrentSMuFLMetadata);
                return ms.ToArray();
            }
        }

        public static void LoadSMuFLMetadataFromBinaryStream(this ScoreRendererSettings settings, Stream stream)
        {
            settings.CurrentSMuFLMetadata = settings.DeserializeSMuFLBinaryMetadata(stream);
        }

        public static SMuFLFontMetadata DeserializeSMuFLBinaryMetadata(this ScoreRendererSettings settings, Stream stream)
        {
            using (BsonDataReader reader = new BsonDataReader(stream))
            {
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize<SMuFLFontMetadata>(reader);
            }
        }

        public static void SaveSMuFLMetadataAsBinary(this ScoreRendererSettings settings, string filePath)
        {
            var bytes = GetSMuFLMetadataAsBinary(settings);
            File.WriteAllBytes(filePath, bytes);
        }
    }
}