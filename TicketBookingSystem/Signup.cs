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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

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
    }
}
