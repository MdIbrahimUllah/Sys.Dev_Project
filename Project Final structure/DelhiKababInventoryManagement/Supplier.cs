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
    public partial class Supplier : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection


            SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier", conn);

            // cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));
            da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
            dt = new DataTable(); //Data table
            da.Fill(dt); //Data Adapter
            dataGridView1.DataSource = dt;

        }

        private void Search_Click(object sender, EventArgs e)
        {
            // searching data from database
            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier WHERE SupplierNumber = @ID", conn);


                cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));



                SqlDataAdapter da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an item number");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(dt); // updating the record
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
