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
        private void button1_Click(object sender, EventArgs e)
        {
            int money1 = Convert.ToInt32(cbMoney.SelectedItem);
            if (cbTerms.Checked)
            {
                money = money + money1;

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Users SET money = '" + money + "' WHERE Id = '" + userid + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                button1.Name = money.ToString();

                FundsAdded?.Invoke(sender, e);

            }
        }
    }
}
