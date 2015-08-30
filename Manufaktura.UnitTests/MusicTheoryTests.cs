using Manufaktura.Music.MelodicTrails;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using Manufaktura.Music.RhythmicTrails;
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
            var translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Unison);
            Assert.AreEqual(translatedPitch, Step.A);
            translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Second);
            Assert.AreEqual(translatedPitch, Step.B);
            translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Third);
            Assert.AreEqual(translatedPitch, Step.C);
            translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Fourth);
            Assert.AreEqual(translatedPitch, Step.D);
            translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Fifth);
            Assert.AreEqual(translatedPitch, Step.E);
            translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Sixth);
            Assert.AreEqual(translatedPitch, Step.FSharp);
            translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Seventh);
            Assert.AreEqual(translatedPitch, Step.G);
            translatedPitch = scale.TranslatePitch(secondStep, DiatonicInterval.Octave);
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
            IMelodicTrail melodicTrail = new HeadMotiveTrail(Pitch.G3, Pitch.C6, 4, 8);
            var melody = melodicTrail.BuildMelody(scale, Pitch.G4);
            melody = melodicTrail.BuildMelody(scale, Pitch.G4);
            melody = melodicTrail.BuildMelody(scale, Pitch.G4);

            melodicTrail = new ConjunctMovementTrail(MovementType.Anabasis, Pitch.G3, Pitch.C6, 4, 8);
            melody = melodicTrail.BuildMelody(scale, Pitch.G4);
            melody = melodicTrail.BuildMelody(scale, Pitch.G4);
            melody = melodicTrail.BuildMelody(scale, Pitch.G4);
        }

        [TestMethod]
        public void RhythmGenerationTest()
        {
            var rhythm = new PolonaiseRhythmicTrail().BuildRhythm(8);
        }

        [TestMethod]
        public void ChordsTest()
        {
            var chord = Chord.CreateChord(Pitch.C4, 0, 2, MajorScale.C);
            MusicalAssertions.StepsMatch(chord.Pitches, Step.C, Step.E, Step.G).Assert();
            chord = Chord.CreateChord(Pitch.G4, 0, MajorScale.C);
            MusicalAssertions.StepsMatch(chord.Pitches, Step.G, Step.B, Step.D).Assert();
            chord = Chord.Create7thChord(Pitch.C4, 0, MajorScale.C);
            MusicalAssertions.StepsMatch(chord.Pitches, Step.C, Step.E, Step.G, Step.Bb).Assert();
            chord = Chord.Create7thChord(Pitch.C4, 1, MajorScale.C);
            MusicalAssertions.StepsMatch(chord.Pitches, Step.E, Step.G, Step.Bb, Step.C).Assert();
            chord = Chord.Create7thChord(Pitch.C4, 2, MajorScale.C);
            MusicalAssertions.StepsMatch(chord.Pitches,  Step.G, Step.Bb, Step.C, Step.E).Assert();
            chord = Chord.Create7thChord(Pitch.C4, 3, MajorScale.C);
            MusicalAssertions.StepsMatch(chord.Pitches, Step.Bb, Step.C, Step.E, Step.G).Assert();
            MusicalAssertions.Throws<ArgumentException>(() => Chord.Create7thChord(Pitch.C4, 4, MajorScale.C)).Assert();
        }
    }
}
