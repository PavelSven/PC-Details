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
            this.tabPageMemory = new System.Windows.Forms.TabPage();
            this.groupBoxMemorySelection = new System.Windows.Forms.GroupBox();
            this.labelMemoryManufacturerValue = new System.Windows.Forms.Label();
            this.labelMemoryManufacturer = new System.Windows.Forms.Label();
            this.labelMemoryPartNumberValue = new System.Windows.Forms.Label();
            this.labelMemoryPartNumber = new System.Windows.Forms.Label();
            this.labelMemoryCapacityValue = new System.Windows.Forms.Label();
            this.labelMemoryCapacity = new System.Windows.Forms.Label();
            this.labelMemorySpeedValue = new System.Windows.Forms.Label();
            this.labelMemorySpeed = new System.Windows.Forms.Label();
            this.labelMemorySerialNumberValue = new System.Windows.Forms.Label();
            this.labelMemorySerialNumber = new System.Windows.Forms.Label();
            this.comboBoxMemorySelection = new System.Windows.Forms.ComboBox();
            this.tabPageMainboard = new System.Windows.Forms.TabPage();
            this.groupBoxMotherboard = new System.Windows.Forms.GroupBox();
            this.labelMotherboardManufacturer = new System.Windows.Forms.Label();
            this.labelMotherboardManufacturerValue = new System.Windows.Forms.Label();
            this.labelMotherboardProduct = new System.Windows.Forms.Label();
            this.labelMotherboardProductValue = new System.Windows.Forms.Label();
            this.labelMotherboardVersionValue = new System.Windows.Forms.Label();
            this.groupBoxBIOS = new System.Windows.Forms.GroupBox();
            this.labelBIOSManufacturerValue = new System.Windows.Forms.Label();
            this.labelBIOSManufacturer = new System.Windows.Forms.Label();
            this.labelBIOSVersionValue = new System.Windows.Forms.Label();
            this.labelBIOSVersion = new System.Windows.Forms.Label();
            this.labelBIOSReleaseDateValue = new System.Windows.Forms.Label();
            this.labelBIOSReleaseDate = new System.Windows.Forms.Label();
            this.groupBoxMotherboardTemperature = new System.Windows.Forms.GroupBox();
            this.labelTemperatureSystemValue = new System.Windows.Forms.Label();
            this.labelTemperatureSystem = new System.Windows.Forms.Label();
            this.labelTemperaturePCIex1Value = new System.Windows.Forms.Label();
            this.labelTemperaturePCIex1 = new System.Windows.Forms.Label();
            this.labelTemperaturePCHValue = new System.Windows.Forms.Label();
            this.labelTemperatureVRMMOSValue = new System.Windows.Forms.Label();
            this.labelTemperaturePCH = new System.Windows.Forms.Label();
            this.labelTemperatureVRMMOS = new System.Windows.Forms.Label();
            this.labelTemperatureSocketValue = new System.Windows.Forms.Label();
            this.labelTemperatureSocket = new System.Windows.Forms.Label();
            this.tabPageCPU = new System.Windows.Forms.TabPage();
            this.groupBoxProcessor = new System.Windows.Forms.GroupBox();
            this.labelCPUManufacturerValue = new System.Windows.Forms.Label();
            this.labelCPUManufacturer = new System.Windows.Forms.Label();
            this.labelCPUNameValue = new System.Windows.Forms.Label();
            this.labelCPUName = new System.Windows.Forms.Label();
            this.labelCPUSocketDesignationValue = new System.Windows.Forms.Label();
            this.labelCPUNumberOfCoresValue = new System.Windows.Forms.Label();
            this.labelCPUProcessorTemperatureValue = new System.Windows.Forms.Label();
            this.labelCPUNumberOfLogicalProcessorsValue = new System.Windows.Forms.Label();
            this.labelCPUSocketDesignation = new System.Windows.Forms.Label();
            this.labelCPUProcessorTemperature = new System.Windows.Forms.Label();
            this.labelCPUNumberOfCores = new System.Windows.Forms.Label();
            this.labelCPUNumberOfLogicalProcessors = new System.Windows.Forms.Label();
            this.pictureBoxProcessorLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxClocks = new System.Windows.Forms.GroupBox();
            this.labelCPUCurrentClockSpeedValue = new System.Windows.Forms.Label();
            this.labelCPUCurrentClockSpeed = new System.Windows.Forms.Label();
            this.labelCPUPercentProcessorTimeValue = new System.Windows.Forms.Label();
            this.labelCPUPercentProcessorTime = new System.Windows.Forms.Label();
            this.labelCPUBusSpeedValue = new System.Windows.Forms.Label();
            this.labelCPUBusSpeed = new System.Windows.Forms.Label();
            this.groupBoxCache = new System.Windows.Forms.GroupBox();
            this.labelCPUL2CacheSizeValue = new System.Windows.Forms.Label();
            this.labelCPUL3CacheSizeValue = new System.Windows.Forms.Label();
            this.labelCPUL2CacheSize = new System.Windows.Forms.Label();
            this.labelCPUL3CacheSize = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMemory.SuspendLayout();
            this.groupBoxMemorySelection.SuspendLayout();
            this.tabPageMainboard.SuspendLayout();
            this.groupBoxMotherboard.SuspendLayout();
            this.groupBoxBIOS.SuspendLayout();
            this.groupBoxMotherboardTemperature.SuspendLayout();
            this.tabPageCPU.SuspendLayout();
            this.groupBoxProcessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessorLogo)).BeginInit();
            this.groupBoxClocks.SuspendLayout();
            this.groupBoxCache.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMemory
            // 
            this.tabPageMemory.Controls.Add(this.groupBoxMemorySelection);
            this.tabPageMemory.Location = new System.Drawing.Point(4, 22);
            this.tabPageMemory.Name = "tabPageMemory";
            this.tabPageMemory.Size = new System.Drawing.Size(433, 298);
            this.tabPageMemory.TabIndex = 2;
            this.tabPageMemory.Text = "Memory";
            this.tabPageMemory.UseVisualStyleBackColor = true;
            // 
            // groupBoxMemorySelection
            // 
            this.groupBoxMemorySelection.Controls.Add(this.comboBoxMemorySelection);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemorySerialNumber);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemorySerialNumberValue);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemorySpeed);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemorySpeedValue);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemoryCapacity);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemoryCapacityValue);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemoryPartNumber);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemoryPartNumberValue);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemoryManufacturer);
            this.groupBoxMemorySelection.Controls.Add(this.labelMemoryManufacturerValue);
            this.groupBoxMemorySelection.Location = new System.Drawing.Point(6, 4);
            this.groupBoxMemorySelection.Name = "groupBoxMemorySelection";
            this.groupBoxMemorySelection.Size = new System.Drawing.Size(422, 129);
            this.groupBoxMemorySelection.TabIndex = 0;
            this.groupBoxMemorySelection.TabStop = false;
            this.groupBoxMemorySelection.Text = "Memory Selection";
            // 
            // labelMemoryManufacturerValue
            // 
            this.labelMemoryManufacturerValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMemoryManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMemoryManufacturerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMemoryManufacturerValue.Location = new System.Drawing.Point(219, 20);
            this.labelMemoryManufacturerValue.Name = "labelMemoryManufacturerValue";
            this.labelMemoryManufacturerValue.Size = new System.Drawing.Size(197, 21);
            this.labelMemoryManufacturerValue.TabIndex = 3;
            this.labelMemoryManufacturerValue.Text = "labelMemoryManufacturerValue";
            this.labelMemoryManufacturerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMemoryManufacturer
            // 
            this.labelMemoryManufacturer.Location = new System.Drawing.Point(123, 20);
            this.labelMemoryManufacturer.Name = "labelMemoryManufacturer";
            this.labelMemoryManufacturer.Size = new System.Drawing.Size(72, 21);
            this.labelMemoryManufacturer.TabIndex = 4;
            this.labelMemoryManufacturer.Text = "Manufacturer";
            this.labelMemoryManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemoryPartNumberValue
            // 
            this.labelMemoryPartNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMemoryPartNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMemoryPartNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMemoryPartNumberValue.Location = new System.Drawing.Point(95, 53);
            this.labelMemoryPartNumberValue.Name = "labelMemoryPartNumberValue";
            this.labelMemoryPartNumberValue.Size = new System.Drawing.Size(154, 21);
            this.labelMemoryPartNumberValue.TabIndex = 3;
            this.labelMemoryPartNumberValue.Text = "labelMemoryPartNumberValue";
            this.labelMemoryPartNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMemoryPartNumber
            // 
            this.labelMemoryPartNumber.Location = new System.Drawing.Point(6, 53);
            this.labelMemoryPartNumber.Name = "labelMemoryPartNumber";
            this.labelMemoryPartNumber.Size = new System.Drawing.Size(70, 21);
            this.labelMemoryPartNumber.TabIndex = 4;
            this.labelMemoryPartNumber.Text = "Part Number";
            this.labelMemoryPartNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemoryCapacityValue
            // 
            this.labelMemoryCapacityValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMemoryCapacityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMemoryCapacityValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMemoryCapacityValue.Location = new System.Drawing.Point(336, 52);
            this.labelMemoryCapacityValue.Name = "labelMemoryCapacityValue";
            this.labelMemoryCapacityValue.Size = new System.Drawing.Size(80, 21);
            this.labelMemoryCapacityValue.TabIndex = 3;
            this.labelMemoryCapacityValue.Text = "labelMemoryCapacityValue";
            this.labelMemoryCapacityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMemoryCapacity
            // 
            this.labelMemoryCapacity.Location = new System.Drawing.Point(270, 53);
            this.labelMemoryCapacity.Name = "labelMemoryCapacity";
            this.labelMemoryCapacity.Size = new System.Drawing.Size(60, 21);
            this.labelMemoryCapacity.TabIndex = 4;
            this.labelMemoryCapacity.Text = "Capacity";
            this.labelMemoryCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemorySpeedValue
            // 
            this.labelMemorySpeedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMemorySpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMemorySpeedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMemorySpeedValue.Location = new System.Drawing.Point(336, 84);
            this.labelMemorySpeedValue.Name = "labelMemorySpeedValue";
            this.labelMemorySpeedValue.Size = new System.Drawing.Size(80, 21);
            this.labelMemorySpeedValue.TabIndex = 3;
            this.labelMemorySpeedValue.Text = "labelMemorySpeedValue";
            this.labelMemorySpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMemorySpeed
            // 
            this.labelMemorySpeed.Location = new System.Drawing.Point(270, 85);
            this.labelMemorySpeed.Name = "labelMemorySpeed";
            this.labelMemorySpeed.Size = new System.Drawing.Size(60, 21);
            this.labelMemorySpeed.TabIndex = 4;
            this.labelMemorySpeed.Text = "Speed";
            this.labelMemorySpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemorySerialNumberValue
            // 
            this.labelMemorySerialNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMemorySerialNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMemorySerialNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMemorySerialNumberValue.Location = new System.Drawing.Point(95, 85);
            this.labelMemorySerialNumberValue.Name = "labelMemorySerialNumberValue";
            this.labelMemorySerialNumberValue.Size = new System.Drawing.Size(154, 21);
            this.labelMemorySerialNumberValue.TabIndex = 3;
            this.labelMemorySerialNumberValue.Text = "labelMemorySerialNumberValue";
            this.labelMemorySerialNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMemorySerialNumber
            // 
            this.labelMemorySerialNumber.Location = new System.Drawing.Point(6, 85);
            this.labelMemorySerialNumber.Name = "labelMemorySerialNumber";
            this.labelMemorySerialNumber.Size = new System.Drawing.Size(83, 21);
            this.labelMemorySerialNumber.TabIndex = 4;
            this.labelMemorySerialNumber.Text = "Serial Number";
            this.labelMemorySerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxMemorySelection
            // 
            this.comboBoxMemorySelection.FormattingEnabled = true;
            this.comboBoxMemorySelection.Location = new System.Drawing.Point(9, 20);
            this.comboBoxMemorySelection.Name = "comboBoxMemorySelection";
            this.comboBoxMemorySelection.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMemorySelection.TabIndex = 5;
            this.comboBoxMemorySelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxMemorySelection_SelectedIndexChanged);
            // 
            // tabPageMainboard
            // 
            this.tabPageMainboard.Controls.Add(this.groupBoxMotherboardTemperature);
            this.tabPageMainboard.Controls.Add(this.groupBoxBIOS);
            this.tabPageMainboard.Controls.Add(this.groupBoxMotherboard);
            this.tabPageMainboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageMainboard.Name = "tabPageMainboard";
            this.tabPageMainboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainboard.Size = new System.Drawing.Size(433, 298);
            this.tabPageMainboard.TabIndex = 1;
            this.tabPageMainboard.Text = "Mainboard";
            this.tabPageMainboard.UseVisualStyleBackColor = true;
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
            this.groupBoxMotherboard.Size = new System.Drawing.Size(420, 79);
            this.groupBoxMotherboard.TabIndex = 1;
            this.groupBoxMotherboard.TabStop = false;
            this.groupBoxMotherboard.Text = "Motherboard";
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
            // labelMotherboardProduct
            // 
            this.labelMotherboardProduct.AutoSize = true;
            this.labelMotherboardProduct.Location = new System.Drawing.Point(7, 46);
            this.labelMotherboardProduct.Name = "labelMotherboardProduct";
            this.labelMotherboardProduct.Size = new System.Drawing.Size(44, 13);
            this.labelMotherboardProduct.TabIndex = 0;
            this.labelMotherboardProduct.Text = "Product";
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
            // groupBoxBIOS
            // 
            this.groupBoxBIOS.Controls.Add(this.labelBIOSReleaseDate);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSReleaseDateValue);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSVersion);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSVersionValue);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSManufacturer);
            this.groupBoxBIOS.Controls.Add(this.labelBIOSManufacturerValue);
            this.groupBoxBIOS.Location = new System.Drawing.Point(7, 203);
            this.groupBoxBIOS.Name = "groupBoxBIOS";
            this.groupBoxBIOS.Size = new System.Drawing.Size(420, 91);
            this.groupBoxBIOS.TabIndex = 2;
            this.groupBoxBIOS.TabStop = false;
            this.groupBoxBIOS.Text = "BIOS";
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
            // labelBIOSManufacturer
            // 
            this.labelBIOSManufacturer.AutoSize = true;
            this.labelBIOSManufacturer.Location = new System.Drawing.Point(7, 26);
            this.labelBIOSManufacturer.Name = "labelBIOSManufacturer";
            this.labelBIOSManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelBIOSManufacturer.TabIndex = 0;
            this.labelBIOSManufacturer.Text = "Manufacturer";
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
            // groupBoxMotherboardTemperature
            // 
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperatureSocket);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperatureSocketValue);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperatureVRMMOS);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperaturePCH);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperatureVRMMOSValue);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperaturePCHValue);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperaturePCIex1);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperaturePCIex1Value);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperatureSystem);
            this.groupBoxMotherboardTemperature.Controls.Add(this.labelTemperatureSystemValue);
            this.groupBoxMotherboardTemperature.Location = new System.Drawing.Point(7, 93);
            this.groupBoxMotherboardTemperature.Name = "groupBoxMotherboardTemperature";
            this.groupBoxMotherboardTemperature.Size = new System.Drawing.Size(421, 104);
            this.groupBoxMotherboardTemperature.TabIndex = 3;
            this.groupBoxMotherboardTemperature.TabStop = false;
            this.groupBoxMotherboardTemperature.Text = "Temperature";
            // 
            // labelTemperatureSystemValue
            // 
            this.labelTemperatureSystemValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTemperatureSystemValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperatureSystemValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTemperatureSystemValue.Location = new System.Drawing.Point(82, 21);
            this.labelTemperatureSystemValue.Name = "labelTemperatureSystemValue";
            this.labelTemperatureSystemValue.Size = new System.Drawing.Size(77, 17);
            this.labelTemperatureSystemValue.TabIndex = 0;
            this.labelTemperatureSystemValue.Text = "labelTemperatureSystemValue";
            this.labelTemperatureSystemValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperatureSystem
            // 
            this.labelTemperatureSystem.AutoSize = true;
            this.labelTemperatureSystem.Location = new System.Drawing.Point(7, 25);
            this.labelTemperatureSystem.Name = "labelTemperatureSystem";
            this.labelTemperatureSystem.Size = new System.Drawing.Size(41, 13);
            this.labelTemperatureSystem.TabIndex = 0;
            this.labelTemperatureSystem.Text = "System";
            // 
            // labelTemperaturePCIex1Value
            // 
            this.labelTemperaturePCIex1Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTemperaturePCIex1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperaturePCIex1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTemperaturePCIex1Value.Location = new System.Drawing.Point(83, 73);
            this.labelTemperaturePCIex1Value.Name = "labelTemperaturePCIex1Value";
            this.labelTemperaturePCIex1Value.Size = new System.Drawing.Size(77, 17);
            this.labelTemperaturePCIex1Value.TabIndex = 0;
            this.labelTemperaturePCIex1Value.Text = "labelTemperaturePCIex1Value";
            this.labelTemperaturePCIex1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperaturePCIex1
            // 
            this.labelTemperaturePCIex1.AutoSize = true;
            this.labelTemperaturePCIex1.Location = new System.Drawing.Point(7, 77);
            this.labelTemperaturePCIex1.Name = "labelTemperaturePCIex1";
            this.labelTemperaturePCIex1.Size = new System.Drawing.Size(47, 13);
            this.labelTemperaturePCIex1.TabIndex = 0;
            this.labelTemperaturePCIex1.Text = "PCIe x 1";
            // 
            // labelTemperaturePCHValue
            // 
            this.labelTemperaturePCHValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTemperaturePCHValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperaturePCHValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTemperaturePCHValue.Location = new System.Drawing.Point(343, 49);
            this.labelTemperaturePCHValue.Name = "labelTemperaturePCHValue";
            this.labelTemperaturePCHValue.Size = new System.Drawing.Size(70, 17);
            this.labelTemperaturePCHValue.TabIndex = 0;
            this.labelTemperaturePCHValue.Text = "labelTemperaturePCHValue";
            this.labelTemperaturePCHValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperatureVRMMOSValue
            // 
            this.labelTemperatureVRMMOSValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTemperatureVRMMOSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperatureVRMMOSValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTemperatureVRMMOSValue.Location = new System.Drawing.Point(344, 21);
            this.labelTemperatureVRMMOSValue.Name = "labelTemperatureVRMMOSValue";
            this.labelTemperatureVRMMOSValue.Size = new System.Drawing.Size(70, 17);
            this.labelTemperatureVRMMOSValue.TabIndex = 0;
            this.labelTemperatureVRMMOSValue.Text = "labelTemperatureVRMMOSValue";
            this.labelTemperatureVRMMOSValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperaturePCH
            // 
            this.labelTemperaturePCH.AutoSize = true;
            this.labelTemperaturePCH.Location = new System.Drawing.Point(267, 53);
            this.labelTemperaturePCH.Name = "labelTemperaturePCH";
            this.labelTemperaturePCH.Size = new System.Drawing.Size(29, 13);
            this.labelTemperaturePCH.TabIndex = 0;
            this.labelTemperaturePCH.Text = "PCH";
            // 
            // labelTemperatureVRMMOS
            // 
            this.labelTemperatureVRMMOS.AutoSize = true;
            this.labelTemperatureVRMMOS.Location = new System.Drawing.Point(267, 25);
            this.labelTemperatureVRMMOS.Name = "labelTemperatureVRMMOS";
            this.labelTemperatureVRMMOS.Size = new System.Drawing.Size(58, 13);
            this.labelTemperatureVRMMOS.TabIndex = 0;
            this.labelTemperatureVRMMOS.Text = "VRM MOS";
            // 
            // labelTemperatureSocketValue
            // 
            this.labelTemperatureSocketValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTemperatureSocketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperatureSocketValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTemperatureSocketValue.Location = new System.Drawing.Point(83, 46);
            this.labelTemperatureSocketValue.Name = "labelTemperatureSocketValue";
            this.labelTemperatureSocketValue.Size = new System.Drawing.Size(77, 17);
            this.labelTemperatureSocketValue.TabIndex = 0;
            this.labelTemperatureSocketValue.Text = "labelTemperatureSocketValue";
            this.labelTemperatureSocketValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperatureSocket
            // 
            this.labelTemperatureSocket.AutoSize = true;
            this.labelTemperatureSocket.Location = new System.Drawing.Point(7, 50);
            this.labelTemperatureSocket.Name = "labelTemperatureSocket";
            this.labelTemperatureSocket.Size = new System.Drawing.Size(66, 13);
            this.labelTemperatureSocket.TabIndex = 0;
            this.labelTemperatureSocket.Text = "CPU Socket";
            // 
            // tabPageCPU
            // 
            this.tabPageCPU.Controls.Add(this.groupBoxCache);
            this.tabPageCPU.Controls.Add(this.groupBoxClocks);
            this.tabPageCPU.Controls.Add(this.groupBoxProcessor);
            this.tabPageCPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(433, 298);
            this.tabPageCPU.TabIndex = 0;
            this.tabPageCPU.Text = "CPU";
            this.tabPageCPU.UseVisualStyleBackColor = true;
            // 
            // groupBoxProcessor
            // 
            this.groupBoxProcessor.Controls.Add(this.pictureBoxProcessorLogo);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfLogicalProcessors);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfCores);
            this.groupBoxProcessor.Controls.Add(this.labelCPUProcessorTemperature);
            this.groupBoxProcessor.Controls.Add(this.labelCPUSocketDesignation);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfLogicalProcessorsValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUProcessorTemperatureValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNumberOfCoresValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUSocketDesignationValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUName);
            this.groupBoxProcessor.Controls.Add(this.labelCPUNameValue);
            this.groupBoxProcessor.Controls.Add(this.labelCPUManufacturer);
            this.groupBoxProcessor.Controls.Add(this.labelCPUManufacturerValue);
            this.groupBoxProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxProcessor.Location = new System.Drawing.Point(6, 6);
            this.groupBoxProcessor.Name = "groupBoxProcessor";
            this.groupBoxProcessor.Size = new System.Drawing.Size(421, 181);
            this.groupBoxProcessor.TabIndex = 1;
            this.groupBoxProcessor.TabStop = false;
            this.groupBoxProcessor.Text = "Processor";
            // 
            // labelCPUManufacturerValue
            // 
            this.labelCPUManufacturerValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUManufacturerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCPUManufacturerValue.Location = new System.Drawing.Point(78, 39);
            this.labelCPUManufacturerValue.Name = "labelCPUManufacturerValue";
            this.labelCPUManufacturerValue.Size = new System.Drawing.Size(337, 21);
            this.labelCPUManufacturerValue.TabIndex = 1;
            this.labelCPUManufacturerValue.Text = "labelCPUManufacturerValue";
            this.labelCPUManufacturerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labelCPUNameValue
            // 
            this.labelCPUNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCPUNameValue.Location = new System.Drawing.Point(78, 16);
            this.labelCPUNameValue.Name = "labelCPUNameValue";
            this.labelCPUNameValue.Size = new System.Drawing.Size(337, 21);
            this.labelCPUNameValue.TabIndex = 1;
            this.labelCPUNameValue.Text = "labelCPUNameValue";
            this.labelCPUNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUName
            // 
            this.labelCPUName.AutoSize = true;
            this.labelCPUName.Location = new System.Drawing.Point(6, 20);
            this.labelCPUName.Name = "labelCPUName";
            this.labelCPUName.Size = new System.Drawing.Size(35, 13);
            this.labelCPUName.TabIndex = 2;
            this.labelCPUName.Text = "Name";
            // 
            // labelCPUSocketDesignationValue
            // 
            this.labelCPUSocketDesignationValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUSocketDesignationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUSocketDesignationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCPUSocketDesignationValue.Location = new System.Drawing.Point(78, 62);
            this.labelCPUSocketDesignationValue.Name = "labelCPUSocketDesignationValue";
            this.labelCPUSocketDesignationValue.Size = new System.Drawing.Size(63, 21);
            this.labelCPUSocketDesignationValue.TabIndex = 1;
            this.labelCPUSocketDesignationValue.Text = "labelCPUSocketDesignationValue";
            this.labelCPUSocketDesignationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUNumberOfCoresValue
            // 
            this.labelCPUNumberOfCoresValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUNumberOfCoresValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUNumberOfCoresValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCPUNumberOfCoresValue.Location = new System.Drawing.Point(47, 92);
            this.labelCPUNumberOfCoresValue.Name = "labelCPUNumberOfCoresValue";
            this.labelCPUNumberOfCoresValue.Size = new System.Drawing.Size(39, 21);
            this.labelCPUNumberOfCoresValue.TabIndex = 1;
            this.labelCPUNumberOfCoresValue.Text = "labelCPUNumberOfCoresValue";
            this.labelCPUNumberOfCoresValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUProcessorTemperatureValue
            // 
            this.labelCPUProcessorTemperatureValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUProcessorTemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUProcessorTemperatureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCPUProcessorTemperatureValue.Location = new System.Drawing.Point(81, 139);
            this.labelCPUProcessorTemperatureValue.Name = "labelCPUProcessorTemperatureValue";
            this.labelCPUProcessorTemperatureValue.Size = new System.Drawing.Size(63, 21);
            this.labelCPUProcessorTemperatureValue.TabIndex = 1;
            this.labelCPUProcessorTemperatureValue.Text = "labelCPUProcessorTemperatureValue";
            this.labelCPUProcessorTemperatureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUNumberOfLogicalProcessorsValue
            // 
            this.labelCPUNumberOfLogicalProcessorsValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUNumberOfLogicalProcessorsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUNumberOfLogicalProcessorsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCPUNumberOfLogicalProcessorsValue.Location = new System.Drawing.Point(150, 92);
            this.labelCPUNumberOfLogicalProcessorsValue.Name = "labelCPUNumberOfLogicalProcessorsValue";
            this.labelCPUNumberOfLogicalProcessorsValue.Size = new System.Drawing.Size(39, 21);
            this.labelCPUNumberOfLogicalProcessorsValue.TabIndex = 1;
            this.labelCPUNumberOfLogicalProcessorsValue.Text = "labelCPUNumberOfLogicalProcessorsValue";
            this.labelCPUNumberOfLogicalProcessorsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUSocketDesignation
            // 
            this.labelCPUSocketDesignation.AutoSize = true;
            this.labelCPUSocketDesignation.Location = new System.Drawing.Point(6, 66);
            this.labelCPUSocketDesignation.Name = "labelCPUSocketDesignation";
            this.labelCPUSocketDesignation.Size = new System.Drawing.Size(41, 13);
            this.labelCPUSocketDesignation.TabIndex = 2;
            this.labelCPUSocketDesignation.Text = "Socket";
            // 
            // labelCPUProcessorTemperature
            // 
            this.labelCPUProcessorTemperature.AutoSize = true;
            this.labelCPUProcessorTemperature.Location = new System.Drawing.Point(9, 143);
            this.labelCPUProcessorTemperature.Name = "labelCPUProcessorTemperature";
            this.labelCPUProcessorTemperature.Size = new System.Drawing.Size(67, 13);
            this.labelCPUProcessorTemperature.TabIndex = 2;
            this.labelCPUProcessorTemperature.Text = "Temperature";
            // 
            // labelCPUNumberOfCores
            // 
            this.labelCPUNumberOfCores.AutoSize = true;
            this.labelCPUNumberOfCores.Location = new System.Drawing.Point(7, 97);
            this.labelCPUNumberOfCores.Name = "labelCPUNumberOfCores";
            this.labelCPUNumberOfCores.Size = new System.Drawing.Size(34, 13);
            this.labelCPUNumberOfCores.TabIndex = 2;
            this.labelCPUNumberOfCores.Text = "Cores";
            // 
            // labelCPUNumberOfLogicalProcessors
            // 
            this.labelCPUNumberOfLogicalProcessors.AutoSize = true;
            this.labelCPUNumberOfLogicalProcessors.Location = new System.Drawing.Point(95, 97);
            this.labelCPUNumberOfLogicalProcessors.Name = "labelCPUNumberOfLogicalProcessors";
            this.labelCPUNumberOfLogicalProcessors.Size = new System.Drawing.Size(46, 13);
            this.labelCPUNumberOfLogicalProcessors.TabIndex = 2;
            this.labelCPUNumberOfLogicalProcessors.Text = "Threads";
            // 
            // pictureBoxProcessorLogo
            // 
            this.pictureBoxProcessorLogo.Location = new System.Drawing.Point(209, 66);
            this.pictureBoxProcessorLogo.Name = "pictureBoxProcessorLogo";
            this.pictureBoxProcessorLogo.Size = new System.Drawing.Size(206, 100);
            this.pictureBoxProcessorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProcessorLogo.TabIndex = 3;
            this.pictureBoxProcessorLogo.TabStop = false;
            // 
            // groupBoxClocks
            // 
            this.groupBoxClocks.Controls.Add(this.labelCPUBusSpeed);
            this.groupBoxClocks.Controls.Add(this.labelCPUBusSpeedValue);
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
            // labelCPUCurrentClockSpeed
            // 
            this.labelCPUCurrentClockSpeed.AutoSize = true;
            this.labelCPUCurrentClockSpeed.Location = new System.Drawing.Point(6, 20);
            this.labelCPUCurrentClockSpeed.Name = "labelCPUCurrentClockSpeed";
            this.labelCPUCurrentClockSpeed.Size = new System.Drawing.Size(63, 13);
            this.labelCPUCurrentClockSpeed.TabIndex = 3;
            this.labelCPUCurrentClockSpeed.Text = "Core Speed";
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
            this.labelCPUPercentProcessorTimeValue.Text = "labelCPUPercentProcessorTimeValue";
            this.labelCPUPercentProcessorTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labelCPUBusSpeedValue
            // 
            this.labelCPUBusSpeedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPUBusSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPUBusSpeedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCPUBusSpeedValue.Location = new System.Drawing.Point(78, 74);
            this.labelCPUBusSpeedValue.Name = "labelCPUBusSpeedValue";
            this.labelCPUBusSpeedValue.Size = new System.Drawing.Size(78, 22);
            this.labelCPUBusSpeedValue.TabIndex = 2;
            this.labelCPUBusSpeedValue.Text = "labelCPUBusSpeedValue";
            this.labelCPUBusSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUBusSpeed
            // 
            this.labelCPUBusSpeed.AutoSize = true;
            this.labelCPUBusSpeed.Location = new System.Drawing.Point(6, 78);
            this.labelCPUBusSpeed.Name = "labelCPUBusSpeed";
            this.labelCPUBusSpeed.Size = new System.Drawing.Size(59, 13);
            this.labelCPUBusSpeed.TabIndex = 3;
            this.labelCPUBusSpeed.Text = "Bus Speed";
            // 
            // groupBoxCache
            // 
            this.groupBoxCache.Controls.Add(this.labelCPUL3CacheSize);
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
            // labelCPUL2CacheSize
            // 
            this.labelCPUL2CacheSize.AutoSize = true;
            this.labelCPUL2CacheSize.Location = new System.Drawing.Point(6, 47);
            this.labelCPUL2CacheSize.Name = "labelCPUL2CacheSize";
            this.labelCPUL2CacheSize.Size = new System.Drawing.Size(19, 13);
            this.labelCPUL2CacheSize.TabIndex = 3;
            this.labelCPUL2CacheSize.Text = "L2";
            // 
            // labelCPUL3CacheSize
            // 
            this.labelCPUL3CacheSize.AutoSize = true;
            this.labelCPUL3CacheSize.Location = new System.Drawing.Point(6, 78);
            this.labelCPUL3CacheSize.Name = "labelCPUL3CacheSize";
            this.labelCPUL3CacheSize.Size = new System.Drawing.Size(19, 13);
            this.labelCPUL3CacheSize.TabIndex = 3;
            this.labelCPUL3CacheSize.Text = "L3";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageCPU);
            this.tabControlMain.Controls.Add(this.tabPageMainboard);
            this.tabControlMain.Controls.Add(this.tabPageMemory);
            this.tabControlMain.Location = new System.Drawing.Point(3, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(441, 324);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 330);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC-Details";
            this.tabPageMemory.ResumeLayout(false);
            this.groupBoxMemorySelection.ResumeLayout(false);
            this.tabPageMainboard.ResumeLayout(false);
            this.groupBoxMotherboard.ResumeLayout(false);
            this.groupBoxMotherboard.PerformLayout();
            this.groupBoxBIOS.ResumeLayout(false);
            this.groupBoxBIOS.PerformLayout();
            this.groupBoxMotherboardTemperature.ResumeLayout(false);
            this.groupBoxMotherboardTemperature.PerformLayout();
            this.tabPageCPU.ResumeLayout(false);
            this.groupBoxProcessor.ResumeLayout(false);
            this.groupBoxProcessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessorLogo)).EndInit();
            this.groupBoxClocks.ResumeLayout(false);
            this.groupBoxClocks.PerformLayout();
            this.groupBoxCache.ResumeLayout(false);
            this.groupBoxCache.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageMemory;
        private System.Windows.Forms.GroupBox groupBoxMemorySelection;
        private System.Windows.Forms.ComboBox comboBoxMemorySelection;
        private System.Windows.Forms.Label labelMemorySerialNumber;
        private System.Windows.Forms.Label labelMemorySerialNumberValue;
        private System.Windows.Forms.Label labelMemorySpeed;
        private System.Windows.Forms.Label labelMemorySpeedValue;
        private System.Windows.Forms.Label labelMemoryCapacity;
        private System.Windows.Forms.Label labelMemoryCapacityValue;
        private System.Windows.Forms.Label labelMemoryPartNumber;
        private System.Windows.Forms.Label labelMemoryPartNumberValue;
        private System.Windows.Forms.Label labelMemoryManufacturer;
        private System.Windows.Forms.Label labelMemoryManufacturerValue;
        private System.Windows.Forms.TabPage tabPageMainboard;
        private System.Windows.Forms.GroupBox groupBoxMotherboardTemperature;
        private System.Windows.Forms.Label labelTemperatureSocket;
        private System.Windows.Forms.Label labelTemperatureSocketValue;
        private System.Windows.Forms.Label labelTemperatureVRMMOS;
        private System.Windows.Forms.Label labelTemperaturePCH;
        private System.Windows.Forms.Label labelTemperatureVRMMOSValue;
        private System.Windows.Forms.Label labelTemperaturePCHValue;
        private System.Windows.Forms.Label labelTemperaturePCIex1;
        private System.Windows.Forms.Label labelTemperaturePCIex1Value;
        private System.Windows.Forms.Label labelTemperatureSystem;
        private System.Windows.Forms.Label labelTemperatureSystemValue;
        private System.Windows.Forms.GroupBox groupBoxBIOS;
        private System.Windows.Forms.Label labelBIOSReleaseDate;
        private System.Windows.Forms.Label labelBIOSReleaseDateValue;
        private System.Windows.Forms.Label labelBIOSVersion;
        private System.Windows.Forms.Label labelBIOSVersionValue;
        private System.Windows.Forms.Label labelBIOSManufacturer;
        private System.Windows.Forms.Label labelBIOSManufacturerValue;
        private System.Windows.Forms.GroupBox groupBoxMotherboard;
        private System.Windows.Forms.Label labelMotherboardVersionValue;
        private System.Windows.Forms.Label labelMotherboardProductValue;
        private System.Windows.Forms.Label labelMotherboardProduct;
        private System.Windows.Forms.Label labelMotherboardManufacturerValue;
        private System.Windows.Forms.Label labelMotherboardManufacturer;
        private System.Windows.Forms.TabPage tabPageCPU;
        private System.Windows.Forms.GroupBox groupBoxCache;
        private System.Windows.Forms.Label labelCPUL3CacheSize;
        private System.Windows.Forms.Label labelCPUL2CacheSize;
        private System.Windows.Forms.Label labelCPUL3CacheSizeValue;
        private System.Windows.Forms.Label labelCPUL2CacheSizeValue;
        private System.Windows.Forms.GroupBox groupBoxClocks;
        private System.Windows.Forms.Label labelCPUBusSpeed;
        private System.Windows.Forms.Label labelCPUBusSpeedValue;
        private System.Windows.Forms.Label labelCPUPercentProcessorTime;
        private System.Windows.Forms.Label labelCPUPercentProcessorTimeValue;
        private System.Windows.Forms.Label labelCPUCurrentClockSpeed;
        private System.Windows.Forms.Label labelCPUCurrentClockSpeedValue;
        private System.Windows.Forms.GroupBox groupBoxProcessor;
        private System.Windows.Forms.PictureBox pictureBoxProcessorLogo;
        private System.Windows.Forms.Label labelCPUNumberOfLogicalProcessors;
        private System.Windows.Forms.Label labelCPUNumberOfCores;
        private System.Windows.Forms.Label labelCPUProcessorTemperature;
        private System.Windows.Forms.Label labelCPUSocketDesignation;
        private System.Windows.Forms.Label labelCPUNumberOfLogicalProcessorsValue;
        private System.Windows.Forms.Label labelCPUProcessorTemperatureValue;
        private System.Windows.Forms.Label labelCPUNumberOfCoresValue;
        private System.Windows.Forms.Label labelCPUSocketDesignationValue;
        private System.Windows.Forms.Label labelCPUName;
        private System.Windows.Forms.Label labelCPUNameValue;
        private System.Windows.Forms.Label labelCPUManufacturer;
        private System.Windows.Forms.Label labelCPUManufacturerValue;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}

