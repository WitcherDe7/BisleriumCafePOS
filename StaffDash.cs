using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisleriumCafe
{
    public partial class StaffDash : Form
    {
        public StaffDash()
        {
            InitializeComponent();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            takeOrder1.Show();
            dailyReport1.Hide();
            transactionHistory1.Hide();
        }

        private void takeOrderBtn_Click(object sender, EventArgs e)
        {
            takeOrder1.Show();
            dailyReport1.Hide();
            transactionHistory1.Hide();
        }

        private void TransactionHistoryBtn_Click(object sender, EventArgs e)
        {
            transactionHistory1.Show();
            dailyReport1.Hide();
            takeOrder1.Hide();

        }

        private void dailyReportBtn_Click(object sender, EventArgs e)
        {
            dailyReport1.Show();
            transactionHistory1.Hide();
            takeOrder1.Hide();
            
        }

        private void logoutBtnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
