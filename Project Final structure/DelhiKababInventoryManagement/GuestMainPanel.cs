using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace DelhiKababInventoryManagement
{
    public partial class GuestMainPanel : Form
    {
        public GuestMainPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Panel pnlContent = new Panel();
            var productGuest = new ProductGuest();
            productGuest.TopLevel = false;
            panelcontent.Controls.Add(productGuest);
            productGuest.BringToFront();
            productGuest.Show();

            panel4.Height = iconButton1.Height;
            panel4.Top = iconButton1.Top;
            lblTitleChildForm.Text = "Product";
            productbox.Visible = true;
            inventorybox.Visible = false;
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Panel pnlContent = new Panel();
            var inventory = new InventoryGuest1();
            inventory.TopLevel = false;
            panelcontent.Controls.Add(inventory);
            inventory.BringToFront();
            inventory.Show();


            panel4.Height = iconButton2.Height;
            panel4.Top = iconButton2.Top;
            lblTitleChildForm.Text = "Inventory";
            productbox.Visible = false;
            inventorybox.Visible = true;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcomeForm = new WelcomeForm();

            welcomeForm.Show();
        }
    }
}
