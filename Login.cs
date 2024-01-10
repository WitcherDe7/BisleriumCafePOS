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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.ToLower() == "admin" && guna2TextBox2.Text.ToLower() == "password")
            {
                AdminDash ad = new AdminDash();
                ad.Show();
                this.Hide();
            }
            else if (guna2TextBox1.Text.ToLower() == "staff" && guna2TextBox2.Text.ToLower() == "password")
            {
                StaffDash sd = new StaffDash();
                sd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Credential", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
