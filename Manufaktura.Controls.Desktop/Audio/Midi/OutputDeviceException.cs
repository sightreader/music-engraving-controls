using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Manufaktura.Controls.Desktop.Audio.Midi
{
	/// <summary>
	/// The exception that is thrown when a error occurs with the OutputDevice
	/// class.
	/// </summary>
	public class OutputDeviceException : Exception
	{
		// The error message.
		private StringBuilder message = new StringBuilder(128);

		/// <summary>
		/// Initializes a new instance of the OutputDeviceException class with
		/// the specified error code.
		/// </summary>
		/// <param name="errCode">
		/// The error code.
		/// </param>
		public OutputDeviceException(int errCode)
		{
			// Get error message.
			midiOutGetErrorText(errCode, message, message.Capacity);
		}

		/// <summary>
		/// Gets a message that describes the current exception.
		/// </summary>
		public override string Message
		{
			get
			{
				return message.ToString();
			}
		}

		[DllImport("winmm.dll")]
		private static extern int midiOutGetErrorText(int errCode,
			StringBuilder message, int sizeOfMessage);
	}
}