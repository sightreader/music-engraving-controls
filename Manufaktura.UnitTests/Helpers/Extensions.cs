using Manufaktura.Music.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.UnitTests.Helpers
{
    public static class Extensions
    {
        public static void Assert(this MusicalAssertions.AssertionResult result) 
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result.IsSuccess, result.Message);
        }
    }
}
