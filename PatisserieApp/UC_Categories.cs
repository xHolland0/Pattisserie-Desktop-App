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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatisserieApp
{
    public partial class UC_Categories : UserControl
    {
        string connectionString = @"Data Source=XHOLLAND\SQLEXPRESS;Initial Catalog=PatisserieApp;Integrated Security=True";
        public UC_Categories()
        {
            InitializeComponent();
        }


        //Home
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Category", sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Method 1 - direct 
                dataGridView1.DataSource = dataTable; //UserControl ekllendikten Sonra Kontro Edilecek!

            }

        }


        //Add Method
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            bool Warn = false;

            if (guna2TextBox1.Text == string.Empty)
            {
                Warn = true;
            }

            if (Warn == true)
            {
                MessageBox.Show("Check data entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);

                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Category values('" + guna2TextBox1.Text + "')";
                cmd.ExecuteNonQuery();
                sqlCon.Close();

                display_data();

                MessageBox.Show("Record Inserted Seccesfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        //Update Method
        public void display_data()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Category";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlCon.Close();
        }


        //Delete Method
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            bool Warn = false;

            if (guna2TextBox1.Text == string.Empty)
            {
                Warn = true;
            }

            if (Warn == true)
            {
                MessageBox.Show("Check data entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);

                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Category where name = '" + guna2TextBox1.Text + "'";
                cmd.ExecuteNonQuery();
                sqlCon.Close();

                display_data();

                MessageBox.Show("Record Delete Seccesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == String.Empty)
            {
                MessageBox.Show("Check data entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();


                SqlCommand cmd = new SqlCommand("UPDATE Category SET Name = @Name Where Id = @Id", sqlCon);
                cmd.Parameters.AddWithValue("@Name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@Id", guna2TextBox2.Text);
                cmd.ExecuteNonQuery();

                sqlCon.Close();
                MessageBox.Show("Record Update Seccesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_Categories_Load(object sender, EventArgs e)
        {

        }
    }
}
