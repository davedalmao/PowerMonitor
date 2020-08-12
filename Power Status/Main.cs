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
        int percentNumber;
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
        }

        private void Form1_Load(object sender, EventArgs e) {
            RefreshStatus();
            RefreshTimer.Enabled = true;
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

            //Battery Percent
            BatteryLife.Text = "Charge Remaining:   " + power.BatteryLifePercent.ToString("P0");

            ChargedState();

            //Percent Number
            percentNumber = (int)(power.BatteryLifePercent * 100);
            BatteryTime.Text = percentNumber.ToString();
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

        private void ChargedState() {
            try {
                //Low Power State
                if (percentNumber <= 25 && power.PowerLineStatus == PowerLineStatus.Offline) {
                    ShowMain();
                    Warning.Visible = true;
                    ////////////////
                    //Add sound here
                    ////////////////
                }

                //98% state
                else if (percentNumber >= 98 && power.PowerLineStatus == PowerLineStatus.Online) {
                    ShowMain();
                    ////////////////
                    //Add sound here
                    ////////////////
                }

                //100% State
                else if (percentNumber == 100) {
                    BatteryLife.Text = "Full Charged:   " + power.BatteryLifePercent.ToString("P0");
                }

                else {
                    //BatteryIndicator.SetState(1); //Green
                    //BatteryIndicator.SetState(2); //Red
                    //BatteryIndicator.SetState(3); //Yellow

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
                if (percentNumber >= 92 && power.PowerLineStatus == PowerLineStatus.Online) {
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



//Implement this, change code above, and add 2 timers, pag base ra sa github
/*         private void CheckpercentNumberLow() {
            try {
                if (percentNumber <= 25 && power.PowerLineStatus == PowerLineStatus.Offline) {
                    ShowMain();
                    Warning.Visible = true;
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
                if (percentNumber >= 98 && power.PowerLineStatus == PowerLineStatus.Online) {
                    ShowMain();
                    ////////////////
                    //Add sound here
                    ////////////////
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }*/