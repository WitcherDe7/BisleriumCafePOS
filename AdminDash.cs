using BisleriumCafe.Admin;
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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            manageMembership1.Hide();
            manageProduct1.Show();
            reports1.Hide();
        }
        private void manageProductBtn_Click(object sender, EventArgs e)
        {
            manageProduct1.Show();
            manageMembership1.Hide();
            reports1.Hide();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            reports1.Show();
            manageMembership1.Hide();
            manageProduct1.Hide();
            
        }

        private void manageMembershipBtn_Click(object sender, EventArgs e)
        {
            manageMembership1.Show();
            manageProduct1.Hide();
            reports1.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
