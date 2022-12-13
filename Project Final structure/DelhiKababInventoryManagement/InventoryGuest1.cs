using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelhiKababInventoryManagement
{
    public partial class InventoryGuest1 : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        public InventoryGuest1()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection


            SqlCommand cmd = new SqlCommand("SELECT ItemName, ExpirationDate, StorageName FROM Item WHERE DATEDIFF(DAY,ExpirationDate,GETDATE()) >1", conn);

            // cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));
            da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
            dt = new DataTable(); //Data table
            da.Fill(dt); //Data Adapter
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection


            SqlCommand cmd = new SqlCommand("SELECT ItemName, StorageName, Quantity FROM Item WHERE (Category = 'Vegetables' AND Quantity <=10) OR (Category = 'General' AND Quantity <=5) OR (Category = 'Fruits' AND Quantity <=4)", conn);

            // cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));
            da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
            dt = new DataTable(); //Data table
            da.Fill(dt); //Data Adapter
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
    }
}
