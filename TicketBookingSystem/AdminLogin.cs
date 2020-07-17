using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBookingSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        TicketClass c = new TicketClass();

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label_admin_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (textBox_Username.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("Fields can not be empty. Try again.");
            }
            else
            {
                TicketClass.user_id = textBox_Username.Text;
                TicketClass.password = textBox_Password.Text;

                success = c.login_check_admin();
                if (success == true)
                {
                    AdminHomepage adminHomepage = new AdminHomepage();
                    adminHomepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter the correct credentials");
                }
            }
        }
    }
}
