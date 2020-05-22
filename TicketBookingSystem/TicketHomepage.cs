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
    public partial class TicketHomepage : Form
    {
        public TicketHomepage()
        {
            InitializeComponent();
        }
        TicketClass c = new TicketClass();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            comboBox_Source.Text = "";
            comboBox_Destination.Text = "";
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
