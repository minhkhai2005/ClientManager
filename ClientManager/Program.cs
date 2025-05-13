using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sign_In;

namespace ClientManager
{
    static class Program
    {
        private static Sign_in signInPage; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var signInPage = new Sign_in();
            signInPage.ShowDialog();
            if (signInPage.DialogResult == DialogResult.OK)
            {
                Application.Run(new ClientManager());
            }
            else
            {
                Application.Exit();
            }
        }

    }
}
