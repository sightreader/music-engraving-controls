using Manufaktura.Music.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void ProportionTest()
        {
            Assert.AreEqual((Proportion.Sesquialtera + new Proportion(1, 2)).DecimalValue, 2);
            Assert.IsTrue((Proportion.Sesquialtera + new Proportion(1, 2)) == 2);
        }

        [TestMethod]
        public void DurationTest()
        {
            Assert.IsTrue(RhythmicDuration.Half + RhythmicDuration.Half == RhythmicDuration.Whole);
            Assert.IsTrue(RhythmicDuration.Quarter + RhythmicDuration.Eighth == RhythmicDuration.Eighth + RhythmicDuration.Quarter);
            Assert.IsTrue(RhythmicDuration.Half.ToTimeSpan(Tempo.Allegro) + RhythmicDuration.Half.ToTimeSpan(Tempo.Allegro) == RhythmicDuration.Whole.ToTimeSpan(Tempo.Allegro));
            Assert.IsTrue(RhythmicDuration.Half.ToFractionOf(RhythmicDuration.Whole) == 0.5);
            var halfNoteTimeSpan = RhythmicDuration.Half.ToTimeSpan(Tempo.Allegro);
            var wholeNoteTimeSpan = RhythmicDuration.Whole.ToTimeSpan(Tempo.Adagio);
            Assert.IsFalse (halfNoteTimeSpan + halfNoteTimeSpan == wholeNoteTimeSpan);
        }

    }
}
