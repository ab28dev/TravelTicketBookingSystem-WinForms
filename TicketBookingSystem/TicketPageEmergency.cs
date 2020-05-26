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
    public partial class TicketPageEmergency : Form
    {
        public TicketPageEmergency()
        {
            InitializeComponent();
        }
        TicketClass c = new TicketClass();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TicketPage_Load(object sender, EventArgs e)
        {
            // Feeding ticket particulars

            label_Source.Text = TicketClass.source;
            label_Destination.Text = TicketClass.destination;
            label_Date.Text = HomePage.date;
        }

        
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }

        private void button_BOOK_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            MessageBox.Show("Your Ticket has been booked successfully.");
            homepage.Show();
            this.Hide();
        }

        private void pictureBox_Ticket_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }
    }
}
