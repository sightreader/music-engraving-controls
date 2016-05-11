using Manufaktura.Controls.Desktop.Audio.Midi;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Desktop.Audio
{
	public class MidiTaskScorePlayer : TaskScorePlayer, IDisposable
	{
		private static Lazy<IEnumerable<MidiDevice>> availableDevices = new Lazy<IEnumerable<MidiDevice>>(() =>
		new ReadOnlyCollection<MidiDevice>(Enumerable.Range(0, MidiDevice.DeviceCount).Select(i => new MidiDevice(i,
			Encoding.ASCII.GetString(MidiDevice.GetDeviceCapabilities(i).name))).ToList()));

		private MidiDevice outDevice;

		public MidiTaskScorePlayer(Score score) : base(score)
		{
			outDevice = new MidiDevice(0, "default");
			outDevice.Open();
		}

		public MidiTaskScorePlayer(Score score, MidiDevice device) : base(score)
		{
			outDevice = device;
			outDevice.Open();
		}

		public static IEnumerable<MidiDevice> AvailableDevices => availableDevices.Value;

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
			outDevice.Dispose();
		}

		public override async void PlayElement(MusicalSymbol element)
		{
			var note = element as Note;
			if (note == null) return;

			if (note.TieType == NoteTieType.Stop || note.TieType == NoteTieType.StopAndStartAnother) return;

			var channelNumber = Score.Staves.IndexOf(note.Staff);
			outDevice.Send(note, true, channelNumber);

			await Task.Delay(new RhythmicDuration(note.BaseDuration.Denominator, note.NumberOfDots).ToTimeSpan(Tempo));

			outDevice.Send(note, false, channelNumber);
		}
	}
}