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
		#region OutputDeviceException Members

		#region Win32 Midi Output Error Function

		[DllImport("winmm.dll")]
		private static extern int midiOutGetErrorText(int errCode,
			StringBuilder message, int sizeOfMessage);

		#endregion Win32 Midi Output Error Function

		#region Fields

		// The error message.
		private StringBuilder message = new StringBuilder(128);

		#endregion Fields

		#region Construction

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

		#endregion Construction

		#region Properties

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

		#endregion Properties

		#endregion OutputDeviceException Members
	}
}