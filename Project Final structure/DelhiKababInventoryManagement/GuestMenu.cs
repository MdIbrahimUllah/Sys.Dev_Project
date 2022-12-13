using FontAwesome.Sharp;
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
    public partial class GuestMenu : Form
    {
        public GuestMenu()
        {
            InitializeComponent();
        }

        private void GuestMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcomeForm = new WelcomeForm();

            welcomeForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var panel=new Panel();  
            this.Hide();
            var guestMainPanel = new GuestMainPanel();
            guestMainPanel.Show();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var panel = new Panel();
            this.Hide();
            var guestMainPanel = new GuestMainPanel();
            guestMainPanel.Show();
        }
    }
}
