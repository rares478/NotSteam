using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace NotSteam
{
    public partial class Community : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public Community(user user)
        {
            InitializeComponent();
            con.Open();
            string query = "Select Games.name from Games inner join[List of owned games] on Games.Id = [List of owned games].GameID where[List of owned games].UserId = '"+user.id+"' order by[List of owned games].[last played] desc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if(lbGame1.Text == "FIND HUBS")
                {
                    lbGame1.Text = reader.GetString(0);
                    object obj = Properties.logo.ResourceManager.GetObject(lbGame1.Text);
                    pictureBox1.Image = (Bitmap)obj;
                    
                }
                else if(lbGame2.Text == "FIND HUBS")
                {
                    lbGame2.Text = reader.GetString(0);
                    object obj = Properties.logo.ResourceManager.GetObject(lbGame2.Text);
                    pictureBox2.Image = (Bitmap)obj;
                }
                else if(lbGame3.Text == "FIND HUBS")
                {
                    lbGame3.Text = reader.GetString(0);
                    object obj = Properties.logo.ResourceManager.GetObject(lbGame3.Text);
                    pictureBox3.Image = (Bitmap)obj;
                }
                else if(lbGame4.Text == "FIND HUBS")
                {
                    lbGame4.Text = reader.GetString(0);
                    object obj = Properties.logo.ResourceManager.GetObject(lbGame4.Text);
                    pictureBox4.Image = (Bitmap)obj;
                }
            }
            con.Close();
        }

        public static EventHandler friend;

        private void searchfriend(object sender,KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string name = richTextBox2.Text;
                RichTextBox tb = sender as RichTextBox;
                tb.Name = name;
                friend?.Invoke(sender, e);
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }
    }
}
