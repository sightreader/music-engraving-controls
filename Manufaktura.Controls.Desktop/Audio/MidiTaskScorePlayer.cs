using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Desktop.Audio
{
	public class MidiTaskScorePlayer : TaskScorePlayer, IDisposable
	{
		private static Lazy<IEnumerable<Device>> availableDevices = new Lazy<IEnumerable<Device>>(() => new ReadOnlyCollection<Device>(Enumerable.Range(0, OutputDevice.DeviceCount).Select(i => new Device(i, OutputDevice.GetDeviceCapabilities(i).name)).ToList()));
		private OutputDevice outDevice;

		public MidiTaskScorePlayer(Score score) : base(score)
		{
			outDevice = new OutputDevice(0);
		}

		public MidiTaskScorePlayer(Score score, Device device) : base(score)
		{
			outDevice = new OutputDevice(device.Index);
		}

		public static IEnumerable<Device> AvailableDevices => availableDevices.Value;

		public void Dispose()
		{
			for (int i = 0; i < Score.Staves.Count; i++)
			{
				ChannelMessageBuilder builder = new ChannelMessageBuilder();
				builder.Command = ChannelCommand.NoteOff;
				builder.Data2 = i;
				builder.Build();

				outDevice.Send(builder.Result);
			}
			outDevice.Close();
			outDevice.Dispose();
		}

		public override async void PlayElement(MusicalSymbol element)
		{
			var note = element as Note;
			if (note == null) return;

			ChannelMessageBuilder builder = new ChannelMessageBuilder();

			var channelNumber = Score.Staves.IndexOf(note.Staff);
			builder.Command = ChannelCommand.NoteOn;
			builder.MidiChannel = channelNumber;
			builder.Data1 = note.MidiPitch;
			builder.Data2 = 127;
			builder.Build();

			outDevice.Send(builder.Result);

			await Task.Delay(new RhythmicDuration(note.BaseDuration.Denominator, note.NumberOfDots).ToTimeSpan(Tempo));

			builder.Command = ChannelCommand.NoteOff;
			builder.Data2 = channelNumber;
			builder.Build();

			outDevice.Send(builder.Result);
		}

		public class Device
		{
			public Device(int index, string name)
			{
				Index = index;
				Name = name;
			}

			public int Index { get; private set; }
			public string Name { get; private set; }

			public override string ToString()
			{
				return Name;
			}
		}
	}
}