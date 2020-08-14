using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerMonitor {
    public partial class MessageBoxes : Form {
        int mov;
        int movX;
        int movY;

        public MessageBoxes(int lowpower, int highpower) {
            InitializeComponent();
            LowStorage.Value = lowpower;
            HighStorage.Value = highpower;
        }

        private void YesBtn_Click(object sender, EventArgs e) {
            Properties.Settings.Default.LowBatteryValue = (int)LowStorage.Value;
            Properties.Settings.Default.HighBatteryValue = (int)HighStorage.Value;

            Properties.Settings.Default.Save();

            OkayPanel.Visible = true;
            OkayPanel.Location = new Point(3, 6);
            OkayPanel.Size = new Size(185, 121);
        }

        private void NoBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void OkayBtn_Click(object sender, EventArgs e) {
            //Application.Restart();
            //Environment.Exit(0);
            Close();
        }

        private void MessageBoxes_MouseDown(object sender, MouseEventArgs e) {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void MessageBoxes_MouseMove(object sender, MouseEventArgs e) {
            if (mov == 1) {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void MessageBoxes_MouseUp(object sender, MouseEventArgs e) {
            mov = 0;
        }

        protected override void OnPaint(PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.NavajoWhite, ButtonBorderStyle.Solid);
        }
    }
}
