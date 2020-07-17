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
    public partial class TicketHistory : Form
    {
        public TicketHistory()
        {
            InitializeComponent();
        }
        
        TicketClass c = new TicketClass();

        public static String flag;
        
        private void HomeButton_Click(object sender, EventArgs e)
        {
            AdminHomepage adminHomepage = new AdminHomepage();
            adminHomepage.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHomepage adminHomepage = new AdminHomepage();
            adminHomepage.Show();
            this.Hide();
        }

        void display()
        {
            // Load data on data grid view
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void button_BOOK_Click(object sender, EventArgs e)
        {
            display();
        }

        private void TicketHistory_Load(object sender, EventArgs e)
        {
            flag = AdminHomepage.flag;
            display();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }
    }
}
