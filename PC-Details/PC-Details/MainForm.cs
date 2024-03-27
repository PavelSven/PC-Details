using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Details
{
    public partial class MainForm : Form
    {
        CPUInfo CPUInfo {  get; set; }

        public MainForm()
        {
            InitializeComponent();

            CPUInfo = new CPUInfo();
            CPUInfo.UpdateInfo();
            //label1.Text = cpuInfo.ToString();

            LoadProcessorInfo();
        }

        private void LoadProcessorInfo()
        {
            labelCPUCaptionValue.Text = CPUInfo.Caption;
            labelCPUManufacturerValue.Text = CPUInfo.Manufacturer;
            labelCPUNameValue.Text = CPUInfo.Name;
            labelCPUSocketDesignationValue.Text = CPUInfo.SocketDesignation;
            labelCPUNumberOfCoresValue.Text = CPUInfo.NumberOfCores.ToString();
            labelCPUNumberOfLogicalProcessorsValue.Text = CPUInfo.NumberOfLogicalProcessors.ToString();
        }
    }
}
