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
    public partial class AccountSetting : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        public AccountSetting()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection


            SqlCommand cmd = new SqlCommand("SELECT * FROM AdminUser", conn);

            // cmd.Parameters.AddWithValue("ID", int.Parse(SearchTxt.Text));
            da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
            dt = new DataTable(); //Data table
            da.Fill(dt); //Data Adapter
            dataGridView1.DataSource = dt;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(dt); // updating the record
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
