namespace PC_Details
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCPU = new System.Windows.Forms.TabPage();
            this.groupBoxCache = new System.Windows.Forms.GroupBox();
            this.labelCPUL3CahceSize = new System.Windows.Forms.Label();
            this.labelCPUL2CacheSize = new System.Windows.Forms.Label();
            this.labelCPUL3CacheSizeValue = new System.Windows.Forms.Label();
            this.labelCPUL2CacheSizeValue = new System.Windows.Forms.Label();
            this.groupBoxClocks = new System.Windows.Forms.GroupBox();
            this.labelCPUPercentProcessorTime = new System.Windows.Forms.Label();
            this.labelCPUPercentProcessorTimeValue = new System.Windows.Forms.Label();
            this.labelCPUCurrentClockSpeed = new System.Windows.Forms.Label();
            this.labelCPUCurrentClockSpeedValue = new System.Windows.Forms.Label();
            this.groupBoxProcessor = new System.Windows.Forms.GroupBox();
            this.labelCPUNumberOfLogicalProcessors = new System.Windows.Forms.Label();
            this.labelCPUNumberOfCores = new System.Windows.Forms.Label();
            this.labelCPUSocketDesignation = new System.Windows.Forms.Label();
            this.labelCPUNumberOfLogicalProcessorsValue = new System.Windows.Forms.Label();
            this.labelCPUNumberOfCoresValue = new System.Windows.Forms.Label();
            this.labelCPUSocketDesignationValue = new System.Windows.Forms.Label();
            this.labelCPUName = new System.Windows.Forms.Label();
            this.labelCPUNameValue = new System.Windows.Forms.Label();
            this.labelCPUManufacturer = new System.Windows.Forms.Label();
            this.labelCPUManufacturerValue = new System.Windows.Forms.Label();
            this.labelCPUCaptionValue = new System.Windows.Forms.Label();
            this.labelCPUCaption = new System.Windows.Forms.Label();
            this.tabPageMainboard = new System.Windows.Forms.TabPage();
            this.tabPageMemory = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageCPU.SuspendLayout();
            this.groupBoxCache.SuspendLayout();
            this.groupBoxClocks.SuspendLayout();
            this.groupBoxProcessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCPU);
            this.tabControlMain.Controls.Add(this.tabPageMainboard);
            this.tabControlMain.Controls.Add(this.tabPageMemory);
            this.tabControlMain.Location = new System.Drawing.Point(3, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(441, 325);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageCPU
            // 
            this.tabPageCPU.Controls.Add(this.groupBoxCache);
            this.tabPageCPU.Controls.Add(this.groupBoxClocks);
            this.tabPageCPU.Controls.Add(this.groupBoxProcessor);
            this.tabPageCPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(433, 299);
            this.tabPageCPU.TabIndex = 0;
            this.tabPageCPU.Text = "CPU";
            this.tabPageCPU.UseVisualStyleBackColor = true;
            // 
            // groupBoxCache
            // 
            this.groupBoxCache.Controls.Add(this.labelCPUL3CahceSize);
            this.groupBoxCache.Controls.Add(this.labelCPUL2CacheSize);
            this.groupBoxCache.Controls.Add(this.labelCPUL3CacheSizeValue);
            this.groupBoxCache.Controls.Add(this.labelCPUL2CacheSizeValue);
            this.groupBoxCache.Location = new System.Drawing.Point(227, 193);
            this.groupBoxCache.Name = "groupBoxCache";
            this.groupBoxCache.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCache.TabIndex = 4;
            this.groupBoxCache.TabStop = false;
            this.groupBoxCache.Text = "Cache";
            // 
            // labelCPUL3CahceSize
            // 
            this.labelCPUL3CahceSize.AutoSize = true;
            this.labelCPUL3CahceSize.Location = new System.Drawing.Point(6, 78);
            this.labelCPUL3CahceSize.Name = "labelCPUL3CahceSize";
            this.labelCPUL3CahceSize.Size = new System.Drawing.Size(19, 13);
            this.labelCPUL3CahceSize.TabIndex = 3;
            this.labelCPUL3CahceSize.Text = "L3";
            // 
            // labelCPUL2CacheSize
            // 
            this.labelCPUL2CacheSize.AutoSize = true;
            this.labelCPUL2CacheSize.Location = new System.Drawing.Point(6, 47);
            this.labelCPUL2CacheSize.Name = "labelCPUL2CacheSize";
            this.labelCPUL2CacheSize.Size = new System.Drawing.Size(19, 13);
            this.labelCPUL2CacheSize.TabIndex = 3;
            this.labelCPUL2CacheSize.Text = "L2";
            // 
            // labelCPUL3CacheSizeValue
            // 
            this.labelCPUL3CacheSizeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUL3CacheSizeValue.Location = new System.Drawing.Point(44, 73);
            this.labelCPUL3CacheSizeValue.Name = "labelCPUL3CacheSizeValue";
            this.labelCPUL3CacheSizeValue.Size = new System.Drawing.Size(93, 22);
            this.labelCPUL3CacheSizeValue.TabIndex = 2;
            this.labelCPUL3CacheSizeValue.Text = "labelCPUL3CacheSizeValue";
            this.labelCPUL3CacheSizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUL2CacheSizeValue
            // 
            this.labelCPUL2CacheSizeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUL2CacheSizeValue.Location = new System.Drawing.Point(44, 46);
            this.labelCPUL2CacheSizeValue.Name = "labelCPUL2CacheSizeValue";
            this.labelCPUL2CacheSizeValue.Size = new System.Drawing.Size(93, 22);
            this.labelCPUL2CacheSizeValue.TabIndex = 2;
            this.labelCPUL2CacheSizeValue.Text = "labelCPUL2CacheSizeValue";
            this.labelCPUL2CacheSizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxClocks
            // 
            this.groupBoxClocks.Controls.Add(this.labelCPUPercentProcessorTime);
            this.groupBoxClocks.Controls.Add(this.labelCPUPercentProcessorTimeValue);
            this.groupBoxClocks.Controls.Add(this.labelCPUCurrentClockSpeed);
            this.groupBoxClocks.Controls.Add(this.labelCPUCurrentClockSpeedValue);
            this.groupBoxClocks.Location = new System.Drawing.Point(6, 193);
            this.groupBoxClocks.Name = "groupBoxClocks";
            this.groupBoxClocks.Size = new System.Drawing.Size(189, 100);
            this.groupBoxClocks.TabIndex = 3;
            this.groupBoxClocks.TabStop = false;
            this.groupBoxClocks.Text = "Clocks";
            // 
            // labelCPUPercentProcessorTime
            // 
            this.labelCPUPercentProcessorTime.AutoSize = true;
            this.labelCPUPercentProcessorTime.Location = new System.Drawing.Point(6, 51);
            this.labelCPUPercentProcessorTime.Name = "labelCPUPercentProcessorTime";
            this.labelCPUPercentProcessorTime.Size = new System.Drawing.Size(31, 13);
            this.labelCPUPercentProcessorTime.TabIndex = 3;
            this.labelCPUPercentProcessorTime.Text = "Load";
            // 
            // labelCPUPercentProcessorTimeValue
            // 
            this.labelCPUPercentProcessorTimeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUPercentProcessorTimeValue.Location = new System.Drawing.Point(78, 47);
            this.labelCPUPercentProcessorTimeValue.Name = "labelCPUPercentProcessorTimeValue";
            this.labelCPUPercentProcessorTimeValue.Size = new System.Drawing.Size(78, 22);
            this.labelCPUPercentProcessorTimeValue.TabIndex = 2;
            this.labelCPUPercentProcessorTimeValue.Text = "labellabelCPUPercentProcessorTimeValue";
            this.labelCPUPercentProcessorTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUCurrentClockSpeed
            // 
            this.labelCPUCurrentClockSpeed.AutoSize = true;
            this.labelCPUCurrentClockSpeed.Location = new System.Drawing.Point(6, 20);
            this.labelCPUCurrentClockSpeed.Name = "labelCPUCurrentClockSpeed";
            this.labelCPUCurrentClockSpeed.Size = new System.Drawing.Size(63, 13);
            this.labelCPUCurrentClockSpeed.TabIndex = 3;
            this.labelCPUCurrentClockSpeed.Text = "Core Speed";
            // 
            // labelCPUCurrentClockSpeedValue
            // 
            this.labelCPUCurrentClockSpeedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUCurrentClockSpeedValue.Location = new System.Drawing.Point(78, 16);
            this.labelCPUCurrentClockSpeedValue.Name = "labelCPUCurrentClockSpeedValue";
            this.labelCPUCurrentClockSpeedValue.Size = new System.Drawing.Size(78, 22);
            this.labelCPUCurrentClockSpeedValue.TabIndex = 2;
            this.labelCPUCurrentClockSpeedValue.Text = "labelCPUCurrentClockSpeedValue";
            this.labelCPUCurrentClockSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxProcessor
            // 
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfLogicalProcessors);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfCores);
            this.groupBoxProcessor.Controls.Add(this.labelCPUSocketDesignation);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfLogicalProcessorsValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfCoresValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUSocketDesignationValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUName);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNameValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUManufacturer);
            this.groupBoxProcessor.Controls.Add(this.labelCPUManufacturerValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUCaptionValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUCaption);
            this.groupBoxProcessor.Location = new System.Drawing.Point(6, 6);
            this.groupBoxProcessor.Name = "groupBoxProcessor";
            this.groupBoxProcessor.Size = new System.Drawing.Size(421, 136);
            this.groupBoxProcessor.TabIndex = 1;
            this.groupBoxProcessor.TabStop = false;
            this.groupBoxProcessor.Text = "Processor";
            // 
            // labelCPUNumberOfLogicalProcessors
            // 
            this.labelCPUNumberOfLogicalProcessors.AutoSize = true;
            this.labelCPUNumberOfLogicalProcessors.Location = new System.Drawing.Point(324, 71);
            this.labelCPUNumberOfLogicalProcessors.Name = "labelCPUNumberOfLogicalProcessors";
            this.labelCPUNumberOfLogicalProcessors.Size = new System.Drawing.Size(46, 13);
            this.labelCPUNumberOfLogicalProcessors.TabIndex = 2;
            this.labelCPUNumberOfLogicalProcessors.Text = "Threads";
            // 
            // labelCPUNumberOfCores
            // 
            this.labelCPUNumberOfCores.AutoSize = true;
            this.labelCPUNumberOfCores.Location = new System.Drawing.Point(324, 43);
            this.labelCPUNumberOfCores.Name = "labelCPUNumberOfCores";
            this.labelCPUNumberOfCores.Size = new System.Drawing.Size(34, 13);
            this.labelCPUNumberOfCores.TabIndex = 2;
            this.labelCPUNumberOfCores.Text = "Cores";
            // 
            // labelCPUSocketDesignation
            // 
            this.labelCPUSocketDesignation.AutoSize = true;
            this.labelCPUSocketDesignation.Location = new System.Drawing.Point(6, 99);
            this.labelCPUSocketDesignation.Name = "labelCPUSocketDesignation";
            this.labelCPUSocketDesignation.Size = new System.Drawing.Size(41, 13);
            this.labelCPUSocketDesignation.TabIndex = 2;
            this.labelCPUSocketDesignation.Text = "Socket";
            // 
            // labelCPUNumberOfLogicalProcessorsValue
            // 
            this.labelCPUNumberOfLogicalProcessorsValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUNumberOfLogicalProcessorsValue.Location = new System.Drawing.Point(376, 67);
            this.labelCPUNumberOfLogicalProcessorsValue.Name = "labelCPUNumberOfLogicalProcessorsValue";
            this.labelCPUNumberOfLogicalProcessorsValue.Size = new System.Drawing.Size(39, 21);
            this.labelCPUNumberOfLogicalProcessorsValue.TabIndex = 1;
            this.labelCPUNumberOfLogicalProcessorsValue.Text = "labelCPUNumberOfLogicalProcessorsValue";
            this.labelCPUNumberOfLogicalProcessorsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUNumberOfCoresValue
            // 
            this.labelCPUNumberOfCoresValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUNumberOfCoresValue.Location = new System.Drawing.Point(376, 39);
            this.labelCPUNumberOfCoresValue.Name = "labelCPUNumberOfCoresValue";
            this.labelCPUNumberOfCoresValue.Size = new System.Drawing.Size(39, 21);
            this.labelCPUNumberOfCoresValue.TabIndex = 1;
            this.labelCPUNumberOfCoresValue.Text = "labelCPUNumberOfCoresValue";
            this.labelCPUNumberOfCoresValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUSocketDesignationValue
            // 
            this.labelCPUSocketDesignationValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUSocketDesignationValue.Location = new System.Drawing.Point(78, 95);
            this.labelCPUSocketDesignationValue.Name = "labelCPUSocketDesignationValue";
            this.labelCPUSocketDesignationValue.Size = new System.Drawing.Size(63, 21);
            this.labelCPUSocketDesignationValue.TabIndex = 1;
            this.labelCPUSocketDesignationValue.Text = "labelCPUSocketDesignationValue";
            this.labelCPUSocketDesignationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUName
            // 
            this.labelCPUName.AutoSize = true;
            this.labelCPUName.Location = new System.Drawing.Point(6, 71);
            this.labelCPUName.Name = "labelCPUName";
            this.labelCPUName.Size = new System.Drawing.Size(35, 13);
            this.labelCPUName.TabIndex = 2;
            this.labelCPUName.Text = "Name";
            // 
            // labelCPUNameValue
            // 
            this.labelCPUNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUNameValue.Location = new System.Drawing.Point(78, 67);
            this.labelCPUNameValue.Name = "labelCPUNameValue";
            this.labelCPUNameValue.Size = new System.Drawing.Size(240, 21);
            this.labelCPUNameValue.TabIndex = 1;
            this.labelCPUNameValue.Text = "labelCPUNameValue";
            this.labelCPUNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUManufacturer
            // 
            this.labelCPUManufacturer.AutoSize = true;
            this.labelCPUManufacturer.Location = new System.Drawing.Point(6, 43);
            this.labelCPUManufacturer.Name = "labelCPUManufacturer";
            this.labelCPUManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelCPUManufacturer.TabIndex = 2;
            this.labelCPUManufacturer.Text = "Manufacturer";
            // 
            // labelCPUManufacturerValue
            // 
            this.labelCPUManufacturerValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUManufacturerValue.Location = new System.Drawing.Point(78, 39);
            this.labelCPUManufacturerValue.Name = "labelCPUManufacturerValue";
            this.labelCPUManufacturerValue.Size = new System.Drawing.Size(240, 21);
            this.labelCPUManufacturerValue.TabIndex = 1;
            this.labelCPUManufacturerValue.Text = "labelCPUManufacturerValue";
            this.labelCPUManufacturerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUCaptionValue
            // 
            this.labelCPUCaptionValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUCaptionValue.Location = new System.Drawing.Point(78, 12);
            this.labelCPUCaptionValue.Name = "labelCPUCaptionValue";
            this.labelCPUCaptionValue.Size = new System.Drawing.Size(337, 21);
            this.labelCPUCaptionValue.TabIndex = 1;
            this.labelCPUCaptionValue.Text = "labelCPUCaptionValue";
            this.labelCPUCaptionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUCaption
            // 
            this.labelCPUCaption.AutoSize = true;
            this.labelCPUCaption.Location = new System.Drawing.Point(6, 16);
            this.labelCPUCaption.Name = "labelCPUCaption";
            this.labelCPUCaption.Size = new System.Drawing.Size(43, 13);
            this.labelCPUCaption.TabIndex = 0;
            this.labelCPUCaption.Text = "Caption";
            // 
            // tabPageMainboard
            // 
            this.tabPageMainboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageMainboard.Name = "tabPageMainboard";
            this.tabPageMainboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainboard.Size = new System.Drawing.Size(433, 299);
            this.tabPageMainboard.TabIndex = 1;
            this.tabPageMainboard.Text = "Mainboard";
            this.tabPageMainboard.UseVisualStyleBackColor = true;
            // 
            // tabPageMemory
            // 
            this.tabPageMemory.Location = new System.Drawing.Point(4, 22);
            this.tabPageMemory.Name = "tabPageMemory";
            this.tabPageMemory.Size = new System.Drawing.Size(433, 299);
            this.tabPageMemory.TabIndex = 2;
            this.tabPageMemory.Text = "Memory";
            this.tabPageMemory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 331);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "PC-Details";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCPU.ResumeLayout(false);
            this.groupBoxCache.ResumeLayout(false);
            this.groupBoxCache.PerformLayout();
            this.groupBoxClocks.ResumeLayout(false);
            this.groupBoxClocks.PerformLayout();
            this.groupBoxProcessor.ResumeLayout(false);
            this.groupBoxProcessor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCPU;
        private System.Windows.Forms.TabPage tabPageMainboard;
        private System.Windows.Forms.TabPage tabPageMemory;
        private System.Windows.Forms.GroupBox groupBoxProcessor;
        private System.Windows.Forms.Label labelCPUCaption;
        private System.Windows.Forms.Label labelCPUCaptionValue;
        private System.Windows.Forms.Label labelCPUManufacturer;
        private System.Windows.Forms.Label labelCPUManufacturerValue;
        private System.Windows.Forms.Label labelCPUName;
        private System.Windows.Forms.Label labelCPUNameValue;
        private System.Windows.Forms.Label labelCPUNumberOfCores;
        private System.Windows.Forms.Label labelCPUSocketDesignation;
        private System.Windows.Forms.Label labelCPUNumberOfCoresValue;
        private System.Windows.Forms.Label labelCPUSocketDesignationValue;
        private System.Windows.Forms.Label labelCPUNumberOfLogicalProcessors;
        private System.Windows.Forms.Label labelCPUNumberOfLogicalProcessorsValue;
        private System.Windows.Forms.Label labelCPUCurrentClockSpeedValue;
        private System.Windows.Forms.GroupBox groupBoxClocks;
        private System.Windows.Forms.Label labelCPUCurrentClockSpeed;
        private System.Windows.Forms.Label labelCPUPercentProcessorTime;
        private System.Windows.Forms.Label labelCPUPercentProcessorTimeValue;
        private System.Windows.Forms.GroupBox groupBoxCache;
        private System.Windows.Forms.Label labelCPUL3CahceSize;
        private System.Windows.Forms.Label labelCPUL2CacheSize;
        private System.Windows.Forms.Label labelCPUL3CacheSizeValue;
        private System.Windows.Forms.Label labelCPUL2CacheSizeValue;
    }
}

