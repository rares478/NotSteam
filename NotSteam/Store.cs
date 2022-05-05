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


            if (name != null)
                switchtogame(name, false);
            else
            {
                initialize();
            }
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
        int[] queue = new int[11];
        string[] queuepic = new string[11];
        int queuelcoation = 0;


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


                lbName.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, false));

                pb1.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, false));
                pb2.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, false));
                pb3.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, false));
                pb4.Click += new EventHandler((sender, e) => switchtogame(lbName.Text, false));

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
            label2.Location = new Point(729, 380);
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
            lbDeveloper.Location = new Point(826, 380);
            lbDeveloper.Size = new Size(35, 13);
            lbDeveloper.TabIndex = 7;
            lbDeveloper.Text = "label3";


            Button category1 = new Button();
            category1.Location = new Point(729, 410);
            category1.Text = "label1";
            category1.BackColor = Color.FromArgb(33, 58, 77);
            category1.ForeColor = Color.FromArgb(87, 162, 206);
            category1.AutoSize = true;
            category1.FlatStyle = FlatStyle.Flat;
            category1.FlatAppearance.BorderSize = 0;
            category1.Click += new EventHandler(category);

            Button category2 = new Button();
            category2.Location = new Point(729 + category1.Width + 3, 410);
            category2.Text = "label2";
            category2.BackColor = Color.FromArgb(33, 58, 77);
            category2.ForeColor = Color.FromArgb(87, 162, 206);
            category2.AutoSize = true;
            category2.FlatStyle = FlatStyle.Flat;
            category2.FlatAppearance.BorderSize = 0;
            category2.Click += new EventHandler(category);

            Button category3 = new Button();
            category3.Location = new Point(729 + 2 * (category2.Width + 4), 410);
            category3.Text = "label3";
            category3.BackColor = Color.FromArgb(33, 58, 77);
            category3.ForeColor = Color.FromArgb(87, 162, 206);
            category3.AutoSize = true;
            category3.FlatStyle = FlatStyle.Flat;
            category3.FlatAppearance.BorderSize = 0;
            category3.Click += new EventHandler(category);

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

            Label lbPrice = new Label();
            lbPrice.AutoSize = true;
            lbPrice.ForeColor = SystemColors.ButtonFace;
            lbPrice.Location = new Point(14, 14);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(35, 13);
            lbPrice.TabIndex = 1;
            
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
            btBuy.Click += new EventHandler((sender,e)=> btBuy_Click(lbGameNameBuy.Text,Convert.ToInt32(lbPrice.Text)));

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
            pbPic1.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));

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
            Controls.Add(category1);
            Controls.Add(category2);
            Controls.Add(category3);

            con.Open();

            int id = 0;

            string que = "SELECT developer,date,description,price,id FROM Games WHERE name = '" + name + "'";
            SqlCommand cmd = new SqlCommand(que, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbDeveloper.Text = reader.GetString(0);
                lbDate.Text = reader.GetDateTime(1).ToString("MM/dd/yyyy");
                tbDescription.Text = reader.GetString(2);
                lbPrice.Text = reader.GetInt32(3).ToString() + "$";
                if (lbPrice.Text == "0$")
                {
                    lbPrice.Text = "FREE";
                    btBuy.Text = "Add to Library";
                }
                id = reader.GetInt32(4);
            }

            string querycategory = "SELECT [Free to Play],[Early Access],Action,Adventure,Casual,Indie,[Massively Multiplayer],Racing,RPG,Simulation,Sports,Strategy,Arcade,[Open World],Space,Horror,Survival from Genres where Id = '" + id + "'";
            SqlCommand cmdcategory = new SqlCommand(querycategory, con);
            SqlDataReader reader1 = cmdcategory.ExecuteReader();
            while (reader1.Read())
            {
                int count = 0;
                if (reader1.GetInt32(0) == 1)
                {
                    category1.Text = "Free to Play";
                    count++;
                }

                if (reader1.GetInt32(1) == 1)
                {
                    if (count == 1)
                    {
                        category2.Text = "Early Access";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Early Access";
                        count++;
                    }
                }

                if (reader1.GetInt32(2) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Action";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Action";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Action";
                        count++;
                    }
                }

                if (reader1.GetInt32(3) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Adventure";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Adventure";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Adventure";
                        count++;
                    }
                }

                if (reader1.GetInt32(4) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Casual";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Casual";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Casual";
                        count++;
                    }
                }

                if (reader1.GetInt32(5) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Indie";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Indie";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Indie";
                        count++;
                    }
                }

                if (reader1.GetInt32(6) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Massively Multiplayer";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Massively Multiplayer";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Massively Multiplayer";
                        count++;
                    }
                }

                if (reader1.GetInt32(7) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Racing";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Racing";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Racing";
                        count++;
                    }
                }

                if (reader1.GetInt32(8) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "RPG";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "RPG";
                        count++;
                    }
                    else
                    {
                        category1.Text = "RPG";
                        count++;
                    }
                }

                if (reader1.GetInt32(9) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Simulation";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Simulation";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Simulation";
                        count++;
                    }
                }

                if (reader1.GetInt32(10) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Sports";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Sports";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Sports";
                        count++;
                    }
                }

                if (reader1.GetInt32(11) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Strategy";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Strategy";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Strategy";
                        count++;
                    }
                }

                if (reader1.GetInt32(12) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Arcade";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Arcade";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Arcade";
                        count++;
                    }
                }

                if (reader1.GetInt32(13) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Open World";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Open World";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Open World";
                        count++;
                    }
                }

                if (reader1.GetInt32(14) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Space";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Space";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Space";
                        count++;
                    }
                }

                if (reader1.GetInt32(15) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Horror";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Horror";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Horror";
                        count++;
                    }
                }

                if (reader1.GetInt32(16) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Survival";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Survival";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Survival";
                        count++;
                    }
                }
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

        private void category(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "Free to Play":
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
                    break;
                case "Early Access":
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
                    break;
                case "Action":
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Action] = '1'";
                    NotSteamForm.actionb = true;
                    Controls.Clear();
                    z = 0;
                    cz = 0;
                    InitializeComponent();
                    initialize();
                    pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
                    pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
                    pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
                    pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
                    break;
                case "Adventure":
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
                    break;
                case "Casual":
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
                    break;
                case "Indie":
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Indie] = '1'";
                    NotSteamForm.indie = true;
                    Controls.Clear();
                    z = 0;
                    cz = 0;
                    InitializeComponent();
                    initialize();
                    pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
                    pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
                    pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
                    pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
                    break;
                case "Massively Multiplayer":
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
                    break;
                case "Racing":
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
                    break;
                case "RPG":
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [RPG] = '1'";
                    NotSteamForm.rpg = true;
                    Controls.Clear();
                    z = 0;
                    cz = 0;
                    InitializeComponent();
                    initialize();
                    pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
                    pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
                    pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
                    pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
                    break;
                case "Simulation":
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Simulation] = '1'";
                    NotSteamForm.simulation = true;
                    Controls.Clear();
                    z = 0;
                    cz = 0;
                    InitializeComponent();
                    initialize();
                    pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
                    pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
                    pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
                    pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
                    break;
                case "Sports":
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Sports] = '1'";
                    NotSteamForm.sports = true;
                    Controls.Clear();
                    z = 0;
                    cz = 0;
                    InitializeComponent();
                    initialize();
                    pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
                    pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
                    pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
                    pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
                    break;
                case "Strategy":
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Strategy] = '1'";
                    Controls.Clear();
                    z = 0;
                    cz = 0;
                    InitializeComponent();
                    initialize();
                    pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
                    pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
                    pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
                    pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
                    break;
                case "Arcade":
                    query = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Arcade] = '1'";
                    Controls.Clear();
                    z = 0;
                    cz = 0;
                    InitializeComponent();
                    initialize();
                    pbQueue1.Load(Properties.Store.ResourceManager.GetString(queuepic[1] + " capsule616x353"));
                    pbQueue2.Load(Properties.Store.ResourceManager.GetString(queuepic[2] + " capsule616x353"));
                    pbQueue3.Load(Properties.Store.ResourceManager.GetString(queuepic[3] + " capsule616x353"));
                    pbQueue4.Load(Properties.Store.ResourceManager.GetString(queuepic[4] + " capsule616x353"));
                    break;
                case "Open World":
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
                    break;
                case "Space":
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
                    break;
                case "Horror":
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
                    break;
                case "Survival":
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
                    break;
            }


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

        private void switchimagesgame(object sender, EventArgs e, PictureBox pbMain)
        {
            PictureBox nus = sender as PictureBox;
            pbMain.Image = nus.Image;
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

        #region game functions
        private void lbl_click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            switchtogame(label.Text, false);
        }

        private void btBuy_Click(string name,int price)
        {
            con.Open();

            string id;
            string idquery = "select Games.Id from Games where Games.name = '" + name + "';";
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
                    if (money > price)
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        DateTime dateTime = DateTime.Now;
                        var dateValue1 = dateTime.ToString("MM/dd/yyyy");
                        cmd.CommandText = "INSERT INTO dbo.[List of owned games](GameID,name,UserId,date_bought) VALUES ('" + id + "', '" + name + "', '" + userid + "', '" + dateValue1 + "')";
                        cmd.ExecuteNonQuery();
                        int money1 = money;
                        int moneyfinal = money1 - price;

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
                        cmdowners.CommandText = "UPDATE Games Set [number bought] = '" + owners + "' WHERE Id = '" + id + "'";

                        SqlCommand cmdmoney = con.CreateCommand();
                        cmdmoney.CommandType = CommandType.Text;
                        cmdmoney.CommandText = "UPDATE Users SET money = '" + moneyfinal + "' WHERE Id = '" + userid + "'";
                        cmdmoney.ExecuteNonQuery();
                        money = moneyfinal;

                        MessageBox.Show("Thank you for your purchase", "Purchase succesful", MessageBoxButtons.OK);
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

        private void queueclick(object sender, EventArgs e)
        {
            if (queuelcoation == 10)
            {
                Controls.Clear();
                z = 0;
                cz = 0;
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
            switchtogame(name, false);
        }

        #endregion
    }
}
