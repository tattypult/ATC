using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    internal static class Program
    {
        public static Form1 form1;
        public static TEST test;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] processList = Process.GetProcessesByName("ATC");
            if (processList.Length > 1)
            {
                MessageBox.Show("Программа уже запущена");
                goto Next;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        Next: { }
        }
    }
}
