using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace PC_Details
{
    internal class CPUInfo
    {
        public string Caption { get; set; }
        public uint CurrentClockSpeed { get; set; }
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
        public ulong PercentProcessorTime { get; set; }

        public ushort Family {  get; set; }

        public void UpdateInfo()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementBaseObject mo in mos.Get()) 
            {
                Caption = mo["Caption"].ToString();
                CurrentClockSpeed = Convert.ToUInt32(mo["CurrentClockSpeed"]);
                Description = mo["Description"].ToString();
                L1InstructionCacheSize = 0;
                L1DataCacheSize = 0;
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
                PercentProcessorTime = 0;

                Family = Convert.ToUInt16(mo["Family"]);
            }
        }

        public override string ToString()
        {
            return
                $"Caption: {Caption}" +
                $"\nCurrentClockSpeed: {CurrentClockSpeed}" +
                $"\nDescription: {Description}" +
                $"\nL1InstructionCacheSize: {L1InstructionCacheSize}" +
                $"\nL1DataCacheSize: {L1DataCacheSize}" +
                $"\nL2CacheSize: {L2CacheSize}" +
                $"\nL3CacheSize: {L3CacheSize}" +
                $"\nManufacturer: {Manufacturer}" +
                $"\nMaxClockSpeed: {MaxClockSpeed}" +
                $"\nName: {Name}" +
                $"\nNumberOfCores: {NumberOfCores}" +
                $"\nNumberOfLogicalProcessors: {NumberOfLogicalProcessors}" +
                $"\nProcessorId: {ProcessorId}" +
                $"\nSecondLevelAddressTranslationExtensions: {SecondLevelAddressTranslationExtensions}" +
                $"\nSocketDesignation: {SocketDesignation}" +
                $"\nVirtualizationFirmwareEnabled: {VirtualizationFirmwareEnabled}" +
                $"\nVMMonitorModeExtensions: {VMMonitorModeExtensions}" +
                $"\nPercentProcessorTime: {PercentProcessorTime}" +

                $"\nFamily: {Family}";
        }

    }
}
