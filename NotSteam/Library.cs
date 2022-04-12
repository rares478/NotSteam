using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotSteam
{
    public partial class Library : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iovit\Documents\notsteam.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true");
        public Library()
        {
            InitializeComponent();
        }

        private void lbAfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lbAfis.GetItemText(lbAfis.SelectedItem);
            int id = 0;
            con.Open();
            string devquery = "select id from Games where name = '" + name + "'";
            SqlCommand cmddev = new SqlCommand(devquery, con);
            SqlDataReader readerdev = cmddev.ExecuteReader();
            if (readerdev.Read())
            {
                id = readerdev.GetInt32(0);
            }

            string lastquery = "select [last played],[date_bought] from [dbo].[List of owned games] WHERE (UserId = '" + userid + "'and GameID = '" + id + "')";
            SqlCommand sqllastquery = new SqlCommand(lastquery, con);
            SqlDataReader readerlast = sqllastquery.ExecuteReader();
            if (readerlast.Read())
            {
                if (readerlast.IsDBNull(0))
                    lbLastPlayed.Text = "never played";
                else
                    lbLastPlayed.Text = readerlast.GetDateTime(0).ToString("MM/dd/yyyy");
                lbDateBought.Text = readerlast.GetDateTime(1).ToString("MM/dd/yyyy");
            }

            if (id >= imageList1.Images.Count)
                id = 0;
            pbAfis.Image = imageList1.Images[id];
            con.Close();
        }
    }
    }
}
