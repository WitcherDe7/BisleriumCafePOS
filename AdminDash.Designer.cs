namespace BisleriumCafe
{
    partial class AdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageMembershipBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reportsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.reports1 = new BisleriumCafe.Admin.Reports();
            this.manageMembership1 = new BisleriumCafe.Admin.ManageMembership();
            this.manageProduct1 = new BisleriumCafe.Admin.ManageProduct();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 800);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(86, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.manageMembershipBtn);
            this.panel2.Controls.Add(this.reportsBtn);
            this.panel2.Controls.Add(this.manageProductBtn);
            this.panel2.Location = new System.Drawing.Point(13, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 581);
            this.panel2.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BorderRadius = 5;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FillColor = System.Drawing.Color.White;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.Location = new System.Drawing.Point(0, 536);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(221, 45);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // manageMembershipBtn
            // 
            this.manageMembershipBtn.BorderRadius = 5;
            this.manageMembershipBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageMembershipBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageMembershipBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageMembershipBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageMembershipBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageMembershipBtn.FillColor = System.Drawing.Color.White;
            this.manageMembershipBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manageMembershipBtn.ForeColor = System.Drawing.Color.Black;
            this.manageMembershipBtn.Image = ((System.Drawing.Image)(resources.GetObject("manageMembershipBtn.Image")));
            this.manageMembershipBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageMembershipBtn.Location = new System.Drawing.Point(0, 90);
            this.manageMembershipBtn.Name = "manageMembershipBtn";
            this.manageMembershipBtn.Size = new System.Drawing.Size(221, 45);
            this.manageMembershipBtn.TabIndex = 4;
            this.manageMembershipBtn.Text = "Manage Membership";
            this.manageMembershipBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageMembershipBtn.Click += new System.EventHandler(this.manageMembershipBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.BorderRadius = 5;
            this.reportsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.FillColor = System.Drawing.Color.White;
            this.reportsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportsBtn.ForeColor = System.Drawing.Color.Black;
            this.reportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportsBtn.Image")));
            this.reportsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportsBtn.Location = new System.Drawing.Point(0, 45);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(221, 45);
            this.reportsBtn.TabIndex = 3;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // manageProductBtn
            // 
            this.manageProductBtn.BorderRadius = 5;
            this.manageProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageProductBtn.FillColor = System.Drawing.Color.Transparent;
            this.manageProductBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manageProductBtn.ForeColor = System.Drawing.Color.Black;
            this.manageProductBtn.Image = ((System.Drawing.Image)(resources.GetObject("manageProductBtn.Image")));
            this.manageProductBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageProductBtn.Location = new System.Drawing.Point(0, 0);
            this.manageProductBtn.Name = "manageProductBtn";
            this.manageProductBtn.Size = new System.Drawing.Size(221, 45);
            this.manageProductBtn.TabIndex = 0;
            this.manageProductBtn.Text = "Manage Product";
            this.manageProductBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageProductBtn.Click += new System.EventHandler(this.manageProductBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.guna2Panel1);
            this.mainPanel.Controls.Add(this.reports1);
            this.mainPanel.Controls.Add(this.manageMembership1);
            this.mainPanel.Controls.Add(this.manageProduct1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(247, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(953, 800);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(953, 49);
            this.guna2Panel1.TabIndex = 5;
            // 
            // reports1
            // 
            this.reports1.Location = new System.Drawing.Point(0, 73);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(953, 715);
            this.reports1.TabIndex = 4;
            // 
            // manageMembership1
            // 
            this.manageMembership1.Location = new System.Drawing.Point(0, 73);
            this.manageMembership1.Name = "manageMembership1";
            this.manageMembership1.Size = new System.Drawing.Size(953, 715);
            this.manageMembership1.TabIndex = 2;
            // 
            // manageProduct1
            // 
            this.manageProduct1.Location = new System.Drawing.Point(0, 73);
            this.manageProduct1.Name = "manageProduct1";
            this.manageProduct1.Size = new System.Drawing.Size(953, 715);
            this.manageProduct1.TabIndex = 0;
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button manageProductBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button manageMembershipBtn;
        private Guna.UI2.WinForms.Guna2Button reportsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private Admin.Reports reports1;
        private Admin.ManageMembership manageMembership1;
        private Admin.ManageProduct manageProduct1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

