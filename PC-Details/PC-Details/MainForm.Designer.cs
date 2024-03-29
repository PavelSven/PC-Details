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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.groupBoxBIOS = new System.Windows.Forms.GroupBox();
            this.groupBoxMotherboard = new System.Windows.Forms.GroupBox();
            this.labelMotherboardVersionValue = new System.Windows.Forms.Label();
            this.labelMotherboardProductValue = new System.Windows.Forms.Label();
            this.labelMotherboardProduct = new System.Windows.Forms.Label();
            this.labelMotherboardManufacturerValue = new System.Windows.Forms.Label();
            this.labelMotherboardManufacturer = new System.Windows.Forms.Label();
            this.tabPageMemory = new System.Windows.Forms.TabPage();
            this.labelBIOSManufacturer = new System.Windows.Forms.Label();
            this.labelBIOSManufacturerValue = new System.Windows.Forms.Label();
            this.labelBIOSVersionValue = new System.Windows.Forms.Label();
            this.labelBIOSVersion = new System.Windows.Forms.Label();
            this.labelBIOSReleaseDateValue = new System.Windows.Forms.Label();
            this.labelBIOSReleaseDate = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageCPU.SuspendLayout();
            this.groupBoxCache.SuspendLayout();
            this.groupBoxClocks.SuspendLayout();
            this.groupBoxProcessor.SuspendLayout();
            this.tabPageMainboard.SuspendLayout();
            this.groupBoxBIOS.SuspendLayout();
            this.groupBoxMotherboard.SuspendLayout();
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
            this.tabControlMain.Size = new System.Drawing.Size(441, 329);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageCPU
            // 
            this.tabPageCPU.Controls.Add(this.groupBoxCache);
            this.tabPageCPU.Controls.Add(this.groupBoxClocks);
            this.tabPageCPU.Controls.Add(this.groupBoxProcessor);
            this.tabPageCPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(433, 303);
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
            this.labelCPUL3CacheSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUL3CacheSizeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUL2CacheSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUL2CacheSizeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUPercentProcessorTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUPercentProcessorTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUCurrentClockSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUCurrentClockSpeedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.groupBoxProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.labelCPUNumberOfLogicalProcessorsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUNumberOfLogicalProcessorsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUNumberOfCoresValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUNumberOfCoresValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUSocketDesignationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUSocketDesignationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUManufacturerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.labelCPUCaptionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUCaptionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.tabPageMainboard.Controls.Add(this.groupBoxBIOS);
            this.tabPageMainboard.Controls.Add(this.groupBoxMotherboard);
            this.tabPageMainboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageMainboard.Name = "tabPageMainboard";
            this.tabPageMainboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainboard.Size = new System.Drawing.Size(433, 303);
            this.tabPageMainboard.TabIndex = 1;
            this.tabPageMainboard.Text = "Mainboard";
            this.tabPageMainboard.UseVisualStyleBackColor = true;
            // 
            // groupBoxBIOS
            // 
            this.groupBoxBIOS.Controls.Add(this.labelBIOSReleaseDate);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSReleaseDateValue);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSVersion);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSVersionValue);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSManufacturer);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSManufacturerValue);
            this.groupBoxBIOS.Location = new System.Drawing.Point(7, 106);
            this.groupBoxBIOS.Name = "groupBoxBIOS";
            this.groupBoxBIOS.Size = new System.Drawing.Size(420, 100);
            this.groupBoxBIOS.TabIndex = 2;
            this.groupBoxBIOS.TabStop = false;
            this.groupBoxBIOS.Text = "BIOS";
            // 
            // groupBoxMotherboard
            // 
            this.groupBoxMotherboard.Controls.Add(this.labelMotherboardVersionValue);
            this.groupBoxMotherboard.Controls.Add(this.labelMotherboardProductValue);
            this.groupBoxMotherboard.Controls.Add(this.labelMotherboardProduct);
            this.groupBoxMotherboard.Controls.Add(this.labelMotherboardManufacturerValue);
            this.groupBoxMotherboard.Controls.Add(this.labelMotherboardManufacturer);
            this.groupBoxMotherboard.Location = new System.Drawing.Point(7, 7);
            this.groupBoxMotherboard.Name = "groupBoxMotherboard";
            this.groupBoxMotherboard.Size = new System.Drawing.Size(420, 84);
            this.groupBoxMotherboard.TabIndex = 1;
            this.groupBoxMotherboard.TabStop = false;
            this.groupBoxMotherboard.Text = "Motherboard";
            // 
            // labelMotherboardVersionValue
            // 
            this.labelMotherboardVersionValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMotherboardVersionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMotherboardVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMotherboardVersionValue.Location = new System.Drawing.Point(360, 42);
            this.labelMotherboardVersionValue.Name = "labelMotherboardVersionValue";
            this.labelMotherboardVersionValue.Size = new System.Drawing.Size(54, 17);
            this.labelMotherboardVersionValue.TabIndex = 0;
            this.labelMotherboardVersionValue.Text = "labelMotherboardVersionValue";
            this.labelMotherboardVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMotherboardProductValue
            // 
            this.labelMotherboardProductValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMotherboardProductValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMotherboardProductValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMotherboardProductValue.Location = new System.Drawing.Point(83, 42);
            this.labelMotherboardProductValue.Name = "labelMotherboardProductValue";
            this.labelMotherboardProductValue.Size = new System.Drawing.Size(260, 17);
            this.labelMotherboardProductValue.TabIndex = 0;
            this.labelMotherboardProductValue.Text = "labelMotherboardProductValue";
            this.labelMotherboardProductValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMotherboardProduct
            // 
            this.labelMotherboardProduct.AutoSize = true;
            this.labelMotherboardProduct.Location = new System.Drawing.Point(7, 46);
            this.labelMotherboardProduct.Name = "labelMotherboardProduct";
            this.labelMotherboardProduct.Size = new System.Drawing.Size(44, 13);
            this.labelMotherboardProduct.TabIndex = 0;
            this.labelMotherboardProduct.Text = "Product";
            // 
            // labelMotherboardManufacturerValue
            // 
            this.labelMotherboardManufacturerValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMotherboardManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMotherboardManufacturerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMotherboardManufacturerValue.Location = new System.Drawing.Point(83, 16);
            this.labelMotherboardManufacturerValue.Name = "labelMotherboardManufacturerValue";
            this.labelMotherboardManufacturerValue.Size = new System.Drawing.Size(331, 17);
            this.labelMotherboardManufacturerValue.TabIndex = 0;
            this.labelMotherboardManufacturerValue.Text = "labelMotherboardManufacturerValue";
            this.labelMotherboardManufacturerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMotherboardManufacturer
            // 
            this.labelMotherboardManufacturer.AutoSize = true;
            this.labelMotherboardManufacturer.Location = new System.Drawing.Point(7, 20);
            this.labelMotherboardManufacturer.Name = "labelMotherboardManufacturer";
            this.labelMotherboardManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelMotherboardManufacturer.TabIndex = 0;
            this.labelMotherboardManufacturer.Text = "Manufacturer";
            // 
            // tabPageMemory
            // 
            this.tabPageMemory.Location = new System.Drawing.Point(4, 22);
            this.tabPageMemory.Name = "tabPageMemory";
            this.tabPageMemory.Size = new System.Drawing.Size(433, 375);
            this.tabPageMemory.TabIndex = 2;
            this.tabPageMemory.Text = "Memory";
            this.tabPageMemory.UseVisualStyleBackColor = true;
            // 
            // labelBIOSManufacturer
            // 
            this.labelBIOSManufacturer.AutoSize = true;
            this.labelBIOSManufacturer.Location = new System.Drawing.Point(7, 26);
            this.labelBIOSManufacturer.Name = "labelBIOSManufacturer";
            this.labelBIOSManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelBIOSManufacturer.TabIndex = 0;
            this.labelBIOSManufacturer.Text = "Manufacturer";
            // 
            // labelBIOSManufacturerValue
            // 
            this.labelBIOSManufacturerValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBIOSManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBIOSManufacturerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelBIOSManufacturerValue.Location = new System.Drawing.Point(83, 22);
            this.labelBIOSManufacturerValue.Name = "labelBIOSManufacturerValue";
            this.labelBIOSManufacturerValue.Size = new System.Drawing.Size(331, 17);
            this.labelBIOSManufacturerValue.TabIndex = 0;
            this.labelBIOSManufacturerValue.Text = "labelBIOSManufacturerValue";
            this.labelBIOSManufacturerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBIOSVersionValue
            // 
            this.labelBIOSVersionValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBIOSVersionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBIOSVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelBIOSVersionValue.Location = new System.Drawing.Point(82, 56);
            this.labelBIOSVersionValue.Name = "labelBIOSVersionValue";
            this.labelBIOSVersionValue.Size = new System.Drawing.Size(67, 17);
            this.labelBIOSVersionValue.TabIndex = 0;
            this.labelBIOSVersionValue.Text = "labelBIOSVersionValue";
            this.labelBIOSVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBIOSVersion
            // 
            this.labelBIOSVersion.AutoSize = true;
            this.labelBIOSVersion.Location = new System.Drawing.Point(6, 60);
            this.labelBIOSVersion.Name = "labelBIOSVersion";
            this.labelBIOSVersion.Size = new System.Drawing.Size(42, 13);
            this.labelBIOSVersion.TabIndex = 0;
            this.labelBIOSVersion.Text = "Version";
            // 
            // labelBIOSReleaseDateValue
            // 
            this.labelBIOSReleaseDateValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBIOSReleaseDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBIOSReleaseDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelBIOSReleaseDateValue.Location = new System.Drawing.Point(270, 56);
            this.labelBIOSReleaseDateValue.Name = "labelBIOSReleaseDateValue";
            this.labelBIOSReleaseDateValue.Size = new System.Drawing.Size(144, 17);
            this.labelBIOSReleaseDateValue.TabIndex = 0;
            this.labelBIOSReleaseDateValue.Text = "labelBIOSReleaseDateValue";
            this.labelBIOSReleaseDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBIOSReleaseDate
            // 
            this.labelBIOSReleaseDate.AutoSize = true;
            this.labelBIOSReleaseDate.Location = new System.Drawing.Point(215, 58);
            this.labelBIOSReleaseDate.Name = "labelBIOSReleaseDate";
            this.labelBIOSReleaseDate.Size = new System.Drawing.Size(30, 13);
            this.labelBIOSReleaseDate.TabIndex = 0;
            this.labelBIOSReleaseDate.Text = "Date";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 336);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC-Details";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCPU.ResumeLayout(false);
            this.groupBoxCache.ResumeLayout(false);
            this.groupBoxCache.PerformLayout();
            this.groupBoxClocks.ResumeLayout(false);
            this.groupBoxClocks.PerformLayout();
            this.groupBoxProcessor.ResumeLayout(false);
            this.groupBoxProcessor.PerformLayout();
            this.tabPageMainboard.ResumeLayout(false);
            this.groupBoxBIOS.ResumeLayout(false);
            this.groupBoxBIOS.PerformLayout();
            this.groupBoxMotherboard.ResumeLayout(false);
            this.groupBoxMotherboard.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxMotherboard;
        private System.Windows.Forms.Label labelMotherboardManufacturer;
        private System.Windows.Forms.Label labelMotherboardProductValue;
        private System.Windows.Forms.Label labelMotherboardProduct;
        private System.Windows.Forms.Label labelMotherboardManufacturerValue;
        private System.Windows.Forms.Label labelMotherboardVersionValue;
        private System.Windows.Forms.GroupBox groupBoxBIOS;
        private System.Windows.Forms.Label labelBIOSReleaseDate;
        private System.Windows.Forms.Label labelBIOSReleaseDateValue;
        private System.Windows.Forms.Label labelBIOSVersion;
        private System.Windows.Forms.Label labelBIOSVersionValue;
        private System.Windows.Forms.Label labelBIOSManufacturer;
        private System.Windows.Forms.Label labelBIOSManufacturerValue;
    }
}

