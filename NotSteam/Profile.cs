using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class Profile : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        int userid;
        string username;
        public Profile(user user)
        {
            InitializeComponent();
            userid = user.id;
            username = user.username;
            DoubleBuffered = true;
            DescriptionShowcase.Visible = false;





            ///
            ///daca vreau sa ma complic si sa schimb culoarea la header trebe sa dau in designer ownerdraw = true 
            ///si sa fac un void ca sa dea draw cu owner la header si cu default pt iteme
            ///https://stackoverflow.com/questions/1814692/change-the-background-color-of-winform-listview-headers
            ///


            con.Open();
            string desc = "select description from Users where id = " + userid + "";
            SqlCommand cmddesc = new SqlCommand(desc, con);
            tbDesc.Text = cmddesc.ExecuteScalar().ToString();
            if (tbDesc.Text.Length == 0)
                tbDesc.Text = "Add a description";
            label1.Text = username;

            string longquery = "Select showcase from Users where Id = '" + userid + "'";
            SqlCommand cmdlong = new SqlCommand(longquery, con);
            int showcase = Convert.ToInt32(cmdlong.ExecuteScalar());
            if (showcase == 1)
            {
                pbShowcase.Visible = true;
                string queryhere = "select PictureBox from Users WHERE Id = '" + userid + "'";
                SqlCommand cmdhere = new SqlCommand(queryhere, con);
                pbShowcase.Load(cmdhere.ExecuteScalar().ToString());
            }
            else if (showcase == 2)
            {
                DescriptionShowcase.Visible = true;
                string queryhere = "Select DescriptionBox from Users where Id= '" + userid + "'";
                SqlCommand sqlhere = new SqlCommand(queryhere, con);
                DescriptionShowcase.Text = sqlhere.ExecuteScalar().ToString();
            }


            lvLibrary.Clear();
            lvLibrary.View = View.Details;
            lvLibrary.AllowColumnReorder = true;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[0].Text = "nimic-nu sterge ca bubuie";
            lvLibrary.Columns[0].Width = 0;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[1].Text = "Game";
            lvLibrary.Columns[1].Width = 130;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[2].Text = "Date bought";
            lvLibrary.Columns[2].Width = 100;
            lvLibrary.LabelEdit = true;
            string query = "select [List of owned games].name, [List of owned games].[date_bought] from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE[List of owned games].UserId = " + userid + "";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvgame = new ListViewItem();
                lvgame.SubItems.Add(reader.GetString(0));
                var dateValue1 = reader.GetDateTime(1).ToString("MM/dd/yyyy");
                lvgame.SubItems.Add(dateValue1);
                lvLibrary.Items.Add(lvgame);
            }
            con.Close();
        }


        string changename = null;
        string description = null;

        private void updatename(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            changename = tb.Text;
        }

        private void updatedesc(object sender, EventArgs e)
        {
            RichTextBox tb = sender as RichTextBox;
            if (tb != null)
                description = tb.Text.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (changename.Length > 0)
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Users SET username = '" + changename + "', description = '" + description + "' WHERE Id = '" + userid + "'";
                    cmd.ExecuteNonQuery();
                    string desc = "select description from Users where Id = " + userid + "";
                    SqlCommand cmddesc = new SqlCommand(desc, con);
                    tbDesc.Text = cmddesc.ExecuteScalar().ToString();
                    if (tbDesc.Text.Length == 0)
                        tbDesc.Text = "Add a description";
                    con.Close();
                }
                else
                    con.Close();
                Controls.Clear();
                InitializeComponent();
                tbDesc.Text = description;
                label1.Text = changename;

                con.Open();
                lvLibrary.Clear();
                lvLibrary.View = View.Details;
                lvLibrary.AllowColumnReorder = true;
                lvLibrary.Columns.Add(new ColumnHeader());
                lvLibrary.Columns[0].Text = "nimic-nu sterge ca bubuie";
                lvLibrary.Columns[0].Width = 0;
                lvLibrary.Columns.Add(new ColumnHeader());
                lvLibrary.Columns[1].Text = "Game";
                lvLibrary.Columns[1].Width = 130;
                lvLibrary.Columns.Add(new ColumnHeader());
                lvLibrary.Columns[2].Text = "Date bought";
                lvLibrary.Columns[2].Width = 100;
                lvLibrary.LabelEdit = true;
                string query = "select [List of owned games].name, [List of owned games].[date_bought] from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE[List of owned games].UserId = " + userid + "";

                SqlCommand cmde = new SqlCommand(query, con);

                SqlDataReader reader = cmde.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvgame = new ListViewItem();
                    lvgame.SubItems.Add(reader.GetString(0));
                    var dateValue1 = reader.GetDateTime(1).ToString("MM/dd/yyyy");
                    lvgame.SubItems.Add(dateValue1);
                    lvLibrary.Items.Add(lvgame);
                }
                con.Close();

            }
            catch (Exception)
            {
            }
        }

        public static event EventHandler EditProfile;

        private void btEdit_Click(object sender, EventArgs e)
        {

            EditProfile?.Invoke(sender, e);
            ///EditProfile();
        }

        public int c = 0;

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            if (c == 1)
            {
                c = 0;
            }
            else
            {
                c = 1;
            }
            lvLibrary.ListViewItemSorter = new ListViewItemComparer(e.Column, c);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (pbShowcase.Visible == true)
            { pbShowcase.Location = new Point(pbShowcase.Location.X, pbShowcase.Location.Y + 360); }
            else if (DescriptionShowcase.Visible == true)
                DescriptionShowcase.Location = new Point(DescriptionShowcase.Location.X, DescriptionShowcase.Location.Y + 360);
            lvLibrary.Location = new Point(179, 164);
            lvLibrary.Visible = true;

        }
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        private int order;
        public ListViewItemComparer(int column, int cc)
        {
            col = column;
            order = cc;
        }
        public int Compare(object x, object y)
        {
            if (order == 0)
            {
                if (col == 2)
                {
                    return DateTime.Compare(Convert.ToDateTime(((ListViewItem)y).SubItems[col].Text), Convert.ToDateTime(((ListViewItem)x).SubItems[col].Text));
                }
                return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
            }
            else
            {
                if (col == 2)
                {
                    return DateTime.Compare(Convert.ToDateTime(((ListViewItem)x).SubItems[col].Text), Convert.ToDateTime(((ListViewItem)y).SubItems[col].Text));
                }
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    }
}
