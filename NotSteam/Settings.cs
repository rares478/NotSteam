using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class Settings : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        int userid;
        string password;
        public Settings(user user)
        {
            userid = user.id; 
            password = user.password;
            InitializeComponent();
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {
            con.Open();

            if (password == tbCurrentPassword.Text)
            {
                if (tbNewPassword.Text.Length > 0)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Users SET password = '" + tbNewPassword.Text + "' WHERE Id = '" + userid + "'";
                    cmd.ExecuteNonQuery();

                }
                else
                    MessageBox.Show("Enter a new password", "Missing password", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Wrong password", "Wrong password", MessageBoxButtons.OK);
            con.Close();
        }

        private void btChangeEmail_Click(object sender, EventArgs e)
        {
            con.Open();

            if (password == tbCurrentPassword.Text)
            {
                if (tbNewEmail.Text.Length > 0)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Users SET email = '" + tbNewEmail.Text + "' WHERE Id = '" + userid + "'";
                    cmd.ExecuteNonQuery();

                }
                else
                    MessageBox.Show("Enter a new email", "Missing email", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Wrong password", "Wrong password", MessageBoxButtons.OK);
            con.Close();
        }
        private static int theme;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            theme = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            theme = 2;
        }
    }
}
