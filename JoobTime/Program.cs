using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JoobTime
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process thisProcess = Process.GetCurrentProcess();
            string nameThisProcess = thisProcess.ProcessName.ToString();
            Process[] otherProcess = Process.GetProcessesByName(nameThisProcess);
            int count = otherProcess.Count();
            if (count == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new formLogin());
            }
            else
            {
                XtraMessageBox.Show("Программа уже запущена.","Внимание");
            }
        }
    }
}
