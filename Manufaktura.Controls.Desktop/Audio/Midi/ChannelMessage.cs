#region License

/* Copyright (c) 2005 Leslie Sanford
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to
 * deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
 * sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

#endregion License

#region Contact

/*
 * Leslie Sanford
 * Email: jabberdabber@hotmail.com
 */

#endregion Contact

using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Manufaktura.Controls.Desktop.Audio.Midi
{
	/// <summary>
	/// Represents MIDI channel messages.
	/// </summary>
	[ImmutableObject(true)]
	public sealed class ChannelMessage : ShortMessage
	{
		//
		// Bit manipulation constants.
		//

		/// <summary>
		/// Maximum value allowed for MIDI channels.
		/// </summary>
		public const int MidiChannelMaxValue = 15;

		private const int CommandMask = ~240;
		private const int MidiChannelMask = ~15;

		/// <summary>
		/// Initializes a new instance of the ChannelEventArgs class with the
		/// specified command, MIDI channel, and data 1 values.
		/// </summary>
		/// <param name="command">
		/// The command value.
		/// </param>
		/// <param name="midiChannel">
		/// The MIDI channel.
		/// </param>
		/// <param name="data1">
		/// The data 1 value.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// If midiChannel is less than zero or greater than 15. Or if
		/// data1 is less than zero or greater than 127.
		/// </exception>
		public ChannelMessage(ChannelCommand command, int midiChannel, int data1)
		{
			msg = 0;

			msg = PackCommand(msg, command);
			msg = PackMidiChannel(msg, midiChannel);
			msg = PackData1(msg, data1);

			#region Ensure

			Debug.Assert(Command == command);
			Debug.Assert(MidiChannel == midiChannel);
			Debug.Assert(Data1 == data1);

			#endregion Ensure
		}

		/// <summary>
		/// Initializes a new instance of the ChannelEventArgs class with the
		/// specified command, MIDI channel, data 1, and data 2 values.
		/// </summary>
		/// <param name="command">
		/// The command value.
		/// </param>
		/// <param name="midiChannel">
		/// The MIDI channel.
		/// </param>
		/// <param name="data1">
		/// The data 1 value.
		/// </param>
		/// <param name="data2">
		/// The data 2 value.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// If midiChannel is less than zero or greater than 15. Or if
		/// data1 or data 2 is less than zero or greater than 127.
		/// </exception>
		public ChannelMessage(ChannelCommand command, int midiChannel,
			int data1, int data2)
		{
			msg = 0;

			msg = PackCommand(msg, command);
			msg = PackMidiChannel(msg, midiChannel);
			msg = PackData1(msg, data1);
			msg = PackData2(msg, data2);

			#region Ensure

			Debug.Assert(Command == command);
			Debug.Assert(MidiChannel == midiChannel);
			Debug.Assert(Data1 == data1);
			Debug.Assert(Data2 == data2);

			#endregion Ensure
		}

		internal ChannelMessage(int message)
		{
			this.msg = message;
		}

		/// <summary>
		/// Gets the channel command value.
		/// </summary>
		public ChannelCommand Command
		{
			get
			{
				return UnpackCommand(msg);
			}
		}

		/// <summary>
		/// Gets the first data value.
		/// </summary>
		public int Data1
		{
			get
			{
				return UnpackData1(msg);
			}
		}

		/// <summary>
		/// Gets the second data value.
		/// </summary>
		public int Data2 => UnpackData2(msg);

		/// <summary>
		/// Gets the MIDI channel.
		/// </summary>
		public int MidiChannel => UnpackMidiChannel(msg);

		/// <summary>
		/// Determines whether two ChannelEventArgs instances are equal.
		/// </summary>
		/// <param name="obj">
		/// The ChannelMessageEventArgs to compare with the current ChannelEventArgs.
		/// </param>
		/// <returns>
		/// <b>true</b> if the specified object is equal to the current
		/// ChannelMessageEventArgs; otherwise, <b>false</b>.
		/// </returns>
		public override bool Equals(object obj)
		{
			var channelMessage = obj as ChannelMessage;
			if (channelMessage == null) return false;

			return msg == channelMessage.msg;
		}

		/// <summary>
		/// Returns a value for the current ChannelEventArgs suitable for use in
		/// hashing algorithms.
		/// </summary>
		/// <returns>
		/// A hash code for the current ChannelEventArgs.
		/// </returns>
		public override int GetHashCode()
		{
			return msg;
		}

		/// <summary>
		/// Returns a value indicating how many bytes are used for the
		/// specified ChannelCommand.
		/// </summary>
		/// <param name="command">
		/// The ChannelCommand value to test.
		/// </param>
		/// <returns>
		/// The number of bytes used for the specified ChannelCommand.
		/// </returns>
		internal static int DataBytesPerType(ChannelCommand command)
		{
			int result;

			if (command == ChannelCommand.ChannelPressure || command == ChannelCommand.ProgramChange)
			{
				result = 1;
			}
			else
			{
				result = 2;
			}

			return result;
		}

		/// <summary>
		/// Packs the command value into an integer message.
		/// </summary>
		/// <param name="message">
		/// The message into which the command is packed.
		/// </param>
		/// <param name="command">
		/// The command value to pack into the message.
		/// </param>
		/// <returns>
		/// An integer message.
		/// </returns>
		internal static int PackCommand(int message, ChannelCommand command)
		{
			return (message & CommandMask) | (int)command;
		}

		/// <summary>
		/// Packs the MIDI channel into the specified integer message.
		/// </summary>
		/// <param name="message">
		/// The message into which the MIDI channel is packed.
		/// </param>
		/// <param name="midiChannel">
		/// The MIDI channel to pack into the message.
		/// </param>
		/// <returns>
		/// An integer message.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// If midiChannel is less than zero or greater than 15.
		/// </exception>
		internal static int PackMidiChannel(int message, int midiChannel)
		{
			#region Preconditons

			if (midiChannel < 0 || midiChannel > MidiChannelMaxValue)
			{
				throw new ArgumentOutOfRangeException("midiChannel", midiChannel,
					"MIDI channel out of range.");
			}

			#endregion Preconditons

			return (message & MidiChannelMask) | midiChannel;
		}

		/// <summary>
		/// Unpacks the command value from the specified integer channel
		/// message.
		/// </summary>
		/// <param name="message">
		/// The message to unpack.
		/// </param>
		/// <returns>
		/// The command value for the packed message.
		/// </returns>
		internal static ChannelCommand UnpackCommand(int message)
		{
			return (ChannelCommand)(message & DataMask & MidiChannelMask);
		}

		/// <summary>
		/// Unpacks the MIDI channel from the specified integer channel
		/// message.
		/// </summary>
		/// <param name="message">
		/// The message to unpack.
		/// </param>
		/// <returns>
		/// The MIDI channel for the pack message.
		/// </returns>
		internal static int UnpackMidiChannel(int message)
		{
			return message & DataMask & CommandMask;
		}
	}
}