using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.UnitTests
{
    public static class MusicalAssertions
    {
        public static bool Throws<TException>(Action action) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                return true;
            }
            return false;
        }

        public static bool ThrowsMalformedScaleException(Action action)
        {
            return Throws<MalformedScaleException>(action);
        }

        public static bool StepsMatch(IEnumerable<Step> steps, params Step[] stepsToCompare)
        {
            var stepsArray = steps.ToArray();
            if (stepsArray.Length != stepsToCompare.Length) return false;
            for (int i = 0; i < stepsArray.Length; i++)
            {
                if (stepsArray[i] != stepsToCompare[i]) return false;
            }
            return true;
        }
    }
}
