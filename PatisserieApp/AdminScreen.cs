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
    public partial class AdminScreen : Form
    {
        string connectionString = @"Data Source=XHOLLAND\SQLEXPRESS;Initial Catalog=PatisserieApp;Integrated Security=True";
        bool sidebarExpand;
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //Set the minimum and maximum size of sidebar panel
            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();

                }
            }

            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //Set Timer Interval To Lowest To Make It Smoother
            SidebarTimer.Start();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            AddUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Products uc = new UC_Products();
            AddUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Categories uc = new UC_Categories();
            AddUserControl(uc);
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }
    }
}