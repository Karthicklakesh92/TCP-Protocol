using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Tcp_Clinent_Program
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern int IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //Checking Whether Current Instance Is Already Running or Not

                //Reading Current Assembly Location
                Assembly assembly = Assembly.GetExecutingAssembly();
                string Location = assembly.Location;

                //Reading Current Assembly Name
                FileSystemInfo FileInformation = new FileInfo(Location);
                string ExeName = FileInformation.Name;

                //Creating Named Global Mutex
                bool bCreatedNew;
                Mutex mutex = new Mutex(true, "Global\\" + ExeName, out bCreatedNew);

                if (bCreatedNew)
                {
                    mutex.ReleaseMutex();
                    Application.Run(new Main());
                }
                else
                {
                    //MessageBox.Show("Unable To Create Mutex and Owned \r\nApplication Is Running Already");

                    //Getting CurrentInstance WindowHandle
                    const int SW_RESTORE = 9;
                    Process process = new Process();
                    process = Process.GetCurrentProcess();
                    Process[] processes = Process.GetProcessesByName(process.ProcessName);

                    IntPtr hWnd = IntPtr.Zero;
                    foreach (Process runningProcess in processes)
                    {
                        if ((runningProcess.Id != process.Id) &&
                            //(runningProcess.MainModule.FileName == process.MainModule.FileName) &&
                             (runningProcess.ProcessName == process.ProcessName) &&
                             (runningProcess.MainWindowHandle != IntPtr.Zero))
                        {
                            hWnd = runningProcess.MainWindowHandle;
                            break;
                        }
                    }

                    // Restore window if minimised. Do not restore if already in
                    // normal or maximised window state, since we don't want to
                    // change the current state of the window.
                    if (IsIconic(hWnd) != 0)
                    {
                        ShowWindow(hWnd, SW_RESTORE);
                    }

                    // Set foreground window.
                    SetForegroundWindow(hWnd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
