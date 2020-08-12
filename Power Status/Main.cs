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

namespace Power_Status {
    /*public static class ModifyProgressBarColor {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state) {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }*/

    public partial class Main : Form {
        PowerStatus power = SystemInformation.PowerStatus;
        int percentNumber, timeLeft;
        int mov;
        int movX;
        int movY;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public Main() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
            BatteryIndicator.ForeColor = Color.FromArgb(255, 0, 0);
            BatteryIndicator.BackColor = Color.FromArgb(150, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e) {
            RefreshStatus();
            RefreshTimer.Enabled = true;
            ForLow.Enabled = true;
            ForHigh.Enabled = true;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e) {
            RefreshStatus();
        }

        private void ForLow_Tick(object sender, EventArgs e) {
            CheckpercentNumberLow();
        }

        private void ForHigh_Tick(object sender, EventArgs e) {
            CheckpercentNumberFull();
        }

        private void Main_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void CloseIcon_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.CenterToScreen();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void RefreshStatus() {
            BatteryState();
            VisualBatteryHealth();
            HighMedLow();

            //Battery Percent
            if (percentNumber == 100) {
                BatteryLife.Text = "Full Charged:   " + power.BatteryLifePercent.ToString("P0");
            }

            else {
                BatteryLife.Text = "Charge Remaining:   " + power.BatteryLifePercent.ToString("P0");
            }


            //Battery Life
            timeLeft = power.BatteryLifeRemaining;
            if (timeLeft > 0) {
                BatteryTime.Text = string.Format("{0} remaining", Time(timeLeft));
            }

            else {
                BatteryTime.Text = "Wait while still charging...";
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

        private void BatteryState() {
            var status = SystemInformation.PowerStatus.BatteryChargeStatus;
            if (status != BatteryChargeStatus.NoSystemBattery) {
                var batteryStatus = status == 0 ? "NOT CHARGING" : status.ToString().ToUpper();
                PowerStatus.Text = batteryStatus;
                //BatteryStatus.Text = power.BatteryChargeStatus.ToString();
            }
        }

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
                //Low Power State
                if (percentNumber <= 25) {
                    ////////////////
                    //Add sound here
                    ////////////////
                }

                //High Power State
                else if (percentNumber >= 80) {
                    ////////////////
                    //Add sound here
                    ////////////////          
                }

                //Med State
                else {
                    //BatteryIndicator.ForeColor = Color.FromArgb(0, 0, 192);
                    BatteryIndicator.ForeColor = Color.Red;
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void CheckpercentNumberLow() {
            try {
                if (percentNumber <= 25 && power.PowerLineStatus == PowerLineStatus.Offline) {
                    ShowMain();
                    Warning.BringToFront();
                    Warning.Visible = true;
                    ForLow.Stop();
                    ForHigh.Start();
                    ////////////////
                    //Add sound here
                    ////////////////
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void CheckpercentNumberFull() {
            try {
                if (percentNumber >= 76 && power.PowerLineStatus == PowerLineStatus.Online) {
                    ShowMain();
                    Warning.SendToBack();
                    Warning.Visible = false;
                    ForHigh.Stop();
                    ForLow.Start();
                    ////////////////
                    //Add sound here
                    ////////////////
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void ShowMain() {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}

//ADD
//modify time interval update in the ui


//Check Battery Percentage
//percentNumber = (int)(power.BatteryLifePercent * 100);


//Percent Number
//percentNumber = (int)(power.BatteryLifePercent * 100);
//BatteryTime.Text = percentNumber.ToString();
