using System;
using System.Threading;
using System.Windows.Forms;

namespace PowerMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex m = new Mutex(true, Application.ProductName, out bool InstanceCount))
            {
                if (InstanceCount)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                    m.ReleaseMutex();
                }

                else
                {
                    MessageBox.Show("Power Monitor is Already RUNNING, Please Check the System Tray.", "Power Monitor");
                }
            }
        }
    }
}
