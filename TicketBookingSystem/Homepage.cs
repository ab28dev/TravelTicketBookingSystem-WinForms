using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBookingSystem
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        TicketClass c = new TicketClass();
        public static String date;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        // clears the fields
        public void clear()
        {
            // clearing by replacing the field with nothing
            comboBox_Source.Text = "";
            comboBox_Destination.Text = "";

            // reset date to tomorrows date
            date_Select.Value = DateTime.Now.AddDays(1);
            
            //hide the modes if visible
            if(button_BUS.Visible == true)
            {
                button_BUS.Visible = false;
            }
            if (button_TRAIN.Visible == true)
            {
                button_TRAIN.Visible = false;
            }
            if (button_AIRPLANE.Visible == true)
            {
                button_AIRPLANE.Visible = false;
            }
            if (button_EMERGENCY.Visible == true)
            {
                button_EMERGENCY.Visible = false;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            int bus_available_flag = 0;
            int train_available_flag = 0;
            int air_available_flag = 0;

            // proceeds if inputs not empty
            if(comboBox_Source.Text == "" || comboBox_Destination.Text == "")
            {
                MessageBox.Show("Fields can not be empty !!! Try Again");
                clear();
            }
            else
            {
                // Stores date
                date = date_Select.Value.ToString("dd-MM-yyyy");

                // Get the value from the input field
                TicketClass.source = comboBox_Source.Text;
                TicketClass.destination = comboBox_Destination.Text;
                if (TicketClass.source == TicketClass.destination)
                {
                    MessageBox.Show("Source and Destination can't be same. Try Again !!!");
                }
                else
                {
                    bool success = c.search_stations(c);

                    if (success == true)
                    {

                        if (c.bus_flag_source == 1 && c.bus_flag_destination == 1)
                        {
                            // Bus Available
                            bus_available_flag = 1;
                            button_BUS.Visible = true;
                            button_BUS.Enabled = true;

                        }
                        if (c.train_flag_source == 1 && c.train_flag_destination == 1)
                        {
                            // Train Available
                            train_available_flag = 1;
                            button_TRAIN.Visible = true;
                            button_TRAIN.Enabled = true;

                        }
                        if (c.air_flag_source == 1 && c.air_flag_destination == 1)
                        {
                            // Airplane Available
                            air_available_flag = 1;
                            button_AIRPLANE.Visible = true;
                            button_AIRPLANE.Enabled = true;
                        }
                        else
                        {
                            // Emergency Option to be added here
                            button_EMERGENCY.Visible = true;
                            button_EMERGENCY.Enabled = true;
                        }

                        if (bus_available_flag == 0 && train_available_flag == 0 && air_available_flag == 0)
                        {
                            // No Direct Mode
                            // Future Development - Do you want to use multiple mode of Transportation

                        }
                    }
                    else
                    {
                        MessageBox.Show("Can not find the information. Try Again Later");
                    }
                }

            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void TicketHomepage_Load(object sender, EventArgs e)
        {
            // Disable modes buttons
            button_BUS.Enabled = false;
            button_TRAIN.Enabled = false;
            button_AIRPLANE.Enabled = false;
            button_EMERGENCY.Enabled = false;

            // Hide modes buttons
            button_BUS.Visible = false;
            button_TRAIN.Visible = false;
            button_AIRPLANE.Visible = false;
            button_EMERGENCY.Visible = false;

            // Limit Date selection 
            date_Select.MinDate = DateTime.Now.AddDays(1);
            date_Select.MaxDate = DateTime.Now.AddDays(91);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        TicketPageEmergency ticketPageEmergency = new TicketPageEmergency();
        TicketPageBus ticketPageBus = new TicketPageBus();
        TicketPageAirplane ticketPageAirplane = new TicketPageAirplane();
        TicketPageTrain ticketPageTrain = new TicketPageTrain();
        
        private void Passanger_details()
        {

        }
        private void button_BUS_Click(object sender, EventArgs e)
        {
            Passanger_details();
            ticketPageBus.Show();
            this.Hide();

        }

        private void button_TRAIN_Click(object sender, EventArgs e)
        {
            Passanger_details();
            ticketPageTrain.Show();
            this.Hide();
            
        }

        private void button_AIRPLANE_Click(object sender, EventArgs e)
        {
            Passanger_details();
            ticketPageAirplane.Show();
            this.Hide();

        }

        private void button_EMERGENCY_Click(object sender, EventArgs e)
        {
            Passanger_details();
            ticketPageEmergency.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ticketPageEmergency.Close();
            ticketPageAirplane.Close();
            ticketPageBus.Close();
            ticketPageTrain.Close();
            this.Close();
        }

        private void date_Select_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
