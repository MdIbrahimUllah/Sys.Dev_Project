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
    public partial class Login : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcomeForm = new WelcomeForm();

            welcomeForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String ConnectionString = "Data Source=DESKTOP-52K1VBD\\SQLEXPRESS;Initial Catalog=DelhiKabab;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open(); //open the sql connection


            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM AdminUser WHERE UserName = '" + UserNameTxt.Text +"' AND UserPassword = '" + PasswordTxt.Text + " ' ", conn);
            dt = new DataTable(); //Data table

            da = new SqlDataAdapter(cmd); //creating an object of data adapter for grid view
            
            da.Fill(dt); //Data Adapter

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();AdminMainPanel admin = new AdminMainPanel();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
