using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class NotSteamForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        static user loggeduser = new user();
        public NotSteamForm(user user)
        {

            InitializeComponent();
            loggeduser = user;
            if (user.admin != 1)
                addGameToNotSteamToolStripMenuItem.Visible = false;

            toolStripMenuItem3.Text = user.username.ToString() + "    " + user.money.ToString() + "$";
            Form mainform = new Store(loggeduser);
            openform(mainform);
            FormBorderStyle = FormBorderStyle.None;
            menuStrip1.Renderer = new MyRenderer();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void moveform(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region switch
        /*public void ChangeTheme(Control.ControlCollection container)
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
        }*/


        #endregion


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Settings(loggeduser);
            openform(settings);
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form libraryform = new Library(loggeduser);
            openform(libraryform);
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
            Form settings = new Settings(loggeduser);
            openform(settings);
        }

        private void aboutNotSteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotSteam client application" + "\n" + "\n" + "Built: Azi" + "\n" + "\n" + "NotSteam API: v001" + "\n" + "\n" + "rares478@gmail.com", "About NotSteam", MessageBoxButtons.OK);
        }

        private void viewGamesLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form libraryform = new Library(loggeduser);
            openform(libraryform);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editProfileNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form profile = new Profile(loggeduser);
            openform(profile);
        }


        private void addGameToNotSteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new AddGame();
            openform(add);
        }



        private Form activeform = null;
        private Form formerform = new Store(loggeduser);

        private void openform(Form form)
        {
            try
            {
                if (activeform != null)
                {
                    formerform = activeform;
                    activeform.Hide();
                }

                if (former)
                {
                    formerform.Close();
                    former = false;
                }

                if (AddFunds.completed)
                {
                    Controls.Clear();
                    InitializeComponent();
                    AddFunds.completed = false;

                    if (loggeduser.admin != 1)
                        addGameToNotSteamToolStripMenuItem.Visible = false;

                    con.Open();

                    string cmmoney = "select money from Users where id = " + loggeduser.id + "";
                    SqlCommand cmdmoney = new SqlCommand(cmmoney, con);
                    string money = cmdmoney.ExecuteScalar().ToString();

                    con.Close();
                    toolStripMenuItem3.Text = loggeduser.username.ToString() + "    " + money;
                }

                activeform = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panel1.Controls.Add(form);
                panel1.Tag = form;
                form.BringToFront();
                form.Show();
            }
            catch (Exception ex)
            {
                Form mainform = new Store(loggeduser);
                openform(mainform);
            }
        }


        private void toolStripmoney_Click(object sender, EventArgs e)
        {
            Form addfundform = new AddFunds(loggeduser);
            openform(addfundform);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form mainform = new Store(loggeduser);
            openform(mainform);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form libraryform = new Library(loggeduser);
            openform(libraryform);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form profileform = new Profile(loggeduser);
            openform(profileform);
        }
        bool former = false;
        private void pbBack_Click(object sender, EventArgs e)
        {
            former = true;
            openform(formerform);
        }

        private void pbForward_Click(object sender, EventArgs e)
        {
            openform(formerform);
        }

        private void viewMyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form profileform = new Profile(loggeduser);
            openform(profileform);
        }

        private void logoutOfAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("This will log you out of NotSteam. You will need to re-enter your account name and password to use NotSteam again." + "\n" + "\n" + "Do you wish to continue ?",
                "Logout", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Restart();
        }

        private void viewMyWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addfundform = new AddFunds(loggeduser);
            openform(addfundform);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
