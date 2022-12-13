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
    public partial class ProductGuest : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        public ProductGuest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection


            SqlCommand cmd = new SqlCommand("SELECT * FROM Item", conn);

            // cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));
            da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
            dt = new DataTable(); //Data table
            da.Fill(dt); //Data Adapter
            dataGridView1.DataSource = dt;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // searching data from database
            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Item WHERE ItemNumber = @ID", conn);


                cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));

                SqlDataAdapter da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show("Please enter an item number");
            }

        }
    }
}
