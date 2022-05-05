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
        public Profile(user user,bool edit)
        {
            InitializeComponent();
            userid = user.id;
            username = user.username;
            DoubleBuffered = true;
            if (edit)
            {
                EditProfile();
            }
            else
            {


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

                lvLibrary.Clear();
                lvLibrary.Visible = true;
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
        }

        public void GoBack(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();

            con.Open();
            string desc = "select description from Users where id = " + userid + "";
            SqlCommand cmddesc = new SqlCommand(desc, con);
            tbDesc.Text = cmddesc.ExecuteScalar().ToString();
            if (tbDesc.Text.Length == 0)
                tbDesc.Text = "Add a description";
            label1.Text = username;

            lvLibrary.Items.Clear();
            string query = "select [List of owned games].name, [List of owned games].[date_bought] from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE [List of owned games].UserId = '" + userid + "'";

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

        string changename=null;
        string description=null;

        private void EditProfile()
        {
            Controls.Clear();

            PictureBox pbBack = new PictureBox();
            Controls.Add(pbBack);
            pbBack.Location = new Point(12, 12);
            pbBack.Image = imageList1.Images[0];
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.Size = new Size(29, 24);
            pbBack.Click += new EventHandler(GoBack);

            TextBox tbChangeName = new TextBox();
            Controls.Add(tbChangeName);
            tbChangeName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            tbChangeName.Location = new Point(118, 150);
            tbChangeName.Name = "tbChangeName";
            tbChangeName.Size = new Size(489, 26);
            tbChangeName.TabIndex = 2;
            tbChangeName.TextChanged += updatename;
            tbChangeName.BackColor = SystemColors.GradientActiveCaption;
            tbChangeName.ForeColor = SystemColors.ActiveCaptionText;

            RichTextBox tbChangeDesc = new RichTextBox();
            Controls.Add(tbChangeDesc);
            tbChangeDesc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            tbChangeDesc.Location = new Point(118, 259);
            tbChangeDesc.Name = "tbChangeDesc";
            tbChangeDesc.Size = new Size(489, 97);
            tbChangeDesc.TabIndex = 3;
            tbChangeDesc.Text = "";
            tbChangeDesc.TextChanged += updatedesc;
            tbChangeDesc.BackColor = SystemColors.GradientActiveCaption;
            tbChangeDesc.ForeColor = SystemColors.ActiveCaptionText;
            tbChangeDesc.Text = tbDesc.Text;

            Label label14 = new Label();
            Controls.Add(label14);
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new Point(115, 131);
            label14.Name = "label14";
            label14.Size = new Size(85, 16);
            label14.TabIndex = 1;
            label14.Text = "Profile Name";

            Label label15 = new Label();
            Controls.Add(label15);
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new Point(118, 240);
            label15.Name = "label15";
            label15.Size = new Size(75, 16);
            label15.TabIndex = 4;
            label15.Text = "Description";

            Button btSave = new Button();
            Controls.Add(btSave);
            btSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btSave.Location = new Point(671, 436);
            btSave.Name = "btSave";
            btSave.Size = new Size(80, 25);
            btSave.TabIndex = 0;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += new EventHandler(btSave_Click);
        }

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
                lvLibrary.Visible = true;
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditProfile();
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
