﻿using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class NotSteamForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iovit\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");

        int userid;
        public NotSteamForm(user user)
        {
            InitializeComponent();
            if (user.admin != 1)
                tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);


            con.Open();
            lbUsername.Text = user.username + "'s games";
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
            cbGames.SelectedItem = cbGames.Items[0];
        }
        int c = 0;

        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component is Button)
                {
                    component.BackColor = Colorscheme.ButtonBG;

                }
                else if (component is TextBox)
                {
                    component.BackColor = Colorscheme.ButtonBG;
                    component.ForeColor = Colorscheme.ButtonFG;
                }
                else if (component is ComboBox)
                {
                    component.BackColor = Colorscheme.ComboBG;
                    component.ForeColor = Colorscheme.ComboFG;
                }
                else if (component is RadioButton)
                {
                    component.BackColor = Colorscheme.ButtonBG;
                    component.ForeColor = Colorscheme.ButtonFG;
                }
                else if (component is TabPage)
                {
                    component.BackColor = Colorscheme.TabBG;
                    component.ForeColor = Colorscheme.TabFG;
                }
                else if (component is RichTextBox)
                {
                    component.BackColor = Colorscheme.ButtonBG;
                    component.ForeColor = Colorscheme.ButtonFG;
                }
                else if (component is ListBox)
                {
                    component.BackColor = Colorscheme.ListBoxBG;
                    component.ForeColor = Colorscheme.ListBoxFG;
                }
            }
        }
        public void ChangeThemeOrig(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component is Button)
                {
                    component.BackColor = ColorOriginal.ButtonBG;

                }
                else if (component is TextBox)
                {
                    component.BackColor = ColorOriginal.ButtonBG;
                    component.ForeColor = ColorOriginal.ButtonFG;
                }
                else if (component is ComboBox)
                {
                    component.BackColor = ColorOriginal.ComboBG;
                    component.ForeColor = ColorOriginal.ComboFG;
                }
                else if (component is RadioButton)
                {
                    component.BackColor = ColorOriginal.ButtonBG;
                    component.ForeColor = ColorOriginal.ButtonFG;
                }
                else if (component is TabPage)
                {
                    component.BackColor = ColorOriginal.TabBG;
                    component.ForeColor = ColorOriginal.TabFG;
                }
                else if (component is RichTextBox)
                {
                    component.BackColor = ColorOriginal.ButtonBG;
                    component.ForeColor = ColorOriginal.ButtonFG;
                }
                else if (component is ListBox)
                {
                    component.BackColor = ColorOriginal.ListBoxBG;
                    component.ForeColor = ColorOriginal.ListBoxFG;
                }
            }
        }

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            if (c == 1)
                c = 0;
            else c = 1;
            lvAfis.ListViewItemSorter = new ListViewItemComparer(e.Column, c);
        }


        private void btAfis_Click(object sender, EventArgs e)
        {
            lvAfis.Items.Clear();
            con.Open();
            string query = "select [List of owned games].name, [List of owned games].[date_bought] from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE[List of owned games].UserId = " + userid + "";

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

            string idquery = "select Games.Id from Games where Games.name = '" + cbGames.GetItemText(cbGames.SelectedItem) + "';";
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
            string amdeja = "select dbo.[List of owned games].name from dbo.[List of owned games] where dbo.[List of owned games].GameID = '" + id + "' AND dbo.[List of owned games].UserId = '" + userid + "'";
            SqlCommand cmdamdeja = new SqlCommand(amdeja, con);
            SqlDataReader reader1 = cmdamdeja.ExecuteReader();
            if (reader1.Read())
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
            else MessageBox.Show("Ai deja jocu", "Inteleg ca vrei sa imi dai bani da nu mersi", MessageBoxButtons.OK);
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
            if (pbAdd.Image == null)
            {
                MessageBox.Show("Please enter a picture", "Missing Picture", MessageBoxButtons.OK);
            }
            else
            {
                /*DateTime now = DateTime.Now;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Games(name,developer,date,description) Values ('" + tbName.Text + "', '" + tbDev.Text + "','" + now + "', '" + rbDesc.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Game Added", "You did it", MessageBoxButtons.OK);*/

            }
        }
        private void addImage(string imageToLoad)
        {
            if (imageToLoad != "")
            {
                imageList1.Images.Add(Image.FromFile(imageToLoad));
                listBox1.BeginUpdate();
                listBox1.Items.Add(imageToLoad);
                listBox1.EndUpdate();
            }
        }
        private void btPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                /*var path = string.Format(@"{0}\Resources\Images\{1}", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, openFileDialog1.FileName);
                var resizedImage = GiftImage.CreateResizedImage(100, 100, 0);
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(resizedImage));
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    encoder.Save(stream);
                }*/
            }
            else MessageBox.Show("something went wrong with the picture", "idk wtf i'm doing", MessageBoxButtons.OK);
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.SelectedTab = tabPage4;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeThemeOrig(tabControl1.Controls);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTheme(tabControl1.Controls);
        }
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        private int order;
        public ListViewItemComparer(int column, int c)
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
