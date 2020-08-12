namespace Power_Status {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BatteryLife = new System.Windows.Forms.Label();
            this.BatteryTime = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.PowerStatus = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.MinimizeIcon = new System.Windows.Forms.PictureBox();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.ForLow = new System.Windows.Forms.Timer(this.components);
            this.ForHigh = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.BatteryIndicator = new Power_Status.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BatteryLife
            // 
            this.BatteryLife.AutoSize = true;
            this.BatteryLife.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLife.Location = new System.Drawing.Point(45, 113);
            this.BatteryLife.Name = "BatteryLife";
            this.BatteryLife.Size = new System.Drawing.Size(163, 17);
            this.BatteryLife.TabIndex = 4;
            this.BatteryLife.Text = "Charge Remaining:   ?";
            // 
            // BatteryTime
            // 
            this.BatteryTime.AutoSize = true;
            this.BatteryTime.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryTime.Location = new System.Drawing.Point(45, 138);
            this.BatteryTime.Name = "BatteryTime";
            this.BatteryTime.Size = new System.Drawing.Size(151, 17);
            this.BatteryTime.TabIndex = 5;
            this.BatteryTime.Text = "Time Remaining:    ?";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // PowerStatus
            // 
            this.PowerStatus.AutoSize = true;
            this.PowerStatus.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerStatus.Location = new System.Drawing.Point(45, 44);
            this.PowerStatus.Name = "PowerStatus";
            this.PowerStatus.Size = new System.Drawing.Size(73, 17);
            this.PowerStatus.TabIndex = 6;
            this.PowerStatus.Text = "DEFAULT";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(107)))), ((int)(((byte)(34)))));
            this.Warning.Location = new System.Drawing.Point(7, 33);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(440, 27);
            this.Warning.TabIndex = 7;
            this.Warning.Text = "BATTERY LOW, PLUG IN YOUR CHARGER!";
            this.Warning.Visible = false;
            // 
            // MinimizeIcon
            // 
            this.MinimizeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeIcon.Image = global::Power_Status.Properties.Resources.Minus_UI;
            this.MinimizeIcon.Location = new System.Drawing.Point(406, 9);
            this.MinimizeIcon.Name = "MinimizeIcon";
            this.MinimizeIcon.Size = new System.Drawing.Size(20, 19);
            this.MinimizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeIcon.TabIndex = 10;
            this.MinimizeIcon.TabStop = false;
            this.MinimizeIcon.Click += new System.EventHandler(this.CloseIcon_Click);
            // 
            // InfoIcon
            // 
            this.InfoIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("InfoIcon.Image")));
            this.InfoIcon.Location = new System.Drawing.Point(380, 9);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(20, 19);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoIcon.TabIndex = 9;
            this.InfoIcon.TabStop = false;
            this.InfoIcon.Click += new System.EventHandler(this.InfoIcon_Click);
            // 
            // ForLow
            // 
            this.ForLow.Interval = 1000;
            this.ForLow.Tick += new System.EventHandler(this.ForLow_Tick);
            // 
            // ForHigh
            // 
            this.ForHigh.Interval = 1000;
            this.ForHigh.Tick += new System.EventHandler(this.ForHigh_Tick);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.test.Location = new System.Drawing.Point(361, 138);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(42, 17);
            this.test.TabIndex = 11;
            this.test.Text = "state";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.AppName);
            this.InfoPanel.Location = new System.Drawing.Point(8, 30);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(439, 133);
            this.InfoPanel.TabIndex = 12;
            this.InfoPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.label3.Location = new System.Drawing.Point(94, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "08 / 12 / 2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.label2.Location = new System.Drawing.Point(94, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developer: John Dave Dalmao";
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.CadetBlue;
            this.AppName.Location = new System.Drawing.Point(93, 10);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(256, 23);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "P O W E R  M O N I T O R";
            // 
            // BatteryIndicator
            // 
            this.BatteryIndicator.Location = new System.Drawing.Point(48, 70);
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
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.test);
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
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BatteryLife;
        private System.Windows.Forms.Label BatteryTime;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label PowerStatus;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.PictureBox InfoIcon;
        private System.Windows.Forms.PictureBox MinimizeIcon;
        private System.Windows.Forms.Timer ForLow;
        private System.Windows.Forms.Timer ForHigh;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AppName;
        private CustomProgressBar BatteryIndicator;
    }
}

