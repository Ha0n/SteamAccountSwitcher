using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SteamAccountSwitcher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Process process = RunningInstance();
            if(process == null)
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            else
            {
                HandleRunningInstance(process);
            }

        }

        public static Process RunningInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != currentProcess.Id)
                    return process;
            }
            return null;
        }

        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void HandleRunningInstance(Process process)
        {
            ShowWindowAsync(process.MainWindowHandle, 1);
            SetForegroundWindow(process.MainWindowHandle);
        }
    }
}