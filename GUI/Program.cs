using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BTL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frmDN = new frmLogin();
            Application.Run(frmDN);
            if (frmDN.statusForm == true)
            {
                frmAdmin frmGiaoDien = new frmAdmin();
                Application.Run(frmGiaoDien);
                if (frmGiaoDien.statusForm == false)
                {
                    Application.Restart();
                }
            }
        }
    }
}
