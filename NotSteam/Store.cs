using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace NotSteam
{
    public partial class Store : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iovit\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        int money;
        int userid;
        bool removed;
        bool theme = false;

        public Store(user user)
        {
            
            InitializeComponent();
            userid = user.id;
            money = user.money;
            initialize();

        }
        private void initialize()
        {
            Controls.Clear();
            Label labelmain = new Label();
            Controls.Add(labelmain);
            labelmain.Location = new Point(249, 13);
            labelmain.Font = new Font("Microsoft Sans Serif", 36);
            labelmain.ImageAlign = ContentAlignment.TopCenter;
            labelmain.Text = "Not Steam";
            labelmain.Size = new Size(251, 55);

            Label lbMoney = new Label();
            Controls.Add(lbMoney);
            lbMoney.Location = new Point(640, 16);
            lbMoney.Size = new Size(41, 13);
            lbMoney.Text = money.ToString();
            lbMoney.AutoSize = true;

            Label lbName = new Label();
            Controls.Add(lbName);
            lbName.Location = new Point(674, 13);
            lbName.Size = new Size(44, 16);
            lbName.TextAlign = ContentAlignment.TopRight;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 10);
            lbName.Text = "nimic";




            con.Open();
            string idquery = "select Games.name from Games";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            int z = 0;
            int cz = 1;
            int i = 0;
            while (reader.Read())
            {
                string name = reader.GetString(0);
                Label lbl = new Label();
                Label lblMissing = new Label();
                Label lbl2 = new Label();
                PictureBox pictureBox = new PictureBox();
                RichTextBox richTextBox = new RichTextBox();

                Controls.Add(lbl);
                Controls.Add(lblMissing);
                Controls.Add(lbl2);
                Controls.Add(pictureBox);
                Controls.Add(richTextBox);
                lbl.Location = new Point(303, 360 + (z * 260));
                lblMissing.Location = new Point(95, 565 + (z * 260));
                lbl2.Location = new Point(303, 400 + (z * 260));
                richTextBox.Location = new Point(308, 175 + ((z + 1) * 260));
                pictureBox.Location = new Point(6, 360 + (z * 260));
                pictureBox.Size = new Size(256, 199);
                richTextBox.Size = new Size(397, 126);
                lblMissing.Text = "Missing image";
                lblMissing.Visible = false;
                ///lbl.Click += new EventHandler(lbl_click);
                lbl.AutoSize = true;
                lbl2.AutoSize = true;
                lbl2.Text = "name"; ///developer(name);
                lbl.Font = new Font("Microsoft Sans Serif", 16);
                richTextBox.Text = "ceva"; ///description(name);
                z++;
                lbl.Text = name;
                if (cz >= imageList1.Images.Count)
                {
                    cz = 0;
                    pictureBox.Image = imageList1.Images[cz];
                    lblMissing.Visible = true;

                }
                else
                {
                    pictureBox.Image = imageList1.Images[cz];
                    cz++;
                }
                i++;
            }
            con.Close();
        }
        private void lbMoney_Click(object sender, EventArgs e)
        {

        }
    }
}
