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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");

        int userid;
        public NotSteamForm(user user)
        {
            InitializeComponent();
            if (user.admin != 1)
                tabControl1.TabPages.Remove(tabPage3);

            con.Open();
            lbUsername.Text = user.username +"'s games" ;
            label3.Text = user.username;
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
            
            string idquery = "select Games.name from Games";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            while (reader.Read())
            {
                cbGames.Items.Add(reader.GetString(0));
            }
            con.Close();
        }
        int c = 0;

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            if (c == 1)
                c = 0;
            else c = 1;
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

        private void btBuy_Click(object sender, EventArgs e)
        {
            con.Open();

            string id;

            string idquery = "select Games.Id from Games where Games.name = '"+ cbGames.GetItemText(cbGames.SelectedItem) + "';";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
            }
            else
                id = null;
            reader.Close();
            string nume = null;
            string amdeja = "select dbo.[List of owned games].name from dbo.[List of owned games] where dbo.[List of owned games].GameID = '"+id+"' AND dbo.[List of owned games].UserId = '"+userid+"'";
            SqlCommand cmdamdeja = new SqlCommand(amdeja, con);
            SqlDataReader reader1 = cmdamdeja.ExecuteReader();
            if(reader1.Read())
            {
                nume = reader1.GetString(0);
            }

            if (nume == null)
            {
                if (id != null)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    DateTime dateTime = DateTime.Now;
                    var dateValue1 = dateTime.ToString("MM/dd/yyyy");
                    cmd.CommandText = "INSERT INTO dbo.[List of owned games](GameID,name,UserId,date_bought) VALUES ('" + id + "', '" + cbGames.GetItemText(cbGames.SelectedItem) + "', '" + userid + "', '" + dateValue1 + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            else MessageBox.Show("Ai deja jocu","Inteleg ca vrei sa imi dai bani da nu mersi",MessageBoxButtons.OK);
            con.Close();
        }

        private void cbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbGames.GetItemText(cbGames.SelectedItem);
            lbName.Text = name;
            con.Open();
            string devquery = "select developer,description from Games where name = '" + name + "'";
            SqlCommand cmddev = new SqlCommand(devquery, con);
            SqlDataReader readerdev = cmddev.ExecuteReader();
            if (readerdev.Read())
            {
                lbdev.Text = readerdev.GetString(0);
                tbDescriere.Text = readerdev.GetString(1);
            }

            int id;

            string idquery = "select Games.Id from Games where Games.name = '" + cbGames.GetItemText(cbGames.SelectedItem) + "';";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            else
                id = 0;
            reader.Close();

            con.Close();
            pbPic.Image = imageList1.Images[id];
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Please enter a picture", "Missing Picture", MessageBoxButtons.OK);
            }
            else
            { 
                DateTime now = DateTime.Now;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Games(name,developer,date,description) Values ('" + tbName.Text + "', '" + tbDev.Text + "','" + now + "', '" + rbDesc.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Game Added", "You did it", MessageBoxButtons.OK);
                imageList1.Images.Add(Image.FromFile(path));

            }
        }
        string path=null;

        private void btPic_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            else MessageBox.Show("something went wrong with the picture", "idk wtf i'm doing", MessageBoxButtons.OK);

            textBox1.Text = path;
            Bitmap pic = new Bitmap(213, 199);
            var tempimage = Image.FromFile(path);
            using (Graphics g = Graphics.FromImage(pic))
            {
                g.DrawImage(tempimage, new Rectangle(0,0,pic.Width,pic.Height));
            }
            imageList1.Images.Add(pic);
        }
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        private int order;
        public ListViewItemComparer(int column,int c)
        {
            col = column;
            order = c;
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
