using Manufaktura.Controls.Model;
using System;
using System.Runtime.InteropServices;

namespace Manufaktura.Controls.Desktop.Audio.Midi
{
	public class MidiDevice : IDisposable
	{
		public string Name;

		protected readonly object lockObject = new object();

		// The device handle.
		protected int hndle = 0;

		private int deviceId;

		/// <summary>
		/// Initializes a new instance of the OutputDevice class.
		/// </summary>
		public MidiDevice(int deviceID, string name)
		{
			Name = name;
			this.deviceId = deviceID;
		}

		protected delegate void GenericDelegate<T>(T args);

		// Represents the method that handles messages from Windows.
		protected delegate void MidiOutProc(int handle, int msg, int instance, int param1, int param2);

		public static int DeviceCount
		{
			get
			{
				return midiOutGetNumDevs();
			}
		}

		public int Handle
		{
			get
			{
				return hndle;
			}
		}

		public static MidiOutCaps GetDeviceCapabilities(int deviceID)
		{
			MidiOutCaps caps = new MidiOutCaps();

			// Get the device's capabilities.
			int result = midiOutGetDevCaps(deviceID, ref caps, Marshal.SizeOf(caps));

			// If the capabilities could not be retrieved.
			if (result != 0)
			{
				// Throw an exception.
				throw new OutputDeviceException(result);
			}

			return caps;
		}

		public void Dispose()
		{
			midiOutClose(Handle);
		}

		public void Open()
		{
			int result = midiOutOpen(ref hndle, deviceId, (i1, i2, i3, i4, i5) => { }, 0, 0);

			if (result != 0)
			{
				throw new OutputDeviceException(result);
			}
		}

		public void Send(Note note, bool on, int channel)
		{
			ChannelMessageBuilder builder = new ChannelMessageBuilder();
			builder.MidiChannel = channel;
			builder.Data1 = note.MidiPitch;

			if (on)
			{
				builder.Command = ChannelCommand.NoteOn;
				builder.Data2 = 127;
			}
			else
			{
				builder.Command = ChannelCommand.NoteOff;
				builder.Data2 = 0;
			}
			builder.Build();

			Send(builder.Result);
		}

		public virtual void Send(ChannelMessage message)
		{
			Send(message.Message);
		}

		public override string ToString()
		{
			return Name;
		}

		[DllImport("winmm.dll")]
		protected static extern int midiOutGetDevCaps(int deviceID,
			ref MidiOutCaps caps, int sizeOfMidiOutCaps);

		[DllImport("winmm.dll")]
		protected static extern int midiOutGetNumDevs();

		[DllImport("winmm.dll")]
		protected static extern int midiOutLongMsg(int handle,
			IntPtr headerPtr, int sizeOfMidiHeader);

		[DllImport("winmm.dll")]
		protected static extern int midiOutPrepareHeader(int handle,
			IntPtr headerPtr, int sizeOfMidiHeader);

		[DllImport("winmm.dll")]
		protected static extern int midiOutReset(int handle);

		[DllImport("winmm.dll")]
		protected static extern int midiOutShortMsg(int handle, int message);

		[DllImport("winmm.dll")]
		protected static extern int midiOutUnprepareHeader(int handle,
			IntPtr headerPtr, int sizeOfMidiHeader);

		protected void Send(int message)
		{
			lock (lockObject)
			{
				int result = midiOutShortMsg(Handle, message);

				if (result != 0)
				{
					throw new OutputDeviceException(result);
				}
			}
		}

		[DllImport("winmm.dll")]
		private static extern int midiOutClose(int handle);

		[DllImport("winmm.dll")]
		private static extern int midiOutOpen(ref int handle, int deviceID,
			MidiOutProc proc, int instance, int flags);
	}
}