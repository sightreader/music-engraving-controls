using Manufaktura.Music.Model;
using Manufaktura.Music.MusicTheory.Model.MajorAndMinor;
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
    public class MusicTheoryTests
    {
        [TestMethod]
        public void BuildMajorScaleTest()
        {
            var majorScale = new MajorScale(Step.G, false);
            Debug.WriteLine("G-dur");
            foreach (var pitch in majorScale.BuildScale(1, 8))
            {
                Debug.WriteLine(pitch.ToString());
            }

            majorScale = new MajorScale(Step.B, false);
            Debug.WriteLine("H-dur");
            foreach (var pitch in majorScale.BuildScale(1, 8))
            {
                Debug.WriteLine(pitch.ToString());
            }

            majorScale = new MajorScale(Step.B, true);
            Debug.WriteLine("B-dur??"); //TODO: Rzucać wyjątek w takiej sytuacji, bo powinno być B, a nie H
            foreach (var pitch in majorScale.BuildScale(1, 8))
            {
                Debug.WriteLine(pitch.ToString());
            }

            majorScale = new MajorScale(Step.Bb, true);
            Debug.WriteLine("B-dur");
            foreach (var pitch in majorScale.BuildScale(1, 8))
            {
                Debug.WriteLine(pitch.ToString());
            }
        }
    }
}
