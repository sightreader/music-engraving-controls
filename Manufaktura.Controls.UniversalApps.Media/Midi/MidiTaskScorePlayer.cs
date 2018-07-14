/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

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
                var midiOffMessage = new MidiNoteOffMessage((byte)actualChannelNumber, (byte)note.Pitch.MidiPitch, 127);
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