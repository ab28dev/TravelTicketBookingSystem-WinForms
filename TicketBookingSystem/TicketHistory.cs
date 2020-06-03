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
    public partial class TicketHistory : Form
    {
        public TicketHistory()
        {
            InitializeComponent();
        }
        
        TicketClass c = new TicketClass();

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button_BOOK_Click(object sender, EventArgs e)
        {
            // Load data on data grid view
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void TicketHistory_Load(object sender, EventArgs e)
        {
            // Load data on data grid view
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }
    }
}