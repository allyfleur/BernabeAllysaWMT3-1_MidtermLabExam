using System;
using System.Windows.Forms;

namespace StudentManagementApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Student_Page());
        }
    }
}