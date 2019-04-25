using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering.Implementations;
using Manufaktura.Controls.SMuFL;
using Manufaktura.Controls.SMuFL.EagerLoading;
using Manufaktura.Core.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

namespace Manufaktura.Orm.UnitTests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void JsonDeserializationTestWithProxy()
        {
            var assembly = typeof(SerializationTests).Assembly;
            var resourceName = $"{typeof(SerializationTests).Namespace}.Assets.bravura_metadata.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                var metadata = LazyLoadJsonProxy<ISMuFLFontMetadata>.Create(result);
                var defaults = metadata.EngravingDefaults;

                var bboxes = metadata.GlyphBBoxes;
                var prop1 = bboxes.AccdnCombDot;
                var prop2 = bboxes.WindTightEmbouchure;
                var prop3 = bboxes.WindRimOnly;
                var prop4 = bboxes.MensuralLongaVoidStemDownRight;
                var prop5 = bboxes.AccSagittalFlat11LDown;
                var prop6 = bboxes.NoteheadSquareBlackWhite;
                var prop7 = bboxes.NoteheadWholeWithX;
                var prop8 = bboxes.ElecMixingConsole;
                var prop9 = bboxes.ElecPause;
                var prop10 = bboxes.PictBeaterWoodTimpaniUp;
                var prop11 = bboxes.AccdnCombLh2RanksEmpty;
                var prop12 = bboxes.AccSagittalSharp5V13LUp;
                var prop13 = bboxes.MensuralNoteheadLongaWhite;
                var prop14 = bboxes.OrnamentTrill;
                var prop15 = bboxes.OrnamentTremblementCouperin;
                var prop16 = bboxes.AccSagittalSharp19SUp;
                var prop17 = bboxes.NoteShapeRoundDoubleWhole;
                var prop18 = bboxes.WindWeakAirPressure;
                var prop19 = bboxes.WindRelaxedEmbouchure;
                var prop20 = bboxes.AccdnCombLh2RanksEmpty;

                var metadataAsProxy = (LazyLoadJsonProxy)metadata;
                var elapsedWithProxy = metadataAsProxy.GetTotalDeserializationTimeWithChildElements();
                var cacheDump = metadataAsProxy.DumpCache(typeof(ISMuFLFontMetadata));

                Debug.WriteLine(elapsedWithProxy);
            }
        }

        [TestMethod]
        public void JsonDeserializationTestWithDynamicProxyOnRealExample() =>
            JsonDeserializationTestWithProxyOnRealExample(SMuFLMusicFont.JSONLoadingModes.LazyWithDynamicProxy);

        [TestMethod]
        public void JsonDeserializationTestWithStaticProxyOnRealExample() =>
            JsonDeserializationTestWithProxyOnRealExample(SMuFLMusicFont.JSONLoadingModes.LazyWithStaticProxy);

        private void JsonDeserializationTestWithProxyOnRealExample(SMuFLMusicFont.JSONLoadingModes loadingMode)
        {
            var assembly = typeof(SerializationTests).Assembly;
            var scoreResourceName = $"{typeof(SerializationTests).Namespace}.Assets.JohannChristophBachFull30.xml";

            using (var scoreStream = assembly.GetManifestResourceStream(scoreResourceName))
            using (var scoreReader = new StreamReader(scoreStream))
            {
                var sw = new Stopwatch();
                sw.Start();

                var scoreString = scoreReader.ReadToEnd();
                var settings = new HtmlScoreRendererSettings();
                settings.RenderSurface = HtmlScoreRendererSettings.HtmlRenderSurface.Svg;
                var profile = SMuFLMusicFont.CreateFromJsonResource<SerializationTests>("Assets.bravura_metadata.json", loadingMode);
                settings.SetMusicFont(profile, "Bravura", "/fakeuri");
                settings.Scale = 1;
                settings.CustomElementPositionRatio = 0.8;
                settings.IgnorePageMargins = true;
                var renderer = new HtmlSvgScoreRenderer(new XElement("root"), "testCanvas", settings);

                renderer.Render(scoreString.ToScore());

                sw.Stop();

                var metadataAsProxy = profile.SMuFLMetadata as LazyLoadJsonProxy;
                if (metadataAsProxy != null)
                {
                    Debug.WriteLine($"All rendering done in {sw.Elapsed}");
                    var deserTime = metadataAsProxy.GetTotalDeserializationTimeWithChildElements();
                    Debug.WriteLine($"Deserialization done in {deserTime}");

                    var cacheDump = metadataAsProxy.DumpCache(typeof(ISMuFLFontMetadata));
                }
            }
        }

        [TestMethod]
        public void JsonDeserialziationTestWithoutProxy()
        {
            var assembly = typeof(SerializationTests).Assembly;
            var resourceName = $"{typeof(SerializationTests).Namespace}.Assets.bravura_metadata.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();

                var sw = new Stopwatch();
                sw.Start();
                var traditionallyLoadedMetadata = JsonConvert.DeserializeObject<SMuFLFontMetadata>(result); //TODO: it must be cached. How to clear cache?
                sw.Stop();

                Debug.WriteLine(sw.Elapsed);
            }
        }

        [TestMethod]
        public void TestBinarySerialization()
        {
            var profile = SMuFLMusicFont.CreateFromJsonResource<SerializationTests>("Assets.bravura_metadata.json", SMuFLMusicFont.JSONLoadingModes.Eager);
            using (var ms = new MemoryStream())
            {
                var serializationSw = new Stopwatch();
                serializationSw.Start();
                profile.SerializeMetadataAsBinary(ms);
                serializationSw.Stop();
                var serializedData = ms.ToArray();

                var deserializationSw = new Stopwatch();
                deserializationSw.Start();
                var newProfile = SMuFLMusicFont.CreateFromBinaryArray(serializedData);
                deserializationSw.Stop();

                Debug.WriteLine($"Serialization: {serializationSw.Elapsed}, Deserialization: {deserializationSw.Elapsed}");
            }
        }
    }
}