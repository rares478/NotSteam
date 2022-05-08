using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class AddGame : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");

        public AddGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            panel1.Visible = false;
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            ///verific daca pretul din textbox contine doar numere
            if (int.TryParse(tbPrice.Text, out int price))
            {
                ///daca nu am adaugat imagine imi zice sa adaug una
                if (pbAdd.Image == null)
                {
                    MessageBox.Show("Please enter a picture", "Missing Picture", MessageBoxButtons.OK);
                }
                else
                {
                    ///adaug jocul
                    DateTime now = DateTime.Now;
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Games(name,developer,date,description,price, [number bought]) Values ('" + tbName.Text + "', '" + tbDev.Text + "','" + now + "', '" + rbDesc.Text + "', '" + price + "', '0')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Game Added", "You did it", MessageBoxButtons.OK);
                    con.Close();


                    con.Open();
                    string query1 = "Select Id from Games WHERE name = '" + tbName.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query1, con);
                    int id = Convert.ToInt32(cmd2.ExecuteScalar());
                    int free = 0, early = 0, action = 0, adventure = 0, casual = 0, indie = 0, MMO = 0, racing = 0, RPG = 0, simulation = 0, sports = 0, strategy = 0, arcade = 0, open = 0, space = 0, horror = 0, survival = 0;
                    if(cbFree.Checked)
                        free = 1;
                    if(cbEarly.Checked)
                        early = 1;
                    if(cbAction.Checked)
                        action = 1;
                    if(cbAdventure.Checked)
                        adventure = 1;
                    if(cbCasual.Checked)
                        casual = 1;
                    if(cbIndie.Checked)
                        indie = 1;
                    if(cbMMO.Checked)
                        MMO = 1;
                    if(cbRacing.Checked)
                        racing = 1;
                    if(cbRPG.Checked)
                        RPG = 1;
                    if(cbSimulation.Checked)
                        simulation = 1;
                    if(cbSports.Checked)
                        sports = 1;
                    if(cbStrategy.Checked)
                        strategy = 1;
                    if(cbArcade.Checked)
                        arcade = 1;
                    if (cbOpen.Checked)
                        open = 1;
                    if(cbSpace.Checked)
                        space = 1;
                    if(cbHorror.Checked)
                        horror = 1;
                    if(cbSurvival.Checked)
                        survival = 1;
                    string query2 = "INSERT INTO Genres(Id,[Free to Play],[Early Access],Action,Adventure,Casual,Indie,Massively Multiplayer,Racing,RPG,Simulation,Sports,Strategy,Arcade,[Open World],Space,Horror,Survival) Values ('" + free + "','" + early + "','" + action + "','" + adventure + "','" + casual + "','" + indie + "','" + MMO + "','" + racing + "','" + RPG + "','" + simulation + "','" + sports + "','" + strategy + "','" + arcade + "','" + open + "','" + space + "','" + horror + "','" + survival + "')";
                    SqlCommand cmd3 = new SqlCommand(query2,con);
                    cmd3.ExecuteNonQuery();
                    con.Close();

                }
            }
            else
                MessageBox.Show("Price can only contain numbers", "Price error", MessageBoxButtons.OK);
        }

        private void btPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                /*var path = string.Format(@"{0}\Resources\Images\{1}", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, openFileDialog1.FileName);
                var resizedImage = GiftImage.CreateResizedImage(100, 100, 0);
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(resizedImage));
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    encoder.Save(stream);
                }*/

                ///Nu stiu de ce nu merge, e probail din cauza ca salveaza doar in cache nu si in proiect
                pbAdd.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else MessageBox.Show("something went wrong with the picture", "idk wtf i'm doing", MessageBoxButtons.OK);
        }
    }
}
