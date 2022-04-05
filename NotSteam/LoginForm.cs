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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30");
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
            tabControl1.SelectedTab = tabControl1.TabPages["Register"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["Login"];
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            string name = tbUsernameReg.Text;
            string password = tbPasswordReg.Text;
            string email = tbEmailReg.Text;
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Users(username,password,email,admin) VALUES ('" + name + "', '" + password + "', '" + email + "', '0')";
            cmd.ExecuteNonQuery();
            con.Close();

            user = new user();
            user.email = email;
            user.username = name;
            user.password = password;
            user.admin = 0;
            this.Close();
        }
    }
}
