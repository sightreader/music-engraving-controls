using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Sanford.Multimedia.Midi;
using System;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Desktop.Audio
{
	public class MidiTaskScorePlayer : TaskScorePlayer, IDisposable
	{
		private OutputDevice outDevice = new OutputDevice(0);

		public MidiTaskScorePlayer(Score score) : base(score)
		{
		}

		public void Dispose()
		{
			outDevice.Dispose();
		}

		public override async void PlayElement(MusicalSymbol element, Staff staff)
		{
			var note = element as Note;
			if (note == null) return;

			try
			{
				ChannelMessageBuilder builder = new ChannelMessageBuilder();

				builder.Command = ChannelCommand.NoteOn;
				builder.MidiChannel = 0;
				builder.Data1 = note.MidiPitch;
				builder.Data2 = 127;
				builder.Build();

				outDevice.Send(builder.Result);

				await Task.Delay(new RhythmicDuration(note.BaseDuration.Denominator, note.NumberOfDots).ToTimeSpan(Tempo));

				builder.Command = ChannelCommand.NoteOff;
				builder.Data2 = 0;
				builder.Build();

				outDevice.Send(builder.Result);
			}
			catch (Exception ex)
			{
				throw;
			}
		}
	}
}