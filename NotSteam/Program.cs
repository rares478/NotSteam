using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSteam
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
            Application.DoEvents();

            user user = null;
            Application.Run(new LoginForm());
            user = LoginForm.user;
            
             if (user != null)
                Application.Run(new NotSteamForm(user));
            else
                MessageBox.Show("Auth Failed", "Auth Failed", MessageBoxButtons.OK);

        }
    }
}
