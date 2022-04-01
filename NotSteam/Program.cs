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

            user user = null;
            while (true)
            {
                Application.Run(new LoginForm());
                if (LoginForm.switchtoRegister)
                {
                    Application.Run(new RegisterForm());
                    if (RegisterForm.switchtoLogin)
                    {
                        continue;
                    }
                    else
                    {
                        user = RegisterForm.user;
                        break;
                    }
                }
                else
                {
                    user = LoginForm.user;
                    break;
                }
            }
            if (user.admin == 1)
                Application.Run(new AdminNotSteam(user));
            else if (user != null && user.admin !=1 )
                Application.Run(new NotSteamForm(user));
            else
                MessageBox.Show("Auth Failed", "Auth Failed", MessageBoxButtons.OK);
            if(AdminNotSteam.switchtoNormal)
                Application.Run(new NotSteamForm(user));
        }
    }
}
