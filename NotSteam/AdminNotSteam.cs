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
    public partial class AdminNotSteam : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminNotSteam(user user )
        {
            InitializeComponent();
            lbUsername.Text = user.username;
        }

        public static bool switchtoNormal = false;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Games(name,developer,date) Values ('" + tbName.Text + "', '" + tbDeveloper.Text + "','" +now+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Game Added", "You did it", MessageBoxButtons.OK);

        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            switchtoNormal = true;
            this.Close();

        }
    }
}
