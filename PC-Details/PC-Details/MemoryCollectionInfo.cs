using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PC_Details
{
    public class MemoryCollectionInfo
    {
        public List<MemoryInfo> memoryInfoList;

        public MemoryCollectionInfo()
        {
            memoryInfoList = new List<MemoryInfo>();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            ManagementObjectSearcher Win32_PhysicalMemory = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject mo in Win32_PhysicalMemory.Get())
            {
                MemoryInfo memoryInfo = new MemoryInfo
                {
                    BankLabel = mo["BankLabel"].ToString(),
                    Capacity = Convert.ToUInt64(mo["Capacity"]),
                    Manufacturer = mo["Manufacturer"].ToString(),
                    PartNumber = mo["PartNumber"].ToString(),
                    SerialNumber = mo["SerialNumber"].ToString(),
                    Speed = Convert.ToUInt32(mo["Speed"])
                };
                memoryInfoList.Add(memoryInfo);
            }
            Win32_PhysicalMemory.Dispose();
        }
    }
}
