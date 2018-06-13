namespace Friendly_DISM
{
    partial class Form1
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
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.clearDismOutput = new System.Windows.Forms.Button();
            this.dismOutputListbox = new System.Windows.Forms.ListBox();
            this.cleanupOnlineImageButton = new System.Windows.Forms.Button();
            this.cleanupWIMButton = new System.Windows.Forms.Button();
            this.saveRadioButton = new System.Windows.Forms.RadioButton();
            this.discardRadioButton = new System.Windows.Forms.RadioButton();
            this.dismountWIMButton = new System.Windows.Forms.Button();
            this.getMountedImagesButton = new System.Windows.Forms.Button();
            this.getWimButtom = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mountWimPage = new System.Windows.Forms.TabPage();
            this.mountWimButtom = new System.Windows.Forms.Button();
            this.wimFileLabel = new System.Windows.Forms.Label();
            this.axportPathLabeel = new System.Windows.Forms.Label();
            this.wimFileTextBox = new System.Windows.Forms.TextBox();
            this.exportPathTextBox = new System.Windows.Forms.TextBox();
            this.wimFileSearchButton = new System.Windows.Forms.Button();
            this.exportPathSearchButton = new System.Windows.Forms.Button();
            this.indexLabel = new System.Windows.Forms.Label();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.dismountWIMMountedButton = new System.Windows.Forms.Button();
            this.discardMountedRadioBurron = new System.Windows.Forms.RadioButton();
            this.saveMountedRadioBurron = new System.Windows.Forms.RadioButton();
            this.addDriverMountedButton = new System.Windows.Forms.Button();
            this.driverMountPathTextBox = new System.Windows.Forms.TextBox();
            this.driverMountPathSeachButton = new System.Windows.Forms.Button();
            this.getDriverMountedbutton = new System.Windows.Forms.Button();
            this.mountWimTab = new System.Windows.Forms.TabControl();
            this.loadingPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.mountWimPage.SuspendLayout();
            this.mountWimTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadingPanel.Controls.Add(this.label1);
            this.loadingPanel.Controls.Add(this.loadingProgressBar);
            this.loadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(638, 633);
            this.loadingPanel.TabIndex = 13;
            this.loadingPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Loading";
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Location = new System.Drawing.Point(165, 313);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(297, 23);
            this.loadingProgressBar.TabIndex = 12;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.clearDismOutput);
            this.mainPanel.Controls.Add(this.mountWimTab);
            this.mainPanel.Controls.Add(this.dismOutputListbox);
            this.mainPanel.Controls.Add(this.cleanupOnlineImageButton);
            this.mainPanel.Controls.Add(this.cleanupWIMButton);
            this.mainPanel.Controls.Add(this.saveRadioButton);
            this.mainPanel.Controls.Add(this.discardRadioButton);
            this.mainPanel.Controls.Add(this.dismountWIMButton);
            this.mainPanel.Controls.Add(this.getMountedImagesButton);
            this.mainPanel.Controls.Add(this.getWimButtom);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(638, 633);
            this.mainPanel.TabIndex = 15;
            // 
            // clearDismOutput
            // 
            this.clearDismOutput.Location = new System.Drawing.Point(151, 368);
            this.clearDismOutput.Name = "clearDismOutput";
            this.clearDismOutput.Size = new System.Drawing.Size(144, 43);
            this.clearDismOutput.TabIndex = 19;
            this.clearDismOutput.Text = "Clear Output";
            this.clearDismOutput.UseVisualStyleBackColor = true;
            this.clearDismOutput.Click += new System.EventHandler(this.clearDismOutput_Click);
            // 
            // dismOutputListbox
            // 
            this.dismOutputListbox.FormattingEnabled = true;
            this.dismOutputListbox.Location = new System.Drawing.Point(304, 12);
            this.dismOutputListbox.Name = "dismOutputListbox";
            this.dismOutputListbox.Size = new System.Drawing.Size(322, 407);
            this.dismOutputListbox.TabIndex = 4;
            // 
            // cleanupOnlineImageButton
            // 
            this.cleanupOnlineImageButton.Location = new System.Drawing.Point(151, 12);
            this.cleanupOnlineImageButton.Name = "cleanupOnlineImageButton";
            this.cleanupOnlineImageButton.Size = new System.Drawing.Size(144, 43);
            this.cleanupOnlineImageButton.TabIndex = 18;
            this.cleanupOnlineImageButton.Text = "Cleanup Online Image";
            this.cleanupOnlineImageButton.UseVisualStyleBackColor = true;
            this.cleanupOnlineImageButton.Click += new System.EventHandler(this.cleanupOnlineImageButton_Click);
            // 
            // cleanupWIMButton
            // 
            this.cleanupWIMButton.Location = new System.Drawing.Point(4, 12);
            this.cleanupWIMButton.Name = "cleanupWIMButton";
            this.cleanupWIMButton.Size = new System.Drawing.Size(144, 43);
            this.cleanupWIMButton.TabIndex = 17;
            this.cleanupWIMButton.Text = "Cleanup WIM";
            this.cleanupWIMButton.UseVisualStyleBackColor = true;
            this.cleanupWIMButton.Click += new System.EventHandler(this.cleanupWIMButton_Click);
            // 
            // saveRadioButton
            // 
            this.saveRadioButton.AutoSize = true;
            this.saveRadioButton.Location = new System.Drawing.Point(154, 87);
            this.saveRadioButton.Name = "saveRadioButton";
            this.saveRadioButton.Size = new System.Drawing.Size(50, 17);
            this.saveRadioButton.TabIndex = 16;
            this.saveRadioButton.Text = "Save";
            this.saveRadioButton.UseVisualStyleBackColor = true;
            // 
            // discardRadioButton
            // 
            this.discardRadioButton.AutoSize = true;
            this.discardRadioButton.Checked = true;
            this.discardRadioButton.Location = new System.Drawing.Point(154, 64);
            this.discardRadioButton.Name = "discardRadioButton";
            this.discardRadioButton.Size = new System.Drawing.Size(61, 17);
            this.discardRadioButton.TabIndex = 15;
            this.discardRadioButton.TabStop = true;
            this.discardRadioButton.Text = "Discard";
            this.discardRadioButton.UseVisualStyleBackColor = true;
            // 
            // dismountWIMButton
            // 
            this.dismountWIMButton.Location = new System.Drawing.Point(4, 61);
            this.dismountWIMButton.Name = "dismountWIMButton";
            this.dismountWIMButton.Size = new System.Drawing.Size(144, 43);
            this.dismountWIMButton.TabIndex = 14;
            this.dismountWIMButton.Text = "Dismount-WIM";
            this.dismountWIMButton.UseVisualStyleBackColor = true;
            this.dismountWIMButton.Click += new System.EventHandler(this.dismountWIMButton_Click);
            // 
            // getMountedImagesButton
            // 
            this.getMountedImagesButton.Location = new System.Drawing.Point(154, 110);
            this.getMountedImagesButton.Name = "getMountedImagesButton";
            this.getMountedImagesButton.Size = new System.Drawing.Size(144, 43);
            this.getMountedImagesButton.TabIndex = 13;
            this.getMountedImagesButton.Text = "Get-MountedImages";
            this.getMountedImagesButton.UseVisualStyleBackColor = true;
            this.getMountedImagesButton.Click += new System.EventHandler(this.getMountedImagesButton_Click);
            // 
            // getWimButtom
            // 
            this.getWimButtom.Location = new System.Drawing.Point(4, 110);
            this.getWimButtom.Name = "getWimButtom";
            this.getWimButtom.Size = new System.Drawing.Size(144, 43);
            this.getWimButtom.TabIndex = 12;
            this.getWimButtom.Text = "Get-Wim Info";
            this.getWimButtom.UseVisualStyleBackColor = true;
            this.getWimButtom.Click += new System.EventHandler(this.getWimButtom_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mountWimPage
            // 
            this.mountWimPage.Controls.Add(this.getDriverMountedbutton);
            this.mountWimPage.Controls.Add(this.driverMountPathSeachButton);
            this.mountWimPage.Controls.Add(this.driverMountPathTextBox);
            this.mountWimPage.Controls.Add(this.indexTextBox);
            this.mountWimPage.Controls.Add(this.exportPathTextBox);
            this.mountWimPage.Controls.Add(this.wimFileTextBox);
            this.mountWimPage.Controls.Add(this.addDriverMountedButton);
            this.mountWimPage.Controls.Add(this.saveMountedRadioBurron);
            this.mountWimPage.Controls.Add(this.discardMountedRadioBurron);
            this.mountWimPage.Controls.Add(this.dismountWIMMountedButton);
            this.mountWimPage.Controls.Add(this.indexLabel);
            this.mountWimPage.Controls.Add(this.exportPathSearchButton);
            this.mountWimPage.Controls.Add(this.wimFileSearchButton);
            this.mountWimPage.Controls.Add(this.axportPathLabeel);
            this.mountWimPage.Controls.Add(this.wimFileLabel);
            this.mountWimPage.Controls.Add(this.mountWimButtom);
            this.mountWimPage.Location = new System.Drawing.Point(4, 22);
            this.mountWimPage.Name = "mountWimPage";
            this.mountWimPage.Padding = new System.Windows.Forms.Padding(3);
            this.mountWimPage.Size = new System.Drawing.Size(628, 190);
            this.mountWimPage.TabIndex = 0;
            this.mountWimPage.Text = "Mount-WIM";
            this.mountWimPage.UseVisualStyleBackColor = true;
            // 
            // mountWimButtom
            // 
            this.mountWimButtom.Location = new System.Drawing.Point(75, 115);
            this.mountWimButtom.Name = "mountWimButtom";
            this.mountWimButtom.Size = new System.Drawing.Size(100, 43);
            this.mountWimButtom.TabIndex = 3;
            this.mountWimButtom.Text = "Mount WIM";
            this.mountWimButtom.UseVisualStyleBackColor = true;
            this.mountWimButtom.Click += new System.EventHandler(this.mountWimButtom_Click);
            // 
            // wimFileLabel
            // 
            this.wimFileLabel.AutoSize = true;
            this.wimFileLabel.Location = new System.Drawing.Point(16, 17);
            this.wimFileLabel.Name = "wimFileLabel";
            this.wimFileLabel.Size = new System.Drawing.Size(49, 13);
            this.wimFileLabel.TabIndex = 4;
            this.wimFileLabel.Text = "WIM File";
            // 
            // axportPathLabeel
            // 
            this.axportPathLabeel.AutoSize = true;
            this.axportPathLabeel.Location = new System.Drawing.Point(3, 66);
            this.axportPathLabeel.Name = "axportPathLabeel";
            this.axportPathLabeel.Size = new System.Drawing.Size(62, 13);
            this.axportPathLabeel.TabIndex = 5;
            this.axportPathLabeel.Text = "Mount Path";
            // 
            // wimFileTextBox
            // 
            this.wimFileTextBox.Location = new System.Drawing.Point(75, 14);
            this.wimFileTextBox.Name = "wimFileTextBox";
            this.wimFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.wimFileTextBox.TabIndex = 6;
            // 
            // exportPathTextBox
            // 
            this.exportPathTextBox.Location = new System.Drawing.Point(75, 63);
            this.exportPathTextBox.Name = "exportPathTextBox";
            this.exportPathTextBox.Size = new System.Drawing.Size(100, 20);
            this.exportPathTextBox.TabIndex = 7;
            // 
            // wimFileSearchButton
            // 
            this.wimFileSearchButton.Location = new System.Drawing.Point(181, 14);
            this.wimFileSearchButton.Name = "wimFileSearchButton";
            this.wimFileSearchButton.Size = new System.Drawing.Size(29, 18);
            this.wimFileSearchButton.TabIndex = 8;
            this.wimFileSearchButton.Text = "***";
            this.wimFileSearchButton.UseVisualStyleBackColor = true;
            this.wimFileSearchButton.Click += new System.EventHandler(this.wimFileSearchButton_Click);
            // 
            // exportPathSearchButton
            // 
            this.exportPathSearchButton.Location = new System.Drawing.Point(181, 63);
            this.exportPathSearchButton.Name = "exportPathSearchButton";
            this.exportPathSearchButton.Size = new System.Drawing.Size(29, 18);
            this.exportPathSearchButton.TabIndex = 9;
            this.exportPathSearchButton.Text = "***";
            this.exportPathSearchButton.UseVisualStyleBackColor = true;
            this.exportPathSearchButton.Click += new System.EventHandler(this.exportPathSearchButton_Click);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(32, 96);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(33, 13);
            this.indexLabel.TabIndex = 12;
            this.indexLabel.Text = "Index";
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(75, 89);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(30, 20);
            this.indexTextBox.TabIndex = 13;
            // 
            // dismountWIMMountedButton
            // 
            this.dismountWIMMountedButton.Enabled = false;
            this.dismountWIMMountedButton.Location = new System.Drawing.Point(201, 115);
            this.dismountWIMMountedButton.Name = "dismountWIMMountedButton";
            this.dismountWIMMountedButton.Size = new System.Drawing.Size(144, 43);
            this.dismountWIMMountedButton.TabIndex = 14;
            this.dismountWIMMountedButton.Text = "Dismount-WIM";
            this.dismountWIMMountedButton.UseVisualStyleBackColor = true;
            this.dismountWIMMountedButton.Click += new System.EventHandler(this.dismountWIMMountedButton_Click);
            // 
            // discardMountedRadioBurron
            // 
            this.discardMountedRadioBurron.AutoSize = true;
            this.discardMountedRadioBurron.Checked = true;
            this.discardMountedRadioBurron.Enabled = false;
            this.discardMountedRadioBurron.Location = new System.Drawing.Point(201, 164);
            this.discardMountedRadioBurron.Name = "discardMountedRadioBurron";
            this.discardMountedRadioBurron.Size = new System.Drawing.Size(61, 17);
            this.discardMountedRadioBurron.TabIndex = 15;
            this.discardMountedRadioBurron.TabStop = true;
            this.discardMountedRadioBurron.Text = "Discard";
            this.discardMountedRadioBurron.UseVisualStyleBackColor = true;
            // 
            // saveMountedRadioBurron
            // 
            this.saveMountedRadioBurron.AutoSize = true;
            this.saveMountedRadioBurron.Enabled = false;
            this.saveMountedRadioBurron.Location = new System.Drawing.Point(295, 164);
            this.saveMountedRadioBurron.Name = "saveMountedRadioBurron";
            this.saveMountedRadioBurron.Size = new System.Drawing.Size(50, 17);
            this.saveMountedRadioBurron.TabIndex = 16;
            this.saveMountedRadioBurron.Text = "Save";
            this.saveMountedRadioBurron.UseVisualStyleBackColor = true;
            // 
            // addDriverMountedButton
            // 
            this.addDriverMountedButton.Enabled = false;
            this.addDriverMountedButton.Location = new System.Drawing.Point(352, 6);
            this.addDriverMountedButton.Name = "addDriverMountedButton";
            this.addDriverMountedButton.Size = new System.Drawing.Size(106, 43);
            this.addDriverMountedButton.TabIndex = 17;
            this.addDriverMountedButton.Text = "Add-Driver";
            this.addDriverMountedButton.UseVisualStyleBackColor = true;
            this.addDriverMountedButton.Click += new System.EventHandler(this.addDriverMountedButton_Click);
            // 
            // driverMountPathTextBox
            // 
            this.driverMountPathTextBox.Enabled = false;
            this.driverMountPathTextBox.Location = new System.Drawing.Point(464, 6);
            this.driverMountPathTextBox.Name = "driverMountPathTextBox";
            this.driverMountPathTextBox.Size = new System.Drawing.Size(100, 20);
            this.driverMountPathTextBox.TabIndex = 18;
            this.driverMountPathTextBox.Text = "PathToDriver";
            // 
            // driverMountPathSeachButton
            // 
            this.driverMountPathSeachButton.Enabled = false;
            this.driverMountPathSeachButton.Location = new System.Drawing.Point(570, 6);
            this.driverMountPathSeachButton.Name = "driverMountPathSeachButton";
            this.driverMountPathSeachButton.Size = new System.Drawing.Size(29, 18);
            this.driverMountPathSeachButton.TabIndex = 19;
            this.driverMountPathSeachButton.Text = "***";
            this.driverMountPathSeachButton.UseVisualStyleBackColor = true;
            this.driverMountPathSeachButton.Click += new System.EventHandler(this.driverMountPathSeachButton_Click);
            // 
            // getDriverMountedbutton
            // 
            this.getDriverMountedbutton.Enabled = false;
            this.getDriverMountedbutton.Location = new System.Drawing.Point(352, 63);
            this.getDriverMountedbutton.Name = "getDriverMountedbutton";
            this.getDriverMountedbutton.Size = new System.Drawing.Size(106, 43);
            this.getDriverMountedbutton.TabIndex = 20;
            this.getDriverMountedbutton.Text = "Get-Driver";
            this.getDriverMountedbutton.UseVisualStyleBackColor = true;
            this.getDriverMountedbutton.Click += new System.EventHandler(this.getDriverMountedbutton_Click);
            // 
            // mountWimTab
            // 
            this.mountWimTab.Controls.Add(this.mountWimPage);
            this.mountWimTab.Controls.Add(this.tabPage2);
            this.mountWimTab.Location = new System.Drawing.Point(0, 417);
            this.mountWimTab.Name = "mountWimTab";
            this.mountWimTab.SelectedIndex = 0;
            this.mountWimTab.Size = new System.Drawing.Size(636, 216);
            this.mountWimTab.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 633);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.loadingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Friendly DISM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.mountWimPage.ResumeLayout(false);
            this.mountWimPage.PerformLayout();
            this.mountWimTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListBox dismOutputListbox;
        private System.Windows.Forms.Button cleanupOnlineImageButton;
        private System.Windows.Forms.Button cleanupWIMButton;
        private System.Windows.Forms.RadioButton saveRadioButton;
        private System.Windows.Forms.RadioButton discardRadioButton;
        private System.Windows.Forms.Button dismountWIMButton;
        private System.Windows.Forms.Button getMountedImagesButton;
        private System.Windows.Forms.Button getWimButtom;
        private System.Windows.Forms.Button clearDismOutput;
        private System.Windows.Forms.TabControl mountWimTab;
        private System.Windows.Forms.TabPage mountWimPage;
        private System.Windows.Forms.Button getDriverMountedbutton;
        private System.Windows.Forms.Button driverMountPathSeachButton;
        private System.Windows.Forms.TextBox driverMountPathTextBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox exportPathTextBox;
        private System.Windows.Forms.TextBox wimFileTextBox;
        private System.Windows.Forms.Button addDriverMountedButton;
        private System.Windows.Forms.RadioButton saveMountedRadioBurron;
        private System.Windows.Forms.RadioButton discardMountedRadioBurron;
        private System.Windows.Forms.Button dismountWIMMountedButton;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Button exportPathSearchButton;
        private System.Windows.Forms.Button wimFileSearchButton;
        private System.Windows.Forms.Label axportPathLabeel;
        private System.Windows.Forms.Label wimFileLabel;
        private System.Windows.Forms.Button mountWimButtom;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

