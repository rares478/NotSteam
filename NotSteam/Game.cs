using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace NotSteam
{
    public partial class Game : Form
    {
        static string path = System.IO.Path.GetFullPath(@"..\..\");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        static user loggeduser = new user();

        int money = 0;
        public Game(user user, string name,bool queue)
        {
            loggeduser = user;
            money = user.money;
            InitializeComponent();

            if(Store.queuelcoation+1 < 10)
               pbqueue.Image = imageList1.Images[0];
            else pbqueue.Image = imageList1.Images[1];
            if(queue)
                pbqueue.Visible = true;

            con.Open();

            int id = 0;

            string que = "SELECT developer,date,description,price,id FROM Games WHERE name = '" + name + "'";
            SqlCommand cmd = new SqlCommand(que, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbDeveloper.Text = reader.GetString(0);
                lbDate.Text = reader.GetDateTime(1).ToString("MM/dd/yyyy");
                tbDescription.Text = reader.GetString(2);
                lbPrice.Text = reader.GetInt32(3).ToString() + "$";
                if (lbPrice.Text == "0$")
                {
                    lbPrice.Text = "FREE";
                    btBuy.Text = "Add to Library";
                }
                id = reader.GetInt32(4);
            }

            string querycategory = "SELECT [Free to Play],[Early Access],Action,Adventure,Casual,Indie,[Massively Multiplayer],Racing,RPG,Simulation,Sports,Strategy,Arcade,[Open World],Space,Horror,Survival from Genres where Id = '" + id + "'";
            SqlCommand cmdcategory = new SqlCommand(querycategory, con);
            SqlDataReader reader1 = cmdcategory.ExecuteReader();
            while (reader1.Read())
            {
                int count = 0;
                if (reader1.GetInt32(0) == 1)
                {
                    category1.Text = "Free to Play";
                    count++;
                }

                if (reader1.GetInt32(1) == 1)
                {
                    if (count == 1)
                    {
                        category2.Text = "Early Access";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Early Access";
                        count++;
                    }
                }

                if (reader1.GetInt32(2) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Action";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Action";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Action";
                        count++;
                    }
                }

                if (reader1.GetInt32(3) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Adventure";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Adventure";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Adventure";
                        count++;
                    }
                }

                if (reader1.GetInt32(4) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Casual";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Casual";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Casual";
                        count++;
                    }
                }

                if (reader1.GetInt32(5) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Indie";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Indie";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Indie";
                        count++;
                    }
                }

                if (reader1.GetInt32(6) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Massively Multiplayer";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Massively Multiplayer";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Massively Multiplayer";
                        count++;
                    }
                }

                if (reader1.GetInt32(7) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Racing";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Racing";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Racing";
                        count++;
                    }
                }

                if (reader1.GetInt32(8) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "RPG";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "RPG";
                        count++;
                    }
                    else
                    {
                        category1.Text = "RPG";
                        count++;
                    }
                }

                if (reader1.GetInt32(9) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Simulation";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Simulation";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Simulation";
                        count++;
                    }
                }

                if (reader1.GetInt32(10) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Sports";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Sports";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Sports";
                        count++;
                    }
                }

                if (reader1.GetInt32(11) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Strategy";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Strategy";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Strategy";
                        count++;
                    }
                }

                if (reader1.GetInt32(12) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Arcade";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Arcade";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Arcade";
                        count++;
                    }
                }

                if (reader1.GetInt32(13) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Open World";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Open World";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Open World";
                        count++;
                    }
                }

                if (reader1.GetInt32(14) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Space";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Space";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Space";
                        count++;
                    }
                }

                if (reader1.GetInt32(15) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Horror";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Horror";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Horror";
                        count++;
                    }
                }

                if (reader1.GetInt32(16) == 1)
                {
                    if (count == 2)
                    {
                        category3.Text = "Survival";
                        break;
                    }
                    else if (count == 1)
                    {
                        category2.Text = "Survival";
                        count++;
                    }
                    else
                    {
                        category1.Text = "Survival";
                        count++;
                    }
                }
            }

            con.Close();

            lbGameNameBuy.Text = name;
            lbGameNameSolo.Text = name;

            pbPic1.Load(Properties.Store.ResourceManager.GetString(name + " ss1"));
            pbPic2.Load(Properties.Store.ResourceManager.GetString(name + " ss2"));
            pbPic3.Load(Properties.Store.ResourceManager.GetString(name + " ss3"));
            pbPic4.Load(Properties.Store.ResourceManager.GetString(name + " ss4"));
            pbPic5.Load(Properties.Store.ResourceManager.GetString(name + " ss5"));
            pbMainBig.Load(Properties.Store.ResourceManager.GetString(name + " ss1"));
            pbMainBig.SizeMode = PictureBoxSizeMode.StretchImage;

            object obj = Properties.Store.ResourceManager.GetObject(name);
            pbHeader.Image = (Bitmap)obj;
            pbHeader.SizeMode = PictureBoxSizeMode.StretchImage;

            pbPic1.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));
            pbPic2.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));
            pbPic3.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));
            pbPic4.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));
            pbPic5.Click += new EventHandler((sender, e) => switchimagesgame(sender, e, pbMainBig));
            btBuy.Click += new EventHandler((sender, e) => btBuy_Click(lbGameNameBuy.Text, Convert.ToInt32(lbPrice.Text)));
        }

        private void switchimagesgame(object sender, EventArgs e, PictureBox pbMain)
        {
            PictureBox nus = sender as PictureBox;
            pbMain.Image = nus.Image;
        }

        private void btBuy_Click(string name, int price)
        {
            con.Open();

            string id;
            string idquery = "select Games.Id from Games where Games.name = '" + name + "';";
            SqlCommand cmdid = new SqlCommand(idquery, con);
            SqlDataReader reader = cmdid.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
            }
            else
                id = null;
            reader.Close();


            string nume = null;
            string amdeja = "select dbo.[List of owned games].name from dbo.[List of owned games] where dbo.[List of owned games].GameID = '" + id + "' AND dbo.[List of owned games].UserId = '" + loggeduser.id + "'";
            SqlCommand cmdamdeja = new SqlCommand(amdeja, con);
            SqlDataReader reader1 = cmdamdeja.ExecuteReader();
            if (reader1.Read())
            {
                nume = reader1.GetString(0);
            }

            if (nume == null)
            {
                if (id != null)
                {
                    if (money > price)
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        DateTime dateTime = DateTime.Now;
                        var dateValue1 = dateTime.ToString("MM/dd/yyyy");
                        cmd.CommandText = "INSERT INTO dbo.[List of owned games](GameID,name,UserId,date_bought) VALUES ('" + id + "', '" + name + "', '" + loggeduser.id + "', '" + dateValue1 + "')";
                        cmd.ExecuteNonQuery();
                        int money1 = money;
                        int moneyfinal = money1 - price;

                        int owners = 0;

                        string cmdownerss = "SELECT dbo.[Games].[number bought] from Games WHERE Id = '" + id + "'";
                        SqlCommand cmdownersget = new SqlCommand(cmdownerss, con);
                        SqlDataReader readerowners = cmdownersget.ExecuteReader();
                        try
                        {
                            owners = readerowners.GetInt32(0);
                            owners = owners + 1;
                        }
                        catch (Exception ex)
                        {
                            owners = 1;
                        }

                        SqlCommand cmdowners = con.CreateCommand();
                        cmdowners.CommandType = CommandType.Text;
                        cmdowners.CommandText = "UPDATE Games Set [number bought] = '" + owners + "' WHERE Id = '" + id + "'";

                        SqlCommand cmdmoney = con.CreateCommand();
                        cmdmoney.CommandType = CommandType.Text;
                        cmdmoney.CommandText = "UPDATE Users SET money = '" + moneyfinal + "' WHERE Id = '" + loggeduser.id + "'";
                        cmdmoney.ExecuteNonQuery();
                        money = moneyfinal;

                        MessageBox.Show("Thank you for your purchase", "Purchase succesful", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("You do not have enough money to buy this game", "Insufficient funds", MessageBoxButtons.OK);
                    }
                }
            }
            else MessageBox.Show("You already own the game", "You cannot buy the game", MessageBoxButtons.OK);
            con.Close();
        }

        public static event EventHandler EndQueue;
        public static event EventHandler NextQueue;

        public void queueclick (object sender,EventArgs e)
        {
            if(Store.queuelcoation+1 == 10)
                EndQueue?.Invoke(sender, e);
            else
            {
                Store.queuelcoation++;
                NextQueue?.Invoke(sender, e);

            }
        }

        public static EventHandler category;
        public void category1_Click(object sender, EventArgs e)
        {
            category?.Invoke(sender, e);
        }

        private void category2_Click(object sender, EventArgs e)
        {
            category?.Invoke(sender, e);
        }

        private void category3_Click(object sender, EventArgs e)
        {
            category?.Invoke(sender,e);
        }
    }
}
