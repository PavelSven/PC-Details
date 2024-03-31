using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;
using LibreHardwareMonitor.Hardware;
using static System.Net.Mime.MediaTypeNames;

namespace PC_Details
{
    public class CPUInfo : INotifyPropertyChanged
    {
        private System.Timers.Timer TimerInfo;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Caption { get; set; }

        private uint currentClockSpeed; 
        public uint CurrentClockSpeed 
        {
            get => currentClockSpeed;
            set 
            {
                if (currentClockSpeed != value)
                {
                    currentClockSpeed = value;
                    OnPropertyChanged();
                }
            }
        }
        //public double CurrentVoltage { get; set; }
        public string Description { get; set; }
        public uint L1InstructionCacheSize {  get; set; }
        public uint L1DataCacheSize { get; set; }
        public uint L2CacheSize { get; set; }
        public uint L3CacheSize { get; set; }
        public string Manufacturer { get; set; }
        public uint MaxClockSpeed { get; set; }
        public string Name { get; set; }
        public uint NumberOfCores { get; set; }
        public uint NumberOfLogicalProcessors { get; set; }
        public string ProcessorId { get; set; }
        public bool SecondLevelAddressTranslationExtensions { get; set; }   //Возможно не понадобится
        public string SocketDesignation {  get; set; }
        public bool VirtualizationFirmwareEnabled { get; set; }
        public bool VMMonitorModeExtensions { get; set; }   //Возможно не понадобится, похожу на VirtualizationFirmwareEnabled
        
        private ulong percentProcessorTime;
        public ulong PercentProcessorTime 
        {
            get => percentProcessorTime;
            set
            {
                if (percentProcessorTime != value)
                {
                    percentProcessorTime = value;
                    OnPropertyChanged();
                }    
            }
        }

        private float? temperature;
        public float? Temperature
        {
            get => temperature;
            set
            {
                if (value == null)
                    value = 0;
                if (temperature != value)
                {
                    temperature = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private float? busSpeed;
        public float? BusSpeed
        {
            get { return busSpeed; }
            set
            {
                if (value == null)
                    value = 0;
                if (busSpeed != value)
                {
                    busSpeed = value;
                    OnPropertyChanged();
                }
            }
        }

        public CPUInfo()
        {
            UpdateStaticInfo();
            UpdateDynamicInfo();
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateStaticInfo()
        {
            /*            uint L1InstructionCacheSizeTemp = 0;
                        uint L1DataCacheSizeTemp = 0;

                        ManagementObjectSearcher Win32_CacheMemory = new ManagementObjectSearcher("SELECT * FROM Win32_CacheMemory WHERE Level = 3");
                        foreach (ManagementObject mo in Win32_CacheMemory.Get())
                        {
                            ushort CacheType = Convert.ToUInt16(mo["CacheType"]);
                            uint MaxCacheSize = 1024 * Convert.ToUInt32(mo["MaxCacheSize"]);

                            // if CacheType is Other or Unknown
                            if (L1InstructionCacheSizeTemp == 0)
                                L1InstructionCacheSizeTemp = MaxCacheSize;

                            // if CacheType is Other or Unknown
                            if (L1DataCacheSizeTemp == 0)
                                L1DataCacheSizeTemp = MaxCacheSize;

                            if (CacheType == 3) // Instruction
                                L1InstructionCacheSizeTemp = MaxCacheSize;

                            if (CacheType == 4) // Data
                                L1DataCacheSizeTemp = MaxCacheSize;
                        }*/

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementBaseObject mo in mos.Get()) 
            {
                Caption = mo["Caption"].ToString();
                //CurrentVoltage = Convert.ToDouble(mo["CurrentVoltage"]) / 10.0;
                Description = mo["Description"].ToString();
                //L1InstructionCacheSize = L1InstructionCacheSizeTemp;
                //L1DataCacheSize = L1DataCacheSizeTemp;
                L2CacheSize = 1024 * Convert.ToUInt32(mo["L2CacheSize"]);
                L3CacheSize = 1024 * Convert.ToUInt32(mo["L3CacheSize"]);
                Manufacturer = mo["Manufacturer"].ToString();
                MaxClockSpeed = Convert.ToUInt32(mo["MaxClockSpeed"]);
                Name = mo["Name"].ToString().Trim();
                NumberOfCores = Convert.ToUInt32(mo["NumberOfCores"]);
                NumberOfLogicalProcessors = Convert.ToUInt32(mo["NumberOfLogicalProcessors"]);
                ProcessorId = mo["ProcessorID"].ToString();
                SecondLevelAddressTranslationExtensions = Convert.ToBoolean(mo["SecondLevelAddressTranslationExtensions"]);
                SocketDesignation = mo["SocketDesignation"].ToString();
                VirtualizationFirmwareEnabled = Convert.ToBoolean(mo["VirtualizationFirmwareEnabled"]);
                VMMonitorModeExtensions = Convert.ToBoolean(mo["VMMonitorModeExtensions"]);
            }

            mos.Dispose();
        }

        public void StartTimer()
        {
            TimerInfo = new System.Timers.Timer(1500);
            TimerInfo.Elapsed += (s, e) => UpdateDynamicInfo();
            TimerInfo.Enabled = true;
            TimerInfo.AutoReset = true;
        }

        public void StopTimer()
        {
            TimerInfo.Enabled = false;
        }

        public void UpdateDynamicInfo()
        {
            PerformanceCounter cpuCounter =
                new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");
            
            float processorPerformance = 0f;
            processorPerformance = cpuCounter.NextValue();
            Thread.Sleep(1);
            processorPerformance = cpuCounter.NextValue();

            cpuCounter.Dispose();

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementBaseObject mo in mos.Get())
            {
                CurrentClockSpeed = (uint)(MaxClockSpeed * (processorPerformance / 100));
                PercentProcessorTime = Convert.ToUInt64(mo["LoadPercentage"]);
            }
            mos.Dispose();

            UpdateFromHardwareMonitor();
        }

        public void UpdateFromHardwareMonitor()
        {
            Computer computer = new Computer();
            computer.IsCpuEnabled = true;
            computer.Open();
            computer.Accept(new UpdateVisitor());

            IHardware hardwareCpu = computer.Hardware.First(h => h.HardwareType == HardwareType.Cpu);

            ISensor sensorTemperature =  hardwareCpu.Sensors.First(s => s.SensorType == SensorType.Temperature);
            Temperature = sensorTemperature.Value;

            ISensor sensorBusSpeed = 
                hardwareCpu.Sensors.Where(s => s.SensorType == SensorType.Clock).First(s => s.Name == "Bus Speed");
            BusSpeed = sensorBusSpeed.Value;

            computer.Close();
        }
    }
}
