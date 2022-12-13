using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelhiKababInventoryManagement
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcomeForm = new WelcomeForm();

            welcomeForm.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminMainMenu = new AdminMainPanel();
            adminMainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminMainMenu = new AdminMainPanel();
            adminMainMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminMainMenu = new AdminMainPanel();
            adminMainMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminMainMenu = new AdminMainPanel();
            adminMainMenu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminMainMenu = new AdminMainPanel();
            adminMainMenu.Show();
        }
    }
}
