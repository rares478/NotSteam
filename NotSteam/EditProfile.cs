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
            panelShowcase.Visible = false;

            int showcase = 0;

            con.Open();
            string query = "select description,showcase from Users where Id = '" + user.id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr.IsDBNull(0) == false)
                    tbDesc.Text = dr.GetString(0);
                description = tbDesc.Text;
                showcase = dr.GetInt32(1);
            }
            con.Close();

            if (showcase == 1)
            {
                DescriptionShowcase.Visible = false;
                pbShowcase.Visible = true;
                tbPic.Visible = true;
                cbShowcases.SelectedItem = "Artwork Showcase";
            }
            if (showcase == 1)
            {
                DescriptionShowcase.Visible = true;
                pbShowcase.Visible = false;
                tbPic.Visible = false;
                cbShowcases.SelectedItem = "Custom Info Box";
            }

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
            if (tbUsername.Text != loggeduser.username)
            {
                string query = "UPDATE Users SET username = '" + tbUsername.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            if (description != tbDesc.Text)
            {
                string query = "UPDATE Users SET description = '" + tbDesc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }

        private void Save2(object sender, EventArgs e)
        {
            if (cbShowcases.SelectedIndex == 0)
            {
                con.Open();
                string query1 = "UPDATE Users SET showcase = '1' WHERE Id = '" + loggeduser.id + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

                string query2 = "UPDATE Users SET PictureBox = '" + tbPic.Text + "' WHERE Id = '" + loggeduser.id + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            if (cbShowcases.SelectedIndex == 1)
            {
                con.Open();
                string query = "UPDATE Users SET showcase = '2 WHERE Id = '" + loggeduser.id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                string query2 = "UPDATE Users SET DescriptionBox = '" + DescriptionShowcase.Text + "' WHERE Id = '" + loggeduser.id + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            GoBack?.Invoke(sender, e);
        }

        private void cbShowcases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShowcases.SelectedIndex == 0)
            {
                DescriptionShowcase.Visible = false;
                pbShowcase.Visible = true;
                tbPic.Visible = true;
            }
            else
            {
                DescriptionShowcase.Visible = true;
                pbShowcase.Visible = false;
                tbPic.Visible = false;

            }
        }

        private void btShowcase_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelGeneral.Dock = DockStyle.None;
            panelShowcase.Visible = true;
            panelShowcase.Parent = panel6;
            panelShowcase.Dock = DockStyle.Fill;
        }

        private void btGeneral_Click(object sender, EventArgs e)
        {
            panelShowcase.Visible = false;
            panelShowcase.Dock = DockStyle.None;
            panelGeneral.Visible = true;
            panelGeneral.Parent = panel6;
            panelGeneral.Dock = DockStyle.Fill;
        }
    }
}
