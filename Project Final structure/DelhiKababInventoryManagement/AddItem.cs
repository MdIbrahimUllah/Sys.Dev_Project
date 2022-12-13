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
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace DelhiKababInventoryManagement
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void textBox2_TextChanged(object sender, EventArgs e)

        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide(); //add item page will hide
           // var adminMainPanel = new AdminMainPanel();
           // adminMainPanel.Show(); // admin main page will be displayed

        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

                conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Item VALUES (@ItemName, @StorageName, @Category, @Brand, @StoreName, @Quantity, @ExpirationDate, @Price)", conn);

                cmd.Parameters.AddWithValue("@ItemName", ItemNameTxt.Text);
                cmd.Parameters.AddWithValue("@StorageName", StorageNameTxt.Text);
                cmd.Parameters.AddWithValue("@Category", CategoryTxt.Text);
                cmd.Parameters.AddWithValue("@Brand", BrandTxt.Text);
                cmd.Parameters.AddWithValue("@StoreName", StoreNameTxt.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(QuantityTxt.Text));
                cmd.Parameters.AddWithValue("@ExpirationDate", DateTime.Parse(ExpirationDateTxt.Text));
                cmd.Parameters.AddWithValue("@Price", SqlMoney.Parse(PriceTxt.Text));

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Data has been added successfully");
        }
    }
}
