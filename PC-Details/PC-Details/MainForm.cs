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
        public MotherboardInfo motherboardInfo;
        public BIOSInfo biosInfo;
        public MemoryCollectionInfo memoryCollectionInfo;

        public MainForm()
        {
            InitializeComponent();

            cpuInfo = new CPUInfo();
            motherboardInfo = new MotherboardInfo();
            biosInfo = new BIOSInfo();
            memoryCollectionInfo = new MemoryCollectionInfo();

            LoadInfo();

            //label1.Text = cpuInfo.test;
        }

        private void LoadInfo()
        {
            LoadProcessorInfo();
            LoadMotherboardInfo();
            LoadBIOSInfo();
            BindCPU();
            BindMotherboard();

            for (int i = 0; i < memoryCollectionInfo.memoryInfoList.Count; i++)
            {
                comboBoxMemorySelection.Items.Add($"Memory #{i + 1}");
            }
            comboBoxMemorySelection.SelectedIndex = 0;

            cpuInfo.StartTimer();
            motherboardInfo.StartTimer();
        }

        private void LoadProcessorInfo()
        {
            labelCPUCaptionValue.Text = cpuInfo.Caption;
            labelCPUL2CacheSizeValue.Text = $"{cpuInfo.L2CacheSize / 6 / 1024} KB per core";
            labelCPUL3CacheSizeValue.Text = $"{cpuInfo.L3CacheSize / 1024 / 1024} MB";
            labelCPUManufacturerValue.Text = cpuInfo.Manufacturer;
            labelCPUNameValue.Text = cpuInfo.Name;
            labelCPUSocketDesignationValue.Text = cpuInfo.SocketDesignation;
            labelCPUNumberOfCoresValue.Text = cpuInfo.NumberOfCores.ToString();
            labelCPUNumberOfLogicalProcessorsValue.Text = cpuInfo.NumberOfLogicalProcessors.ToString();
        }

        private void BindCPU()
        {
            Binding bindingCurrentClockSpeed = new Binding("Text", cpuInfo, "CurrentClockSpeed", true);
            bindingCurrentClockSpeed.Format += (sender, e) => e.Value = $"{e.Value} MHz";
            labelCPUCurrentClockSpeedValue.DataBindings.Add(bindingCurrentClockSpeed);

            Binding bindingPercentProcessorTime = new Binding("Text", cpuInfo, "PercentProcessorTime", true);
            bindingPercentProcessorTime.Format += (sender, e) => e.Value = $"{e.Value} %";
            labelCPUPercentProcessorTimeValue.DataBindings.Add(bindingPercentProcessorTime);
            
            Binding bindingCPUTemperature = new Binding("Text", cpuInfo, "Temperature", true);
            bindingCPUTemperature.Format += (sender, e) => e.Value = $"{e.Value:0} C";
            labelCPUProcessorTemperatureValue.DataBindings.Add(bindingCPUTemperature);
            
            Binding bindingCPUBusSpeed = new Binding("Text", cpuInfo, "BusSpeed", true);
            bindingCPUBusSpeed.Format += (sender, e) => e.Value = $"{e.Value:0.00} MHz";
            labelCPUBusSpeedValue.DataBindings.Add(bindingCPUBusSpeed);
        }

        private void BindMotherboard()
        {
            Binding bindingMotherboardTemperatureSystem = new Binding("Text", motherboardInfo, "TemperatureSystem", true);
            bindingMotherboardTemperatureSystem.Format += (sender, e) => e.Value = $"{e.Value:0} C";
            labelTemperatureSystemValue.DataBindings.Add(bindingMotherboardTemperatureSystem);

            Binding bindingMotherboardTemperatureVRMMOS = new Binding("Text", motherboardInfo, "TemperatureVRMMOS", true);
            bindingMotherboardTemperatureVRMMOS.Format += (sender, e) => e.Value = $"{e.Value:0} C";
            labelTemperatureVRMMOSValue.DataBindings.Add(bindingMotherboardTemperatureVRMMOS);

            Binding bindingMotherboardTemperaturePCH = new Binding("Text", motherboardInfo, "TemperaturePCH", true);
            bindingMotherboardTemperaturePCH.Format += (sender, e) => e.Value = $"{e.Value:0} C";
            labelTemperaturePCHValue.DataBindings.Add(bindingMotherboardTemperaturePCH);

            Binding bindingMotherboardTemperatureCPUSocket = new Binding("Text", motherboardInfo, "TemperatureCPUSocket", true);
            bindingMotherboardTemperatureCPUSocket.Format += (sender, e) => e.Value = $"{e.Value:0} C";
            labelTemperatureSocketValue.DataBindings.Add(bindingMotherboardTemperatureCPUSocket);

            Binding bindingMotherboardTemperaturePCIex1 = new Binding("Text", motherboardInfo, "TemperaturePCIex1", true);
            bindingMotherboardTemperaturePCIex1.Format += (sender, e) => e.Value = $"{e.Value:0} C";
            labelTemperaturePCIex1Value.DataBindings.Add(bindingMotherboardTemperaturePCIex1);
        }

        private void LoadMotherboardInfo()
        {
            labelMotherboardManufacturerValue.Text = motherboardInfo.Manufacturer;
            labelMotherboardProductValue.Text = motherboardInfo.Product;
            labelMotherboardVersionValue.Text = motherboardInfo.Version;
        }

        private void LoadBIOSInfo()
        {
            labelBIOSManufacturerValue.Text = biosInfo.Manufacturer;
            labelBIOSVersionValue.Text = biosInfo.Name;
            labelBIOSReleaseDateValue.Text = biosInfo.ReleaseDate.Insert(4, ".").Insert(7, ".").Substring(0, 10);
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
            if (tabControlMain.SelectedIndex == 1)
            {
                motherboardInfo.StartTimer();
            }
            else
            {
                motherboardInfo.StopTimer();
            }
        }

        private void comboBoxMemorySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMemoryInfo(comboBoxMemorySelection.SelectedIndex);
        }

        private void LoadMemoryInfo(int index)
        {
            labelMemoryManufacturerValue.Text = memoryCollectionInfo.memoryInfoList[index].Manufacturer;
            labelMemoryPartNumberValue.Text = memoryCollectionInfo.memoryInfoList[index].PartNumber;
            labelMemorySerialNumberValue.Text = memoryCollectionInfo.memoryInfoList[index].SerialNumber;
            labelMemoryCapacityValue.Text = $"{memoryCollectionInfo.memoryInfoList[index].Capacity / 1024 / 1024 / 1024} GB";
            labelMemorySpeedValue.Text = $"{memoryCollectionInfo.memoryInfoList[index].Speed} MHz";
        }
    }
}
