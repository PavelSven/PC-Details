using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace PC_Details
{
    public class MotherboardInfo
    {
        public string Manufacturer {  get; set; }
        public string Product {  get; set; }
        public string Version {  get; set; }

        public MotherboardInfo()
        {
            UpdateInfo();
        }

        private void UpdateInfo()
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
    }
}
