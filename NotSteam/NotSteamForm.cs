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
    public partial class NotSteamForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public static bool isAdmin = false;
        int userid;
        public NotSteamForm(user user)
        {
            InitializeComponent();
            lbUsername.Text = user.username;
            userid = user.id;
        }

        private void btAfis_Click(object sender, EventArgs e)
        {
            lvAfis.View = View.Details;
            lvAfis.AllowColumnReorder = true;
            ListViewItem lvgame = new ListViewItem("Game");
            ListViewItem lvdate = new ListViewItem("date");
            
            con.Open();

            string query = "select [List of owned games].name, [List of owned games].[date bought] from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE[List of owned games].UserId = Users.Id";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lvgame.SubItems.Add(reader.GetString(0));
                lvdate.SubItems.Add(reader.GetDateTime(1).ToString());
                
            }
            lvAfis.Items.AddRange(new ListViewItem[] {lvgame, lvdate});
            con.Close();

        }
        int joc;
        string name;
        private void btBuy_Click(object sender, EventArgs e)
        {
            con.Open();
            string id;
            string idquery = "select Games.Id from Games where Games.name = '"+ name +"';";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
            }
            else
                id = null;

            if (id!= null)
                { 
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    DateTime dateTime = DateTime.Now;
                    var dateValue1 = dateTime.ToString("MM/dd/yyyy");
                    cmd.CommandText = "INSERT INTO dbo.[List of owned games](GameID,name,UserId,date_bought) VALUES ('" + id + "', '" + name + "', '" + userid +"', '"+dateValue1+"')";
                    cmd.ExecuteNonQuery();
                con.Close();
                }
        }

        private void rbGTA_CheckedChanged(object sender, EventArgs e)
        {
            joc = 5;
            name = "GTA";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            joc = 6;
            name = "BTD 6";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            joc = 7;
            name = "Dying Light";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            joc = 8;
            name = "New World";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            joc = 9;
            name = "CS 1.6";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            joc = 10;
            name = "PUBG";
        }
    }
}
