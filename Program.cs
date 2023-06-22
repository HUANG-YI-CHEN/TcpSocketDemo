using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TcpSocketDemo
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Mutex Form
            _ = new System.Threading.Mutex(true, Application.ProductName, out bool ret);
            if (ret)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                Environment.Exit(Environment.ExitCode);
            }  
            #endregion
        }
    }
}
