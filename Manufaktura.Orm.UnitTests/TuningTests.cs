using Manufaktura.Music.Model;
using Manufaktura.Music.Tuning;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests
{
    [TestClass]
    public class TuningTests
    {
        [TestMethod]
        public void TuningTest()
        {
            var tuning = new PythagoreanTuning(Pitch.C4);
            var comma = tuning.CommaBetweenLastIntervalAndPerfectOctave;
            
        }
    }
}
