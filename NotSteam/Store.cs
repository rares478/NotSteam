using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

            var rnd = new Random();
            for (int i = 1; i <= 12; i++)
            {
                int ceva = rnd.Next(56);
                if (ceva == 13 || ceva == 15 || ceva == 19 || ceva == 23 || ceva == 34 || ceva == 0)
                    ceva++;
                while (a.Contains(ceva))
                {
                    ceva = rnd.Next(56);
                    if (ceva == 13 || ceva == 15 || ceva == 19 || ceva == 23 || ceva == 34 || ceva == 0)
                        ceva++;

                }

                a[i] = ceva;
            }

            for (int i = 1; i <= 10; i++)
            {
                int ceva = rnd.Next(56);
                if (ceva == 13 || ceva == 15 || ceva == 19 || ceva == 23 || ceva == 34 || ceva == 0)
                    ceva++;
                while (queue.Contains(ceva))
                {
                    ceva = rnd.Next(56);
                    if (ceva == 13 || ceva == 15 || ceva == 19 || ceva == 23 || ceva == 34 || ceva == 0)
                        ceva++;

                }
                queue[i] = ceva;
            }

            con.Open();
            string queryqueue = "SELECT name from Games where Id in (" + queue[1] + ", " + queue[2] + ", " + queue[3] + ", " + queue[4] + ", " + queue[5] + ", " + queue[6] + ", " + queue[7] + ", " + queue[8] + ", " + queue[9] + ", " + queue[10] + ")";
            SqlCommand cmdqueue = new SqlCommand(queryqueue, con);
            SqlDataReader readercevaqueue = cmdqueue.ExecuteReader();
            int iii = 1;
            while (readercevaqueue.Read())
            {
                queuepic[iii] = readercevaqueue.GetString(0);
                iii++;
            }
            con.Close();

            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));

            con.Open();
            string queryget = "SELECT name,price from Games where Id in (" + a[1] + ", " + a[2] + ", " + a[3] + ", " + a[4] + ", " + a[5] + "," + a[6] + ", " + a[7] + ", " + a[8] + ", " + a[9] + ", " + a[10] + ", " + a[11] + ", " + a[12] + ")";
            SqlCommand cmd = new SqlCommand(queryget, con);
            SqlDataReader readerceva = cmd.ExecuteReader();
            int ii = 1;
            while (readerceva.Read())
            {
                b[ii] = readerceva.GetString(0);
                c[ii] = readerceva.GetInt32(1);
                ii++;
            }
            con.Close();


            if (name != null)
                switchtogame(name, false);
            else
            {
                initialize();
            }
            CustomToolStripRenderer r = new CustomToolStripRenderer();
            r.RoundedEdges = true;
            menuStrip1.Renderer = r;
            panel3.Scroll += (s, e) =>
            {
                HandleScroll();
            };
            panel3.MouseWheel += (s, e) =>
            {
                HandleScroll();
            };
        }

        int[] a = new int[13];
        string[] b = new string[13];
        int[] c = new int[13];
        int[] queue = new int[11];
        string[] queuepic = new string[11];
        int queuelcoation = 0;


        int count = 0;
        int z = 0;
        int cz = 0;

        private void changefeature(int i)
        {
            lbGameName.Text = b[i];
            lbGamePrice.Text = c[i].ToString();
            pbMain.Load(Properties.Store.ResourceManager.GetString(b[i] + " capsule616x353"));
            pbSS1.Load(Properties.Store.ResourceManager.GetString(b[i] + " ss1"));
            pbSS2.Load(Properties.Store.ResourceManager.GetString(b[i] + " ss2"));
            pbSS3.Load(Properties.Store.ResourceManager.GetString(b[i] + " ss3"));
            pbSS4.Load(Properties.Store.ResourceManager.GetString(b[i] + " ss4"));
        }

        private void initialize()
        {

            changefeature(1);

            con.Open();
            SqlCommand cmdid = new SqlCommand(query, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            count = reader.FieldCount;


            while (reader.Read() && z <= cz + 10)
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

                panel3.Controls.Add(lbl);
                panel3.Controls.Add(lbl2);
                panel3.Controls.Add(pictureBox);
                panel3.Controls.Add(richTextBox);

                ///adaug 700px

                lbl.Location = new Point(303, 1260 + (z * 260));
                lbl2.Location = new Point(303, 1300 + (z * 260));
                richTextBox.Location = new Point(308, 1075 + ((z + 1) * 260));
                pictureBox.Location = new Point(6, 1260 + (z * 260));

                pictureBox.Size = new Size(231, 87);
                richTextBox.Size = new Size(397, 126);

                lbl.Click += new EventHandler(lbl_click);
                lbl.AutoSize = true;
                lbl2.AutoSize = true;
                lbl2.Text = developer(name);
                lbl.Font = new Font("Microsoft Sans Serif", 16);
                richTextBox.Text = description(name);

                z++;
                lbl.Text = name;


                if (name.Contains(" "))
                    name.Replace(" ", "_");
                object obj = Properties.Store.ResourceManager.GetObject(name);

                pictureBox.Image = (Bitmap)obj;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            con.Close();
        }

        private void switchimagesgame(object sender,EventArgs e, PictureBox pbMain)
        {
            PictureBox nus = sender as PictureBox;
            pbMain.Image = nus.Image;
        }

        private void switchtogame(string name, bool queue)
        {
            timer1.Stop();
            Controls.Clear();

            if (queue)
            {
                PictureBox pbqueue = new PictureBox();
                pbqueue.Location = new Point(900, 500);
                Controls.Add(pbqueue);
                pbqueue.Click += new EventHandler(queueclick);
                pbqueue.Image = imageList1.Images[0];
                pbqueue.Size = new Size(147, 47);
            }

            PictureBox pbMainBig = new PictureBox();
            pbMainBig.Location = new Point(111, 106);
            pbMainBig.Size = new Size(598, 336);

            Label lbGameNameSolo = new Label();
            lbGameNameSolo.Text = name;
            lbGameNameSolo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbGameNameSolo.ForeColor = SystemColors.ButtonFace;
            lbGameNameSolo.Location = new Point(106, 74);
            lbGameNameSolo.AutoSize = true;

            PictureBox pbHeader = new PictureBox();
            pbHeader.Location = new Point(729, 106);
            pbHeader.Size = new Size(321, 151);

            RichTextBox tbDescription = new RichTextBox();
            tbDescription.Location = new Point(729, 264);
            tbDescription.Size = new Size(321, 97);
            tbDescription.ForeColor = SystemColors.ButtonFace;
            tbDescription.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.ReadOnly = true;

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            label1.Location = new Point(729, 360);
            label1.Size = new Size(75, 13);
            label1.TabIndex = 4;
            label1.Text = "Release Date:";

            Label label2 = new Label();
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            label2.Location = new Point(729, 386);
            label2.Size = new Size(62, 13);
            label2.TabIndex = 5;
            label2.Text = "Developer: ";

            Label lbDate = new Label();
            lbDate.AutoSize = true;
            lbDate.ForeColor = Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(160)))));
            lbDate.Location = new Point(823, 360);
            lbDate.Size = new Size(35, 13);
            lbDate.TabIndex = 6;
            lbDate.Text = "label3";

            Label lbDeveloper = new Label();
            lbDeveloper.AutoSize = true;
            lbDeveloper.ForeColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(162)))), ((int)(((byte)(206)))));
            lbDeveloper.Location = new Point(826, 386);
            lbDeveloper.Size = new Size(35, 13);
            lbDeveloper.TabIndex = 7;
            lbDeveloper.Text = "label3";
            
            Label lbGameNameBuy = new Label();
            lbGameNameBuy.AutoSize = true;
            lbGameNameBuy.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbGameNameBuy.ForeColor = SystemColors.ButtonFace;
            lbGameNameBuy.Location = new Point(18, 21);
            lbGameNameBuy.Size = new Size(70, 25);
            lbGameNameBuy.TabIndex = 0;

            Panel panel5 = new Panel();
            panel5.Controls.Add(lbGameNameBuy);
            panel5.Location = new Point(111, 558);
            panel5.Size = new Size(598, 68);
            panel5.BackColor = Color.FromArgb(66, 81, 95);
            panel5.TabIndex = 8;

            Button btBuy = new Button();
            btBuy.BackColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(166)))), ((int)(((byte)(33)))));
            btBuy.FlatAppearance.BorderSize = 0;
            btBuy.FlatStyle = FlatStyle.Flat;
            btBuy.ForeColor = SystemColors.ButtonFace;
            btBuy.Location = new Point(83, 3);
            btBuy.Size = new Size(102, 35);
            btBuy.TabIndex = 0;
            btBuy.Text = "Buy";
            btBuy.UseVisualStyleBackColor = false;

            Label lbPrice = new Label();
            lbPrice.AutoSize = true;
            lbPrice.ForeColor = SystemColors.ButtonFace;
            lbPrice.Location = new Point(14, 14);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(35, 13);
            lbPrice.TabIndex = 1;

            Panel panelbuy = new Panel();
            panelbuy.BackColor = Color.Black;
            panelbuy.Controls.Add(lbPrice);
            panelbuy.Controls.Add(btBuy);
            panelbuy.Location = new Point(502, 608);
            panelbuy.Size = new Size(188, 41);
            panelbuy.TabIndex = 9;

            PictureBox pbPic1 = new PictureBox();
            pbPic1.Location = new Point(125, 448);
            pbPic1.Size = new Size(109, 58);
            pbPic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPic1.TabIndex = 10;
            pbPic1.TabStop = false;
            pbPic1.Click += new EventHandler((sender,e) => switchimagesgame(sender,e, pbMainBig));

            PictureBox pbPic2 = new PictureBox();
            pbPic2.Location = new Point(240, 448);
            pbPic2.Size = new Size(109, 58);
            pbPic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPic2.TabIndex = 11;
            pbPic2.TabStop = false;
            pbPic2.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));

            PictureBox pbPic3 = new PictureBox();
            pbPic3.Location = new Point(355, 448);
            pbPic3.Size = new Size(109, 58);
            pbPic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPic3.TabIndex = 12;
            pbPic3.TabStop = false;
            pbPic3.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));

            PictureBox pbPic4 = new PictureBox();
            pbPic4.Location = new Point(470, 448);
            pbPic4.Size = new Size(109, 58);
            pbPic4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPic4.TabIndex = 13;
            pbPic4.TabStop = false;
            pbPic4.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));

            PictureBox pbPic5 = new PictureBox();
            pbPic5.Location = new Point(585, 448);
            pbPic5.Size = new Size(109, 58);
            pbPic5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPic5.TabIndex = 14;
            pbPic5.TabStop = false;
            pbPic5.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));

            Controls.Add(panelbuy);
            Controls.Add(panel5);
            Controls.Add(lbDeveloper);
            Controls.Add(lbDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbDescription);
            Controls.Add(pbHeader);
            Controls.Add(lbGameNameSolo);
            Controls.Add(pbMainBig);
            Controls.Add(pbPic1);
            Controls.Add(pbPic2);
            Controls.Add(pbPic3);
            Controls.Add(pbPic4);
            Controls.Add(pbPic5);

            con.Open();

            string que = "SELECT developer,date,description,price FROM Games WHERE name = '" + name + "'";
            SqlCommand cmd = new SqlCommand(que, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                lbDeveloper.Text = reader.GetString(0);
                lbDate.Text = reader.GetDateTime(1).ToString("MM/dd/yyyy");
                tbDescription.Text = reader.GetString(2);
                lbPrice.Text = reader.GetInt32(3).ToString(); ;
                if (lbPrice.Text == "0")
                    lbPrice.Text = "FREE";
            }
            con.Close();

            lbGameNameBuy.Text = name;

            pbPic1.Load(Properties.Store.ResourceManager.GetString(name + " ss1"));
            pbPic2.Load(Properties.Store.ResourceManager.GetString(name + " ss2"));
            pbPic3.Load(Properties.Store.ResourceManager.GetString(name + " ss3"));
            pbPic4.Load(Properties.Store.ResourceManager.GetString(name + " ss4"));
            pbPic5.Load(Properties.Store.ResourceManager.GetString(name + " ss5"));
            pbMainBig.Load(Properties.Store.ResourceManager.GetString(name + " ss1"));
            pbMainBig.SizeMode = PictureBoxSizeMode.StretchImage;

            object obj = Properties.Store.ResourceManager.GetObject(name);
            pbHeader.Image = (Bitmap)obj;
            pbHeader.SizeMode = PictureBoxSizeMode.StretchImage;



        }



        #region swap pics

        private void swappics(object pb2, EventArgs e)
        {
            PictureBox image = pb2 as PictureBox;
            tmpimg = pbMain.Image;
            timer1.Stop();
            pbMain.Image = image.Image;
        }
        Image tmpimg = null;

        private void swapback(object pb2, EventArgs e)
        {
            pbMain.Image = tmpimg;
            timer1.Start();
        }

        #endregion

        #region game functions
        private void lbl_click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            selected = label.Text;
            switchtogame(label.Text, false);
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
                        int owners = 0;


                        string cmdownerss = "SELECT dbo.[Games].[number bought] from Games WHERE Id = '" + id + "'";
                        SqlCommand cmdownersget = new SqlCommand(cmdownerss, con);
                        SqlDataReader readerowners = cmdownersget.ExecuteReader();
                        try
                        {
                            owners = readerowners.GetInt32(0);
                            owners = owners + 1;
                        }
                        catch (Exception ex)
                        {
                            owners = 1;
                        }

                        SqlCommand cmdowners = con.CreateCommand();
                        cmdowners.CommandType = CommandType.Text;
                        cmdowners.CommandText = "UPDATE Games Set [number bought] = '" + owners + "'";

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

        private void queueclick(object sender, EventArgs e)
        {
            if (queuelcoation == 10)
            {
                Controls.Clear();
                InitializeComponent();
                initialize();
                WindowState = FormWindowState.Maximized;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                queuelcoation++;
                switchtogame(queuepic[queuelcoation], true);
            }
        }
        #endregion

        #region dev + desc
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

        #endregion

        #region searchbox
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
                        con.Close();
                        switchtogame(name, false);
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
        #endregion

        int ceva = 0;
        private void HandleScroll()

        {
            if (panel3.VerticalScroll.Value > 2000 && ceva == 0)
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
            if (panel3.VerticalScroll.Value > 7000 && ceva == 1)
            {
                cz = cz + z + 1;
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
            if (panel3.VerticalScroll.Value > 12000 && ceva == 2)
            {
                cz = cz + z + 2;
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
            if (cz < count && ceva == 3)
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

        private void pbMain_Click(object sender, EventArgs e)
        {
            switchtogame(lbGameName.Text, false);
        }

        int tick = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick == 12)
                tick = 1;
            changefeature(tick);
            tick++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tick == 12)
                tick = 0;
            tick = tick + 1;
            changefeature(tick);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tick == 1)
                tick = 13;
            tick = tick - 1;
            changefeature(tick);
        }

        private void customPanelRenderer1_Paint(object sender, PaintEventArgs e)
        {
            if (tick == 12)
                tick = 0;
            tick = tick + 1;
            changefeature(tick);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            queueclick(sender, e);
        }
    }
}
