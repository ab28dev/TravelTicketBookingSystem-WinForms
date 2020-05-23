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
    public partial class TicketPage : Form
    {
        public TicketPage()
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

            label_TICKET.Text = HomePage.type_of_t;
            label_Source.Text = TicketClass.source;
            label_Destination.Text = TicketClass.destination;

        }

        
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Close();
            this.Close();
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
    }
}
