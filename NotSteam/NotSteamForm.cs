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
using System.Collections;

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

            lvAfis.View = View.Details;
            lvAfis.AllowColumnReorder = true;
            lvAfis.Columns.Add(new ColumnHeader());
            lvAfis.Columns[0].Text = "nimic-nu sterge ca bubuie";
            lvAfis.Columns[0].Width = 0;
            lvAfis.Columns.Add(new ColumnHeader());
            lvAfis.Columns[1].Text = "Game";
            lvAfis.Columns[1].Width = 100;
            lvAfis.Columns.Add(new ColumnHeader());
            lvAfis.Columns[2].Text = "Date bought";
            lvAfis.Columns[2].Width = 120;
            lvAfis.LabelEdit = true;
            lvAfis.ColumnClick += new ColumnClickEventHandler(ColumnClick);
        }
        int c = 0;

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            c++;
            lvAfis.ListViewItemSorter = new ListViewItemComparer(e.Column,c);
        }

        private void btAfis_Click(object sender, EventArgs e)
        {
            lvAfis.Items.Clear();
            con.Open();

            string query = "select [List of owned games].name, [List of owned games].[date_bought] from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE[List of owned games].UserId = "+userid+"";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvgame = new ListViewItem();
                lvgame.SubItems.Add(reader.GetString(0));
                var dateValue1 = reader.GetDateTime(1).ToString("MM/dd/yyyy");
                lvgame.SubItems.Add(dateValue1);
                lvAfis.Items.Add(lvgame);   
            }
            con.Close();

        }
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
            name = "GTA";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            name = "BTD 6";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            name = "Dying Light";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            name = "New World";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            name = "CS 1.6";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            name = "PUBG";
        }
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        private int order;
        public ListViewItemComparer(int column,int c)
        {
            col = column;
            if (c % 2 == 1)
                order = 1;
            else order = 0;
        }
        public int Compare(object x, object y)
        {
            if (order == 1)
            {
                if (col == 2)
                {
                    return DateTime.Compare(Convert.ToDateTime(((ListViewItem)x).SubItems[col].Text), Convert.ToDateTime(((ListViewItem)y).SubItems[col].Text));
                }
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
            else
            {
                if (col == 2)
                {
                    return DateTime.Compare(Convert.ToDateTime(((ListViewItem)y).SubItems[col].Text), Convert.ToDateTime(((ListViewItem)x).SubItems[col].Text));
                }
                return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
            }
        }
    }
}
