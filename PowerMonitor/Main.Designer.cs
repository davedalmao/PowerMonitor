﻿namespace PowerMonitor
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BatteryLife = new System.Windows.Forms.Label();
            this.BatteryTime = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.PowerStatus = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.ForLow = new System.Windows.Forms.Timer(this.components);
            this.ForHigh = new System.Windows.Forms.Timer(this.components);
            this.BatteryHealth = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LowBatteryStateSelector = new System.Windows.Forms.NumericUpDown();
            this.HighBatteryStateSelector = new System.Windows.Forms.NumericUpDown();
            this.SetBtn = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.PopUpLabel2 = new System.Windows.Forms.Label();
            this.PopUpLabel1 = new System.Windows.Forms.Label();
            this.HighPowerAlertCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingsLogo = new System.Windows.Forms.PictureBox();
            this.SettingsIcon = new System.Windows.Forms.PictureBox();
            this.MinimizeIcon = new System.Windows.Forms.PictureBox();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ExitMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ChargingTimer = new System.Windows.Forms.Timer(this.components);
            this.EnterTwice = new System.Windows.Forms.Label();
            this.BatteryIndicator = new PowerMonitor.CustomProgressBar();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowBatteryStateSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighBatteryStateSelector)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            this.ExitMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BatteryLife
            // 
            this.BatteryLife.AutoSize = true;
            this.BatteryLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLife.Location = new System.Drawing.Point(46, 111);
            this.BatteryLife.Name = "BatteryLife";
            this.BatteryLife.Size = new System.Drawing.Size(154, 18);
            this.BatteryLife.TabIndex = 4;
            this.BatteryLife.Text = "Charge Remaining:   ?";
            // 
            // BatteryTime
            // 
            this.BatteryTime.AutoSize = true;
            this.BatteryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryTime.Location = new System.Drawing.Point(46, 136);
            this.BatteryTime.Name = "BatteryTime";
            this.BatteryTime.Size = new System.Drawing.Size(143, 18);
            this.BatteryTime.TabIndex = 5;
            this.BatteryTime.Text = "Time Remaining:    ?";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // PowerStatus
            // 
            this.PowerStatus.AutoSize = true;
            this.PowerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerStatus.Location = new System.Drawing.Point(46, 42);
            this.PowerStatus.Name = "PowerStatus";
            this.PowerStatus.Size = new System.Drawing.Size(75, 18);
            this.PowerStatus.TabIndex = 6;
            this.PowerStatus.Text = "DEFAULT";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(107)))), ((int)(((byte)(34)))));
            this.Warning.Location = new System.Drawing.Point(8, 35);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(440, 27);
            this.Warning.TabIndex = 7;
            this.Warning.Text = "BATTERY LOW, PLUG IN YOUR CHARGER!";
            this.Warning.Visible = false;
            // 
            // ForLow
            // 
            this.ForLow.Enabled = true;
            this.ForLow.Interval = 1000;
            this.ForLow.Tick += new System.EventHandler(this.ForLow_Tick);
            // 
            // ForHigh
            // 
            this.ForHigh.Enabled = true;
            this.ForHigh.Interval = 1000;
            this.ForHigh.Tick += new System.EventHandler(this.ForHigh_Tick);
            // 
            // BatteryHealth
            // 
            this.BatteryHealth.AutoSize = true;
            this.BatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BatteryHealth.Location = new System.Drawing.Point(365, 136);
            this.BatteryHealth.Name = "BatteryHealth";
            this.BatteryHealth.Size = new System.Drawing.Size(38, 18);
            this.BatteryHealth.TabIndex = 11;
            this.BatteryHealth.Text = "High";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.AppName);
            this.InfoPanel.Location = new System.Drawing.Point(12, 68);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(30, 30);
            this.InfoPanel.TabIndex = 12;
            this.InfoPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(86, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "08 / 15 / 2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(86, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developer:  John Dave Dalmao";
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.CadetBlue;
            this.AppName.Location = new System.Drawing.Point(85, 13);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(246, 25);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "P O W E R   M O N I T O R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "S E T T I N G S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(191, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Low Battery Warning: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(191, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "High Battery Alert:";
            // 
            // LowBatteryStateSelector
            // 
            this.LowBatteryStateSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.LowBatteryStateSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowBatteryStateSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LowBatteryStateSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LowBatteryStateSelector.ForeColor = System.Drawing.Color.NavajoWhite;
            this.LowBatteryStateSelector.Location = new System.Drawing.Point(361, 12);
            this.LowBatteryStateSelector.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LowBatteryStateSelector.Name = "LowBatteryStateSelector";
            this.LowBatteryStateSelector.Size = new System.Drawing.Size(49, 24);
            this.LowBatteryStateSelector.TabIndex = 4;
            this.LowBatteryStateSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowBatteryStateSelector.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // HighBatteryStateSelector
            // 
            this.HighBatteryStateSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.HighBatteryStateSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighBatteryStateSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HighBatteryStateSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.HighBatteryStateSelector.ForeColor = System.Drawing.Color.NavajoWhite;
            this.HighBatteryStateSelector.Location = new System.Drawing.Point(361, 42);
            this.HighBatteryStateSelector.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.HighBatteryStateSelector.Name = "HighBatteryStateSelector";
            this.HighBatteryStateSelector.Size = new System.Drawing.Size(49, 24);
            this.HighBatteryStateSelector.TabIndex = 5;
            this.HighBatteryStateSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighBatteryStateSelector.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // SetBtn
            // 
            this.SetBtn.BackColor = System.Drawing.Color.Teal;
            this.SetBtn.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBtn.ForeColor = System.Drawing.Color.NavajoWhite;
            this.SetBtn.Location = new System.Drawing.Point(339, 80);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(71, 30);
            this.SetBtn.TabIndex = 6;
            this.SetBtn.Text = "S E T";
            this.SetBtn.UseVisualStyleBackColor = false;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.PopUpLabel2);
            this.SettingsPanel.Controls.Add(this.PopUpLabel1);
            this.SettingsPanel.Controls.Add(this.HighPowerAlertCheckBox);
            this.SettingsPanel.Controls.Add(this.SettingsLogo);
            this.SettingsPanel.Controls.Add(this.SetBtn);
            this.SettingsPanel.Controls.Add(this.HighBatteryStateSelector);
            this.SettingsPanel.Controls.Add(this.LowBatteryStateSelector);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.label5);
            this.SettingsPanel.Location = new System.Drawing.Point(410, 68);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(30, 30);
            this.SettingsPanel.TabIndex = 13;
            this.SettingsPanel.Visible = false;
            // 
            // PopUpLabel2
            // 
            this.PopUpLabel2.AutoSize = true;
            this.PopUpLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUpLabel2.ForeColor = System.Drawing.Color.BurlyWood;
            this.PopUpLabel2.Location = new System.Drawing.Point(228, 96);
            this.PopUpLabel2.Name = "PopUpLabel2";
            this.PopUpLabel2.Size = new System.Drawing.Size(90, 16);
            this.PopUpLabel2.TabIndex = 10;
            this.PopUpLabel2.Text = "battery is high";
            // 
            // PopUpLabel1
            // 
            this.PopUpLabel1.AutoSize = true;
            this.PopUpLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUpLabel1.ForeColor = System.Drawing.Color.BurlyWood;
            this.PopUpLabel1.Location = new System.Drawing.Point(228, 79);
            this.PopUpLabel1.Name = "PopUpLabel1";
            this.PopUpLabel1.Size = new System.Drawing.Size(85, 16);
            this.PopUpLabel1.TabIndex = 9;
            this.PopUpLabel1.Text = "Pop up when";
            // 
            // HighPowerAlertCheckBox
            // 
            this.HighPowerAlertCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.HighPowerAlertCheckBox.BackColor = System.Drawing.Color.Teal;
            this.HighPowerAlertCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HighPowerAlertCheckBox.Checked = true;
            this.HighPowerAlertCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HighPowerAlertCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HighPowerAlertCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.HighPowerAlertCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSpringGreen;
            this.HighPowerAlertCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighPowerAlertCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighPowerAlertCheckBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.HighPowerAlertCheckBox.Location = new System.Drawing.Point(196, 81);
            this.HighPowerAlertCheckBox.Name = "HighPowerAlertCheckBox";
            this.HighPowerAlertCheckBox.Size = new System.Drawing.Size(30, 30);
            this.HighPowerAlertCheckBox.TabIndex = 8;
            this.HighPowerAlertCheckBox.Text = "✔";
            this.HighPowerAlertCheckBox.UseVisualStyleBackColor = false;
            this.HighPowerAlertCheckBox.CheckedChanged += new System.EventHandler(this.HighPowerAlertCheckBox_CheckedChanged);
            // 
            // SettingsLogo
            // 
            this.SettingsLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsLogo.Image = global::PowerMonitor.Properties.Resources.Tools;
            this.SettingsLogo.Location = new System.Drawing.Point(57, 45);
            this.SettingsLogo.Name = "SettingsLogo";
            this.SettingsLogo.Size = new System.Drawing.Size(69, 66);
            this.SettingsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsLogo.TabIndex = 7;
            this.SettingsLogo.TabStop = false;
            this.SettingsLogo.Click += new System.EventHandler(this.SettingsLogo_Click);
            // 
            // SettingsIcon
            // 
            this.SettingsIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsIcon.Image = global::PowerMonitor.Properties.Resources.Gear_UI;
            this.SettingsIcon.Location = new System.Drawing.Point(358, 14);
            this.SettingsIcon.Name = "SettingsIcon";
            this.SettingsIcon.Size = new System.Drawing.Size(20, 20);
            this.SettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsIcon.TabIndex = 14;
            this.SettingsIcon.TabStop = false;
            this.ToolTip.SetToolTip(this.SettingsIcon, "Settings");
            this.SettingsIcon.Click += new System.EventHandler(this.SettingsIcon_Click);
            // 
            // MinimizeIcon
            // 
            this.MinimizeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeIcon.Image = global::PowerMonitor.Properties.Resources.Minus_UI;
            this.MinimizeIcon.Location = new System.Drawing.Point(384, 14);
            this.MinimizeIcon.Name = "MinimizeIcon";
            this.MinimizeIcon.Size = new System.Drawing.Size(20, 19);
            this.MinimizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeIcon.TabIndex = 10;
            this.MinimizeIcon.TabStop = false;
            this.ToolTip.SetToolTip(this.MinimizeIcon, "Minimize to System Tray");
            this.MinimizeIcon.Click += new System.EventHandler(this.MinimizeIcon_Click);
            // 
            // InfoIcon
            // 
            this.InfoIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("InfoIcon.Image")));
            this.InfoIcon.Location = new System.Drawing.Point(332, 14);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(20, 19);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoIcon.TabIndex = 9;
            this.InfoIcon.TabStop = false;
            this.ToolTip.SetToolTip(this.InfoIcon, "Info");
            this.InfoIcon.Click += new System.EventHandler(this.InfoIcon_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ExitMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.BalloonTipShown += new System.EventHandler(this.NotifyIcon_BalloonTipShown);
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // ExitMenuStrip
            // 
            this.ExitMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplicationToolStripMenuItem});
            this.ExitMenuStrip.Name = "ExitMenuStrip";
            this.ExitMenuStrip.Size = new System.Drawing.Size(176, 26);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Power Monitor";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // ToolTip
            // 
            // 
            // ChargingTimer
            // 
            this.ChargingTimer.Enabled = true;
            this.ChargingTimer.Tick += new System.EventHandler(this.ChargingTimer_Tick);
            // 
            // EnterTwice
            // 
            this.EnterTwice.AutoSize = true;
            this.EnterTwice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTwice.ForeColor = System.Drawing.Color.Chocolate;
            this.EnterTwice.Location = new System.Drawing.Point(28, 15);
            this.EnterTwice.Name = "EnterTwice";
            this.EnterTwice.Size = new System.Drawing.Size(254, 20);
            this.EnterTwice.TabIndex = 11;
            this.EnterTwice.Text = "Press  E N T E R  twice to minimize";
            this.EnterTwice.Visible = false;
            // 
            // BatteryIndicator
            // 
            this.BatteryIndicator.Location = new System.Drawing.Point(49, 68);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(355, 30);
            this.BatteryIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BatteryIndicator.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(455, 175);
            this.Controls.Add(this.EnterTwice);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SettingsIcon);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.BatteryHealth);
            this.Controls.Add(this.MinimizeIcon);
            this.Controls.Add(this.InfoIcon);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.PowerStatus);
            this.Controls.Add(this.BatteryTime);
            this.Controls.Add(this.BatteryLife);
            this.Controls.Add(this.BatteryIndicator);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowBatteryStateSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighBatteryStateSelector)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            this.ExitMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BatteryLife;
        private System.Windows.Forms.Label BatteryTime;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label PowerStatus;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Timer ForLow;
        private System.Windows.Forms.Timer ForHigh;
        private System.Windows.Forms.Label BatteryHealth;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AppName;
        private CustomProgressBar BatteryIndicator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SettingsLogo;
        private System.Windows.Forms.Panel SettingsPanel;
        public System.Windows.Forms.NumericUpDown LowBatteryStateSelector;
        public System.Windows.Forms.NumericUpDown HighBatteryStateSelector;
        public System.Windows.Forms.PictureBox InfoIcon;
        public System.Windows.Forms.PictureBox MinimizeIcon;
        public System.Windows.Forms.PictureBox SettingsIcon;
        public System.Windows.Forms.Button SetBtn;
        private System.Windows.Forms.Label PopUpLabel1;
        private System.Windows.Forms.Label PopUpLabel2;
        public System.Windows.Forms.CheckBox HighPowerAlertCheckBox;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ExitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Timer ChargingTimer;
        private System.Windows.Forms.Label EnterTwice;
    }
}

