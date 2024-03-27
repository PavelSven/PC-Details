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
        public CPUInfo CPUInfo {  get; set; }

        public MainForm()
        {
            InitializeComponent();

            CPUInfo = new CPUInfo();

            LoadProcessorInfo();
            Bind();

/*            labelCPUL2CacheSizeValue.Text = $"L1InstructionCacheSize {CPUInfo.L1InstructionCacheSize / 1000}\n" +
                $"L1DataCacheSize {CPUInfo.L1DataCacheSize / 1000}\n" +
                $"L2CacheSize {CPUInfo.L2CacheSize / 1000}\n" +
                $"L3CacheSize {CPUInfo.L3CacheSize / 1000000}\n";*/


            CPUInfo.StartTimer();
        }

        private void LoadProcessorInfo()
        {
            labelCPUCaptionValue.Text = CPUInfo.Caption;
            labelCPUL2CacheSizeValue.Text = $"{CPUInfo.L2CacheSize / 6 / 1000} KB per core";
            labelCPUL3CacheSizeValue.Text = $"{CPUInfo.L3CacheSize / 1000 / 1000} MB";
            labelCPUManufacturerValue.Text = CPUInfo.Manufacturer;
            labelCPUNameValue.Text = CPUInfo.Name;
            labelCPUSocketDesignationValue.Text = CPUInfo.SocketDesignation;
            labelCPUNumberOfCoresValue.Text = CPUInfo.NumberOfCores.ToString();
            labelCPUNumberOfLogicalProcessorsValue.Text = CPUInfo.NumberOfLogicalProcessors.ToString();
            //labelCPUCurrentVoltageValue.Text = CPUInfo.CurrentVoltage.ToString();
        }

        private void Bind()
        {
            Binding bindingCurrentClockSpeed = new Binding("Text", CPUInfo, "CurrentClockSpeed", true);
            bindingCurrentClockSpeed.Format += (sender, e) => e.Value = $"{e.Value} MHz";
            labelCPUCurrentClockSpeedValue.DataBindings.Add(bindingCurrentClockSpeed);

            Binding bindingPercentProcessorTime = new Binding("Text", CPUInfo, "PercentProcessorTime", true);
            bindingPercentProcessorTime.Format += (sender, e) => e.Value = $"{e.Value} %";
            labelCPUPercentProcessorTimeValue.DataBindings.Add(bindingPercentProcessorTime);
        }
    }
}
