using Manufaktura.Controls.Model;
using System;

namespace Manufaktura.Controls.Parser
{
    public class ScoreWriterException : Exception
    {
        public ScoreWriterException(object element, string message) : base(message)
        {
            FaultyElement = element;
        }

        public object FaultyElement { get; private set; }
    }
}