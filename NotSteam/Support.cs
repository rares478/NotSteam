using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class Support : Form
    {
        user loggeduser = null;
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public Support(string name, user user)
        {
            InitializeComponent();
            lbName.Text = name;
            loggeduser = user;
            lbUsername.Text = user.username;

            con.Open();
            string query = "Select date_bought from dbo.[List of owned games] WHERE name = '" + name + "' AND UserId = '" + loggeduser.id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbPurchased.Text = reader.GetDateTime(0).ToString("MM/dd/yyyy");
                lbPurchased2.Text = lbPurchased.Text;
            }
            con.Close();

            btGameplay.Click += new EventHandler((sender, e) => switchpanels(PanelMainQuestions, PanelGameplay));
            label5.Click += new EventHandler((sender, e) => switchpanels(PanelMainQuestions, PanelGameplay));

            btGameplay1.Click += new EventHandler((sender, e) => switchpanels(PanelGameplay, PanelContactGameSupport));
            label10.Click += new EventHandler((sender, e) => switchpanels(PanelGameplay, PanelContactGameSupport));
            btGameplay2.Click += new EventHandler((sender, e) => switchpanels(PanelGameplay, PanelContactGameSupport));
            label11.Click += new EventHandler((sender, e) => switchpanels(PanelGameplay, PanelContactGameSupport));
            btGameplayDifferent.Click += new EventHandler((sender, e) => switchpanels(PanelGameplay, PanelMainQuestions));
            label9.Click += new EventHandler((sender, e) => switchpanels(PanelGameplay, PanelMainQuestions));

            btNotLibrary.Click += new EventHandler((sender, e) => switchpanels(PanelMainQuestions, PanelNotLibrary));
            btNotLibraryViewLibraryPanel.Click += new EventHandler(btLibrary_Click);
            labelidk.Click += new EventHandler(btLibrary_Click);
            btNotLibraryViewLibrary.Click += new EventHandler(btLibrary_Click);
            btNotLibraryDifferent.Click += new EventHandler((sender, e) => switchpanels(PanelNotLibrary, PanelMainQuestions));

            btRemove.Click += new EventHandler((sender, e) => switchpanels(PanelMainQuestions, PanelRemove));
            label7.Click += new EventHandler((sender, e) => switchpanels(PanelMainQuestions, PanelRemove));

            lbGameNameRemove.Text = lbName.Text + " from your account " + user.username;
            lbGameNameRemove2.Text = lbName.Text;

            BtRemoveGame.Click += new EventHandler((sender, e) => { removegame(lbName.Text); switchpanels(PanelRemove, PanelRemoved); });
            label24.Click += new EventHandler((sender, e) => { removegame(lbName.Text); switchpanels(PanelRemove, PanelRemoved); });
            btChangeMind.Click += new EventHandler((sender, e) => switchpanels(PanelRemove, PanelMainQuestions));
            label22.Click += new EventHandler((sender, e) => switchpanels(PanelRemove, PanelMainQuestions));

            btReturnLibrary.Click += new EventHandler(btLibrary_Click);
            label30.Click += new EventHandler(btLibrary_Click);

        }

        private void switchpanels(Panel panel, Panel paneltoswitch)
        {
            paneltoswitch.Location = panel.Location;
            panel.Visible = false;
            paneltoswitch.Visible = true;
        }

        private void removegame(string name)
        {
            con.Open();
            string query = "Delete FROM [dbo].[List of owned games] WHERE name = '" + name + "' AND UserId = '" + loggeduser.id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static event EventHandler ViewinStore;
        private void btStore_Click(object sender, EventArgs e)
        {
            btStore.Name = lbName.Text;
            ViewinStore?.Invoke(sender, e);
        }

        public static event EventHandler ViewinLibrary;
        private void btLibrary_Click(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel panel = (Panel)sender;
                panel.Name = lbName.Text;
            }
            if (sender is Label)
            {
                Label label = (Label)sender;
                label.Name = lbName.Text;
            }
            ViewinLibrary?.Invoke(sender, e);
        }
    }
}
