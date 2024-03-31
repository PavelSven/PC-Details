using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace PC_Details
{
    public class BIOSInfo
    {
        public string Manufacturer {get;set;}
        public string Name { get;set;}
        public string ReleaseDate { get;set;}

        public BIOSInfo()
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            ManagementObjectSearcher Win32_BIOS = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
                foreach (ManagementObject mo in Win32_BIOS.Get())
                {
                    Manufacturer = mo["Manufacturer"].ToString();
                    Name = mo["Name"].ToString();
                    ReleaseDate = mo["ReleaseDate"].ToString();
                
                }
            Win32_BIOS.Dispose();
        }
    }
}
