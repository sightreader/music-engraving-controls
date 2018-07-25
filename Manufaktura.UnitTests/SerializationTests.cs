using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

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
                var bboxesAsProxy = (LazyLoadJsonProxy)bboxes;
                var elapsedWithProxy = metadataAsProxy.TotalTimeSpentOnDeserialization + bboxesAsProxy.TotalTimeSpentOnDeserialization;

                Debug.WriteLine(elapsedWithProxy);
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
    }
}