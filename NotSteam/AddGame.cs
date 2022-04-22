using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NotSteam
{
    public partial class AddGame : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rares\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");

        public AddGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
                    cmd.CommandText = "INSERT INTO Games(name,developer,date,description,price) Values ('" + tbName.Text + "', '" + tbDev.Text + "','" + now + "', '" + rbDesc.Text + "', '" + price + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Game Added", "You did it", MessageBoxButtons.OK);
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
