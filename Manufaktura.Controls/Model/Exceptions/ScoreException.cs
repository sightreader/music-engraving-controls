using Manufaktura.Controls.Model;
using System;

namespace Manufaktura.Controls.Model.Exceptions
{
    public class ScoreException : Exception
    {
        public ScoreException(object element, string message) : base(message)
        {
            FaultyElement = element;
        }

        public object FaultyElement { get; private set; }
    }
}