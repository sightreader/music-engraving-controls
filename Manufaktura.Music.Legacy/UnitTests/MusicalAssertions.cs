using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.UnitTests
{
    public static class MusicalAssertions
    {
        public static AssertionResult Throws<TException>(Action action) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                return AssertionResult.Success();
            }
            return AssertionResult.Failure("Exception of type {0} has not been thrown.", typeof(TException).Name);
        }

        public static AssertionResult ThrowsMalformedScaleException(Action action)
        {
            return Throws<MalformedScaleException>(action);
        }

        public static AssertionResult StepsMatch(IEnumerable<Step> steps, params Step[] stepsToCompare)
        {
            if (steps == null) throw new ArgumentNullException("steps");
            if (stepsToCompare == null) throw new ArgumentNullException("stepsToCompare");

            var stepsArray = steps.ToArray();
            if (stepsArray.Length != stepsToCompare.Length)
                return AssertionResult.Failure("Number of steps does not match.");
            for (int i = 0; i < stepsArray.Length; i++)
            {
                if (stepsArray[i] != stepsToCompare[i])
                    return AssertionResult.Failure("Step at index {0} does not match. Expected {1} but was {2}.", i, stepsToCompare[i], stepsArray[i]);
            }
            return AssertionResult.Success();
        }

        public class AssertionResult
        {
            public bool IsSuccess { get; protected set; }
            public string Message { get; protected set; }

            protected AssertionResult(bool result, string message)
            {
                IsSuccess = result;
                Message = message;
            }

            public static AssertionResult Success()
            {
                return new AssertionResult(true, null);
            }

            public static AssertionResult Failure(string format, params object[] parameters)
            {
                return new AssertionResult(false, string.Format(format, parameters));
            }
        }
    }
}
