﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        TicketClass c = new TicketClass();

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            bool success = false;

            if(textBox_Username.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("Fields can not be empty. Try again.");
            }
            else
            {
                TicketClass.user_id = textBox_Username.Text;
                TicketClass.password = textBox_Password.Text;

                success = c.login_check();
                if (success == true)
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter the correct credentials");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label_admin_login_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
