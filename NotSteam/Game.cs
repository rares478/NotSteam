using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotSteam
{
    public partial class Game : Form
    {
        string name = null;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        int money;
        public Game(user user)
        {
            InitializeComponent();
            int id;
            string idquery = "select Id,developer,date,description,price from Games where name = '" + name + "'";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                lbDevGame.Text = "Developer: " + reader.GetString(1);
                lbRelease.Text = "released on: " + reader.GetDateTime(2).ToString("MM/dd/yyyy");
                tbGame.Text = reader.GetString(3);
                btBuyGame.Text = Convert.ToString(reader.GetInt32(4));
            }
            else
                id = 0;
            reader.Close();

            con.Close();
            if (id + 1 >= imageList1.Images.Count)
            {
                id = 0; lbMissingGame.Visible = true;

            }
            else
                lbMissingGame.Visible = false;
            pbGame.Image = imageList1.Images[id + 1];
            lbGameNameBuy.Text = "Buy " + lbNameGame.Text;
            con.Close();
        }
        private Store mainform = null;
        public Game(Form callingform)
        {
            mainform = callingform as Store;
            InitializeComponent();
            name = mainform.selected;
        }

        private void btBuyGame_Click(object sender, EventArgs e)
        {

        }
    }
}
