using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class Library : Form
    {
        int userid;
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public Library(user user, string name)
        {
            userid = user.id;
            InitializeComponent();
            DoubleBuffered = true;
            lbAfis.Items.Clear();
            panel1.Parent = pbAfis;

            con.Open();
            string query = "select [List of owned games].name from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE[List of owned games].UserId = " + userid + "";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbAfis.Items.Add(reader.GetString(0));
            }
            con.Close();
            lbAfis.SelectedIndex = 0;

            NotSteamForm.Maximized += new EventHandler((sender, e) =>
            {
                pbAfis.Size = new Size(pbAfis.Width, 400);
                pbLogo.Size = new Size(280, 175);
                pbLogo.Location = new Point(6, 100);
            });
            NotSteamForm.Normal += new EventHandler((sender, e) =>
            {
                pbAfis.Size = new Size(pbAfis.Width, 350);
                pbLogo.Size = new Size(256, 144);
                pbLogo.Location = new Point(6, 134);
            });

            if (name != null)
                lbAfis.SelectedItem = name;

        }
        private void lbAfis_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = lbAfis.GetItemText(lbAfis.SelectedItem);
            try
            {
                pbLogo.Parent = pbAfis;
                if (name.Contains(" "))
                    name.Replace(" ", "_");
                object obj = Properties.Resources.ResourceManager.GetObject(name);
                object logo = Properties.logo.ResourceManager.GetObject(name);

                pbAfis.Image = (Bitmap)obj;
                pbLogo.Image = (Bitmap)logo;

                button1.Name = name;


            }
            catch (Exception)
            {
                pbAfis.Image = imageList1.Images[0];
            }
            if (pbAfis.Image == null)
                pbAfis.Image = imageList1.Images[0];
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
            con.Close();
        }



        private void btPlay_Click(object sender, EventArgs e)
        {

        }

        public static event EventHandler OpenStoreClick;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenStoreClick?.Invoke(sender, e);
        }

        public static event EventHandler OpenSupport;
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Name = lbAfis.SelectedItem.ToString();
            OpenSupport?.Invoke(sender, e);
        }
    }
}
