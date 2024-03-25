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
            this.tabPageMainboard = new System.Windows.Forms.TabPage();
            this.tabPageMemory = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
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
            this.tabPageCPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(433, 299);
            this.tabPageCPU.TabIndex = 0;
            this.tabPageCPU.Text = "CPU";
            this.tabPageCPU.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCPU;
        private System.Windows.Forms.TabPage tabPageMainboard;
        private System.Windows.Forms.TabPage tabPageMemory;
    }
}

