using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotSteam
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            MessageBox.Show(path);
            pictureBox1.Image = imageList1.Images[0];
            DoubleBuffered = true;
        }
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public static user user = null;
        public static bool switchtoRegister = false;


        public void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter username or password",
                      "Email or Password Empty", MessageBoxButtons.OK);
                return;
            }

            try
            { 
                string loginquery = "SELECT * FROM Users WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(loginquery, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    user = new user
                    {
                        id = reader.GetInt32(0),
                        username = reader.GetString(1),
                        password = reader.GetString(2),
                        admin = reader.GetInt32(4),
                        money = reader.GetInt32(6)
                    };
                    con.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect",
                    "Username or Password Error", MessageBoxButtons.OK);
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect to database",
                "Database Connection Error", MessageBoxButtons.OK);
            }

        }

        public void btRegister_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["Register"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["Login"];
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            string name = tbUsernameReg.Text;
            string password = tbPasswordReg.Text;
            string email = tbEmailReg.Text;
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Users(username,password,email,admin,money) VALUES ('" + name + "', '" + password + "', '" + email + "', '0', '0')";
            cmd.ExecuteNonQuery();
            con.Close();

            user = new user
            {
                email = email,
                username = name,
                password = password,
                admin = 0,
                money = 0
            };
            this.Close();
        }
    }
}
