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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static user user = null;
        public static bool switchtoLogin = false;

        public void btRegister_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Users(GameID,name,UserId, date bought) VALUES ('" + tbUsername.Text + "', '" + tbPassword.Text + "', '" + tbEmail.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void btLogin_Click(object sender, EventArgs e)
        {
            RegisterForm.switchtoLogin = true;
            this.Close();
        }
    }
}
