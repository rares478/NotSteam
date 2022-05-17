using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class NotSteamForm : Form
    {

        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public static user loggeduser = new user();
        public NotSteamForm(user user)
        {

            InitializeComponent();
            loggeduser = user;
            if (user.admin != 1)
                addGameToNotSteamToolStripMenuItem.Visible = false;
            label4.Text = user.username;
            StartPosition = FormStartPosition.CenterScreen;

            toolStripMenuItem3.Text = user.username.ToString() + "    " + user.money.ToString() + "$";
            Form mainform = new Store(loggeduser, storeceva, null);
            openform(mainform);
            FormBorderStyle = FormBorderStyle.None;
            menuStrip1.Renderer = new MyRenderer();
            if (WindowState != FormWindowState.Maximized)
                panel1.Width = 0;

            Library.OpenStoreClick += new EventHandler((sender, e) => { Button bt = sender as Button; string gamename = bt.Name; openform(new Game(user, gamename, false)); });
            AddFunds.FundsAdded += new EventHandler((sender, e) => { Button bt = sender as Button; toolStripMenuItem3.Text = user.username.ToString() + "    " + bt.Name + "$"; });
            Library.OpenSupport += new EventHandler((sender, e) => { Button bt = sender as Button; string name = bt.Name; openform(new Support(name, user)); });
            Support.ViewinStore += new EventHandler((sender, e) => { Label bt = sender as Label; panel1.Width = 400; string name = bt.Name; openform(new Game(user, name, false)); });
            Support.ViewinLibrary += new EventHandler((sender, e) =>
            {
                Label lb;
                Panel pn;
                if (sender is Label)
                {
                    lb = (Label)sender;
                    openform(new Library(user, lb.Name));
                }
                if (sender is Panel)
                {
                    pn = (Panel)sender;
                    openform(new Library(user, pn.Name));
                }
            });
            Profile.EditProfile += new EventHandler((sender, e) => { openform(new EditProfile(user)); });
            EditProfile.GoBack += new EventHandler((sender, e) =>
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select username, money from Users WHERE Id = '" + user.id + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    toolStripMenuItem3.Text = reader.GetString(0) + "    " + reader.GetInt32(1).ToString() + "$";
                }
                openform(new Profile(user,false));
            });
            Store.Switchtogame += new EventHandler((sender, e) => { string st = sender as string; openform(new Game(user, st, false)); });
            Store.Switchtoqueue += new EventHandler((sender, e) => { openform(new Game(user, Store.queuepic[Store.queuelcoation + 1], true)); });
            Game.NextQueue += new EventHandler((sender, e) => { openform(new Game(user, Store.queuepic[Store.queuelcoation + 1], true)); });
            Game.EndQueue += new EventHandler((sender, e) => { openform(new Store(user, storeceva, null)); });
            Game.category += new EventHandler((sender, e) =>
            {
                Button bt = sender as Button;
                switch (bt.Text)
                {
                    case "Free to Play":
                        openform(new Store(user, free, null));
                        break;
                    case "Early Access":
                        openform(new Store(user, Early, null));
                        break;
                    case "Action":
                        openform(new Store(user, action, null));
                        break;
                    case "Casual":
                        openform(new Store(user, Casual, null));
                        break;
                    case "Indie":
                        openform(new Store(user, Indie, null));
                        break;
                    case "Massively Multiplayer":
                        openform(new Store(user, Multiplayer, null));
                        break;
                    case "Racing":
                        openform(new Store(user, Racing, null));
                        break;
                    case "RPG":
                        openform(new Store(user, RPG, null));
                        break;
                    case "Simulation":
                        openform(new Store(user, Simulation, null));
                        break;
                    case "Sports":
                        openform(new Store(user, Sports, null));
                        break;
                    case "Strategy":
                        openform(new Store(user, Strategy, null));
                        break;
                    case "Arcade":
                        openform(new Store(user, Arcade, null));
                        break;
                    case "Open World":
                        openform(new Store(user, OpenWorld, null));
                        break;
                    case "Space":
                        openform(new Store(user, Space, null));
                        break;
                    case "Horror":
                        openform(new Store(user, Horror, null));
                        break;
                    case "Survival":
                        openform(new Store(user, Survival, null));
                        break;
                }
            });
            Community.friend += new EventHandler((sender, e) => { RichTextBox richText = sender as RichTextBox; string name = richText.Name; openform(new Friends(user,name)); });
            Friends.Profile += new EventHandler((sender, e) => { Label label = sender as Label; user friend = new user(); friend.id = Convert.ToInt32(label.Name); friend.username = label.Text;openform(new Profile(friend, true)); });
        }

        #region category strings

        string Arcade = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Arcade] = '1'";
        string OpenWorld = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Open World] = '1'";
        string Space = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Space] = '1'";
        string Horror = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Horror] = '1'";
        string Survival = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Survival] = '1'";
        string free = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Free to Play] = '1'";
        string Early = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Early Access] = '1'";
        string action = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Action] = '1'";
        string Adventure = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Adventure] = '1'";
        string Casual = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Casual] = '1'";
        string Indie = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Indie] = '1'";
        string Multiplayer = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Massively Multiplayer] = '1'";
        string Racing = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Racing] = '1'";
        string RPG = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [RPG] = '1'";
        string Simulation = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Simulation] = '1'";
        string Sports = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Sports] = '1'";
        string Strategy = "select name,price from Games inner join Genres on Genres.Id = Games.Id WHERE [Strategy] = '1'";

        #endregion

        public static event EventHandler Normal;
        public static event EventHandler Maximized;

        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void moveform(object sender, MouseEventArgs e)
        {
            panel1.Width = 0;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            Point point = new Point(Cursor.Position.X, 0);
            if (Cursor.Position == point)
            {

                WindowState = FormWindowState.Maximized;
                Maximized?.Invoke(sender, e);
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Store)
                    {
                        panel1.Width = 400;
                        break;
                    }
                    else panel1.Width = 0;
                }

            }
        }

        #endregion

        #region Main Buttons

        string storeceva = "select name,price from Games";

        private Form activeform = null;
        private Form formerform = null;

        private void openform(Form form)
        {
            try
            {

                if (activeform != null)
                {
                    formerform = activeform;
                    activeform.Hide();
                }

                activeform = form;

                #region do not open
                if (former == false)
                {
                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();

                    int addfunds = Application.OpenForms.OfType<AddFunds>().Count();
                    int addgame = Application.OpenForms.OfType<AddGame>().Count();
                    int Library = Application.OpenForms.OfType<Library>().Count();
                    int Profile = Application.OpenForms.OfType<Profile>().Count();
                    int Settings = Application.OpenForms.OfType<Settings>().Count();
                    int Store = Application.OpenForms.OfType<Store>().Count();
                    int Support = Application.OpenForms.OfType<Support>().Count();
                    int Game = Application.OpenForms.OfType<Game>().Count();
                    int EditProfile = Application.OpenForms.OfType<EditProfile>().Count();
                    int Community = Application.OpenForms.OfType<Community>().Count();
                    foreach (Form thisform in forms)
                    {
                        if (thisform.Name == "AddFunds" && (addfunds >= 1 || (formerform.Name != "AddFunds" && activeform.Name != "AddFunds")))
                        {
                            thisform.Close();
                            addfunds--;
                        }
                        if (thisform.Name == "AddGame" && (addgame >= 1 || (formerform.Name != "AddGame" && activeform.Name != "AddGame")))
                        {
                            thisform.Close();
                            addgame--;
                        }
                        if (thisform.Name == "Library" && (Library > 1 || (formerform.Name != "Library" && activeform.Name != "Library")))
                        {
                            Library--;
                            thisform.Close();
                        }
                        if (thisform.Name == "Profile" && (Profile > 1 || (formerform.Name != "Profile" && activeform.Name != "Profile")))
                        {
                            Profile--;
                            thisform.Close();
                        }
                        if (thisform.Name == "Store" && (Store > 1 || (activeform.Name != "Store" && formerform.Name != "Store")))///memory leak da idk
                        {
                            Store--;
                            thisform.Close();
                        }
                        if (thisform.Name == "Settings" && (Settings >= 1 || (formerform.Name != "Settings" && activeform.Name != "Settings")))
                        {
                            Settings--;
                            thisform.Close();
                        }
                        if (thisform.Name == "Support" && (Support >= 1 || (formerform.Name != "Support" && activeform.Name != "Support")))
                        {
                            Support--;
                            thisform.Close();
                        }
                        if (thisform.Name == "Game" && (Game >= 1 || (formerform.Name != "Game" && activeform.Name != "Game")))
                        {
                            Game--;
                            thisform.Close();
                        }
                        if (thisform.Name == "EditProfile" && (EditProfile >= 1 || (formerform.Name != "EditProfile" && activeform.Name != "EditProfile")))
                        {
                            EditProfile--;
                            thisform.Close();
                        }
                        if(thisform.Name == "Community" && (Community >= 1 || (formerform.Name != "Community" && activeform.Name != "Community")))
                        {
                            Community--;
                            thisform.Close();
                        }
                    }
                }
                #endregion


                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panel3.Controls.Add(form);
                panel3.Tag = form;
                form.BringToFront();
                form.Show();
                nimicToolStripMenuItem.Text = Application.OpenForms.Count.ToString();
                former = false;
            }
            catch (Exception)
            {
                Form mainform = new Store(loggeduser, storeceva, null);
                openform(mainform);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            openform(new Store(loggeduser, storeceva, null));
            if (WindowState == FormWindowState.Maximized)
                panel1.Width = 400;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openform(new Library(loggeduser, null));
            panel1.Width = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Width = 0;
            openform(new Community(loggeduser));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            openform(new Profile(loggeduser,false));
            panel1.Width = 0;
        }

        bool former = false;
        private void pbBack_Click(object sender, EventArgs e)
        {
            former = true;
            openform(formerform);
        }

        private void pbForward_Click(object sender, EventArgs e) => openform(formerform);

        #endregion

        #region Sidepanel

        public static bool freetoplay = false;

        private void label20_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, free, null);
            freetoplay = true;
            openform(mainform);
        }
        public static bool early = false;
        private void label21_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Early, null);
            early = true;
            openform(mainform);
        }
        public static bool actionb = false;
        private void label22_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, action, null);
            actionb = true;
            openform(mainform);
        }
        public static bool adventure = false;
        private void label23_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Adventure, null);
            adventure = true;
            openform(mainform);
        }
        public static bool casual = false;
        private void label24_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Casual, null);
            casual = true;
            openform(mainform);
        }
        public static bool indie = false;
        private void label25_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Indie, null);
            indie = true;
            openform(mainform);
        }
        public static bool multiplayer = false;
        private void label26_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Multiplayer, null);
            multiplayer = true;
            openform(mainform);
        }
        public static bool racing = false;
        private void label27_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Racing, null);
            racing = true;
            openform(mainform);
        }
        public static bool rpg = false;
        private void label28_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, RPG, null);
            rpg = true;
            openform(mainform);
        }
        public static bool simulation = false;
        private void label29_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Simulation, null);
            simulation = true;
            openform(mainform);
        }
        public static bool sports = false;
        private void label30_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Sports, null);
            sports = true;
            openform(mainform);
        }
        private void label31_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser, Strategy, null);
            openform(mainform);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            string query = "select name,price from Games order by Games.[number bought] DESC";
            Form mainform = new Store(loggeduser, query, null);
            openform(mainform);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form addfundform = new AddFunds(loggeduser);
            openform(addfundform);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form addfundform = new AddFunds(loggeduser);
            openform(addfundform);
        }
        private void label32_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int id = rand.Next(1, 56);
            con.Open();
            string query = "select name from Games where Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = cmd.ExecuteScalar().ToString();
            con.Close();
            Form mainform = new Store(loggeduser, query, name);
            openform(mainform);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            string query = "select name,price from Games where Games.date >= DATEADD(day, -31, getdate())";
            Form mainform = new Store(loggeduser, query, null);
            openform(mainform);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            string query = "select name,price from Games where Games.date >= DATEADD(day, -31, getdate())";
            Form mainform = new Store(loggeduser, query, null);
            openform(mainform);
        }

        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region mainstrip
        private void toolStripMenuItem49_Click(object sender, EventArgs e) => Application.Exit();

        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {
            if (activeform.Name == "Store")
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    Normal?.Invoke(sender, e);
                    WindowState = FormWindowState.Normal;
                    panel1.Width = 0;
                }
                else
                {
                    Maximized?.Invoke(sender, e);
                    WindowState = FormWindowState.Maximized;
                    panel1.Width = 400;
                }
            }
            else
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    Normal?.Invoke(sender, e);
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    Maximized?.Invoke(sender, e);
                    WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void toolStripMenuItem51_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("This will log you out of NotSteam. You will need to re-enter your account name and password to use NotSteam again." + "\n" + "\n" + "Do you wish to continue ?",
                "Logout", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Restart();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            openform(new Settings(loggeduser));
            panel1.Width = 0;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e) => Application.Exit();

        private void addGameToNotSteamToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openform(new AddGame());
            panel1.Width = 0;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            openform(new Library(loggeduser, null));
            panel1.Width = 0;
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            openform(new Settings(loggeduser));
            panel1.Width = 0;
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            openform(new Profile(loggeduser,false));
            panel1.Width = 0;
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            openform(new Library(loggeduser, null));
            panel1.Width = 0;
        }

        private void toolStripMenuItem48_Click(object sender, EventArgs e) => MessageBox.Show("NotSteam client application" + "\n" + "\n" + "Built: Azi" + "\n" + "\n" + "NotSteam API: v001" + "\n" + "\n" + "rares478@gmail.com", "About NotSteam", MessageBoxButtons.OK);

        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {
            openform(new Profile(loggeduser, false));
            panel1.Width = 0;
        }

        private void toolStripMenuItem55_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("This will log you out of NotSteam. You will need to re-enter your account name and password to use NotSteam again." + "\n" + "\n" + "Do you wish to continue ?",
                "Logout", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Restart();
        }

        private void toolStripMenuItem57_Click(object sender, EventArgs e)
        {
            openform(new AddFunds(loggeduser));
            panel1.Width = 0;
        }
        #endregion
    }
}
