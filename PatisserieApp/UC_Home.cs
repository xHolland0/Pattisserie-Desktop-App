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

namespace PatisserieApp
{
    public partial class UC_Home : UserControl
    {
        string connectionString = @"Data Source=XHOLLAND\SQLEXPRESS;Initial Catalog=PatisserieApp;Integrated Security=True";
        public UC_Home()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Products", sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Method 1 - direct 
                dataGridView1.DataSource = dataTable; //UserControl ekllendikten Sonra Kontro Edilecek!

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Category", sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Method 1 - direct 
                dataGridView2.DataSource = dataTable;

            }
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
