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

		public MidiTaskScorePlayer(Score score) : this(score, new MidiDevice(0, "default"))
		{
		}

		public MidiTaskScorePlayer(Score score, MidiDevice device) : base(score)
		{
			outDevice = device;
			outDevice.Open();
			pitchesPlaying = new ConcurrentDictionary<int, List<int>>(Enumerable.Range(0, score.Staves.Count * 2).Select(i => new KeyValuePair<int, List<int>>(i, new List<int>())));
		}

		public static IEnumerable<MidiDevice> AvailableDevices => availableDevices.Value;

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

		private ConcurrentDictionary<int, List<int>> pitchesPlaying;

		public override async void PlayElement(MusicalSymbol element)
		{
			var note = element as Note;
			if (note == null) return;

			if (note.TieType == NoteTieType.Stop || note.TieType == NoteTieType.StopAndStartAnother) return;
			var firstNoteInMeasure = element.Measure.Elements.IndexOf(note) == 0;

			var channelNumber = Score.Staves.IndexOf(note.Staff) * 2;
			if (pitchesPlaying[channelNumber].Contains(note.MidiPitch)) channelNumber += 1;
			pitchesPlaying[channelNumber]?.Add(note.MidiPitch);
			outDevice.Send(note, true, channelNumber, firstNoteInMeasure ? 127 : 100);

			await Task.Delay(new RhythmicDuration(note.BaseDuration.Denominator, note.NumberOfDots).ToTimeSpan(Tempo));

			outDevice.Send(note, false, channelNumber);
			pitchesPlaying[channelNumber].Remove(note.MidiPitch);
		}
	}
}