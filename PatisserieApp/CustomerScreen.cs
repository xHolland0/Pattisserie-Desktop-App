using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;

namespace PatisserieApp
{
    public partial class CustomerScreen : Form
    {
        int total = 0;
        
        string connectionString = @"Data Source=XHOLLAND\SQLEXPRESS;Initial Catalog=PatisserieApp;Integrated Security=True";
        private PictureBox ProductpictureBox;
        private Label ProductName, ProductPrice, pp;


        public CustomerScreen()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            Set_Data();
        }

        public void Set_Data()
        {
            SqlConnection SqlCon = new SqlConnection(connectionString);
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand("Select Image,Name,Price From Products" , SqlCon);
            SqlDataReader dr = cmd.ExecuteReader();  

            while (dr.Read())
            {
                long len = dr.GetBytes(0,0,null,0,0);
                byte[] array = new byte[System.Convert.ToInt32(len)+1];
                dr.GetBytes(0, 0, array,0, System.Convert.ToInt32(len));
                ProductpictureBox = new PictureBox();

                ProductpictureBox.Width=105;
                ProductpictureBox.Height = 160;

                ProductpictureBox.BackgroundImageLayout=ImageLayout.Stretch;
                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                ProductpictureBox.BackgroundImage = bitmap;
                ProductpictureBox.Cursor = Cursors.Hand;

                ProductPrice = new Label();
                ProductPrice.Text = dr["Price"] + "$".ToString();
                ProductPrice.BackColor = Color.Transparent;
                ProductPrice.ForeColor = Color.Black;
                ProductPrice.Font = new Font(ProductPrice.Font.FontFamily , 15, FontStyle.Bold);
                ProductPrice.Dock = DockStyle.Top;
                ProductPrice.TextAlign = ContentAlignment.MiddleLeft;


                pp = new Label();
                pp.Text = dr["Price"].ToString();
                pp.Dock = DockStyle.Fill;
                pp.ForeColor = Color.Transparent;
                pp.BackColor = Color.Transparent;

                ProductName = new Label();
                ProductName.Text = dr["Name"].ToString();
                ProductName.BackColor = Color.FromArgb(150,0,0,0);
                ProductName.ForeColor = Color.White;
                ProductName.Font = new Font(ProductPrice.Font.FontFamily, 13, FontStyle.Bold);
                ProductName.Dock = DockStyle.Bottom;
                ProductName.TextAlign = ContentAlignment.TopCenter;

                ProductpictureBox.Controls.Add(ProductPrice);
                ProductpictureBox.Controls.Add(ProductName);
                ProductpictureBox.Controls.Add(pp);

                flowLayoutPanel1.Controls.Add(ProductpictureBox);


                pp.Click += Pp_Click;                     

            }
        }

        private void Pp_Click(object? sender, EventArgs e)
        {
            int a = Convert.ToInt16(pp.Text);
            total += a;
            label2.Text=total+"$".ToString();
        }
    }
}
