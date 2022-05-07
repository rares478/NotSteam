using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class EditProfile : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        user loggeduser = null;
        string description = null;

        public EditProfile(user user)
        {
            InitializeComponent();
            loggeduser = user;
            label1.Text = user.username;
            tbUsername.Text = user.username;
            tbDesc.Text = "";

            con.Open();
            string query = "select description from Users where Id = '" + user.id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if(dr.IsDBNull(0) == false)
                tbDesc.Text = dr.GetString(0);
                description = tbDesc.Text;
            }
            con.Close();
            btSave.Click += new EventHandler(Save);
            btSaveLabel.Click += new EventHandler(Save);
            btCancel.Click += new EventHandler(Cancel);
            btCancelLabel.Click += new EventHandler(Cancel);

            btCancel2.Click += new EventHandler(Cancel);
            labelcancel2.Click += new EventHandler(Cancel);

            btSave2.Click += new EventHandler(Save2);
            labelsave2.Click += new EventHandler(Save2);

        }

        public static event EventHandler GoBack;

        private void Save(object sender, EventArgs e)
        {
            con.Open();
            if(tbUsername.Text != loggeduser.username)
            {
                string query = "UPDATE Users SET username = '" + tbUsername.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            if(description != tbDesc.Text)
            {
                string query = "UPDATE Users SET description = '" + tbDesc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }

        private static void Save2(object sender,EventArgs e)
        {
            
        }


        private void Cancel(object sender, EventArgs e)
        {
            GoBack?.Invoke(sender, e);
        }

        private void btShowcase_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelGeneral.Dock = DockStyle.None;
            panelShowcase.Visible = true;
            panelShowcase.Parent = panel5;
            panelShowcase.Location = new System.Drawing.Point(314, 111);
            panelShowcase.Dock = DockStyle.Fill;
        }

        private void cbShowcases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbShowcases.SelectedIndex == 0)
            {
                pbShowcase.Visible = true;
            }
            else
            {
                DescriptionShowcase.Visible = true;
            }
        }
    }
}
