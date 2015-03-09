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
            Assert.IsTrue(Duration.Half + Duration.Half == Duration.Whole);
            Assert.IsTrue(Duration.Quarter + Duration.Eighth == Duration.Eighth + Duration.Quarter);
            Assert.IsTrue(Duration.Half.ToTimeSpan(Tempo.Allegro) + Duration.Half.ToTimeSpan(Tempo.Allegro) == Duration.Whole.ToTimeSpan(Tempo.Allegro));
            Assert.IsTrue(Duration.Half.ToFractionOf(Duration.Whole) == 0.5);
            Assert.IsFalse (Duration.Half.ToTimeSpan(Tempo.Allegro) + Duration.Half.ToTimeSpan(Tempo.Allegro) == Duration.Whole.ToTimeSpan(Tempo.Adagio));
        }

    }
}
