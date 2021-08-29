using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace AudioDevicesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDevices();
        }

        private void LoadDevices()
        {
            for (int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
               var deviceInfo =  WaveIn.GetCapabilities(deviceId);
                RecordingDeviceComboBox.Items.Add(deviceInfo.ProductName);
            }

            for (int deviceId = 0; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveOut.GetCapabilities(deviceId);
                PlaybackDeviceComboBox.Items.Add(deviceInfo.ProductName);
            }
          
        }
    }
}
