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
using System.IO;
using System.Text.Json;

namespace PatisserieApp
{
    public partial class UC_Products : UserControl
    {
        string imgurl = null;
        string connectionString = @"Data Source=XHOLLAND\SQLEXPRESS;Initial Catalog=PatisserieApp;Integrated Security=True";
        public UC_Products()
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
                dataGridView1.DataSource = dataTable; //UserControl eklendikten Sonra Kontrol Edilecek!

            }
        }

        //File Select -Image
        private void guna2Button6_Click(object sender, EventArgs e)

        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgurl = ofd.FileName;//Eğerki Proje Üzerine İmgUrl Kullanılabilir!
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        //File Select -Image


        //Add Method
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int x = 0;

            SqlConnection sqlCon = new SqlConnection(connectionString);

            sqlCon.Open();
            SqlCommand cmd3 = new SqlCommand("Select Id From Category Where Name Like '%" + guna2ComboBox1.Text + "%' ", sqlCon);
            SqlDataReader dr = cmd3.ExecuteReader();


            if (dr.Read())
            {
                x = Convert.ToInt32(dr[0]);
            }

            dr.Close();

            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Products (Name,Price,StockQuantity,Description,Image,CategoryId) VALUES (@Name,@Price,@StockQuantity,@Description,@Image,@CategoryId)", sqlCon);
            cmd1.Parameters.AddWithValue("@Name", guna2TextBox1.Text);
            cmd1.Parameters.AddWithValue("@Price", guna2TextBox2.Text);
            cmd1.Parameters.AddWithValue("@StockQuantity", guna2TextBox3.Text);
            cmd1.Parameters.AddWithValue("@Description", guna2TextBox5.Text);

            cmd1.Parameters.AddWithValue("@Image", arr);
            cmd1.Parameters.AddWithValue("@CategoryId", value: x);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Product Saved!");

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Products", sqlCon);
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd2.ExecuteReader());
            dataGridView1.DataSource = dataTable;
            sqlCon.Close();

        }


        private void UC_Products_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand sqlquery = new SqlCommand("select Name from Category", sqlCon);
            SqlDataReader reader = sqlquery.ExecuteReader();
            while (reader.Read())
            {
                guna2ComboBox1.Items.Add(reader[0]);
            }
            reader.Close();
        }
        //Add Method



        //Update Method
        public void display_data()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlCon.Close();
        }
        //Update Method



        //Delete Method
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Products where name = '" + guna2TextBox1.Text + "'";
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            display_data();

            MessageBox.Show("Record Deleted Seccesfull");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == String.Empty)
            {
                MessageBox.Show("Check data entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x = 0;

                SqlConnection sqlCon = new SqlConnection(connectionString);

                sqlCon.Open();
                SqlCommand cmd3 = new SqlCommand("Select Id From Category Where Name Like '%" + guna2ComboBox1.Text + "%' ", sqlCon);
                SqlDataReader dr = cmd3.ExecuteReader();


                if (dr.Read())
                {
                    x = Convert.ToInt32(dr[0]);
                }

                dr.Close();

                Image img = pictureBox1.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                SqlCommand cmd = new SqlCommand("UPDATE Products SET Name = @Name, Price = @Price, StockQuantity = @StockQuantity, Description = @Description,Image = @Image,CategoryId = @CategoryId Where Id = @Id", sqlCon);
                cmd.Parameters.AddWithValue("@Name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@Price", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@StockQuantity", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@Description", guna2TextBox5.Text);

                cmd.Parameters.AddWithValue("@Image", arr);
                cmd.Parameters.AddWithValue("@CategoryId", value:x);

                cmd.Parameters.AddWithValue("@Id", guna2TextBox4.Text);
                cmd.ExecuteNonQuery();

                //Update Yapacak İseniz Bütün Girdilerin Girişi Sağlanması Gerekli, İnvalid giriş sağlamayın

                sqlCon.Close();
                MessageBox.Show("Record Update Seccesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Delete Method

    }
}
