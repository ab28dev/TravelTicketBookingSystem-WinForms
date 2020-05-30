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
    public partial class ReservationTypeEmergency : Form
    {
        public ReservationTypeEmergency()
        {
            InitializeComponent();
        }

        private void ReservationTypeEmergency_Load(object sender, EventArgs e)
        {

        }

        private void label_Source_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Source_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_BOOK_Click(object sender, EventArgs e)
        {
            TicketPageEmergency ticketPageEmergency = new TicketPageEmergency();
            ticketPageEmergency.Show();
            this.Hide();
        }
    }
}
