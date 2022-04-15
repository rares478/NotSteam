using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class Profile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        int userid;
        string username;
        public Profile(user user)
        {
            InitializeComponent();
            userid = user.id;
            username = user.username;

            initialize();
        }

        string changename;
        string description;

        private void EditProfile()
        {
            Controls.Clear();

            TextBox tbChangeName = new TextBox();
            Controls.Add(tbChangeName);
            tbChangeName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            tbChangeName.Location = new Point(118, 150);
            tbChangeName.Name = "tbChangeName";
            tbChangeName.Size = new Size(489, 26);
            tbChangeName.TabIndex = 2;
            tbChangeName.TextChanged += updatename;

            RichTextBox tbChangeDesc = new RichTextBox();
            Controls.Add(tbChangeDesc);
            tbChangeDesc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            tbChangeDesc.Location = new Point(118, 259);
            tbChangeDesc.Name = "tbChangeDesc";
            tbChangeDesc.Size = new Size(489, 97);
            tbChangeDesc.TabIndex = 3;
            tbChangeDesc.Text = "";
            tbChangeDesc.TextChanged += updatedesc;

            Label label14 = new Label();
            Controls.Add(label14);
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new Point(115, 131);
            label14.Name = "label14";
            label14.Size = new Size(85, 16);
            label14.TabIndex = 1;
            label14.Text = "Profile Name";

            Label label15 = new Label();
            Controls.Add(label15);
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new Point(118, 240);
            label15.Name = "label15";
            label15.Size = new Size(75, 16);
            label15.TabIndex = 4;
            label15.Text = "Description";

            Button btSave = new Button();
            Controls.Add(btSave);
            btSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btSave.Location = new Point(671, 436);
            btSave.Name = "btSave";
            btSave.Size = new Size(80, 25);
            btSave.TabIndex = 0;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += new EventHandler(btSave_Click);


        }

        private void updatename(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            changename = tb.Text;
        }

        private void updatedesc(object sender, EventArgs e)
        {
            RichTextBox tb = sender as RichTextBox;
            if (tb != null)
                description = tb.Text.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (changename.Length > 0)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Users SET username = '" + changename + "', description = '" + description + "' WHERE Id = '" + userid + "'";
                cmd.ExecuteNonQuery();
                string desc = "select description from Users where Id = " + userid + "";
                SqlCommand cmddesc = new SqlCommand(desc, con);
                tbDesc.Text = cmddesc.ExecuteScalar().ToString();
                if (tbDesc.Text.Length == 0)
                    tbDesc.Text = "Add a description";
                con.Close();
            }
            else
                con.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditProfile();
        }

        private void initialize()
        {
            Controls.Clear();

            RichTextBox tbDesc = new RichTextBox();
            Controls.Add(tbDesc);
            tbDesc.Location = new Point(38, 126);
            tbDesc.Name = "tbDesc";
            tbDesc.ReadOnly = true;
            tbDesc.Size = new Size(264, 81);
            tbDesc.TabIndex = 11;
            tbDesc.Text = "Add a description";

            Label label6 = new Label();
            Controls.Add(label6);
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new Point(43, 75);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 12;
            label6.Text = "label6";

            ListView lvLibrary = new ListView();
            Controls.Add(lvLibrary);
            lvLibrary.HideSelection = false;
            lvLibrary.Location = new Point(38, 229);
            lvLibrary.Name = "lvLibrary";
            lvLibrary.Size = new Size(264, 280);
            lvLibrary.TabIndex = 13;
            lvLibrary.UseCompatibleStateImageBehavior = false;

            Button btEdit = new Button();
            Controls.Add(btEdit);
            btEdit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btEdit.Location = new Point(650, 126);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(95, 26);
            btEdit.TabIndex = 14;
            btEdit.Text = "Edit Profile";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;

            Label label13 = new Label();
            Controls.Add(label13);
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new Point(661, 453);
            label13.Name = "label13";
            label13.Size = new Size(63, 20);
            label13.TabIndex = 22;
            label13.Text = "Artwork";

            Label label12 = new Label();
            Controls.Add(label12);
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new Point(660, 417);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 21;
            label12.Text = "Guides";

            Label label11 = new Label();
            Controls.Add(label11);
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new Point(660, 377);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 20;
            label11.Text = "Reviews";

            Label label10 = new Label();
            Controls.Add(label10);
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new Point(660, 340);
            label10.Name = "label10";
            label10.Size = new Size(125, 20);
            label10.TabIndex = 19;
            label10.Text = "Workshop Items";

            Label label9 = new Label();
            Controls.Add(label9);
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(660, 303);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 18;
            label9.Text = "Videos";

            Label label8 = new Label();
            Controls.Add(label8);
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new Point(660, 265);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 17;
            label8.Text = "Screenshots";

            Label label7 = new Label();
            Controls.Add(label7);
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new Point(660, 229);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 16;
            label7.Text = "Inventory";

            Label lbLibrary = new Label();
            Controls.Add(lbLibrary);
            lbLibrary.AutoSize = true;
            lbLibrary.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbLibrary.Location = new Point(660, 198);
            lbLibrary.Name = "lbLibrary";
            lbLibrary.Size = new Size(61, 20);
            lbLibrary.TabIndex = 15;
            lbLibrary.Text = "Games";
            lbLibrary.Click += new EventHandler(lbLibrary_Click);

            con.Open();
            string desc = "select description from Users where id = " + userid + "";
            SqlCommand cmddesc = new SqlCommand(desc, con);
            tbDesc.Text = cmddesc.ExecuteScalar().ToString();
            if (tbDesc.Text.Length == 0)
                tbDesc.Text = "Add a description";
            label6.Text = username;
            con.Close();
        }

        int c = 0;

        private void lbLibrary_Click(object sender, EventArgs e)
        {
            lvLibrary.Clear();
            lvLibrary.Visible = true;
            lvLibrary.View = View.Details;
            lvLibrary.AllowColumnReorder = true;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[0].Text = "nimic-nu sterge ca bubuie";
            lvLibrary.Columns[0].Width = 0;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[1].Text = "Game";
            lvLibrary.Columns[1].Width = 100;
            lvLibrary.Columns.Add(new ColumnHeader());
            lvLibrary.Columns[2].Text = "Date bought";
            lvLibrary.Columns[2].Width = 120;
            lvLibrary.ColumnClick += new ColumnClickEventHandler(ColumnClick);
            lvLibrary.LabelEdit = true;

            con.Open();
            string query = "select [List of owned games].name, [List of owned games].[date_bought] from dbo.[List of owned games] inner join Games on Games.Id = [List of owned games].GameID inner join Users on Users.Id = [List of owned games].UserId WHERE [List of owned games].UserId = '" + userid + "'";
            
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvgame = new ListViewItem();
                lvgame.SubItems.Add(reader.GetString(0));
                var dateValue1 = reader.GetDateTime(1).ToString("MM/dd/yyyy");
                lvgame.SubItems.Add(dateValue1);
                lvLibrary.Items.Add(lvgame);
            }
            con.Close();
        }
        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            if (c == 1)
                c = 0;
            else c = 1;
            lvLibrary.ListViewItemSorter = new ListViewItemComparer(e.Column, c);
        }
    }
}
