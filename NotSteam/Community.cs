using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class Community : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public Community(user user)
        {
            InitializeComponent();
        }

        public static EventHandler friend;

        private void searchfriend(object sender,KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string name = richTextBox2.Text;
                con.Open();
                string query = "SELECT Id From Users WHERE username = '" + name + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                RichTextBox tb = sender as RichTextBox;
                tb.Name = id.ToString();
                friend?.Invoke(sender, e);
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }
    }
}
