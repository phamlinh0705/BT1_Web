using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace FunnyWinForms
{
    static class Program
    {
        /// <summary>
        /// Điểm bắt đầu ứng dụng WinForms
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
