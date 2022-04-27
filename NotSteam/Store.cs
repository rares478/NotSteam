using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace NotSteam
{
    public partial class Store : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        int money;
        int userid;
        string query = null;

        public Store(user user, string queryceva, string name)
        {

            InitializeComponent();
            userid = user.id;
            DoubleBuffered = true;
            money = user.money;
            query = queryceva;
            if (name != null)
                switchtogame(name);
            else
                initialize();
            CustomToolStripRenderer r = new CustomToolStripRenderer();
            r.RoundedEdges = true;
            menuStrip1.Renderer = r;
            panel2.Scroll += (s, e) =>
            {
                HandleScroll();
            };
            panel2.MouseWheel += (s, e) =>
            {
                HandleScroll();
            };

        }
        int count = 0;
        int z = 0;
        int cz = 0;
        private void initialize()
        {
            con.Open();
            SqlCommand cmdid = new SqlCommand(query, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            count = reader.FieldCount;

            while (reader.Read() && z <= cz+10)
            {
               
                string name = reader.GetString(0);
                Label lbl = new Label();
                Label lbl2 = new Label();
                PictureBox pictureBox = new PictureBox();
                RichTextBox richTextBox = new RichTextBox();

                lbl.ForeColor = SystemColors.ActiveCaption;
                lbl2.ForeColor = SystemColors.ActiveCaption;
                richTextBox.BackColor = Color.FromArgb(16, 25, 35);
                richTextBox.ForeColor = SystemColors.ActiveCaption;
                richTextBox.BorderStyle = BorderStyle.None;

                panel2.Controls.Add(lbl);
                panel2.Controls.Add(lbl2);
                panel2.Controls.Add(pictureBox);
                panel2.Controls.Add(richTextBox);

                lbl.Location = new Point(303, 360 + (z * 260));
                lbl2.Location = new Point(303, 400 + (z * 260));
                richTextBox.Location = new Point(308, 175 + ((z + 1) * 260));
                pictureBox.Location = new Point(6, 360 + (z * 260));
                pictureBox.Size = new Size(256, 199);
                richTextBox.Size = new Size(397, 126);

                lbl.Click += new EventHandler(lbl_click);
                lbl.AutoSize = true;
                lbl2.AutoSize = true;
                lbl2.Text = developer(name);
                lbl.Font = new Font("Microsoft Sans Serif", 16);
                richTextBox.Text = description(name);

                z++;
                lbl.Text = name;

                foreach (string img in imageList1.Images.Keys)
                {
                    if (img == name)
                        pictureBox.Image = imageList1.Images[imageList1.Images.IndexOfKey(img)];
                    if (pictureBox.Image == null)
                    {
                        pictureBox.Image = imageList1.Images[0];
                    }
                }

            }
            con.Close();
        }

        private void switchtogame(string name)
        {
            Controls.Clear();

            Label lbNameGame = new Label();
            Controls.Add(lbNameGame);
            lbNameGame.Location = new Point(15, 90);
            lbNameGame.AutoSize = true;
            lbNameGame.Font = new Font("Microsoft Sans Serif", 15);

            PictureBox pbGame = new PictureBox();
            Controls.Add(pbGame);
            pbGame.Location = new Point(12, 120);
            pbGame.Name = "pbGame";
            pbGame.Size = new Size(256, 199);
            pbGame.TabIndex = 1;
            pbGame.TabStop = false;

            Button btBuyGame = new Button();
            btBuyGame.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            btBuyGame.Location = new Point(512, 49);
            btBuyGame.FlatStyle = FlatStyle.Flat;
            btBuyGame.ForeColor = SystemColors.ActiveCaption;
            btBuyGame.BackColor = SystemColors.ControlText;
            btBuyGame.Name = "btBuyGame";
            btBuyGame.Size = new Size(75, 23);
            btBuyGame.TabIndex = 16;
            btBuyGame.Text = "button1";
            btBuyGame.UseVisualStyleBackColor = true;
            btBuyGame.Click += new EventHandler(btBuy_Click);

            RichTextBox tbGame = new RichTextBox();
            Controls.Add(tbGame);
            tbGame.BackColor = SystemColors.GradientActiveCaption;
            tbGame.ForeColor = SystemColors.ActiveCaptionText;
            tbGame.Location = new Point(317, 120);
            tbGame.Name = "tbGame";
            tbGame.ReadOnly = true;
            tbGame.Size = new Size(397, 126);
            tbGame.TabIndex = 11;
            tbGame.Text = "";

            Label lbDevGame = new Label();
            Controls.Add(lbDevGame);
            lbDevGame.AutoSize = true;
            lbDevGame.Location = new Point(314, 258);
            lbDevGame.Name = "lbDevGame";
            lbDevGame.Size = new Size(41, 13);
            lbDevGame.TabIndex = 12;
            lbDevGame.Text = "label17";

            Label lbRelease = new Label();
            Controls.Add(lbRelease);
            lbRelease.AutoSize = true;
            lbRelease.Location = new Point(314, 286);
            lbRelease.Name = "lbRelease";
            lbRelease.Size = new Size(41, 13);
            lbRelease.TabIndex = 17;
            lbRelease.Text = "label19";

            Label lbGameNameBuy = new Label();
            lbGameNameBuy.AutoSize = true;
            lbGameNameBuy.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbGameNameBuy.Location = new Point(3, 0);
            lbGameNameBuy.Name = "lbGameNameBuy";
            lbGameNameBuy.Size = new Size(70, 24);
            lbGameNameBuy.TabIndex = 15;
            lbGameNameBuy.Text = "label18";

            Label lbMissingGame = new Label();
            Controls.Add(lbMissingGame);
            lbMissingGame.AutoSize = true;
            lbMissingGame.Location = new Point(76, 322);
            lbMissingGame.Name = "lbMissingGame";
            lbMissingGame.Size = new Size(74, 13);
            lbMissingGame.TabIndex = 19;
            lbMissingGame.Text = "Missing Image";
            lbMissingGame.Visible = false;



            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            Controls.Add(tableLayoutPanel1);
            tableLayoutPanel1.BackColor = Color.DeepSkyBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbGameNameBuy, 0, 0);
            tableLayoutPanel1.Controls.Add(btBuyGame, 1, 1);
            tableLayoutPanel1.Location = new Point(95, 363);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.97675F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.02325F));
            tableLayoutPanel1.Size = new Size(590, 75);
            tableLayoutPanel1.TabIndex = 18;

            lbNameGame.Text = name;
            con.Open();


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
            foreach (string img in imageList1.Images.Keys)
            {
                if (img == name)
                {
                    pbGame.Image = imageList1.Images[imageList1.Images.IndexOfKey(img)];
                    break;
                }
                if (pbGame.Image == null)
                {
                    pbGame.Image = imageList1.Images[0];
                }
            }
            lbGameNameBuy.Text = "Buy " + lbNameGame.Text;
            con.Close();
        }



        private void lbl_click(object sender, EventArgs e)
        {
            /*if (theme)
                ChangeTheme(tabControl1.Controls);
            else ChangeThemeOrig(tabControl1.Controls);*/

            Label label = sender as Label;
            selected = label.Text;
            switchtogame(label.Text);
        }

        public string selected = null;

        private void btBuy_Click(object sender, EventArgs e)
        {

            Button btnBuy = sender as Button;

            con.Open();

            string id;
            string idquery = "select Games.Id from Games where Games.name = '" + selected + "';";
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
                    if (money > Convert.ToInt32(btnBuy.Text))
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        DateTime dateTime = DateTime.Now;
                        var dateValue1 = dateTime.ToString("MM/dd/yyyy");
                        cmd.CommandText = "INSERT INTO dbo.[List of owned games](GameID,name,UserId,date_bought) VALUES ('" + id + "', '" + selected + "', '" + userid + "', '" + dateValue1 + "')";
                        cmd.ExecuteNonQuery();
                        int money1 = money;
                        int money2 = Convert.ToInt32(btnBuy.Text);
                        int moneyfinal = money1 - money2;
                        SqlCommand cmdmoney = con.CreateCommand();
                        cmdmoney.CommandType = CommandType.Text;
                        cmdmoney.CommandText = "UPDATE Users SET money = '" + moneyfinal + "' WHERE Id = '" + userid + "'";
                        cmdmoney.ExecuteNonQuery();
                        money = moneyfinal;
                    }
                    else
                    {
                        MessageBox.Show("You do not have enough money to buy this game", "Insufficient funds", MessageBoxButtons.OK);
                    }
                }
            }
            else MessageBox.Show("You already own the game", "You cannot buy the game", MessageBoxButtons.OK);
            con.Close();
        }

        private string description(string name)
        {
            string nimic = "";
            string devquery = "select description from Games where name = '" + name + "'";
            SqlCommand cmddev = new SqlCommand(devquery, con);
            SqlDataReader readerdev = cmddev.ExecuteReader();
            if (readerdev.Read())
            {
                return readerdev.GetString(0);
            }
            else return nimic;
        }

        private string developer(string name)
        {
            string devquery = "select developer from Games where name = '" + name + "'";
            SqlCommand cmddev = new SqlCommand(devquery, con);
            SqlDataReader readerdev = cmddev.ExecuteReader();
            if (readerdev.Read())
            {
                return readerdev.GetString(0);
            }
            else return null;
        }

        private void preferanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string name = toolStripTextBox1.Text;
                if (name.Contains("'"))
                {
                    name = name.Replace("'", "");
                }
                string queryceva = "select name from Games";
                SqlCommand cmd = new SqlCommand(queryceva, con);
                con.Open();
                bool nope = true;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (name == reader.GetString(0))
                    {
                        switchtogame(name);
                        break;
                        nope = false;
                    }
                }
                con.Close();
                if (nope)
                {
                    query = "select name from Games where name like '" + name + "%'";
                    Controls.Clear();
                    InitializeComponent();
                    initialize();
                    WindowState = FormWindowState.Maximized;
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
        }

        int ceva = 0;
        private void HandleScroll()
        {
            if (panel2.VerticalScroll.Value > 2000 && ceva ==0)
            {
                cz = cz + z;
                if (NotSteamForm.freetoplay)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Free to Play] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.early)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Early Access] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.actionb)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Action] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.adventure)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Adventure] = '1' Games.AND Id >'" + cz + "'";
                else if (NotSteamForm.casual)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Casual] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.indie)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Indie] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.multiplayer)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Massively Multiplayer] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.racing)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Racing] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.rpg)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [RPG] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.simulation)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Simulation] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.sports)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Sports] = '1' AND Games.Id >'" + cz + "'";
                else query = "select name from Games where Id >'" + cz + "'";

                z = 3;
                initialize();
                ceva++;
            }
            if(panel2.VerticalScroll.Value > 7000 && ceva == 1)
            {
                cz = cz + z+1;
                if (NotSteamForm.freetoplay)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Free to Play] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.early)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Early Access] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.actionb)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Action] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.adventure)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Adventure] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.casual)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Casual] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.indie)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Indie] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.multiplayer)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Massively Multiplayer] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.racing)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Racing] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.rpg)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [RPG] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.simulation)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Simulation] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.sports)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Sports] = '1' AND Games.Id >'" + cz + "'";
                else query = "select name from Games where Id >'" + cz + "'";
                z = 3;
                initialize();
                ceva++;
            }
            if(panel2.VerticalScroll.Value > 12000 && ceva == 2)
            {
                cz = cz + z+2;
                if (NotSteamForm.freetoplay)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Free to Play] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.early)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Early Access] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.actionb)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Action] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.adventure)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Adventure] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.casual)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Casual] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.indie)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Indie] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.multiplayer)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Massively Multiplayer] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.racing)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Racing] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.rpg)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [RPG] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.simulation)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Simulation] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.sports)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Sports] = '1' AND Games.Id >'" + cz + "'";
                else query = "select name from Games where Id >'" + cz + "'";
                z = 3;
                initialize();
                ceva++;
            }
            if(cz< count && ceva == 3)
            {
                cz = count - cz;
                if (NotSteamForm.freetoplay)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Free to Play] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.early)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Early Access] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.actionb)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Action] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.adventure)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Adventure] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.casual)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Casual] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.indie)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Indie] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.multiplayer)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Massively Multiplayer] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.racing)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Racing] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.rpg)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [RPG] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.simulation)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Simulation] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.sports)
                    query = "select name from Games inner join Genres on Genres.Id = Games.Id WHERE [Sports] = '1' AND Games.Id >'" + cz + "'";
                else query = "select name from Games where Id >'" + cz + "'";
                z = 3;
                initialize();
                ceva++;
            }

        }
    }
}
