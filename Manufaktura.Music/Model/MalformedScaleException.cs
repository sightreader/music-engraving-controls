using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
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
