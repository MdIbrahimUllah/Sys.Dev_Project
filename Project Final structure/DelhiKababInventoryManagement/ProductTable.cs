using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelhiKababInventoryManagement
{
    public partial class ProductTable : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        
        public ProductTable()
        {
            InitializeComponent();
        }

        private void productgrid_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            var additem = new AddItem();
            additem.Show(); // item added page will display

        }

        private void SearchButton_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an item number");
            }

        }

        private void Edit_Click(object sender, EventArgs e)
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

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(dt); // updating the record
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
    }
}
