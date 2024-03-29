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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label_LOGIN_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label_SIGNUP_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
