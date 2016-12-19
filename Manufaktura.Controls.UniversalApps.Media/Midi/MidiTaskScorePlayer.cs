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
    public class MidiTaskScorePlayer : TaskScorePlayer
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
        }

        public override void PlayElement(MusicalSymbol element)
        {
            var pitchedElement = element as IHasPitch;
            if (pitchedElement == null) return;

            if (currentMidiOutputDevice == null)
                throw new Exception($"{nameof(MidiTaskScorePlayer)} is not initialized. Run {nameof(InitializeAsync)}. " +
                    $"To see the list of available devices use {nameof(GetDeviceNamesAsync)}.");

            var midiMessageToSend = new MidiNoteOnMessage(0, (byte)pitchedElement.Pitch.MidiPitch, 127);
            currentMidiOutputDevice.SendMessage(midiMessageToSend);
        }

        protected override async void PlayQueue(Queue<TimelineElement<IHasDuration>> simultaneousElements)
        {
            while (simultaneousElements.Any())
            {
                var element = simultaneousElements.Dequeue();
                if (ElapsedTime != element.When) await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => ElapsedTime = element.When);
                var note = element.What as Note;
                if (note == null) continue;
                PlayElement(note);
            }
        }
    }
}