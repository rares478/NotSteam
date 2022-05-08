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
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public static int money;
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


            initialize();

            CustomToolStripRenderer r = new CustomToolStripRenderer
            {
                RoundedEdges = true
            };
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
        public static int[] queue = new int[11];
        public static string[] queuepic = new string[11];
        public static int queuelcoation = 0;


        int z = 0;
        int cz = 0;



        private void initialize()
        {

            changefeature(1);

            con.Open();
            SqlCommand cmdid = new SqlCommand(query, con);
            SqlDataReader reader = cmdid.ExecuteReader();


            while (reader.Read() && z <= cz + 10)
            {

                string name = reader.GetString(0);

                Label lbName = new Label();
                lbName.AutoSize = true;
                lbName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lbName.Location = new Point(12, 10);
                lbName.Size = new Size(70, 25);
                lbName.TabIndex = 0;

                PictureBox pb1 = new PictureBox();
                pb1.Location = new Point(13, 67);
                pb1.Size = new Size(280, 141);
                pb1.TabIndex = 1;
                pb1.TabStop = false;
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;

                PictureBox pb2 = new PictureBox();
                pb2.Location = new Point(287, 79);
                pb2.Size = new Size(212, 119);
                pb2.TabIndex = 2;
                pb2.TabStop = false;
                pb2.SizeMode = PictureBoxSizeMode.StretchImage;

                PictureBox pb3 = new PictureBox();
                pb3.Location = new Point(495, 79);
                pb3.Size = new Size(212, 119);
                pb3.TabIndex = 3;
                pb3.TabStop = false;
                pb3.SizeMode = PictureBoxSizeMode.StretchImage;

                PictureBox pb4 = new PictureBox();
                pb4.Location = new Point(704, 79);
                pb4.Size = new Size(212, 119);
                pb4.TabIndex = 4;
                pb4.TabStop = false;
                pb4.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lbPrice = new Label();
                lbPrice.AutoSize = true;
                lbPrice.ForeColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(162)))), ((int)(((byte)(206)))));
                lbPrice.Location = new Point(13, 215);
                lbPrice.Size = new Size(35, 13);
                lbPrice.TabIndex = 5;
                lbPrice.Text = "label2";


                Button btSwitch = new Button();
                btSwitch.BackColor = Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
                btSwitch.FlatAppearance.BorderSize = 0;
                btSwitch.FlatStyle = FlatStyle.Flat;
                btSwitch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btSwitch.ForeColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(162)))), ((int)(((byte)(206)))));
                btSwitch.Location = new Point(6, 6);
                btSwitch.Size = new Size(122, 23);
                btSwitch.TabIndex = 0;
                btSwitch.Text = "Visit Product Page";
                btSwitch.UseVisualStyleBackColor = false;


                Panel panel2 = new Panel();
                panel2.Controls.Add(btSwitch);
                panel2.Dock = DockStyle.Bottom;
                panel2.Location = new Point(0, 244);
                panel2.Name = "panel2";
                panel2.Size = new Size(933, 38);
                panel2.TabIndex = 6;
                panel2.BackColor = Color.FromArgb(22, 32, 45);


                Panel panel = new Panel();
                panel.BackColor = Color.FromArgb(22, 32, 45);
                panel.Controls.Add(panel2);
                panel.Controls.Add(lbPrice);
                panel.Controls.Add(pb4);
                panel.Controls.Add(pb3);
                panel.Controls.Add(pb1);
                panel.Controls.Add(pb2);
                panel.Controls.Add(lbName);
                panel.Location = new Point(88, 1260 + (z * 300));
                panel.Size = new Size(933, 282);
                panel.TabIndex = 0;

                panel3.Controls.Add(panel);


                lbName.Text = name;
                lbPrice.Text = reader.GetInt32(1).ToString() + "$";
                if (lbPrice.Text == "0$")
                    lbPrice.Text = "Free";
                int newHeight = 212;
                int newWidth = 119;


                ///bitmap1.Dispose(); throws error in Program.cs ??????  invalid parameter ????
                pb1.Load(Properties.Store.ResourceManager.GetString(name + " ss1"));

                Bitmap original1 = new Bitmap(pb1.Image);
                Bitmap bitmap1 = new Bitmap(original1, 424, 238);
                Graphics g1 = Graphics.FromImage(bitmap1);
                pb1.Image = bitmap1;
                g1.Dispose();
                original1.Dispose();


                pb2.Load(Properties.Store.ResourceManager.GetString(name + " ss2"));

                Bitmap original2 = new Bitmap(pb2.Image);
                Bitmap bitmap2 = new Bitmap(original2, newWidth, newHeight);
                Graphics g2 = Graphics.FromImage(bitmap2);
                pb2.Image = bitmap2;
                g2.Dispose();
                original2.Dispose();


                pb3.Load(Properties.Store.ResourceManager.GetString(name + " ss3"));

                Bitmap original3 = new Bitmap(pb3.Image);
                Bitmap bitmap3 = new Bitmap(original3, newWidth, newHeight);
                Graphics g3 = Graphics.FromImage(bitmap3);
                pb3.Image = bitmap3;
                g3.Dispose();
                original3.Dispose();


                pb4.Load(Properties.Store.ResourceManager.GetString(name + " ss4"));

                Bitmap original4 = new Bitmap(pb4.Image);
                Bitmap bitmap4 = new Bitmap(original4, newWidth, newHeight);
                Graphics g4 = Graphics.FromImage(bitmap4);
                pb4.Image = bitmap4;
                g4.Dispose();
                original4.Dispose();


                lbName.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, e));

                pb1.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, e));
                pb2.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, e));
                pb3.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, e));
                pb4.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, e));

                pb2.MouseEnter += new EventHandler((sender, e) => onhoverimage(sender, e, lbName.Text, Properties.Store.ResourceManager.GetString(name + " ss2")));
                pb2.MouseLeave += new EventHandler((sender, e) => onexitimage(sender, e, Properties.Store.ResourceManager.GetString(name + " ss2"), pb1));

                pb3.MouseEnter += new EventHandler((sender, e) => onhoverimage(sender, e, lbName.Text, Properties.Store.ResourceManager.GetString(name + " ss3")));
                pb3.MouseLeave += new EventHandler((sender, e) => onexitimage(sender, e, Properties.Store.ResourceManager.GetString(name + " ss3"), pb1));

                pb4.MouseEnter += new EventHandler((sender, e) => onhoverimage(sender, e, lbName.Text, Properties.Store.ResourceManager.GetString(name + " ss4")));
                pb4.MouseLeave += new EventHandler((sender, e) => onexitimage(sender, e, Properties.Store.ResourceManager.GetString(name + " ss4"), pb1));

                z++;

            }
            con.Close();
        }

        private void switchtogame(string name, EventArgs e)
        {
            Switchtogame?.Invoke(name, e);
        }

        #region pic functions
        private void onexitimage(object sender, EventArgs e, string url, PictureBox pbmain)
        {
            PictureBox pb = sender as PictureBox;

            pb.Load(url);

            pb.Size = new Size(212, 119);
            pb.Location = new Point(pb.Location.X + 15, pb.Location.Y + 30);
            Bitmap original3 = new Bitmap(pb.Image);
            Bitmap bitmap3 = new Bitmap(original3, 212, 199);
            Graphics g3 = Graphics.FromImage(bitmap3);
            pb.Image = bitmap3;
            g3.Dispose();
            original3.Dispose();
            pbmain.BringToFront();
        }

        private void onhoverimage(object sender, EventArgs e, string name, string url)
        {
            PictureBox pb = sender as PictureBox;

            pb.Load(url);

            pb.Size = new Size(424, 238);
            pb.Location = new Point(pb.Location.X - 15, pb.Location.Y - 30);
            Bitmap original3 = new Bitmap(pb.Image);
            Bitmap bitmap3 = new Bitmap(original3, 424, 238);
            Graphics g3 = Graphics.FromImage(bitmap3);
            pb.Image = bitmap3;
            g3.Dispose();
            original3.Dispose();
            pb.BringToFront();

        }

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

        public static event EventHandler Switchtogame;


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
                        switchtogame(name, e);
                        break;
                        nope = false;
                    }
                }
                con.Close();
                if (nope)
                {
                    query = "select name from Games where name like '" + name + "%'";
                    Controls.Clear();
                    z = 0;
                    cz = 0;
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
            if (panel3.VerticalScroll.Value > 2400 && ceva == 0)
            {
                cz = cz + z;
                if (NotSteamForm.freetoplay)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Free to Play] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.early)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Early Access] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.actionb)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Action] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.adventure)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Adventure] = '1' Games.AND Id >'" + cz + "'";
                else if (NotSteamForm.casual)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Casual] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.indie)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Indie] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.multiplayer)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Massively Multiplayer] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.racing)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Racing] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.rpg)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [RPG] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.simulation)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Simulation] = '1' AND Games.Id >'" + cz + "'";
                else if (NotSteamForm.sports)
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Sports] = '1' AND Games.Id >'" + cz + "'";
                else query = "select name,price from Games where Id >'" + cz + "'";

                z = 3;
                initialize();
                ceva++;
            }

        }

        #region slide
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

        public static event EventHandler Switchtoqueue;

        private void queueclick(object sender, EventArgs e)
        {
            Switchtoqueue?.Invoke(sender, e);
        }
        private void pbMain_Click(object sender, EventArgs e)
        {
            switchtogame(lbGameName.Text, e);
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
        #endregion

        private void discoveryQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queueclick(sender, e);
        }
        #region menu strip
        private void newTrendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games where Games.date >= DATEADD(day, -31, getdate())";
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void topSellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games order by Games.[number bought] DESC";
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void freeToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Free to Play] = '1'";
            NotSteamForm.freetoplay = true;
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void earlyAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Early Access] = '1'";
            NotSteamForm.early = true;
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void adventureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Adventure] = '1'";
            NotSteamForm.adventure = true;
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void casualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Casual] = '1'";
            NotSteamForm.casual = true;
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void racingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Racing] = '1'";
            NotSteamForm.racing = true;
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void horrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Horror] = '1'";
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void openWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Open World] = '1'";
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void spaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Space] = '1'";
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void survivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Survival] = '1'";
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void mMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Massively Multiplayer] = '1'";
            NotSteamForm.multiplayer = true;
            Controls.Clear();
            z = 0;
            cz = 0;
            InitializeComponent();
            initialize();
            pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
            pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
            pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
            pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
        }

        private void recommendationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int id = rand.Next(1, 56);
            con.Open();
            string query = "select name from Games where Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = cmd.ExecuteScalar().ToString();
            con.Close();
            switchtogame(name, e);
        }

        #endregion
    }
}
