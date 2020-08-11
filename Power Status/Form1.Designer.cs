namespace Power_Status
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
            this.components = new System.ComponentModel.Container();
            this.BatteryIndicator = new System.Windows.Forms.ProgressBar();
            this.BatteryLife = new System.Windows.Forms.Label();
            this.BatteryStatus = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.PowerStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BatteryIndicator
            // 
            this.BatteryIndicator.Location = new System.Drawing.Point(70, 42);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(270, 30);
            this.BatteryIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BatteryIndicator.TabIndex = 3;
            // 
            // BatteryLife
            // 
            this.BatteryLife.AutoSize = true;
            this.BatteryLife.Location = new System.Drawing.Point(67, 85);
            this.BatteryLife.Name = "BatteryLife";
            this.BatteryLife.Size = new System.Drawing.Size(112, 13);
            this.BatteryLife.TabIndex = 4;
            this.BatteryLife.Text = "Charge Remaining:   ?";
            // 
            // BatteryStatus
            // 
            this.BatteryStatus.AutoSize = true;
            this.BatteryStatus.Location = new System.Drawing.Point(67, 110);
            this.BatteryStatus.Name = "BatteryStatus";
            this.BatteryStatus.Size = new System.Drawing.Size(94, 13);
            this.BatteryStatus.TabIndex = 5;
            this.BatteryStatus.Text = "Battery Status:    ?";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // PowerStatus
            // 
            this.PowerStatus.AutoSize = true;
            this.PowerStatus.Location = new System.Drawing.Point(67, 16);
            this.PowerStatus.Name = "PowerStatus";
            this.PowerStatus.Size = new System.Drawing.Size(56, 13);
            this.PowerStatus.TabIndex = 6;
            this.PowerStatus.Text = "DEFAULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 151);
            this.Controls.Add(this.PowerStatus);
            this.Controls.Add(this.BatteryStatus);
            this.Controls.Add(this.BatteryLife);
            this.Controls.Add(this.BatteryIndicator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar BatteryIndicator;
        private System.Windows.Forms.Label BatteryLife;
        private System.Windows.Forms.Label BatteryStatus;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label PowerStatus;
    }
}

