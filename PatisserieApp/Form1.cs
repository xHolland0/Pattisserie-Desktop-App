namespace PatisserieApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();

            MessageBox.Show("Customer Login Succes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            if (username == "Admin" && password == "Admin123")
            {
                Visible = false;
                AdminScreen adminscreen = new AdminScreen();
                adminscreen.Show();

                MessageBox.Show("Admin Login Succes");
                MessageBox.Show("Admin Login Succes","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error Username Or Password Is Wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}