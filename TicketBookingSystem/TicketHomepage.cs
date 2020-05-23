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
            if(c.source == c.destination)
            {
                MessageBox.Show("Source and Destination can't be same. Try Again !!!");
                clear();
            }
            else
            {
                bool success = c.search_stations(c);

                if (success == true)
                {
                    MessageBox.Show("True");
                    clear();

                }
                else
                {
                    MessageBox.Show("Can not find the information. Try Again Later");
                }
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
