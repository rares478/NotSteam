using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;


namespace NotSteam
{
    public partial class Friends : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public Friends(user user, string name)
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            richTextBox1.Text = name;
            string query = "Select username, Id from Users WHERE username LIKE '%" + name + "%';";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if(panel1.Visible == false)
                {
                    panel1.Visible = true;
                    lbName1.Text = reader.GetString(0);
                    id1 = reader.GetInt32(1);
                }
                else if(panel2.Visible == false)
                {
                    panel1.Visible = true;
                    lbName2.Text = reader.GetString(0);
                    id2 = reader.GetInt32(2);
                }
                else
                {
                    panel3.Visible = true;
                    lbName3.Text = reader.GetString(0);
                    id3 = reader.GetInt32(3);
                }
            }    

        }
        int id1, id2, id3;

        private void lbName2_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Name = id2.ToString();
            Profile?.Invoke(sender, e);
        }

        private void lbName3_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Name = id3.ToString();
            Profile?.Invoke(sender, e);
        }

        private void btAdd1_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = NotSteamForm.loggeduser.id;
            string query1 = "insert into Friends(UserId,FriendId) Values('" + id + "','" + id1 + "')";
            string query2 = "insert into Friends(UserId,FriendId) Values('" + id1 + "','" + id + "')";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void btAdd2_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = NotSteamForm.loggeduser.id;
            string query1 = "insert into Friends(UserId,FriendId) Values('" + id + "','" + id2 + "')";
            string query2 = "insert into Friends(UserId,FriendId) Values('" + id2 + "','" + id + "')";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void btAdd3_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = NotSteamForm.loggeduser.id;
            string query1 = "insert into Friends(UserId,FriendId) Values('" + id + "','" + id3 + "')";
            string query2 = "insert into Friends(UserId,FriendId) Values('" + id3 + "','" + id + "')";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public static EventHandler Profile;

        private void lbName1_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Name = id1.ToString();
            Profile?.Invoke(sender, e);
        }
    }
}
