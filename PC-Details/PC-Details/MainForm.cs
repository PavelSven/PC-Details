using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Details
{
    public partial class MainForm : Form
    {
        public CPUInfo cpuInfo;
        public MotherboardInfo mainboardInfo;
        public BIOS bios;

        public MainForm()
        {
            InitializeComponent();

            cpuInfo = new CPUInfo();
            mainboardInfo = new MotherboardInfo();
            bios = new BIOS();

            LoadProcessorInfo();
            LoadMotherboardInfo();
            LoadBIOSInfo();
            Bind();

            cpuInfo.StartTimer();

/*            labelCPUL2CacheSizeValue.Text = $"L1InstructionCacheSize {CPUInfo.L1InstructionCacheSize / 1000}\n" +
                $"L1DataCacheSize {CPUInfo.L1DataCacheSize / 1000}\n" +
                $"L2CacheSize {CPUInfo.L2CacheSize / 1000}\n" +
                $"L3CacheSize {CPUInfo.L3CacheSize / 1000000}\n";*/
            //label1.Text = mainboardInfo.test;
        }

        private void LoadProcessorInfo()
        {
            labelCPUCaptionValue.Text = cpuInfo.Caption;
            labelCPUL2CacheSizeValue.Text = $"{cpuInfo.L2CacheSize / 6 / 1000} KB per core";
            labelCPUL3CacheSizeValue.Text = $"{cpuInfo.L3CacheSize / 1000 / 1000} MB";
            labelCPUManufacturerValue.Text = cpuInfo.Manufacturer;
            labelCPUNameValue.Text = cpuInfo.Name;
            labelCPUSocketDesignationValue.Text = cpuInfo.SocketDesignation;
            labelCPUNumberOfCoresValue.Text = cpuInfo.NumberOfCores.ToString();
            labelCPUNumberOfLogicalProcessorsValue.Text = cpuInfo.NumberOfLogicalProcessors.ToString();
            //labelCPUCurrentVoltageValue.Text = CPUInfo.CurrentVoltage.ToString();
        }

        private void Bind()
        {
            Binding bindingCurrentClockSpeed = new Binding("Text", cpuInfo, "CurrentClockSpeed", true);
            bindingCurrentClockSpeed.Format += (sender, e) => e.Value = $"{e.Value} MHz";
            labelCPUCurrentClockSpeedValue.DataBindings.Add(bindingCurrentClockSpeed);

            Binding bindingPercentProcessorTime = new Binding("Text", cpuInfo, "PercentProcessorTime", true);
            bindingPercentProcessorTime.Format += (sender, e) => e.Value = $"{e.Value} %";
            labelCPUPercentProcessorTimeValue.DataBindings.Add(bindingPercentProcessorTime);
        }

        private void LoadMotherboardInfo()
        {
            labelMotherboardManufacturerValue.Text = mainboardInfo.Manufacturer;
            labelMotherboardProductValue.Text = mainboardInfo.Product;
            labelMotherboardVersionValue.Text = mainboardInfo.Version;
        }

        private void LoadBIOSInfo()
        {
            labelBIOSManufacturerValue.Text = bios.Manufacturer;
            labelBIOSVersionValue.Text = bios.Name;
            labelBIOSReleaseDateValue.Text = bios.ReleaseDate.Insert(4, ".").Insert(7, ".").Substring(0, 10);
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                cpuInfo.StartTimer();
            }
            else
            {
                cpuInfo.StopTimer();
            }
        }
    }
}
