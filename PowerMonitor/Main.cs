using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using Microsoft.Win32;
using System.Diagnostics;

namespace PowerMonitor {
    public partial class Main : Form {
        PowerStatus power = SystemInformation.PowerStatus;
        int percentNumber, timeLeft;
        int mov;
        int movX;
        int movY;

        public Main() {
            InitializeComponent();
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Power Monitor", Application.ExecutablePath.ToString());
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Main_Load(object sender, EventArgs e) {
            RefreshStatus();
            RefreshTimer.Enabled = true;
            ForLow.Enabled = true;
            ForHigh.Enabled = true;
            ChargingTimer.Enabled = true;

            LowBatteryStateSelector.Value = Properties.Settings.Default.LowBatteryValue;
            HighBatteryStateSelector.Value = Properties.Settings.Default.HighBatteryValue;
            HighPowerAlertCheckBox.Checked = Properties.Settings.Default.CheckBoxValue;
            ForHigh.Enabled = Properties.Settings.Default.TimerValue;

            //this.ShowInTaskbar = false;
            //this.Hide();
        }

        protected override void OnPaint(PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.NavajoWhite, ButtonBorderStyle.Solid);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e) {
            RefreshStatus();
        }

        private void ForLow_Tick(object sender, EventArgs e) {
            CheckPercentNumberLow();
        }

        private void ForHigh_Tick(object sender, EventArgs e) {
            CheckPercentNumberHigh();
        }

        private void ChargingTimer_Tick(object sender, EventArgs e) {
            BatteryState();
        }

        private void Main_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            ShowMain();
            NotifyIcon.Visible = false;
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
            //Environment.Exit(0);
        }

        private void MinimizeIcon_Click(object sender, EventArgs e) {
            this.CenterToScreen();
            this.WindowState = FormWindowState.Minimized;
            NotifyIcon.Visible = true;
            SettingsPanel.Visible = false;
            InfoPanel.Visible = false;
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.CenterToScreen();
        }

        private void SetBtn_Click(object sender, EventArgs e) {
            MessageBoxes mb = new MessageBoxes((int)LowBatteryStateSelector.Value, (int)HighBatteryStateSelector.Value, HighPowerAlertCheckBox.Checked);
            mb.Owner = this;
            mb.Show();

            InfoIcon.Enabled = false;
            SettingsIcon.Enabled = false;
            MinimizeIcon.Enabled = false;
            SetBtn.Enabled = false;
            LowBatteryStateSelector.Enabled = false;
            HighBatteryStateSelector.Enabled = false;
            HighPowerAlertCheckBox.Enabled = false;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e) {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e) {
            if (mov == 1) {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e) {
            mov = 0;
        }

        private void HighPowerAlertCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (HighPowerAlertCheckBox.Checked) {
                HighPowerAlertCheckBox.Text = "✔";
                ForHigh.Enabled = true;
                PopUpLabel1.ForeColor = Color.NavajoWhite;
                PopUpLabel2.ForeColor = Color.NavajoWhite;
                ForHigh.Start();
            }

            else {
                HighPowerAlertCheckBox.Text = "";
                ForHigh.Enabled = false;
                PopUpLabel1.ForeColor = Color.BurlyWood;
                PopUpLabel2.ForeColor = Color.BurlyWood;
                ForHigh.Stop();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void RefreshStatus() {
            VisualBatteryHealth();
            HighMedLow();
            BatteryPercent();
            CurrentBatteryLife();
        }

        //Progressbar Visuals
        private void VisualBatteryHealth() {
            percentNumber = (int)(power.BatteryLifePercent * 100);
            if (percentNumber <= 100) {
                BatteryIndicator.Value = percentNumber;
            }

            else {
                BatteryIndicator.Value = 0;
            }
        }

        //Change Color According to State
        private void HighMedLow() {
            try {
                percentNumber = (int)(power.BatteryLifePercent * 100);
                //Low Power State
                if (percentNumber <= LowBatteryStateSelector.Value) {
                    BatteryHealth.Text = "Low";

                    //Red
                    BatteryIndicator.ForeColor = Color.FromArgb(120, 0, 0);
                    BatteryIndicator.BackColor = Color.FromArgb(172, 0, 0);
                }

                //High Power State
                else if (percentNumber >= 80) {
                    BatteryHealth.Text = "High";

                    //Green
                    BatteryIndicator.ForeColor = Color.FromArgb(0, 120, 0);
                    BatteryIndicator.BackColor = Color.FromArgb(0, 172, 0);

                    Warning.SendToBack();
                    Warning.Visible = false;
                }

                else if (percentNumber <= LowBatteryStateSelector.Value && power.PowerLineStatus == PowerLineStatus.Online) {
                    Warning.SendToBack();
                    Warning.Visible = false;
                }

                //Med State
                else {
                    BatteryHealth.Text = "Med";

                    //Blue
                    BatteryIndicator.ForeColor = Color.FromArgb(0, 0, 120);
                    BatteryIndicator.BackColor = Color.FromArgb(0, 0, 172);

                    Warning.SendToBack();
                    Warning.Visible = false;
                }
            }

            catch (Exception ex) {
                MessageBox.Show("Error Message: " + ex.Message);
                Application.Exit();
            }
        }

        private void BatteryPercent() {
            percentNumber = (int)(power.BatteryLifePercent * 100);
            if (percentNumber == 100) {
                BatteryLife.Text = "Full Charged:   " + power.BatteryLifePercent.ToString("P0");
            }

            else {
                BatteryLife.Text = "Charge Remaining:   " + power.BatteryLifePercent.ToString("P0");
            }
        }

        private void CurrentBatteryLife() {
            timeLeft = power.BatteryLifeRemaining;
            if (timeLeft > 0) {
                BatteryTime.Text = string.Format("{0} remaining", Time(timeLeft));
            }

            else {
                BatteryTime.Text = "Wait while still charging / calculating...";
            }
        }

        private void BatteryState() {
            percentNumber = (int)(power.BatteryLifePercent * 100);

            if (power.PowerLineStatus == PowerLineStatus.Online) {
                Warning.SendToBack();
                Warning.Visible = false;
                PowerStatus.Text = "CHARGING";

                this.CenterToScreen();
                this.WindowState = FormWindowState.Minimized;
                NotifyIcon.Visible = true;

                ChargingTimer.Stop();
            }

            else if (power.PowerLineStatus == PowerLineStatus.Offline) {
                PowerStatus.Text = "NOT CHARGING";
                ChargingTimer.Start();
            }

            else if (power.PowerLineStatus == PowerLineStatus.Offline && percentNumber > 0 && percentNumber <= 100) {
                PowerStatus.Text = "NOT CHARGING";
                ChargingTimer.Start();
            }

            else {
                PowerStatus.Text = "UNKNOWN";
            }
        }

        private void CheckPercentNumberLow() {
            try {
                percentNumber = (int)(power.BatteryLifePercent * 100);
                if (percentNumber <= LowBatteryStateSelector.Value && power.PowerLineStatus == PowerLineStatus.Offline) {
                    this.CenterToScreen();

                    ShowMain();
                    Warning.BringToFront();
                    Warning.Visible = true;

                    SettingsPanel.Visible = false;
                    SettingsPanel.Location = new Point(410, 68);
                    SettingsPanel.Size = new Size(30, 30);

                    InfoPanel.Visible = false;
                    InfoPanel.Location = new Point(12, 68);
                    InfoPanel.Size = new Size(30, 30);

                    ForLow.Stop();
                    ForHigh.Start();

                    //Sound Alert When Form Pops Up
                    SoundPlayer sp = new SoundPlayer(Properties.Resources.Alert);
                    sp.Play();
                }
            }

            catch (Exception ex) {
                MessageBox.Show("Error Message: " + ex.Message);
                Application.Exit();
            }
        }

        private void CheckPercentNumberHigh() {
            try {
                percentNumber = (int)(power.BatteryLifePercent * 100);
                if (percentNumber >= HighBatteryStateSelector.Value && power.PowerLineStatus == PowerLineStatus.Online) {
                    this.CenterToScreen();
                    ShowMain();
                    Warning.SendToBack();
                    Warning.Visible = false;

                    SettingsPanel.Visible = false;
                    SettingsPanel.Location = new Point(410, 68);
                    SettingsPanel.Size = new Size(30, 30);

                    InfoPanel.Visible = false;
                    InfoPanel.Location = new Point(12, 68);
                    InfoPanel.Size = new Size(30, 30);

                    ForHigh.Stop();
                    ForLow.Start();

                    //Sound Alert When Form Pops Up
                    SoundPlayer sp = new SoundPlayer(Properties.Resources.Alert);
                    sp.Play();
                }
            }

            catch (Exception ex) {
                MessageBox.Show("Error Message: " + ex.Message);
                Application.Exit();
            }
        }

        private void ShowMain() {
            this.Show();
            this.BringToFront();
            this.CenterToScreen();
            this.WindowState = FormWindowState.Normal;

            if (WindowState == FormWindowState.Normal) {
                ReallyCenterToScreen();
            }
        }

        private string Time(int seconds) {
            const int secondsPerMinute = 60;
            const int secondsPerHour = 3600;

            if (seconds < 0) {
                return "indeterminate";
            }

            else {
                int hours = seconds / secondsPerHour;
                seconds -= hours * secondsPerHour;
                int minutes = seconds / secondsPerMinute;
                seconds -= minutes * secondsPerHour;

                if (hours == 0) {
                    return string.Format("{0} minutes", minutes);
                }
                else {
                    return string.Format("{0} hours {1} minutes", hours, minutes);
                }
            }
        }

        protected void ReallyCenterToScreen() {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point() {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }

        ////////////////////////INFO and SETTINGS///////////////////////
        private void InfoIcon_Click(object sender, EventArgs e) {
            if (InfoPanel.Visible == true) {
                InfoPanel.Visible = false;
                InfoPanel.Location = new Point(12, 68);
                InfoPanel.Size = new Size(30, 30);

                Warning.SendToBack();
                PowerStatus.SendToBack();
            }

            else {
                InfoPanel.Visible = true;
                InfoPanel.BringToFront();
                InfoPanel.Location = new Point(8, 38);
                InfoPanel.Size = new Size(439, 124);

                SettingsPanel.Visible = false;
                SettingsPanel.Location = new Point(410, 68);
                SettingsPanel.Size = new Size(30, 30);

                Warning.SendToBack();
                PowerStatus.SendToBack();
            }
        }

        private void SettingsIcon_Click(object sender, EventArgs e) {
            if (SettingsPanel.Visible == true) {
                SettingsPanel.Visible = false;
                SettingsPanel.Location = new Point(410, 68);
                SettingsPanel.Size = new Size(30, 30);

                Warning.SendToBack();
                PowerStatus.SendToBack();
            }

            else {
                SettingsPanel.Visible = true;
                SettingsPanel.BringToFront();
                SettingsPanel.Location = new Point(8, 38);
                SettingsPanel.Size = new Size(439, 124);

                InfoPanel.Visible = false;
                InfoPanel.Location = new Point(12, 68);
                InfoPanel.Size = new Size(30, 30);

                Warning.SendToBack();
                PowerStatus.SendToBack();
            }
        }
        ///////////////////////////////////////////////////        
    }
}



//Check Battery Percentage
//percentNumber = (int)(power.BatteryLifePercent * 100);

//Percent Number
//percentNumber = (int)(power.BatteryLifePercent * 100);
//BatteryTime.Text = percentNumber.ToString();


/*private void BatteryState() {
    var status = SystemInformation.PowerStatus.BatteryChargeStatus;
    if (status != BatteryChargeStatus.NoSystemBattery) {
        var batteryStatus = status == 0 ? "NOT CHARGING" : status.ToString().ToUpper();
        PowerStatus.Text = batteryStatus;
        //BatteryStatus.Text = power.BatteryChargeStatus.ToString();
    }
}*/

//John Dave R. Dalmao