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

using System;
using Windows.Devices.Enumeration;

namespace Manufaktura.Controls.UniversalApps.Media.Midi
{
    internal class MidiDeviceWatcher
    {
        internal DeviceInformationCollection deviceInformationCollection = null;
        internal DeviceWatcher deviceWatcher = null;
        private bool enumerationCompleted = false;
        private string midiSelector = string.Empty;

        internal MidiDeviceWatcher(string midiSelectorString)
        {
            deviceWatcher = DeviceInformation.CreateWatcher(midiSelectorString);
            midiSelector = midiSelectorString;

            deviceWatcher.Added += DeviceWatcher_Added;
            deviceWatcher.Removed += DeviceWatcher_UpdatedOrRemoved;
            deviceWatcher.Updated += DeviceWatcher_UpdatedOrRemoved;
            deviceWatcher.EnumerationCompleted += DeviceWatcher_EnumerationCompleted;
        }

        /// <summary>
        /// Destructor: Remove Device Watcher events
        /// </summary>
        ~MidiDeviceWatcher()
        {
            deviceWatcher.Added -= DeviceWatcher_Added;
            deviceWatcher.Removed -= DeviceWatcher_UpdatedOrRemoved;
            deviceWatcher.Updated -= DeviceWatcher_UpdatedOrRemoved;
            deviceWatcher.EnumerationCompleted -= DeviceWatcher_EnumerationCompleted;
        }

        /// <summary>
        /// Get the DeviceInformationCollection
        /// </summary>
        /// <returns></returns>
        internal DeviceInformationCollection GetDeviceInformationCollection()
        {
            return deviceInformationCollection;
        }

        /// <summary>
        /// Start the Device Watcher
        /// </summary>
        internal void Start()
        {
            if (deviceWatcher.Status != DeviceWatcherStatus.Started)
            {
                deviceWatcher.Start();
            }
        }

        /// <summary>
        /// Stop the Device Watcher
        /// </summary>
        internal void Stop()
        {
            if (deviceWatcher.Status != DeviceWatcherStatus.Stopped)
            {
                deviceWatcher.Stop();
            }
        }

        private async void DeviceWatcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            if (enumerationCompleted) deviceInformationCollection = await DeviceInformation.FindAllAsync(midiSelector);
        }

        private async void DeviceWatcher_EnumerationCompleted(DeviceWatcher sender, object args)
        {
            enumerationCompleted = true;
            deviceInformationCollection = await DeviceInformation.FindAllAsync(midiSelector);
        }

        private async void DeviceWatcher_UpdatedOrRemoved(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            if (enumerationCompleted) deviceInformationCollection = await DeviceInformation.FindAllAsync(midiSelector);
        }
    }
}