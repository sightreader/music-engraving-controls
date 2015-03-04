using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using Manufaktura.Music.UnitTests;
using Manufaktura.UnitTests.Helpers;
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
            var scale = new MajorScale(Step.G, false);
            var steps = scale.BuildScale(1, 8);
            MusicalAssertions.StepsMatch(steps, Step.G, Step.A, Step.B, Step.C, Step.D, Step.E, Step.FSharp, Step.G).Assert();

            scale = new MajorScale(Step.B, false);
            steps = scale.BuildScale(1, 8);
            MusicalAssertions.StepsMatch(steps, Step.B, Step.CSharp, Step.DSharp, Step.E, Step.FSharp, Step.GSharp, Step.ASharp, Step.B).Assert();

            scale = new MajorScale(Step.Bb, true);
            steps = scale.BuildScale(1, 8);
            MusicalAssertions.StepsMatch(steps, Step.Bb, Step.C, Step.D, Step.Eb, Step.F, Step.G, Step.A, Step.Bb).Assert();

            MusicalAssertions.ThrowsMalformedScaleException(() => scale = new MajorScale(Step.B, true)).Assert();
        }

        [TestMethod]
        public void BuildMinorScaleTest()
        {
            var scale = new MinorScale(Step.A, false);
            var steps = scale.BuildScale(1, 8);
            MusicalAssertions.StepsMatch(steps, Step.A, Step.B, Step.C, Step.D, Step.E, Step.F, Step.G, Step.A).Assert();

            scale = new MinorScale(Step.E, false);
            steps = scale.BuildScale(1, 8);
            MusicalAssertions.StepsMatch(steps, Step.E, Step.FSharp, Step.G, Step.A, Step.B, Step.C, Step.D, Step.E).Assert();

            
        }
    }
}
