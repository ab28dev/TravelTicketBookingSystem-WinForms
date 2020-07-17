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
    public partial class AdminHomepage : Form
    {
        public AdminHomepage()
        {
            InitializeComponent();
        }
        
        int click = 0;
        public static String flag;

        TicketHistory ticketHistory = new TicketHistory();
        TicketClass c = new TicketClass();
        private void ticket_history_Click(object sender, EventArgs e)
        {
            flag = "all"; 
            ticketHistory.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            dateTime_from.Visible = false;
            dateTime_to.Visible = false;
            go.Visible = false;
            c.ticket_stats();
            label_T1.Text = TicketClass.today.ToString();
            label_T2.Text = TicketClass.this_month.ToString();
            label_T3.Text = TicketClass.this_year.ToString();
            label_T4.Text = TicketClass.total.ToString();

        }

        private void dateTime_from_ValueChanged(object sender, EventArgs e)
        {

        }
        void visible()
        {
            
            dateTime_from.Visible = true;
            dateTime_to.Visible = true;
            go.Visible = true;
            
        }
        void hide()
        {
            
            dateTime_from.Visible = false;
            dateTime_to.Visible = false;
            go.Visible = false;
           
        }
        private void CustomRange_Click(object sender, EventArgs e)
        {
            if(click == 0)
            {
                visible();
                click = 1;
            }
            else if(click == 1)
            {
                hide();
                click = 0;
            }
            
        }

        private void today_Click(object sender, EventArgs e)
        {
            flag = "today"; 
            ticketHistory.Show();
            this.Hide();
        }

        private void this_month_Click(object sender, EventArgs e)
        {
            flag = "month";
            ticketHistory.Show();
            this.Hide();
        }

        private void this_year_Click(object sender, EventArgs e)
        {
            flag = "year";
            ticketHistory.Show();
            this.Hide();
        }

        private void go_Click(object sender, EventArgs e)
        {
            flag = "custom";
            TicketClass.DateFrom = dateTime_from.Value;
            TicketClass.DateTo = dateTime_to.Value;
            ticketHistory.Show();
            this.Hide();
        }
    }
}
