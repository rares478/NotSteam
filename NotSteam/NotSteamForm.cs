using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class NotSteamForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");

        int userid;
        bool removed;
        bool theme = false;
        int money;
        public NotSteamForm(user user)
        {

            InitializeComponent();
            loggeduser.username = user.username;
            loggeduser.money = user.money;
            loggeduser.id = user.id;
            loggeduser.admin = user.admin;
            if (user.admin != 1)
                addGameToNotSteamToolStripMenuItem.Visible = false;

            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            toolStripmoney.Text = user.money.ToString();
            toolStripProfile.Text = user.username.ToString();

            label6.Text = user.username;
            lbUsername.Text = user.username + "'s games";
            label16.Text = user.username;
            label17.Text = money.ToString();

            ///Initialize();

            label19.Click += new EventHandler(label19_Click);


            con.Open();

            removed = true;

            string desc = "select description from Users where id = " + user.id + "";
            SqlCommand cmddesc = new SqlCommand(desc, con);
            tbDesc.Text = cmddesc.ExecuteScalar().ToString();
            if (tbDesc.Text.Length == 0)
                tbDesc.Text = "Add a description";
            tbChangeDesc.Text = cmddesc.ExecuteScalar().ToString();


            con.Close();

        }

        private void lbl_click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            if (theme)
                ChangeTheme(tabControl1.Controls);
            else ChangeThemeOrig(tabControl1.Controls);
            Label label = sender as Label;
            if (label != null)
                lbNameGame.Text = label.Text;
            con.Open();
            int id;
            string idquery = "select Id,developer,date,description,price from Games where name = '" + label.Text + "'";
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
            if (id >= imageList1.Images.Count)
            {
                id = 0; lbMissingGame.Visible = true;

            }
            else
                lbMissingGame.Visible = false;
            pbGame.Image = imageList1.Images[id];
            tabControl1.SelectedTab = tabPage7;
            lbGameNameBuy.Text = "Buy " + lbNameGame.Text;
            con.Close();
        }

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
                }
                else if (component is RichTextBox)
                {
                    component.BackColor = Colorscheme.ButtonBG;
                    component.ForeColor = Colorscheme.ButtonFG;
                }
                else if (component is ListView)
                {
                    component.BackColor = Colorscheme.ListBoxBG;
                    component.ForeColor = Colorscheme.ListBoxFG;
                }
                else if (component is Label)
                {
                    component.ForeColor = Colorscheme.TabFG;
                }
                else if (component is RadioButton)
                {
                    component.ForeColor = Colorscheme.TabFG;
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
                    component.BackColor = ColorOriginal.RichTextBox;
                    component.ForeColor = ColorOriginal.ButtonFG;
                }
                else if (component is ComboBox)
                {
                    component.BackColor = ColorOriginal.RichTextBox;
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
                    component.BackColor = ColorOriginal.RichTextBox;
                    component.ForeColor = ColorOriginal.ButtonFG;
                }
                else if (component is ListView)
                {
                    component.BackColor = ColorOriginal.RichTextBox;
                    component.ForeColor = ColorOriginal.ListBoxFG;
                }
                else if (component is Label)
                {
                    component.ForeColor = ColorOriginal.ButtonFG;
                }
                else if (component is RadioButton)
                {
                    component.ForeColor = ColorOriginal.ButtonFG;
                }
            }
        }

        private void AfisGames()
        {
            lbAfis.Items.Clear();
            con.Open();
            string query = "select [List of owned games].name from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE[List of owned games].UserId = " + loggeduser.id + "";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbAfis.Items.Add(reader.GetString(0));
            }
            con.Close();

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

                ///Nu stiu de ce nu merge, e probail din cauza ca salveaza doar in cache nu si in proiect
                pbAdd.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else MessageBox.Show("something went wrong with the picture", "idk wtf i'm doing", MessageBoxButtons.OK);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            theme = false;
            ChangeThemeOrig(tabControl1.Controls);
            ChangeThemeOrig(tabPage1.Controls);
            ChangeThemeOrig(tabPage2.Controls);
            ChangeThemeOrig(tabPage3.Controls);
            ChangeThemeOrig(tabPage4.Controls);
            ChangeThemeOrig(tabPage5.Controls);
            ChangeThemeOrig(tabPage6.Controls);
            ChangeThemeOrig(tabPage7.Controls);
            ChangeThemeOrig(tabPage8.Controls);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            theme = true;
            ChangeTheme(tabControl1.Controls);
            ChangeTheme(tabPage1.Controls);
            ChangeTheme(tabPage2.Controls);
            ChangeTheme(tabPage3.Controls);
            ChangeTheme(tabPage4.Controls);
            ChangeTheme(tabPage5.Controls);
            ChangeTheme(tabPage6.Controls);
            ChangeTheme(tabPage7.Controls);
            ChangeTheme(tabPage8.Controls);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (removed)
            {
                tabControl1.TabPages.Add(tabPage4);
                removed = false;
                if (theme)
                    ChangeTheme(tabControl1.Controls);
                else ChangeThemeOrig(tabControl1.Controls);
                tabControl1.SelectedTab = tabPage4;
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.SelectedTab = tabPage1;
                removed = true;
            }
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("This will log you out of NotSteam. You will need to re-enter your account name and password to use NotSteam again." + "\n" + "\n" + "Do you wish to continue ?",
                "Logout", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Restart();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (removed)
            {
                tabControl1.TabPages.Add(tabPage4);
                if (theme)
                    ChangeTheme(tabControl1.Controls);
                else ChangeThemeOrig(tabControl1.Controls);
                removed = false;
                tabControl1.SelectedTab = tabPage4;
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.SelectedTab = tabPage1;
                removed = true;
            }
        }

        private void aboutNotSteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotSteam client application" + "\n" + "\n" + "Built: Azi" + "\n" + "\n" + "NotSteam API: v001" + "\n" + "\n" + "rares478@gmail.com", "About NotSteam", MessageBoxButtons.OK);
        }

        private void viewGamesLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editProfileNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            if (theme)
                ChangeTheme(tabControl1.Controls);
            else ChangeThemeOrig(tabControl1.Controls);
            tabControl1.SelectedTab = tabPage6;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            if (theme)
                ChangeTheme(tabControl1.Controls);
            else ChangeThemeOrig(tabControl1.Controls);
            tabControl1.SelectedTab = tabPage6;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (tbChangeName.Text.Length > 0)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Users SET username = '" + tbChangeName.Text + "', description = '" + tbChangeDesc.Text + "' WHERE Id = '" + userid + "'";
                cmd.ExecuteNonQuery();
                label6.Text = tbChangeName.Text;
                string desc = "select description from Users where Id = " + userid + "";
                SqlCommand cmddesc = new SqlCommand(desc, con);
                tbDesc.Text = cmddesc.ExecuteScalar().ToString();
                if (tbDesc.Text.Length == 0)
                    tbDesc.Text = "Add a description";
                con.Close();
            }
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.SelectedTab = tabPage5;

        }

        private void lbLibrary_Click(object sender, EventArgs e)
        {
            lvLibrary.Clear();
            lvLibrary.Visible = true;
            lvLibrary.View = View.Details;
            lvLibrary.AllowColumnReorder = true;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[0].Text = "nimic-nu sterge ca bubuie";
            lvLibrary.Columns[0].Width = 0;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[1].Text = "Game";
            lvLibrary.Columns[1].Width = 100;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[2].Text = "Date bought";
            lvLibrary.Columns[2].Width = 120;
            lvLibrary.LabelEdit = true;
            con.Open();
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string id;
            string idquery = "select Games.Id from Games where Games.name = '" + lbNameGame.Text + "';";
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
                    if (money > Convert.ToInt32(btBuyGame.Text))
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        DateTime dateTime = DateTime.Now;
                        var dateValue1 = dateTime.ToString("MM/dd/yyyy");
                        cmd.CommandText = "INSERT INTO dbo.[List of owned games](GameID,name,UserId,date_bought) VALUES ('" + id + "', '" + lbNameGame.Text + "', '" + userid + "', '" + dateValue1 + "')";
                        cmd.ExecuteNonQuery();
                        int money1 = money;
                        int money2 = Convert.ToInt32(btBuyGame.Text);
                        int moneyfinal = money1 - money2;
                        SqlCommand cmdmoney = con.CreateCommand();
                        cmdmoney.CommandType = CommandType.Text;
                        cmdmoney.CommandText = "UPDATE Users SET money = '" + moneyfinal + "' WHERE Id = '" + userid + "'";
                        cmdmoney.ExecuteNonQuery();
                        money = moneyfinal;
                    }
                    else
                    {
                        DialogResult result;
                        result = MessageBox.Show("You do not have enough money to buy this game", "Insufficient funds", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            tabControl1.TabPages.Add(tabPage8);
                            if (theme)
                                ChangeTheme(tabControl1.Controls);
                            else ChangeThemeOrig(tabControl1.Controls);
                            tabControl1.SelectedTab = tabPage8;
                        }

                    }
                }
            }
            else MessageBox.Show("You already own the game", "You cannot buy the game", MessageBoxButtons.OK);
            con.Close();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab != tabPage7)
                tabControl1.TabPages.Remove(tabPage7);
            if (tabControl1.SelectedTab != tabPage4)
                tabControl1.TabPages.Remove(tabPage4);
            if (tabControl1.SelectedTab == tabPage2)
            {
                AfisGames();
                lbAfis.SelectedIndex = 0;
            }
            if (tabControl1.SelectedTab != tabPage8)
                tabControl1.TabPages.Remove(tabPage8);
            if (tabControl1.SelectedTab != tabPage3)
                tabControl1.TabPages.Remove(tabPage3);
        }

        private void lbAfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lbAfis.GetItemText(lbAfis.SelectedItem);
            int id = 0;
            con.Open();
            string devquery = "select id from Games where name = '" + name + "'";
            SqlCommand cmddev = new SqlCommand(devquery, con);
            SqlDataReader readerdev = cmddev.ExecuteReader();
            if (readerdev.Read())
            {
                id = readerdev.GetInt32(0);
            }

            string lastquery = "select [last played],[date_bought] from [dbo].[List of owned games] WHERE (UserId = '" + userid + "'and GameID = '" + id + "')";
            SqlCommand sqllastquery = new SqlCommand(lastquery, con);
            SqlDataReader readerlast = sqllastquery.ExecuteReader();
            if (readerlast.Read())
            {
                if (readerlast.IsDBNull(0))
                    lbLastPlayed.Text = "never played";
                else
                    lbLastPlayed.Text = readerlast.GetDateTime(0).ToString("MM/dd/yyyy");
                lbDateBought.Text = readerlast.GetDateTime(1).ToString("MM/dd/yyyy");
            }

            if (id >= imageList1.Images.Count)
                id = 0;
            pbAfis.Image = imageList1.Images[id];
            con.Close();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            string name = lbAfis.GetItemText(lbAfis.SelectedItem);
            int id = 0;
            con.Open();
            string devquery = "select id from Games where name = '" + name + "'";
            SqlCommand cmddev = new SqlCommand(devquery, con);
            SqlDataReader readerdev = cmddev.ExecuteReader();
            if (readerdev.Read())
                id = readerdev.GetInt32(0);


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DateTime dateTime = DateTime.Now;
            var dateValue1 = dateTime.ToString("MM/dd/yyyy");
            cmd.CommandText = "UPDATE [dbo].[List of owned games] SET [last played] = '" + dateValue1 + "' WHERE (UserId = '" + userid + "' and GameID = '" + id + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            if (theme)
                ChangeTheme(tabControl1.Controls);
            else ChangeThemeOrig(tabControl1.Controls);
        }

        private void addGameToNotSteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new AddGame();
            openform(add);
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {
            con.Open();

            string password = null;
            string idquery = "select password from Users where id = '" + userid + "';";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            if (reader.Read())
                password = reader.GetString(0);
            if (password == tbCurrentPassword.Text)
            {
                if (tbNewPassword.Text.Length > 0)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Users SET password = '" + tbNewPassword.Text + "' WHERE Id = '" + userid + "'";
                    cmd.ExecuteNonQuery();

                }
                else
                    MessageBox.Show("Enter a new password", "Missing password", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Wrong password", "Wrong password", MessageBoxButtons.OK);
            con.Close();
        }

        private void btChangeEmail_Click(object sender, EventArgs e)
        {
            con.Open();

            string password = null;
            string idquery = "select password from Users where id = '" + userid + "';";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            if (reader.Read())
                password = reader.GetString(0);
            if (password == tbCurrentPassword.Text)
            {
                if (tbNewEmail.Text.Length > 0)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Users SET email = '" + tbNewEmail.Text + "' WHERE Id = '" + userid + "'";
                    cmd.ExecuteNonQuery();

                }
                else
                    MessageBox.Show("Enter a new email", "Missing email", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Wrong password", "Wrong password", MessageBoxButtons.OK);
            con.Close();
        }

        private Form activeform = null;

        private void openform(Form form)
        {
            if (activeform != null)
                activeform.Close();
            if (AddFunds.completed)
            {
                Controls.Clear();
                InitializeComponent();
                AddFunds.completed = false;

                if (loggeduser.admin != 1)
                    addGameToNotSteamToolStripMenuItem.Visible = false;

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage6);
                tabControl1.TabPages.Remove(tabPage7);
                tabControl1.TabPages.Remove(tabPage8);
                toolStripmoney.Text = loggeduser.money.ToString();
                toolStripProfile.Text = loggeduser.username.ToString();

                label6.Text = loggeduser.username;
                lbUsername.Text = loggeduser.username + "'s games";
                label16.Text = loggeduser.username;
                label17.Text = money.ToString();

                ///Initialize();

                label19.Click += new EventHandler(label19_Click);


                con.Open();

                removed = true;

                string cmmoney = "select money from Users where id = " + loggeduser.id + "";
                SqlCommand cmdmoney = new SqlCommand(cmmoney, con);
                toolStripmoney.Text = cmdmoney.ExecuteScalar().ToString();


                string desc = "select description from Users where id = " + loggeduser.id + "";
                SqlCommand cmddesc = new SqlCommand(desc, con);
                tbDesc.Text = cmddesc.ExecuteScalar().ToString();
                if (tbDesc.Text.Length == 0)
                    tbDesc.Text = "Add a description";
                tbChangeDesc.Text = cmddesc.ExecuteScalar().ToString();


                con.Close();
            }
            activeform = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser);
            openform(mainform);
            if (AddFunds.completed)
            {
                Controls.Clear();
                InitializeComponent();
                AddFunds.completed = false;
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            Form profileform = new Profile(loggeduser);
            openform(profileform);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Form libraryform = new Library(loggeduser);
            openform(libraryform);

        }
        static user loggeduser = new user();

        private void toolStripmoney_Click(object sender, EventArgs e)
        {
            Form addfundform = new AddFunds(loggeduser);
            openform(addfundform);
        }
    }
    class ListViewItemComparerUp : IComparer
    {
        private int col;
        public ListViewItemComparerUp(int column)

        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            
                if (col == 2)
                {
                    return DateTime.Compare(Convert.ToDateTime(((ListViewItem)x).SubItems[col].Text), Convert.ToDateTime(((ListViewItem)y).SubItems[col].Text));
                }
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
  
        }
    }
    class ListViewItemComparerDown : IComparer
    {
        private int col;
        public ListViewItemComparerDown(int column)

        {
            col = column;
        }
        public int Compare(object x, object y)
        {

            if (col == 2)
            {
                return DateTime.Compare(Convert.ToDateTime(((ListViewItem)y).SubItems[col].Text), Convert.ToDateTime(((ListViewItem)x).SubItems[col].Text));
            }
            return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);

        }
    }
}
