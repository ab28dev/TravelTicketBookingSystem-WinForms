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
    public partial class TicketPageAirplane : Form
    {
        public TicketPageAirplane()
        {
            InitializeComponent();
        }

        PassangerDetails p = new PassangerDetails();

        private void TicketPageAIR_Load(object sender, EventArgs e)
        {
            // Feeding ticket particulars
            label_Distance.Text = TicketClass.distance.ToString();
            label_Source.Text = TicketClass.source;
            label_Destination.Text = TicketClass.destination;
            label_Date.Text = HomePage.date;
            label_Price.Text = TicketClass.price.ToString();
            label_TicketNo.Text = TicketClass.ticketno.ToString();

            label_Name1.Visible = false;
            label_Age1.Visible = false;
            label_Gender1.Visible = false;

            label_Name2.Visible = false;
            label_Age2.Visible = false;
            label_Gender2.Visible = false;

            label_Name3.Visible = false;
            label_Age3.Visible = false;
            label_Gender3.Visible = false;

            label_Name4.Visible = false;
            label_Age4.Visible = false;
            label_Gender4.Visible = false;

            if (PassangerDetails.no_of_passangers > 0 && PassangerDetails.no_of_passangers < 5)
            {
                label_Name1.Visible = true;
                label_Age1.Visible = true;
                label_Gender1.Visible = true;

                label_Name1.Text = PassangerDetails.Name1;
                label_Age1.Text = PassangerDetails.Age1.ToString();
                label_Gender1.Text = PassangerDetails.Gender1.ToString();
            }

            if (PassangerDetails.no_of_passangers > 1 && PassangerDetails.no_of_passangers < 5)
            {
                label_Name2.Visible = true;
                label_Age2.Visible = true;
                label_Gender2.Visible = true;
                

                label_Name2.Text = PassangerDetails.Name2;
                label_Age2.Text = PassangerDetails.Age2.ToString();
                label_Gender2.Text = PassangerDetails.Gender2.ToString();
            }

            if (PassangerDetails.no_of_passangers > 2 && PassangerDetails.no_of_passangers < 5)
            {
                label_Name3.Visible = true;
                label_Age3.Visible = true;
                label_Gender3.Visible = true;

                label_Name3.Text = PassangerDetails.Name3;
                label_Age3.Text = PassangerDetails.Age3.ToString();
                label_Gender3.Text = PassangerDetails.Gender3.ToString();
            }

            if (PassangerDetails.no_of_passangers > 3 && PassangerDetails.no_of_passangers < 5)
            {
                label_Name4.Visible = true;
                label_Age4.Visible = true;
                label_Gender4.Visible = true;

                label_Name4.Text = PassangerDetails.Name4;
                label_Age4.Text = PassangerDetails.Age4.ToString();
                label_Gender4.Text = PassangerDetails.Gender4.ToString();
            }
        }

        private void label_TICKET_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PassangerDetails passanger = new PassangerDetails();
            passanger.Show();
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
            TicketClass ticketClass = new TicketClass();
            ticketClass.add_ticket(ticketClass, PassangerDetails.str_mode);

            HomePage homepage = new HomePage();
            bool success = false;
            success = ticketClass.add_passangers();
            if(success == true)
            {
                MessageBox.Show("Your Ticket has been booked successfully.");
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in booking ticket. Try again !!!");
            }
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_Date_Click(object sender, EventArgs e)
        {

        }

        private void label_Source_Click(object sender, EventArgs e)
        {

        }

        private void label_Destination_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Arrive_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Depart_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TicketNo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Price_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label_Name2_Click(object sender, EventArgs e)
        {

        }

        private void label_Age2_Click(object sender, EventArgs e)
        {

        }

        private void label_Age3_Click(object sender, EventArgs e)
        {

        }

        private void label_Age4_Click(object sender, EventArgs e)
        {

        }
    }
}
