using Manufaktura.Music.MelodicTrails;
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

namespace Manufaktura.UnitTests
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

        [TestMethod]
        public void DiatonicIntervalTranslationsTest()
        {
            var scale = new MajorScale(Step.G, false);
            var pitches = scale.BuildScale(1, 8);

            var secondStep = pitches.ElementAt(1);
            var translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Unison);
            Assert.AreEqual(translatedPitch, Step.A);
            translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Second);
            Assert.AreEqual(translatedPitch, Step.B);
            translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Third);
            Assert.AreEqual(translatedPitch, Step.C);
            translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Fourth);
            Assert.AreEqual(translatedPitch, Step.D);
            translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Fifth);
            Assert.AreEqual(translatedPitch, Step.E);
            translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Sixth);
            Assert.AreEqual(translatedPitch, Step.FSharp);
            translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Seventh);
            Assert.AreEqual(translatedPitch, Step.G);
            translatedPitch = scale.TranslatePitch(secondStep, IntervalBase.Octave);
            Assert.AreEqual(translatedPitch, Step.A);
        }

        [TestMethod]
        public void ChromaticIntervalTranslationsTest()
        {
            var scale = new MajorScale(Step.G, false);
            var pitches = scale.BuildScale(1, 8);

            var secondStep = pitches.ElementAt(1);
            var translatedPitch = scale.TranslatePitch(secondStep, Interval.MajorThird);
            Assert.AreEqual(translatedPitch, Step.CSharp);
        }

        [TestMethod]
        public void MelodyGenerationTest()
        {
            var scale = new MajorScale(Step.G, false);
            var melodicTrail = new HeadMotiveMelodicTrail();
            var melody = melodicTrail.BuildMelody(scale, Pitch.G4);
            melody = melodicTrail.BuildMelody(scale, Pitch.G4);
            melody = melodicTrail.BuildMelody(scale, Pitch.G4);
        }
    }
}
