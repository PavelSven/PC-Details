using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PC_Details
{
    public class MotherboardInfo : INotifyPropertyChanged
    {
        private System.Timers.Timer timerInfo;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Manufacturer {  get; set; }
        public string Product {  get; set; }
        public string Version {  get; set; }

        private float? temperatureSystem;
        public float? TemperatureSystem
        {
            get { return temperatureSystem; }
            set 
            {
                if (value == null)
                    value = 0;
                if (temperatureSystem != value)
                {
                    temperatureSystem = value;
                    OnPropertyChanged();
                }
            }
        }

        private float? temperatureVRMMOS;
        public float? TemperatureVRMMOS
        {
            get { return temperatureVRMMOS; }
            set
            {
                if (value == null)
                    value = 0;
                if (temperatureVRMMOS != value)
                {
                    temperatureVRMMOS = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private float? temperaturePCH;
        public float? TemperaturePCH
        {
            get { return temperaturePCH; }
            set
            {
                if (value == null)
                    value = 0;
                if (temperaturePCH != value)
                {
                    temperaturePCH = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private float? temperatureCPUSocket;
        public float? TemperatureCPUSocket
        {
            get { return temperatureCPUSocket; }
            set
            {
                if (value == null)
                    value = 0;
                if (temperatureCPUSocket != value)
                {
                    temperatureCPUSocket = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private float? temperaturePCIex1;
        public float? TemperaturePCIex1
        {
            get { return temperaturePCIex1; }
            set
            {
                if (value == null)
                    value = 0;
                if (temperaturePCIex1 != value)
                {
                    temperaturePCIex1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public MotherboardInfo()
        {
            UpdateStaticInfo();
            UpdateTemperature();
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateStaticInfo()
        {
            ManagementObjectSearcher Win32_BaseBoard = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject mo in Win32_BaseBoard.Get())
            {
                Manufacturer = mo["Manufacturer"].ToString();
                Product = mo["Product"].ToString();
                Version = mo["Version"].ToString();
            }
            Win32_BaseBoard.Dispose();
        }

        private void UpdateTemperature()
        {
            Computer computer = new Computer();
            computer.IsMotherboardEnabled = true;
            computer.Open();
            computer.Accept(new UpdateVisitor());

            IHardware hardwareMotherboard = computer.Hardware.First(h => h.HardwareType == HardwareType.Motherboard);
            foreach (IHardware subhardware in hardwareMotherboard.SubHardware)
            {
                ISensor[] sensorsTemperature = subhardware.Sensors.Where(s => s.SensorType == SensorType.Temperature).ToArray();
                for (int i = 0; i < sensorsTemperature.Length; i++)
                {
                    if (sensorsTemperature[i].Name == "System")
                        TemperatureSystem = sensorsTemperature[i].Value;
                    else if (sensorsTemperature[i].Name == "VRM MOS")
                        TemperatureVRMMOS = sensorsTemperature[i].Value;                    
                    else if (sensorsTemperature[i].Name == "PCH")
                        TemperaturePCH = sensorsTemperature[i].Value;                    
                    else if (sensorsTemperature[i].Name == "CPU Socket")
                        TemperatureCPUSocket = sensorsTemperature[i].Value;
                    else if (sensorsTemperature[i].Name == "PCIe x1")
                        TemperaturePCIex1 = sensorsTemperature[i].Value;
                }
            }

            computer.Close();
        }

        public void StartTimer()
        {
            timerInfo = new System.Timers.Timer(1500);
            timerInfo.Elapsed += (s, e) => UpdateTemperature();
            timerInfo.Enabled = true;
            timerInfo.AutoReset = true;
        }

        public void StopTimer()
        {
            timerInfo.Enabled = false;
        }
    }
}
