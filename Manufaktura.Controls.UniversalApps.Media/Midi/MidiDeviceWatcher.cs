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