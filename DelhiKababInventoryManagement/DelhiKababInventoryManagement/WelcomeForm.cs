namespace DelhiKababInventoryManagement
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
         
            login.Show();
            
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var guestMenu = new GuestMenu();
            guestMenu.Show();

        }
    }
}