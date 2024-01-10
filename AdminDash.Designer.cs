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
            this.transactionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageMembershipBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.salesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sales1 = new BisleriumCafe.Admin.Sales();
            this.transactionHistory11 = new BisleriumCafe.Staff.TransactionHistory();
            this.reports11 = new BisleriumCafe.Admin.Reports();
            this.manageMembership1 = new BisleriumCafe.Admin.ManageMembership();
            this.manageProduct1 = new BisleriumCafe.Admin.ManageProduct();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.panel2.Controls.Add(this.salesBtn);
            this.panel2.Controls.Add(this.transactionBtn);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.manageMembershipBtn);
            this.panel2.Controls.Add(this.manageProductBtn);
            this.panel2.Location = new System.Drawing.Point(13, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 581);
            this.panel2.TabIndex = 0;
            // 
            // transactionBtn
            // 
            this.transactionBtn.Animated = true;
            this.transactionBtn.BorderRadius = 5;
            this.transactionBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.transactionBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.transactionBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.transactionBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.transactionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionBtn.FillColor = System.Drawing.Color.White;
            this.transactionBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transactionBtn.ForeColor = System.Drawing.Color.Black;
            this.transactionBtn.Image = ((System.Drawing.Image)(resources.GetObject("transactionBtn.Image")));
            this.transactionBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.transactionBtn.Location = new System.Drawing.Point(0, 135);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(221, 45);
            this.transactionBtn.TabIndex = 7;
            this.transactionBtn.Text = "Transactions";
            this.transactionBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(0, 90);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(221, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Reports";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Animated = true;
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
            this.manageMembershipBtn.Animated = true;
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
            this.manageMembershipBtn.Location = new System.Drawing.Point(0, 45);
            this.manageMembershipBtn.Name = "manageMembershipBtn";
            this.manageMembershipBtn.Size = new System.Drawing.Size(221, 45);
            this.manageMembershipBtn.TabIndex = 4;
            this.manageMembershipBtn.Text = "Manage Membership";
            this.manageMembershipBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageMembershipBtn.Click += new System.EventHandler(this.manageMembershipBtn_Click);
            // 
            // manageProductBtn
            // 
            this.manageProductBtn.Animated = true;
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
            this.mainPanel.Controls.Add(this.sales1);
            this.mainPanel.Controls.Add(this.transactionHistory11);
            this.mainPanel.Controls.Add(this.reports11);
            this.mainPanel.Controls.Add(this.guna2Panel1);
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
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(953, 49);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(354, 9);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(279, 30);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Bislerium Cafe | POS SYSTEM";
            // 
            // salesBtn
            // 
            this.salesBtn.Animated = true;
            this.salesBtn.BorderRadius = 5;
            this.salesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesBtn.FillColor = System.Drawing.Color.White;
            this.salesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salesBtn.ForeColor = System.Drawing.Color.Black;
            this.salesBtn.Image = ((System.Drawing.Image)(resources.GetObject("salesBtn.Image")));
            this.salesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.salesBtn.Location = new System.Drawing.Point(0, 180);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(221, 45);
            this.salesBtn.TabIndex = 8;
            this.salesBtn.Text = "Sales";
            this.salesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // sales1
            // 
            this.sales1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sales1.Location = new System.Drawing.Point(11, 73);
            this.sales1.Name = "sales1";
            this.sales1.Size = new System.Drawing.Size(930, 715);
            this.sales1.TabIndex = 8;
            // 
            // transactionHistory11
            // 
            this.transactionHistory11.Location = new System.Drawing.Point(11, 73);
            this.transactionHistory11.Name = "transactionHistory11";
            this.transactionHistory11.Size = new System.Drawing.Size(930, 715);
            this.transactionHistory11.TabIndex = 7;
            // 
            // reports11
            // 
            this.reports11.Location = new System.Drawing.Point(11, 73);
            this.reports11.Name = "reports11";
            this.reports11.Size = new System.Drawing.Size(930, 715);
            this.reports11.TabIndex = 6;
            // 
            // manageMembership1
            // 
            this.manageMembership1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manageMembership1.Location = new System.Drawing.Point(0, 73);
            this.manageMembership1.Name = "manageMembership1";
            this.manageMembership1.Size = new System.Drawing.Size(953, 715);
            this.manageMembership1.TabIndex = 2;
            // 
            // manageProduct1
            // 
            this.manageProduct1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button manageProductBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button manageMembershipBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private Admin.ManageMembership manageMembership1;
        private Admin.ManageProduct manageProduct1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Admin.Reports reports11;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button transactionBtn;
        private Staff.TransactionHistory transactionHistory11;
        private Guna.UI2.WinForms.Guna2Button salesBtn;
        private Admin.Sales sales1;
    }
}

