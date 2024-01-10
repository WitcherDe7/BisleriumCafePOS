namespace BisleriumCafe
{
    partial class StaffDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDash));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutBtnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.dailyReportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TransactionHistoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.takeOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.takeOrder1 = new BisleriumCafe.Staff.checkoutBtn();
            this.transactionHistory1 = new BisleriumCafe.Staff.TransactionHistory();
            this.dailyReport1 = new BisleriumCafe.Staff.DailyReport();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dailyReport1);
            this.mainPanel.Controls.Add(this.transactionHistory1);
            this.mainPanel.Controls.Add(this.takeOrder1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(247, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(953, 800);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(94, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff";
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logoutBtnStaff);
            this.panel2.Controls.Add(this.dailyReportBtn);
            this.panel2.Controls.Add(this.TransactionHistoryBtn);
            this.panel2.Controls.Add(this.takeOrderBtn);
            this.panel2.Location = new System.Drawing.Point(13, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 581);
            this.panel2.TabIndex = 0;
            // 
            // logoutBtnStaff
            // 
            this.logoutBtnStaff.BorderRadius = 5;
            this.logoutBtnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtnStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtnStaff.FillColor = System.Drawing.Color.White;
            this.logoutBtnStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutBtnStaff.ForeColor = System.Drawing.Color.Black;
            this.logoutBtnStaff.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtnStaff.Image")));
            this.logoutBtnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtnStaff.Location = new System.Drawing.Point(0, 536);
            this.logoutBtnStaff.Name = "logoutBtnStaff";
            this.logoutBtnStaff.Size = new System.Drawing.Size(221, 45);
            this.logoutBtnStaff.TabIndex = 5;
            this.logoutBtnStaff.Text = "Logout";
            this.logoutBtnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtnStaff.Click += new System.EventHandler(this.logoutBtnStaff_Click);
            // 
            // dailyReportBtn
            // 
            this.dailyReportBtn.BorderRadius = 5;
            this.dailyReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dailyReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dailyReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dailyReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dailyReportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dailyReportBtn.FillColor = System.Drawing.Color.White;
            this.dailyReportBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dailyReportBtn.ForeColor = System.Drawing.Color.Black;
            this.dailyReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("dailyReportBtn.Image")));
            this.dailyReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dailyReportBtn.Location = new System.Drawing.Point(0, 90);
            this.dailyReportBtn.Name = "dailyReportBtn";
            this.dailyReportBtn.Size = new System.Drawing.Size(221, 45);
            this.dailyReportBtn.TabIndex = 2;
            this.dailyReportBtn.Text = "Daily Report";
            this.dailyReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dailyReportBtn.Click += new System.EventHandler(this.dailyReportBtn_Click);
            // 
            // TransactionHistoryBtn
            // 
            this.TransactionHistoryBtn.BorderRadius = 5;
            this.TransactionHistoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TransactionHistoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TransactionHistoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TransactionHistoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TransactionHistoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionHistoryBtn.FillColor = System.Drawing.Color.White;
            this.TransactionHistoryBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TransactionHistoryBtn.ForeColor = System.Drawing.Color.Black;
            this.TransactionHistoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransactionHistoryBtn.Image")));
            this.TransactionHistoryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TransactionHistoryBtn.Location = new System.Drawing.Point(0, 45);
            this.TransactionHistoryBtn.Name = "TransactionHistoryBtn";
            this.TransactionHistoryBtn.Size = new System.Drawing.Size(221, 45);
            this.TransactionHistoryBtn.TabIndex = 1;
            this.TransactionHistoryBtn.Text = "Transaction History";
            this.TransactionHistoryBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TransactionHistoryBtn.Click += new System.EventHandler(this.TransactionHistoryBtn_Click);
            // 
            // takeOrderBtn
            // 
            this.takeOrderBtn.BorderRadius = 5;
            this.takeOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.takeOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.takeOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.takeOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.takeOrderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.takeOrderBtn.FillColor = System.Drawing.Color.White;
            this.takeOrderBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.takeOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.takeOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("takeOrderBtn.Image")));
            this.takeOrderBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.takeOrderBtn.Location = new System.Drawing.Point(0, 0);
            this.takeOrderBtn.Name = "takeOrderBtn";
            this.takeOrderBtn.Size = new System.Drawing.Size(221, 45);
            this.takeOrderBtn.TabIndex = 0;
            this.takeOrderBtn.Text = "Take Order";
            this.takeOrderBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.takeOrderBtn.Click += new System.EventHandler(this.takeOrderBtn_Click);
            // 
            // takeOrder1
            // 
            this.takeOrder1.Location = new System.Drawing.Point(0, 73);
            this.takeOrder1.Name = "takeOrder1";
            this.takeOrder1.Size = new System.Drawing.Size(950, 715);
            this.takeOrder1.TabIndex = 0;
            // 
            // transactionHistory1
            // 
            this.transactionHistory1.Location = new System.Drawing.Point(0, 73);
            this.transactionHistory1.Name = "transactionHistory1";
            this.transactionHistory1.Size = new System.Drawing.Size(950, 715);
            this.transactionHistory1.TabIndex = 1;
            // 
            // dailyReport1
            // 
            this.dailyReport1.Location = new System.Drawing.Point(0, 73);
            this.dailyReport1.Name = "dailyReport1";
            this.dailyReport1.Size = new System.Drawing.Size(950, 715);
            this.dailyReport1.TabIndex = 2;
            // 
            // StaffDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDash";
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button logoutBtnStaff;
        private Guna.UI2.WinForms.Guna2Button dailyReportBtn;
        private Guna.UI2.WinForms.Guna2Button TransactionHistoryBtn;
        private Guna.UI2.WinForms.Guna2Button takeOrderBtn;
        private Staff.DailyReport dailyReport1;
        private Staff.TransactionHistory transactionHistory1;
        private Staff.checkoutBtn takeOrder1;
    }
}