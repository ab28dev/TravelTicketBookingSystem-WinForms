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
    public partial class TicketPageTrain : Form
    {
        public TicketPageTrain()
        {
            InitializeComponent();
        }
        private void TicketPageTrain_Load(object sender, EventArgs e)
        {
            // Feeding ticket particulars
            label_Distance.Text = TicketClass.distance.ToString();
            label_Source.Text = TicketClass.source;
            label_Destination.Text = TicketClass.destination;
            label_Date.Text = HomePage.date;
            label_Price.Text = TicketClass.price.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ReservationTypeTrain reservationTypeTrain = new ReservationTypeTrain();
            reservationTypeTrain.Show();
            this.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();

        }

        private void button_BOOK_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            MessageBox.Show("Your Ticket has been booked successfully.");
            homepage.Show();
            this.Hide();
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
