using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using Manufaktura.Music.Tuning;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests
{
    [TestClass]
    public class TuningTests
    {
        [TestMethod]
        public void PythagoreanTuningTest()
        {
            var tuning = new PythagoreanTuning(Pitch.C4);
            var comma = tuning.CommaBetweenLastIntervalAndPerfectOctave;

            var scale = new MajorScale(Step.G, false);
            foreach (var pitch in scale.BuildScale(1, 9))
            {
                var tp = pitch.Tune(new TunedPitch(Pitch.A4, 440), tuning);
                Debug.WriteLine(tp.ToString());
            }
        }

        [TestMethod]
        public void TertianTuningTest()
        {
            var tuning = new TertianTuning(Pitch.C4);
            var comma = tuning.CommaBetweenLastIntervalAndPerfectOctave;

            var scale = new MajorScale(Step.G, false);
            foreach (var pitch in scale.BuildScale(1, 9))
            {
                var tp = pitch.Tune(new TunedPitch(Pitch.A4, 440), tuning);
                Debug.WriteLine(tp.ToString());
            }
        }
    }
}
