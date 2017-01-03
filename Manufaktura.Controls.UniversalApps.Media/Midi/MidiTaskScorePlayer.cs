using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.Midi;
using Windows.UI.Core;

namespace Manufaktura.Controls.UniversalApps.Media.Midi
{
    public class MidiTaskScorePlayer : ChannelSelectingTaskScorePlayer
    {
        private readonly CoreDispatcher dispatcher;
        private IMidiOutPort currentMidiOutputDevice;
        private Dictionary<MidiMessageType, string> messageTypes = new Dictionary<MidiMessageType, string>();
        public MidiTaskScorePlayer(Score score, CoreDispatcher dispatcher) : base(score)
        {
            this.dispatcher = dispatcher;
        }

        public async Task<string[]> GetDeviceNamesAsync()
        {
            var devices = await DeviceInformation.FindAllAsync(MidiOutPort.GetDeviceSelector()).AsTask();
            return devices.Select(d => d.Name).ToArray();
        }

        public async Task InitializeAsync(string deviceName)
        {
            var devices = await DeviceInformation.FindAllAsync(MidiOutPort.GetDeviceSelector()).AsTask();
            var devInfo = devices?.FirstOrDefault(d => d.Name == deviceName);
            if (devInfo == null)
                throw new Exception($"Device {deviceName} not found.");

            currentMidiOutputDevice = await MidiOutPort.FromIdAsync(devInfo.Id).AsTask();
            if (currentMidiOutputDevice == null)
                throw new Exception($"Midi output port could not be found for device {deviceName}.");
        }

        public override async void PlayElement(MusicalSymbol element)
        {
            var note = element as Note;
            if (note == null || currentMidiOutputDevice == null) return;

            var firstNoteInMeasure = element.Measure.Elements.IndexOf(note) == 0;

            var channelNumber = GetChannelNumber(Score.Staves.IndexOf(note.Staff));
            var actualChannelNumber = (pitchesPlaying[channelNumber].Contains(note.MidiPitch)) ? channelNumber + 1 : channelNumber;

            if (!pitchesPlaying[channelNumber].Contains(note.MidiPitch)) pitchesPlaying[channelNumber].Add(note.MidiPitch);
            var midiMessageToSend = new MidiNoteOnMessage((byte)actualChannelNumber, (byte)note.Pitch.MidiPitch, firstNoteInMeasure ? (byte)127 : (byte)100);
            currentMidiOutputDevice.SendMessage(midiMessageToSend);

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            Task.Delay(note.BaseDuration.ToTimeSpan(Tempo)).ContinueWith((t,o) =>
            {
                var midiOffMessage = new MidiNoteOffMessage(0, (byte)note.Pitch.MidiPitch, 127);
                currentMidiOutputDevice.SendMessage(midiOffMessage);
                if (pitchesPlaying[channelNumber].Contains(note.MidiPitch)) pitchesPlaying[channelNumber].Remove(note.MidiPitch);
            }, null);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        protected override void PlayQueue(Queue<TimelineElement<IHasDuration>> simultaneousElements)
        {
            while (simultaneousElements.Any())
            {
                var element = simultaneousElements.Dequeue();
#pragma warning disable CS4014 // We can't await here - we want it to run completely async because otherwise it would interrupt the playback
                if (ElapsedTime != element.When) dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => ElapsedTime = element.When);
#pragma warning restore CS4014 // We can't await here - we want it to run completely async because otherwise it would interrupt the playback
                var note = element.What as Note;
                if (note == null) continue;
                PlayElement(note);
            }
        }
    }
}