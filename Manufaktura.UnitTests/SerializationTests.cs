using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests
{
    [TestClass]
   public  class SerializationTests
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
            }
        
        }
    }
}
