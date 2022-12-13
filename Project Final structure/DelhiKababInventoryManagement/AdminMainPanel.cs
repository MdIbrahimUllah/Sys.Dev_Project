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
    public partial class AdminMainPanel : Form
    {
        public AdminMainPanel()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Load(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

            Panel pnlContent = new Panel();
            var setting = new AccountSetting();
            setting.TopLevel = false;
            panelContent.Controls.Add(setting);
            setting.BringToFront();
            setting.Show();
            panelcolor.Height = iconButton5.Height;
            panelcolor.Top = iconButton5.Top;
            lblTitleChildForm.Text = "User Account";
            productbox.Visible = false;
            inventorybox.Visible = false;
            supplierbox.Visible = false;
            orderlistbox.Visible = false;
            useraccountbox.Visible = true;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcomeForm = new WelcomeForm();

            welcomeForm.Show();
        }

        private void AdminMainPanel_Load(object sender, EventArgs e)
        {

        }

        //product icon for admin
        private void iconButton1_Click(object sender, EventArgs e)
        {
           // product table will be displayed

            Panel pnlContent = new Panel();
            var productTable=new ProductTable();
            productTable.TopLevel = false;
            panelContent.Controls.Add(productTable);
            productTable.BringToFront();
            productTable.Show();

            panelcolor.Height=iconButton1.Height;
            panelcolor.Top = iconButton1.Top;
            lblTitleChildForm.Text = "Product";
            productbox.Visible = true;
            inventorybox.Visible =false;
           supplierbox.Visible = false;
            orderlistbox.Visible = false;
           useraccountbox.Visible = false;
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Panel pnlContent = new Panel();
            var inventory = new Inventory();
            inventory.TopLevel = false;
            panelContent.Controls.Add(inventory);
            inventory.BringToFront();
            inventory.Show();

            panelcolor.Height = iconButton2.Height;
            panelcolor.Top = iconButton2.Top;
            lblTitleChildForm.Text = "Inventory";
            productbox.Visible = false;
            inventorybox.Visible = true;
            supplierbox.Visible = false;
            orderlistbox.Visible = false;
            useraccountbox.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Panel pnlContent = new Panel();
            var supplier = new Supplier();
            supplier.TopLevel = false;
            panelContent.Controls.Add(supplier);
            supplier.BringToFront();
            supplier.Show();
            panelcolor.Height = iconButton3.Height;
            panelcolor.Top = iconButton3.Top;
            lblTitleChildForm.Text = "Supplier";
            productbox.Visible = false;
            inventorybox.Visible = false;
            supplierbox.Visible = true;
            orderlistbox.Visible = false;
            useraccountbox.Visible = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            Panel pnlContent = new Panel();
            var order = new Order();
            order.TopLevel = false;
            panelContent.Controls.Add(order);
            order.BringToFront();
           order.Show();

            panelcolor.Height = iconButton4.Height;
            panelcolor.Top = iconButton4.Top;
            lblTitleChildForm.Text = "Order List";
            productbox.Visible = false;
            inventorybox.Visible = false;
            supplierbox.Visible = false;
            orderlistbox.Visible = true;
            useraccountbox.Visible = false;
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
