using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Desktop.Audio.Midi;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Concurrent;
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

		private ConcurrentDictionary<int, List<int>> pitchesPlaying;

		public MidiTaskScorePlayer(Score score) : this(score, new MidiDevice(0, "default"))
		{
		}

		public MidiTaskScorePlayer(Score score, MidiDevice device) : base(score)
		{
			outDevice = device;
			outDevice.Open();
			pitchesPlaying = new ConcurrentDictionary<int, List<int>>(Enumerable.Range(0, ChannelsCount).Select(i => new KeyValuePair<int, List<int>>(i, new List<int>())));
		}

		public static IEnumerable<MidiDevice> AvailableDevices => availableDevices.Value;
		private int ChannelsCount => Score.Staves.Count < 5 ? Score.Staves.Count * 2 : Score.Staves.Count * 2 + 2;

		public void Dispose()
		{
			for (int i = 0; i < Score.Staves.Count * 2; i++)
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
			var firstNoteInMeasure = element.Measure.Elements.IndexOf(note) == 0;

			var channelNumber = GetChannelNumber(Score.Staves.IndexOf(note.Staff));
			var actualChannelNumber = (pitchesPlaying[channelNumber].Contains(note.MidiPitch)) ? channelNumber + 1 : channelNumber;

			if (!pitchesPlaying[channelNumber].Contains(note.MidiPitch)) pitchesPlaying[channelNumber].Add(note.MidiPitch);
			outDevice.Send(note, true, actualChannelNumber, firstNoteInMeasure ? 127 : 100);

			await Task.Delay(new RhythmicDuration(note.BaseDuration.Denominator, note.NumberOfDots).ToTimeSpan(Tempo));

			outDevice.Send(note, false, actualChannelNumber);
			if (pitchesPlaying[channelNumber].Contains(note.MidiPitch)) pitchesPlaying[channelNumber].Remove(note.MidiPitch);
		}

		private int GetChannelNumber(int staffIndex)
		{
			var channelIndex = staffIndex * 2;
			if (channelIndex > 7) channelIndex += 2;
			return channelIndex;
		}
	}
}