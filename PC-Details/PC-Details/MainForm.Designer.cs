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
            this.groupBoxProcessor = new System.Windows.Forms.GroupBox();
            this.labelCPUNumberOfCores = new System.Windows.Forms.Label();
            this.labelCPUSocketDesignation = new System.Windows.Forms.Label();
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
            this.labelCPUNumberOfLogicalProcessorsValue = new System.Windows.Forms.Label();
            this.labelCPUNumberOfLogicalProcessors = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageCPU.SuspendLayout();
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
            this.tabPageCPU.Controls.Add(this.groupBoxProcessor);
            this.tabPageCPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(433, 299);
            this.tabPageCPU.TabIndex = 0;
            this.tabPageCPU.Text = "CPU";
            this.tabPageCPU.UseVisualStyleBackColor = true;
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
            this.groupBoxProcessor.Size = new System.Drawing.Size(421, 138);
            this.groupBoxProcessor.TabIndex = 1;
            this.groupBoxProcessor.TabStop = false;
            this.groupBoxProcessor.Text = "Processor";
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
            // labelCPUNumberOfCoresValue
            // 
            this.labelCPUNumberOfCoresValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCPUNumberOfCoresValue.Location = new System.Drawing.Point(376, 39);
            this.labelCPUNumberOfCoresValue.Name = "labelCPUNumberOfCoresValue";
            this.labelCPUNumberOfCoresValue.Size = new System.Drawing.Size(39, 21);
            this.labelCPUNumberOfCoresValue.TabIndex = 1;
            this.labelCPUNumberOfCoresValue.Text = "labelCPUNumberOfCoresValue";
            this.labelCPUNumberOfCoresValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUSocketDesignationValue
            // 
            this.labelCPUSocketDesignationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.labelCPUNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.labelCPUManufacturerValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCPUManufacturerValue.Location = new System.Drawing.Point(78, 39);
            this.labelCPUManufacturerValue.Name = "labelCPUManufacturerValue";
            this.labelCPUManufacturerValue.Size = new System.Drawing.Size(240, 21);
            this.labelCPUManufacturerValue.TabIndex = 1;
            this.labelCPUManufacturerValue.Text = "labelCPUManufacturerValue";
            this.labelCPUManufacturerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPUCaptionValue
            // 
            this.labelCPUCaptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // labelCPUNumberOfLogicalProcessorsValue
            // 
            this.labelCPUNumberOfLogicalProcessorsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCPUNumberOfLogicalProcessorsValue.Location = new System.Drawing.Point(376, 67);
            this.labelCPUNumberOfLogicalProcessorsValue.Name = "labelCPUNumberOfLogicalProcessorsValue";
            this.labelCPUNumberOfLogicalProcessorsValue.Size = new System.Drawing.Size(39, 21);
            this.labelCPUNumberOfLogicalProcessorsValue.TabIndex = 1;
            this.labelCPUNumberOfLogicalProcessorsValue.Text = "labelCPUNumberOfLogicalProcessorsValue";
            this.labelCPUNumberOfLogicalProcessorsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
    }
}

