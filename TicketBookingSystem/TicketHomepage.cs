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
    public partial class TicketHomepage : Form
    {
        public TicketHomepage()
        {
            InitializeComponent();
        }

        private TicketClass c = new TicketClass();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // clears the fields
        public void clear()
        {
            // clearing by replacing the field with nothing
            comboBox_Source.Text = "";
            comboBox_Destination.Text = "";

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            // Get the value from the input field
            c.source = comboBox_Source.Text;
            c.destination = comboBox_Destination.Text;
            bool source_bus = c.search_source_for_bus(c);
            if(source_bus == true)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void TicketHomepage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
