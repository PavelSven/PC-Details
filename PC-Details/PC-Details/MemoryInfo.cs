using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Details
{
    public class MemoryInfo
    {
        public string BankLabel { get; set; }
        public ulong Capacity { get; set; }
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public uint Speed { get; set; }
    }
}
