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
    public partial class Order : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        public Order()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {


            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection


            SqlCommand cmd = new SqlCommand("SELECT ItemName, Quantity FROM Item", conn);

            // cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));
            da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
            dt = new DataTable(); //Data table
            da.Fill(dt); //Data Adapter
            dataGridView1.DataSource = dt;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Update(dt); // updating the record
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the item name and quantity");    
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
