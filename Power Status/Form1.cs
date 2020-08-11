using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshStatus();
            RefreshTimer.Enabled = true;            
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }
        
        PowerStatus power = SystemInformation.PowerStatus;

        private void RefreshStatus()
        {
            CheckChargeState();
            VisualBatteryHealth();

             //Battery Percent
            BatteryLife.Text = "Charge Remaining:   " + power.BatteryLifePercent.ToString("P0");
            BatteryStatus.Text = power.BatteryChargeStatus.ToString();

            //Check Battery Percentage
            int a = (int)(power.BatteryLifePercent * 100);
            if (a <= 25)
            {
                this.Show();
            }
        }

        private void CheckChargeState()
        {
            switch (power.PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    //MainsPower.Checked = true; 
                    PowerStatus.Text = "CHARGING";
                    break;

                case PowerLineStatus.Offline:
                    //MainsPower.Checked = false;
                    PowerStatus.Text = "UNPLUGGED";
                    break;

                case PowerLineStatus.Unknown:
                    //MainsPower.CheckState = CheckState.Indeterminate;
                    PowerStatus.Text = "INDETERMINATE";
                    break;
            }
        }

        private void VisualBatteryHealth()
        {
            int powerPercent = (int)(power.BatteryLifePercent * 100);
            if (powerPercent <= 100)
            {
                BatteryIndicator.Value = powerPercent;
            }

            else
            {
                BatteryIndicator.Value = 0;
            }
        }

        public void a()
        {
           
        }
    }
}

//ADD
//modify time interval update in the ui
