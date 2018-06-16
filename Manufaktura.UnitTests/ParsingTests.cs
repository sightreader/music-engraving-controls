using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.Digest;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Manufaktura.Orm.UnitTests
{
    [TestClass]
    public class ParsingTests
    {
        [TestMethod]
        public void TestRhythmRelativeDigestParser()
        {
            var score = Score.CreateOneStaffScore(Clef.Treble, MajorScale.C);
            score.FirstStaff.AddRange(Enumerable.Repeat(Pitch.C4, 9).AddRhythm("4 4 8 8 4. 2 8 16 1"));
            var digest = new RhythmRelativeDigestParser().ParseBack(score);
            Assert.IsFalse(digest.Contains("0"));
        }
    }
}