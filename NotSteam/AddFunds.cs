using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class AddFunds : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        int money;
        int userid;
        public AddFunds(user user)
        {
            InitializeComponent();
            money = user.money;
            userid = user.id;
            DoubleBuffered = true;
        }

        public static event EventHandler FundsAdded;

        private void bt5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            money = money + 5;
            cmd.CommandText = "UPDATE Users SET money = '" + money + "' WHERE Id = '" + userid + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            bt5.Name = money.ToString();

            FundsAdded?.Invoke(sender, e);
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            money = money + 10;
            cmd.CommandText = "UPDATE Users SET money = '" + money + "' WHERE Id = '" + userid + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            bt10.Name = money.ToString();

            FundsAdded?.Invoke(sender, e);
        }

        private void bt25_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            money = money + 25;
            cmd.CommandText = "UPDATE Users SET money = '" + money + "' WHERE Id = '" + userid + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            bt25.Name = money.ToString();

            FundsAdded?.Invoke(sender, e);
        }

        private void bt50_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            money = money + 50;
            cmd.CommandText = "UPDATE Users SET money = '" + money + "' WHERE Id = '" + userid + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            bt50.Name = money.ToString();

            FundsAdded?.Invoke(sender, e);
        }

        private void bt100_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            money = money + 100;
            cmd.CommandText = "UPDATE Users SET money = '" + money + "' WHERE Id = '" + userid + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            bt100.Name = money.ToString();

            FundsAdded?.Invoke(sender, e);
        }
    }
}
