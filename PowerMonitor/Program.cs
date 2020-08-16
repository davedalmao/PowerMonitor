using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace PowerMonitor {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            bool InstanceCount = false;

            using (Mutex m = new Mutex(true, "MyRunningApp", out InstanceCount)) {
                if (InstanceCount) {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                    m.ReleaseMutex();
                }

                else {
                    MessageBox.Show("Power Monitor is Already RUNNING, Please Check the System Tray.", "Power Monitor");
                }
            }
        }
    }
}
