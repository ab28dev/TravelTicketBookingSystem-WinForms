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
    public partial class ReservationTypeBus : Form
    {
        public ReservationTypeBus()
        {
            InitializeComponent();
        }

        private void ReservationTypeBus_Load(object sender, EventArgs e)
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
            TicketPageBus ticketPageBus = new TicketPageBus();
            ticketPageBus.Show();
            this.Hide();
        }
    }
}
