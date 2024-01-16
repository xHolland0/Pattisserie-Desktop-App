namespace PatisserieApp
{
    partial class AdminScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(230, 177, 37);
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel4);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(242, 649);
            Sidebar.MinimumSize = new Size(79, 649);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(242, 649);
            Sidebar.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.Menu;
            menuButton.Location = new Point(16, 20);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(41, 45);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(219, 54);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 177, 37);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.Database;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-15, -6);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(242, 68);
            button1.TabIndex = 2;
            button1.Text = "              Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 169);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(219, 54);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 177, 37);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.Product;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-15, -6);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(245, 68);
            button2.TabIndex = 2;
            button2.Text = "              Products";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 229);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(209, 54);
            panel4.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 177, 37);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.Category;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-23, -5);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(241, 68);
            button3.TabIndex = 2;
            button3.Text = "                Categories";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(245, 47);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(730, 590);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.Cursor = Cursors.Hand;
            guna2ControlBox2.CustomizableEdges = customizableEdges3;
            guna2ControlBox2.FillColor = Color.FromArgb(230, 177, 37);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(873, 12);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox2.Size = new Size(45, 29);
            guna2ControlBox2.TabIndex = 4;
            // 
            // guna2ControlBox3
            // 
            guna2ControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox3.Cursor = Cursors.Hand;
            guna2ControlBox3.CustomizableEdges = customizableEdges5;
            guna2ControlBox3.FillColor = Color.FromArgb(230, 177, 37);
            guna2ControlBox3.IconColor = Color.White;
            guna2ControlBox3.Location = new Point(938, 12);
            guna2ControlBox3.Name = "guna2ControlBox3";
            guna2ControlBox3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox3.Size = new Size(45, 29);
            guna2ControlBox3.TabIndex = 3;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 649);
            Controls.Add(guna2ControlBox3);
            Controls.Add(guna2ControlBox2);
            Controls.Add(guna2Panel1);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminScreen";
            Text = "AdminScreen";
            Load += AdminScreen_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Label label1;
        private PictureBox menuButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Timer SidebarTimer;
        private RichTextBox richTextBox1;
    }
}