using System;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Exception indicating that musical scale is malformed
    /// </summary>
    public class MalformedScaleException : Exception
    {
        public MalformedScaleException(string message) : base(message)
        {
        }

        public MalformedScaleException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}