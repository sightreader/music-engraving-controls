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
        public void JsonSerializationTest()
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

                var sw = new Stopwatch();
                sw.Start();
                var traditionallyLoadedMetadata = JsonConvert.DeserializeObject<SMuFLFontMetadata>(result); //TODO: it must be cached. How to clear cache?
                sw.Stop();

                var metadataAsProxy = (LazyLoadJsonProxy<ISMuFLFontMetadata>)metadata;
                var elapsedWithProxy = new TimeSpan(metadataAsProxy.PerformanceLog.Sum(pl => pl.Value.Ticks));
                Assert.IsTrue(elapsedWithProxy < sw.Elapsed); 
            }
        }
    }
}