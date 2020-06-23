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
    public partial class PassangerDetails : Form
    {
        public PassangerDetails()
        {
            InitializeComponent();
        }
        public static String str_mode { get; set; }
        public static int no_of_passangers = 1;

        TicketClass c = new TicketClass();
        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_BOOK_Click(object sender, EventArgs e)
        {
            int flag = 0;
            c.ticket_no();

            if(textBox_p1_name.Text == "" || textBox_p1_age.Text == "" || comboBox_p1_gender.Text == "" || comboBox_p1_food.Text == "")
            {
                MessageBox.Show("Please add atleast 1 passanger to continue. No field can be left empty.");
                flag = 0;
            }
            if(checkBox_p2.Checked == true)
            {
                if (textBox_p2_name.Text == "" || textBox_p2_age.Text == "" || comboBox_p2_gender.Text == "" || comboBox_p2_food.Text == "")
                {
                    MessageBox.Show("Please add atleast 1 passanger to continue. No field can be left empty.");
                    flag = 0;
                }
                else
                {
                    no_of_passangers++;
                    flag = 1;
                }
            }
            if(checkBox_p3.Checked == true)
            {
                if (textBox_p3_name.Text == "" || textBox_p3_age.Text == "" || comboBox_p3_gender.Text == "" || comboBox_p3_food.Text == "")
                {
                    MessageBox.Show("Please add atleast 1 passanger to continue. No field can be left empty.");
                    flag = 0;
                }
                else
                {
                    no_of_passangers++;
                    flag = 1;
                }
            }
            if(checkBox_p4.Checked == true)
            {
                if (textBox_p4_name.Text == "" || textBox_p4_age.Text == "" || comboBox_p4_gender.Text == "" || comboBox_p4_food.Text == "")
                {
                    MessageBox.Show("Please add atleast 1 passanger to continue. No field can be left empty.");
                    flag = 0;
                }
                else
                {
                    no_of_passangers++;
                    flag = 1;
                }
            }

            // to be edited

            if (TicketClass.mode == "AIR")
            {
                
                if(class_AIR.Text == "")
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            }
            else if (TicketClass.mode == "BUS")
            {
                if (class_BUS.Text == "")
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                };
            }
            else if (TicketClass.mode == "TRAIN")
            {
                if (class_TRAIN.Text == "")
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            }
            else
            {
                if (class_EMERGENCY.Text == "")
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                MessageBox.Show("Please fill all the details !!!");
            }
            else if (flag == 1)
            {
                TicketPageAirplane ticketPageAirplane = new TicketPageAirplane();
                ticketPageAirplane.Show();
                this.Hide();
            }
        }

        private void textBox_p1_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBox_p2_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBox_p3_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBox_p4_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBox_p1_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space))
                e.Handled = true;
        }

        private void ReservationTypeAir_Load(object sender, EventArgs e)
        {
            
            checkBox_p1.Enabled = true;
            textBox_p1_name.Visible = false;
            textBox_p1_age.Visible = false;
            comboBox_p1_gender.Visible = false;
            comboBox_p1_food.Visible = false;

            checkBox_p2.Enabled = false;
            textBox_p2_name.Visible = false;
            textBox_p2_age.Visible = false;
            comboBox_p2_gender.Visible = false;
            comboBox_p2_food.Visible = false;

            checkBox_p3.Enabled = false;
            textBox_p3_name.Visible = false;
            textBox_p3_age.Visible = false;
            comboBox_p3_gender.Visible = false;
            comboBox_p3_food.Visible = false;

            checkBox_p4.Enabled = false;
            textBox_p4_name.Visible = false;
            textBox_p4_age.Visible = false;
            comboBox_p4_gender.Visible = false;
            comboBox_p4_food.Visible = false;

            class_AIR.Enabled = false;
            class_AIR.Visible = false;
            class_BUS.Enabled = false;
            class_BUS.Visible = false;
            class_TRAIN.Enabled = false;
            class_TRAIN.Visible = false;
            class_EMERGENCY.Enabled = false;
            class_EMERGENCY.Visible = false;


            str_mode = TicketClass.mode;
        
            if (TicketClass.mode == "AIR")
            {
                //enable combo box
                class_AIR.Enabled = true;
                class_AIR.Visible = true;
                class_BUS.Enabled = false;
                class_BUS.Visible = false;
                class_TRAIN.Enabled = false;
                class_TRAIN.Visible = false;
                class_EMERGENCY.Enabled = false;
                class_EMERGENCY.Visible = false;
            }
            else if (TicketClass.mode == "BUS")
            {
                class_AIR.Enabled = false;
                class_AIR.Visible = false;
                class_BUS.Enabled = true;
                class_BUS.Visible = true;
                class_TRAIN.Enabled = false;
                class_TRAIN.Visible = false;
                class_EMERGENCY.Enabled = false;
                class_EMERGENCY.Visible = false;
            }
            else if (TicketClass.mode == "TRAIN")
            {
                class_AIR.Enabled = false;
                class_AIR.Visible = false;
                class_BUS.Enabled = false;
                class_BUS.Visible = false;
                class_TRAIN.Enabled = true;
                class_TRAIN.Visible = true;
                class_EMERGENCY.Enabled = false;
                class_EMERGENCY.Visible = false;
            }
            else
            {
                class_AIR.Enabled = false;
                class_AIR.Visible = false;
                class_BUS.Enabled = false;
                class_BUS.Visible = false;
                class_TRAIN.Enabled = false;
                class_TRAIN.Visible = false;
                class_EMERGENCY.Enabled = true;
                class_EMERGENCY.Visible = true;
            }
        }


        private void checkBox_p1_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBox_p1.Checked == false)
            {
                textBox_p1_name.Visible = false;
                textBox_p1_age.Visible = false;
                comboBox_p1_gender.Visible = false;
                comboBox_p1_food.Visible = false;

                checkBox_p2.Enabled = false;
                textBox_p2_name.Visible = false;
                textBox_p2_age.Visible = false;
                comboBox_p2_gender.Visible = false;
                comboBox_p2_food.Visible = false;

                checkBox_p3.Enabled = false;
                textBox_p3_name.Visible = false;
                textBox_p3_age.Visible = false;
                comboBox_p3_gender.Visible = false;
                comboBox_p3_food.Visible = false;

                checkBox_p4.Enabled = false;
                textBox_p4_name.Visible = false;
                textBox_p4_age.Visible = false;
                comboBox_p4_gender.Visible = false;
                comboBox_p4_food.Visible = false;

                checkBox_p2.Checked = false;
                checkBox_p3.Checked = false;
                checkBox_p4.Checked = false;

            }
            else if(checkBox_p1.Checked == true)
            {
                checkBox_p2.Enabled = true;
                textBox_p1_name.Visible = true;
                textBox_p1_age.Visible = true;
                comboBox_p1_gender.Visible = true;
                comboBox_p1_food.Visible = true;
            }
        }

        private void checkBox_p2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p2.Checked == false)
            {

                textBox_p2_name.Visible = false;
                textBox_p2_age.Visible = false;
                comboBox_p2_gender.Visible = false;
                comboBox_p2_food.Visible = false;

                checkBox_p3.Enabled = false;
                textBox_p3_name.Visible = false;
                textBox_p3_age.Visible = false;
                comboBox_p3_gender.Visible = false;
                comboBox_p3_food.Visible = false;

                checkBox_p4.Enabled = false;
                textBox_p4_name.Visible = false;
                textBox_p4_age.Visible = false;
                comboBox_p4_gender.Visible = false;
                comboBox_p4_food.Visible = false;

                checkBox_p3.Checked = false;
                checkBox_p4.Checked = false;
            }
            else if (checkBox_p2.Checked == true)
            {
                checkBox_p3.Enabled = true;
                textBox_p2_name.Visible = true;
                textBox_p2_age.Visible = true;
                comboBox_p2_gender.Visible = true;
                comboBox_p2_food.Visible = true;

            }
        }

        private void checkBox_p3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p3.Checked == false)
            {
                textBox_p3_name.Visible = false;
                textBox_p3_age.Visible = false;
                comboBox_p3_gender.Visible = false;
                comboBox_p3_food.Visible = false;

                checkBox_p4.Enabled = false;
                textBox_p4_name.Visible = false;
                textBox_p4_age.Visible = false;
                comboBox_p4_gender.Visible = false;
                comboBox_p4_food.Visible = false;

                checkBox_p4.Checked = false;
            }
            else if (checkBox_p3.Checked == true)
            {
                checkBox_p4.Enabled = true;
                textBox_p3_name.Visible = true;
                textBox_p3_age.Visible = true;
                comboBox_p3_gender.Visible = true;
                comboBox_p3_food.Visible = true;
            }
        }

        private void checkBox_p4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p4.Checked == false)
            {
                textBox_p4_name.Visible = false;
                textBox_p4_age.Visible = false;
                comboBox_p4_gender.Visible = false;
                comboBox_p4_food.Visible = false;

            }
            else if (checkBox_p4.Checked == true)
            {
                
                textBox_p4_name.Visible = true;
                textBox_p4_age.Visible = true;
                comboBox_p4_gender.Visible = true;
                comboBox_p4_food.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }
    }
}
