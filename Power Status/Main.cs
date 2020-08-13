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
using System.Drawing.Drawing2D;

namespace Power_Status {
    public partial class Main : Form {
        PowerStatus power = SystemInformation.PowerStatus;
        int percentNumber, timeLeft;
        int low = 25;
        int high = 98;
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
        }

        ////////Rounded Borders with Border Color////////
        public void SetWindowRegion() {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 30);// 30 represents the size of the fillet angle
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius) {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arcRect, 180, 90);// top left

            arcRect.X = rect.Right - diameter;//top right
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = rect.Bottom - diameter;// buttom right
            path.AddArc(arcRect, 0, 90);

            arcRect.X = rect.Left;// button left
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }

        private static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r) {
            int l = 2 * r;
            // Divide the rounded rectangle into a combination of straight lines and arcs, and add them to the path in turn
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);

            gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);

            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);

            gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
            return gp;
        }

        public void FillRoundRectangle(Graphics g, Rectangle rectangle, Pen pen, int r) {
            rectangle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            g.DrawPath(pen, GetRoundRectangle(rectangle, r));
        }

        protected override void OnPaint(PaintEventArgs e) {
            Pen pen = new Pen(Color.NavajoWhite, 1);
            pen.DashStyle = DashStyle.Solid;
            Rectangle rectangle = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            FillRoundRectangle(e.Graphics, rectangle, pen, 14);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Main_Load(object sender, EventArgs e) {
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

            if (this.WindowState == FormWindowState.Normal) {
                SetWindowRegion();
            }
            else {
                this.Region = null;
            }
        }

        private void MinimizeIcon_Click(object sender, EventArgs e) {
            this.CenterToScreen();
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
            BatteryPercent();
            CurrentBatteryLife();
        }

        private void BatteryState() {
            if (power.PowerLineStatus == PowerLineStatus.Online) {
                Warning.SendToBack();
                Warning.Visible = false;
                PowerStatus.Text = "CHARGING";
            }

            else if (power.PowerLineStatus == PowerLineStatus.Offline) {
                PowerStatus.Text = "NOT CHARGING";
            }

            else {
                PowerStatus.Text = "UNKNOWN";
            }
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
                //Low Power State
                if (percentNumber <= 25) {
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
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void BatteryPercent() {
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
                BatteryTime.Text = "Wait while still charging...";
            }
        }

        private void CheckpercentNumberLow() {
            try {
                if (percentNumber <= low && power.PowerLineStatus == PowerLineStatus.Offline) {
                    this.CenterToScreen();
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
                if (percentNumber >= high && power.PowerLineStatus == PowerLineStatus.Online) {
                    this.CenterToScreen();
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

        ////////////////////////INFO and SETTINGS///////////////////////
        private void InfoIcon_Click(object sender, EventArgs e) {
            if (InfoPanel.Visible == true) {
                InfoPanel.Visible = false;
                InfoPanel.Location = new Point(12, 68);
                InfoPanel.Size = new Size(30, 30);
            }

            else {
                InfoPanel.Visible = true;
                InfoPanel.Location = new Point(8, 38);
                InfoPanel.Size = new Size(439, 124);

                SettingsPanel.Visible = false;
                SettingsPanel.Location = new Point(410, 68);
                SettingsPanel.Size = new Size(30, 30);
            }
        }

        private void SettingsIcon_Click(object sender, EventArgs e) {
            if (SettingsPanel.Visible == true) {
                SettingsPanel.Visible = false;
                SettingsPanel.Location = new Point(410, 68);
                SettingsPanel.Size = new Size(30, 30);
            }

            else {
                SettingsPanel.Visible = true;
                SettingsPanel.Location = new Point(8, 38);
                SettingsPanel.Size = new Size(439, 124);

                InfoPanel.Visible = false;
                InfoPanel.Location = new Point(12, 68);
                InfoPanel.Size = new Size(30, 30);
            }
        }
        ///////////////////////////////////////////////////
    }
}

//ADD
//modify time interval update in the ui

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
