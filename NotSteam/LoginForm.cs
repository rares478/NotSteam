using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotSteam
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static user user = null;
        public static bool switchtoRegister = false;


        public void btLogin_Click(object sender, EventArgs e)
        {
            string username = this.tbUsername.Text;
            string password = this.tbPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter username or password",
                      "Email or Password Empty", MessageBoxButtons.OK);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30");
                string loginquery = "SELECT * FROM Users WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(loginquery, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    user = new user();
                    user.id = reader.GetInt32(0);
                    user.username = reader.GetString(1);
                    user.password = reader.GetString(2);
                    user.admin = reader.GetInt32(4);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect",
                    "Username or Password Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database",
                "Database Connection Error", MessageBoxButtons.OK);
            }

        }

        public void btRegister_Click(object sender, EventArgs e)
        {
            LoginForm.switchtoRegister= true;
            this.Close();
        }
    }
}
